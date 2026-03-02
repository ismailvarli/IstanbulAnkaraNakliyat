using Microsoft.AspNetCore.Mvc;

namespace IstanbulAnkaraNakliyat.Controllers;

public class BlogController : Controller
{
    [HttpGet("/blog")]
    public IActionResult Index()
    {
        ViewData["Title"]       = "Nakliyat Blog | İstanbul Ankara Taşıma Rehberleri 2026";
        ViewData["Description"] = "Nakliyat rehberleri, taşınma ipuçları ve ev taşıma planlaması hakkında uzman içerikler. Doğru firma seçimi, ambalaj tüyoları ve daha fazlası.";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/blog";
        return View();
    }

    [HttpGet("/blog/nakliyat-firmasi-nasil-secilir")]
    public IActionResult NakliyatFirmasiNasilSecilir()
    {
        ViewData["Title"]       = "Nakliyat Firması Nasıl Seçilir? 7 Kritik Soru | Blog";
        ViewData["Description"] = "Güvenilir nakliyat firması seçerken sormanız gereken 7 kritik soru. Fiyat tuzağına düşmeyin, sigortasız taşıma riskine girmeyin.";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/blog/nakliyat-firmasi-nasil-secilir";
        return View();
    }

    [HttpGet("/blog/evden-eve-nakliyat-oncesi-hazirlik")]
    public IActionResult EvdenEveNakliyatOncesiHazirlik()
    {
        ViewData["Title"]       = "Nakliyat Öncesi Hazırlık Listesi: 21 Günlük Plan | Blog";
        ViewData["Description"] = "Taşınmadan 3 hafta önce başlayarak stressiz bir taşınma deneyimi yaşayın. Adım adım hazırlık takvimi ve kontrol listesi.";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/blog/evden-eve-nakliyat-oncesi-hazirlik";
        return View();
    }

    [HttpGet("/blog/tasinirken-yapilan-hatalar")]
    public IActionResult TasinirkenYapilanHatalar()
    {
        ViewData["Title"]       = "Taşınırken Yapılan 10 Büyük Hata ve Nasıl Önlenir | Blog";
        ViewData["Description"] = "Taşınırken en sık yapılan 10 hata ve bunlardan kaçınmanın yolları. Nakliyat sigortası, ambalaj ve firma seçiminde dikkat edilmesi gerekenler.";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/blog/tasinirken-yapilan-hatalar";
        return View();
    }

    [HttpGet("/blog/parca-esya-mi-tam-arac-mi")]
    public IActionResult ParcaEsyaMiTamAracMi()
    {
        ViewData["Title"]       = "Parça Eşya mı Tam Araç mı? Hangisi Size Uygun? | Blog";
        ViewData["Description"] = "Parsiyel nakliyat ile tam araç kiralama arasında nasıl karar verilir? Fiyat karşılaştırması, avantajlar ve hangi durumda ne tercih edilmeli.";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/blog/parca-esya-mi-tam-arac-mi";
        return View();
    }

    [HttpGet("/blog/nakliyat-sigortasi-nedir")]
    public IActionResult NakliyatSigortasiNedir()
    {
        ViewData["Title"]       = "Nakliyat Sigortası Nedir, Neleri Kapsar? | Blog";
        ViewData["Description"] = "Nakliyat sigortası nasıl çalışır, hasar durumunda ne yapılır, hangi eşyalar kapsam dışı kalır? Bilmeniz gereken her şey.";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/blog/nakliyat-sigortasi-nedir";
        return View();
    }

    [HttpGet("/blog/istanbul-ankara-tasima-rehberi")]
    public IActionResult IstanbulAnkaraTasimaRehberi()
    {
        ViewData["Title"]       = "İstanbul'dan Ankara'ya Taşınma Rehberi 2026 | Blog";
        ViewData["Description"] = "İstanbul'dan Ankara'ya taşınmayı planlıyorsanız bu rehber tam size göre. Taşıma süreci, fiyatlar, dikkat edilmesi gerekenler ve Ankara'da yaşam.";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/blog/istanbul-ankara-tasima-rehberi";
        return View();
    }
}
