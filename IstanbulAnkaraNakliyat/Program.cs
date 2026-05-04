var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

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

app.UseStaticFiles();
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
