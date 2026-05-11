using Microsoft.AspNetCore.ResponseCompression;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

// Brotli + Gzip sıkıştırma
builder.Services.AddResponseCompression(o =>
{
    o.EnableForHttps = true;
    o.Providers.Add<BrotliCompressionProvider>();
    o.Providers.Add<GzipCompressionProvider>();
});
builder.Services.Configure<BrotliCompressionProviderOptions>(o =>
    o.Level = System.IO.Compression.CompressionLevel.Fastest);
builder.Services.Configure<GzipCompressionProviderOptions>(o =>
    o.Level = System.IO.Compression.CompressionLevel.Fastest);

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseResponseCompression();

// Güvenlik header'ları
app.Use(async (ctx, next) =>
{
    ctx.Response.Headers["X-Content-Type-Options"] = "nosniff";
    ctx.Response.Headers["X-Frame-Options"]        = "SAMEORIGIN";
    ctx.Response.Headers["Referrer-Policy"]        = "strict-origin-when-cross-origin";
    ctx.Response.Headers["Permissions-Policy"]     = "camera=(), microphone=(), geolocation=()";
    await next();
});

// non-www → www kalıcı yönlendirme
app.Use(async (ctx, next) =>
{
    var host = ctx.Request.Host.Host;
    if (!host.StartsWith("www.") && host != "localhost" && !host.StartsWith("192.") && !host.StartsWith("10."))
    {
        var to = $"https://www.{host}{ctx.Request.Path}{ctx.Request.QueryString}";
        ctx.Response.Redirect(to, permanent: true);
        return;
    }
    await next();
});

// URL normalizasyon — büyük harf → küçük harf 301
app.Use(async (ctx, next) =>
{
    var path = ctx.Request.Path.Value;
    if (path != null && path.Length > 1)
    {
        var lower = path.ToLowerInvariant();
        if (lower != path)
        {
            ctx.Response.Redirect(lower + ctx.Request.QueryString, permanent: true);
            return;
        }
    }
    await next();
});

// Statik dosyalar 1 yıl önbellek
app.UseStaticFiles(new StaticFileOptions
{
    OnPrepareResponse = ctx =>
        ctx.Context.Response.Headers["Cache-Control"] = "public,max-age=31536000,immutable"
});
app.UseRouting();
app.UseAuthorization();

// ── Eski / hatalı URL yönlendirmeleri (301) ─────────────────────────
app.MapGet("/sarefikochsar-istanbul-nakliyat", ctx =>
{
    ctx.Response.Redirect("/sereflikocehisar-istanbul-nakliyat", permanent: true);
    return Task.CompletedTask;
});
app.MapGet("/teklifgonder", ctx =>
{
    ctx.Response.Redirect("/iletisim", permanent: true);
    return Task.CompletedTask;
});

// ── Yorum gönder ────────────────────────────────────────────────────
app.MapControllerRoute("review-post", "yorum/gonder",
    new { controller = "Review", action = "Gonder" });

// ── Nakliyat güzergah sayfaları (slug'dan önce explicit route'lar) ──
app.MapControllerRoute("ist-ank",      "istanbul-ankara-nakliyat",
    new { controller = "Nakliyat", action = "IstanbulAnkara" });
app.MapControllerRoute("ank-ist",      "ankara-istanbul-nakliyat",
    new { controller = "Nakliyat", action = "AnkaraIstanbul" });

// ── İlçe slug sayfaları ─────────────────────────────────────────────
app.MapControllerRoute("ist-ilce-ank", "{slug}-ankara-nakliyat",
    new { controller = "Nakliyat", action = "AnkaraHedef" });
app.MapControllerRoute("ank-ilce-ist", "{slug}-istanbul-nakliyat",
    new { controller = "Nakliyat", action = "IstanbulHedef" });

// ── Default ─────────────────────────────────────────────────────────
app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");

app.Run();
