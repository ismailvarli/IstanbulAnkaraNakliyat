var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

builder.Services.AddWebOptimizer(pipeline =>
{
    // CSS: bootstrap-grid + site.css → tek istek
    pipeline.AddCssBundle("/css/bundle.css",
        "lib/bootstrap/dist/css/bootstrap-grid.min.css",
        "css/site.css");

    // JS: site.js → minified
    pipeline.AddJavaScriptBundle("/js/bundle.js",
        "js/site.js");
});

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseWebOptimizer();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

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
