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

    [HttpGet("/ceyiz-tasima")]
    public IActionResult CeyizTasima()
    {
        ViewData["Title"]       = "Çeyiz Taşıma İstanbul Ankara | Güvenli Çeyiz Nakliyat 2026";
        ViewData["Description"] = "İstanbul Ankara arası çeyiz taşıma hizmeti. Beyaz eşya, çeyiz sandığı, porselen ve kırılgan eşyalar özel ambalajla güvenle taşınır. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/ceyiz-tasima";
        return View();
    }

    [HttpGet("/istanbul-nakliyat")]
    public IActionResult IstanbulNakliyat()
    {
        ViewData["Title"]       = "İstanbul Nakliyat | Ev & Ofis Taşıma Hizmeti 2026";
        ViewData["Description"] = "İstanbul nakliyat hizmeti. İstanbul'un 39 ilçesinde ev, ofis ve parça eşya taşıma. Sigortalı, güvenilir, uygun fiyatlı nakliyat: 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/istanbul-nakliyat";
        return View();
    }

    [HttpGet("/ankara-nakliyat")]
    public IActionResult AnkaraNakliyat()
    {
        ViewData["Title"]       = "Ankara Nakliyat | Ev & Ofis Taşıma Hizmeti 2026";
        ViewData["Description"] = "Ankara nakliyat hizmeti. Ankara'nın tüm ilçelerinde ev, ofis ve parça eşya taşıma. Sigortalı, profesyonel nakliyat: 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/ankara-nakliyat";
        return View();
    }

    [HttpGet("/istanbul-ankara-sehirlerarasi-nakliyat")]
    public IActionResult IstanbulAnkaraSehirlerarasi()
    {
        ViewData["Title"]       = "İstanbul Ankara Şehirlerarası Nakliyat | 2026 Fiyatları";
        ViewData["Description"] = "İstanbul'dan Ankara'ya şehirlerarası nakliyat. Tam araç ve parsiyel seçenekleri, sigortalı taşıma, 450 km güzergahta deneyimli hizmet: 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/istanbul-ankara-sehirlerarasi-nakliyat";
        return View();
    }

    [HttpGet("/ankara-istanbul-sehirlerarasi-nakliyat")]
    public IActionResult AnkaraIstanbulSehirlerarasi()
    {
        ViewData["Title"]       = "Ankara İstanbul Şehirlerarası Nakliyat | 2026 Fiyatları";
        ViewData["Description"] = "Ankara'dan İstanbul'a şehirlerarası nakliyat. Tam araç ve parsiyel seçenekleri, sigortalı taşıma, deneyimli ekip: 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/ankara-istanbul-sehirlerarasi-nakliyat";
        return View();
    }

    [HttpGet("/istanbul-ankara-ceyiz-tasima")]
    public IActionResult IstanbulAnkaraCeyizTasima()
    {
        ViewData["Title"]       = "İstanbul Ankara Çeyiz Taşıma | Güvenli Çeyiz Nakliyat 2026";
        ViewData["Description"] = "İstanbul'dan Ankara'ya çeyiz taşıma hizmeti. Porselen, beyaz eşya, çeyiz sandığı özel ambalajla 450 km'yi hasarsız aşar. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/istanbul-ankara-ceyiz-tasima";
        return View();
    }
}
