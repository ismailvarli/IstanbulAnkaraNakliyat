using System.Text.Json;
using IstanbulAnkaraNakliyat.Models;
using Microsoft.AspNetCore.Mvc;

namespace IstanbulAnkaraNakliyat.Controllers;

public class ReviewController : Controller
{
    private readonly string _path;

    public ReviewController(IWebHostEnvironment env)
        => _path = Path.Combine(env.ContentRootPath, "App_Data", "reviews.json");

    [HttpGet("/yorumlar")]
    public IActionResult Yorumlar()
    {
        ViewData["Title"]       = "Müşteri Yorumları | İstanbul Ankara Nakliyat";
        ViewData["Description"] = "İstanbul Ankara Nakliyat müşteri yorumları ve değerlendirmeleri. Gerçek müşterilerimizin deneyimleri, taşıma hikayeleri ve puanları.";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/yorumlar";
        var reviews = Load(_path);
        return View(reviews);
    }

    [HttpPost("/yorum/gonder")]
    public IActionResult Gonder(string ad, string yorum, int puan)
    {
        if (string.IsNullOrWhiteSpace(ad) || string.IsNullOrWhiteSpace(yorum) || yorum.Trim().Length < 10)
            return Redirect("/?yorum=hata#yorum-formu");

        var r = new Review
        {
            Ad    = ad.Trim()[..Math.Min(60, ad.Trim().Length)],
            Yorum = yorum.Trim()[..Math.Min(500, yorum.Trim().Length)],
            Puan  = Math.Clamp(puan, 1, 5),
            Tarih = DateTime.Now.ToString("dd.MM.yyyy")
        };

        Directory.CreateDirectory(Path.GetDirectoryName(_path)!);
        var list = Load(_path);
        list.Insert(0, r);
        System.IO.File.WriteAllText(_path, JsonSerializer.Serialize(list, new JsonSerializerOptions { WriteIndented = true }));

        return Redirect("/?yorum=tesekkur#yorum-formu");
    }

    public static List<Review> Load(string path)
    {
        if (!System.IO.File.Exists(path)) return new();
        try { return JsonSerializer.Deserialize<List<Review>>(System.IO.File.ReadAllText(path)) ?? new(); }
        catch { return new(); }
    }
}
