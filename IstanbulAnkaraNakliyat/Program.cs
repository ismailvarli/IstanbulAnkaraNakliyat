var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
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
