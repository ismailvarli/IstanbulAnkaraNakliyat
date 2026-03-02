using Microsoft.AspNetCore.Mvc;

namespace IstanbulAnkaraNakliyat.Controllers;

public class ServicesController : Controller
{
    [HttpGet("/evden-eve-nakliyat")]
    public IActionResult EvdenEve()
    {
        ViewData["Title"]       = "Evden Eve Nakliyat İstanbul Ankara | Profesyonel Ev Taşıma 2026";
        ViewData["Description"] = "İstanbul Ankara arası evden eve nakliyat hizmeti. Sigortalı taşıma, ambalaj, söküm-montaj dahil. Kapıdan kapıya güvenli ev taşıma: 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/evden-eve-nakliyat";
        return View();
    }

    [HttpGet("/ofis-tasima")]
    public IActionResult OfisTasima()
    {
        ViewData["Title"]       = "Ofis Taşıma İstanbul Ankara | Kurumsal Nakliyat Hizmeti 2026";
        ViewData["Description"] = "İstanbul-Ankara arası ofis taşıma hizmeti. Sunucu, kasa, arşiv ve hassas ekipman dahil profesyonel kurumsal nakliyat. Hemen teklif alın.";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/ofis-tasima";
        return View();
    }

    [HttpGet("/parca-esya-tasima")]
    public IActionResult ParcaEsya()
    {
        ViewData["Title"]       = "Parça Eşya Taşıma İstanbul Ankara | Parsiyel Nakliyat 2026";
        ViewData["Description"] = "İstanbul Ankara arası parça eşya taşıma ve parsiyel nakliyat hizmeti. Tek koliden başlar. Ekonomik, güvenli ve sigortalı taşımacılık.";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/parca-esya-tasima";
        return View();
    }

    [HttpGet("/esya-depolama")]
    public IActionResult EsyaDepolama()
    {
        ViewData["Title"]       = "Eşya Depolama İstanbul Ankara | Güvenli Eşya Muhafazası 2026";
        ViewData["Description"] = "İstanbul ve Ankara'da eşya depolama hizmeti. Güvenli, kapalı, kameralı depo. Aylık kiralama, klimalı ortam. Ücretsiz bilgi: 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/esya-depolama";
        return View();
    }

    [HttpGet("/ambalaj-hizmeti")]
    public IActionResult Ambalaj()
    {
        ViewData["Title"]       = "Ambalaj Hizmeti Nakliyat | Profesyonel Paketleme 2026";
        ViewData["Description"] = "Nakliyat öncesi profesyonel ambalaj hizmeti. Balonlu naylon, streç film, köpük koruma ile eşyalarınız hasar görmeden taşınır.";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/ambalaj-hizmeti";
        return View();
    }

    [HttpGet("/nakliyat-ucreti")]
    public IActionResult NakliyatUcreti()
    {
        ViewData["Title"]       = "Nakliyat Fiyatları 2026 | İstanbul Ankara Taşıma Ücreti";
        ViewData["Description"] = "İstanbul Ankara nakliyat fiyatları ve taşıma ücretleri 2026. 1+1, 2+1, 3+1 daire, ofis ve parça eşya için fiyat listesi. Ücretsiz teklif alın.";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/nakliyat-ucreti";
        return View();
    }
}
