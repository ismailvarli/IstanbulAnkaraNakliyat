using System.Text.Json;
using IstanbulAnkaraNakliyat.Models;
using Microsoft.AspNetCore.Mvc;

namespace IstanbulAnkaraNakliyat.Controllers;

public class TeklifController : Controller
{
    private readonly string _path;

    public TeklifController(IWebHostEnvironment env)
        => _path = Path.Combine(env.ContentRootPath, "App_Data", "teklifler.json");

    [HttpPost("/teklif/gonder")]
    public IActionResult Gonder(string ad, string telefon, string yon, string daireTipi, string tarih, string not)
    {
        if (string.IsNullOrWhiteSpace(ad) || string.IsNullOrWhiteSpace(telefon))
            return Json(new { ok = false, mesaj = "Ad ve telefon zorunludur." });

        // Basic phone validation
        var tel = telefon.Trim().Replace(" ", "").Replace("-", "");
        if (tel.Length < 10)
            return Json(new { ok = false, mesaj = "Geçerli bir telefon numarası giriniz." });

        var teklif = new Teklif
        {
            Ad        = ad.Trim()[..Math.Min(80, ad.Trim().Length)],
            Telefon   = tel,
            Yon       = yon ?? "",
            DaireTipi = daireTipi ?? "",
            Tarih     = tarih ?? "",
            Not       = (not ?? "").Trim()[..Math.Min(500, (not ?? "").Trim().Length)],
            Gonderim  = DateTime.Now.ToString("dd.MM.yyyy HH:mm")
        };

        Directory.CreateDirectory(Path.GetDirectoryName(_path)!);
        var list = Load(_path);
        list.Insert(0, teklif);
        System.IO.File.WriteAllText(_path, JsonSerializer.Serialize(list, new JsonSerializerOptions { WriteIndented = true }));

        return Json(new { ok = true });
    }

    public static List<Teklif> Load(string path)
    {
        if (!System.IO.File.Exists(path)) return new();
        try { return JsonSerializer.Deserialize<List<Teklif>>(System.IO.File.ReadAllText(path)) ?? new(); }
        catch { return new(); }
    }
}
