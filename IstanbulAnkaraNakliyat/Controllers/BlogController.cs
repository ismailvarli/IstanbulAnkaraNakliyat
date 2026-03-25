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

    [HttpGet("/blog/sehirlerarasi-nakliyat-asamalari")]
    public IActionResult SehirlerarasiNakliyatAsamalari()
    {
        ViewData["Title"]       = "Şehirlerarası Nakliyat Aşamaları: Baştan Sona Taşınma Süreci | Blog";
        ViewData["Description"] = "Şehirlerarası nakliyat nasıl yapılır? Keşiften teslimata kadar her aşama, hangi ekipmanlar kullanılır, süreç ne kadar sürer?";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/blog/sehirlerarasi-nakliyat-asamalari";
        return View();
    }

    [HttpGet("/blog/tasinmak-icin-en-iyi-mevsim")]
    public IActionResult TasinmakIcinEnIyiMevsim()
    {
        ViewData["Title"]       = "Taşınmak İçin En İyi Mevsim Hangisi? Yıl Boyunca Nakliyat Rehberi | Blog";
        ViewData["Description"] = "Yaz mı kış mı, ilkbahar mı? Taşınma için en uygun dönem ve mevsime göre nakliyat fiyatlarının nasıl değiştiğini öğrenin.";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/blog/tasinmak-icin-en-iyi-mevsim";
        return View();
    }

    [HttpGet("/blog/nakliyat-fiyati-nasil-hesaplanir")]
    public IActionResult NakliyatFiyatiNasilHesaplanir()
    {
        ViewData["Title"]       = "Nakliyat Fiyatı Nasıl Hesaplanır? 2026 Fiyat Rehberi | Blog";
        ViewData["Description"] = "Evden eve nakliyat fiyatını belirleyen faktörler neler? Daire büyüklüğü, kat, mesafe ve asansöre göre fiyat rehberi.";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/blog/nakliyat-fiyati-nasil-hesaplanir";
        return View();
    }

    [HttpGet("/blog/esya-paketleme-teknikleri")]
    public IActionResult EsyaPacketlemeTechnikleri()
    {
        ViewData["Title"]       = "Eşya Paketleme Teknikleri: Taşınmadan Önce Bilmeniz Gerekenler | Blog";
        ViewData["Description"] = "Kırılgan eşyaları nasıl paketle? Hangi kutu, hangi malzeme? Profesyonellerin kullandığı eşya paketleme yöntemleri.";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/blog/esya-paketleme-teknikleri";
        return View();
    }

    [HttpGet("/blog/istanbul-ankara-nakliyat-kac-saat")]
    public IActionResult IstanbulAnkaraNakliyatKacSaat()
    {
        ViewData["Title"]       = "İstanbul Ankara Nakliyat Kaç Saat Sürer? Gerçekçi Süre Rehberi | Blog";
        ViewData["Description"] = "İstanbul'dan Ankara'ya taşınma kaç saat sürer? Yükleme, yol ve boşaltma süreleri, trafiğin etkisi ve zaman planlaması.";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/blog/istanbul-ankara-nakliyat-kac-saat";
        return View();
    }

    [HttpGet("/blog/nakliyat-sozlesmesi-ve-haklar")]
    public IActionResult NakliyatSozlesmesiVeHaklar()
    {
        ViewData["Title"]       = "Nakliyat Sözleşmesi Nasıl Yapılır? Dolandırıcılıktan Korunma Rehberi | Blog";
        ViewData["Description"] = "Nakliyat firmasıyla sözleşme yaparken nelere dikkat edilmeli? Fiyat şişirme, sahte sigorta ve eksik teslimattan korunmanın yolları.";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/blog/nakliyat-sozlesmesi-ve-haklar";
        return View();
    }

    [HttpGet("/blog/esya-hasar-gorurse-haklariniz")]
    public IActionResult EsyaHasarGorurseHaklariniz()
    {
        ViewData["Title"]       = "Nakliyatta Eşya Hasar Görürse Haklarınız Neler? | Blog";
        ViewData["Description"] = "Taşınma sırasında eşyanız kırıldı veya hasar gördü mü? Nakliyat firmasına karşı yasal haklarınızı ve hasar tazminat sürecini öğrenin.";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/blog/esya-hasar-gorurse-haklariniz";
        return View();
    }

    [HttpGet("/blog/asansorlu-nakliyat-nedir")]
    public IActionResult AsansorluNakliyatNedir()
    {
        ViewData["Title"]       = "Asansörlü Nakliyat Nedir, Ne Zaman Gerekli? | Blog";
        ViewData["Description"] = "Asansörlü nakliyat sistemi nasıl çalışır? Hangi kat ve eşya için gerekli? Merdiven taşımaya kıyasla fiyat ve avantaj karşılaştırması.";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/blog/asansorlu-nakliyat-nedir";
        return View();
    }

    [HttpGet("/blog/yeni-eve-tasindiktan-sonra")]
    public IActionResult YeniEveTasindiktanSonra()
    {
        ViewData["Title"]       = "Yeni Eve Taşındıktan Sonra Yapılacaklar Listesi | Blog";
        ViewData["Description"] = "Yeni evinize taşındıktan sonra unutmamanız gereken 10 kritik adım. Adres değişikliği, abonelikler, komşuluk ve ev güvenliği.";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/blog/yeni-eve-tasindiktan-sonra";
        return View();
    }

    [HttpGet("/blog/nakliyat-fiyatlari-neden-farkli")]
    public IActionResult NakliyatFiyatlariNedenFarkli()
    {
        ViewData["Title"]       = "Nakliyat Fiyatları Neden Bu Kadar Farklı? | Blog";
        ViewData["Description"] = "Aynı taşıma için iki farklı firmadan 3 kat farklı fiyat mı aldınız? Nakliyat fiyat farklarının gerçek nedenlerini öğrenin.";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/blog/nakliyat-fiyatlari-neden-farkli";
        return View();
    }

    [HttpGet("/blog/ankara-yasam-maliyeti")]
    public IActionResult AnkaraYasamMaliyeti()
    {
        ViewData["Title"]       = "Ankara'da Yaşam Maliyeti 2026 | İstanbul ile Karşılaştırma";
        ViewData["Description"] = "Ankara ve İstanbul arasında kira, market, ulaşım ve yaşam giderleri karşılaştırması. İstanbul'dan Ankara'ya taşınmak ne kadar tasarruf sağlar?";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/blog/ankara-yasam-maliyeti";
        return View();
    }

    [HttpGet("/blog/nakliyat-oncesi-esya-envanteri")]
    public IActionResult NakliyatOncesiEsyaEnvanteri()
    {
        ViewData["Title"]       = "Taşınmadan Önce Eşya Envanteri Nasıl Çıkarılır? | Blog";
        ViewData["Description"] = "Eşya envanteri çıkarmak taşınmayı kolaylaştırır, fiyatı düşürür ve kayıpları önler. Adım adım envanter rehberi ve şablonu.";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/blog/nakliyat-oncesi-esya-envanteri";
        return View();
    }

    [HttpGet("/blog/ofis-tasima-rehberi")]
    public IActionResult OfisTasimaRehberi()
    {
        ViewData["Title"]       = "Ofis Taşıma Rehberi: Sıfır İş Kaybıyla Kurumsal Nakliyat | Blog";
        ViewData["Description"] = "Ofis taşıma sürecini nasıl planlarsınız? IT altyapısı, arşiv, personel koordinasyonu ve hafta sonu operasyonuyla iş sürekliliği nasıl sağlanır?";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/blog/ofis-tasima-rehberi";
        return View();
    }

    [HttpGet("/blog/nakliyat-sirasinda-degerli-esyalar")]
    public IActionResult NakliyatSirasindaDegerliEsyalar()
    {
        ViewData["Title"]       = "Nakliyatta Değerli Eşyaları Koruma Rehberi | Blog";
        ViewData["Description"] = "Antika, mücevher, sanat eseri ve elektronik cihazları taşıma sırasında nasıl korursunuz? Özel ambalaj, sigorta ve güvenli taşıma yöntemleri.";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/blog/nakliyat-sirasinda-degerli-esyalar";
        return View();
    }
}
