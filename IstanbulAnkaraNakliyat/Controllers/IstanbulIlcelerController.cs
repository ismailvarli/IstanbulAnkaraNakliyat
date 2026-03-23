using Microsoft.AspNetCore.Mvc;

namespace IstanbulAnkaraNakliyat.Controllers;

/// <summary>
/// İstanbul ilçelerinden Ankara'ya nakliyat — her ilçe ayrı action + ayrı view
/// URL pattern: /{ilce}-ankara-nakliyat
/// Views: Views/IstanbulIlceler/{Action}.cshtml
/// </summary>
public class IstanbulIlcelerController : Controller
{
    // ── Anadolu Yakası ──────────────────────────────────────────
    [HttpGet("kadikoy-ankara-nakliyat")]
    public IActionResult Kadikoy()
    {
        ViewData["Title"]       = "Kadıköy Ankara Nakliyat | Bağdat Caddesi ve Moda'dan Güvenli Taşıma";
        ViewData["Description"] = "Kadıköy'den Ankara'ya profesyonel evden eve nakliyat. Moda, Fenerbahçe, Fikirtepe ve Bağdat Caddesi mahallelerinden sigortalı, kapıdan kapıya taşıma. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/kadikoy-ankara-nakliyat";
        return View();
    }

    [HttpGet("uskudar-ankara-nakliyat")]
    public IActionResult Uskudar()
    {
        ViewData["Title"]       = "Üsküdar Ankara Nakliyat | Çengelköy ve Kandilli'den Profesyonel Taşıma";
        ViewData["Description"] = "Üsküdar'dan Ankara'ya evden eve nakliyat. Çengelköy, Kandilli, Beylerbeyi ve Kuzguncuk mahallelerinden sigortalı, asansörlü taşıma hizmeti. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/uskudar-ankara-nakliyat";
        return View();
    }

    [HttpGet("umraniye-ankara-nakliyat")]
    public IActionResult Umraniye()
    {
        ViewData["Title"]       = "Ümraniye Ankara Nakliyat | TEM Güzergahında Hızlı Ev Taşıma";
        ViewData["Description"] = "Ümraniye'den Ankara'ya nakliyat. Armağanevler, İnkılap, Siteler ve Yunus Emre mahallelerinden TEM bağlantılı hızlı, sigortalı taşıma. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/umraniye-ankara-nakliyat";
        return View();
    }

    [HttpGet("maltepe-ankara-nakliyat")]
    public IActionResult Maltepe()
    {
        ViewData["Title"]       = "Maltepe Ankara Nakliyat | Sahil İlçesinden Profesyonel Ev Taşıma";
        ViewData["Description"] = "Maltepe'den Ankara'ya evden eve nakliyat. Bağlarbaşı, Cevizli, Küçükyalı ve Gülensu mahallelerinden sigortalı, kapıdan kapıya taşıma. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/maltepe-ankara-nakliyat";
        return View();
    }

    [HttpGet("pendik-ankara-nakliyat")]
    public IActionResult Pendik()
    {
        ViewData["Title"]       = "Pendik Ankara Nakliyat | Havalimanı Yakınından Güvenli Taşıma";
        ViewData["Description"] = "Pendik'ten Ankara'ya nakliyat. Kurtköy, Kaynarca, Dolayoba ve Yenişehir mahallelerinden sigortalı, profesyonel ev ve ofis taşıma. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/pendik-ankara-nakliyat";
        return View();
    }

    [HttpGet("kartal-ankara-nakliyat")]
    public IActionResult Kartal()
    {
        ViewData["Title"]       = "Kartal Ankara Nakliyat | Anadolu Yakasından Profesyonel Taşıma";
        ViewData["Description"] = "Kartal'dan Ankara'ya evden eve nakliyat. Soğanlık, Yakacık, Cevizli ve Karlıktepe mahallelerinden sigortalı, kapıdan kapıya taşıma. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/kartal-ankara-nakliyat";
        return View();
    }

    [HttpGet("atasehir-ankara-nakliyat")]
    public IActionResult Atasehir()
    {
        ViewData["Title"]       = "Ataşehir Ankara Nakliyat | Finans Merkezinden Kurumsal Taşıma";
        ViewData["Description"] = "Ataşehir'den Ankara'ya nakliyat. İçerenköy, Ferhatpaşa, Küçükbakkalköy ve Yenisahra mahallelerinden sigortalı, kurumsal ev ve ofis taşıma. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/atasehir-ankara-nakliyat";
        return View();
    }

    [HttpGet("beykoz-ankara-nakliyat")]
    public IActionResult Beykoz()
    {
        ViewData["Title"]       = "Beykoz Ankara Nakliyat | Boğaz Kıyısı Villalardan Güvenli Taşıma";
        ViewData["Description"] = "Beykoz'dan Ankara'ya evden eve nakliyat. Çubuklu, Paşabahçe, Anadoluhisarı ve Riva mahallelerinden sigortalı, lüks ev taşıma hizmeti. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/beykoz-ankara-nakliyat";
        return View();
    }

    [HttpGet("cekmekoy-ankara-nakliyat")]
    public IActionResult Cekmekoy()
    {
        ViewData["Title"]       = "Çekmeköy Ankara Nakliyat | Orman İlçesinden Profesyonel Taşıma";
        ViewData["Description"] = "Çekmeköy'den Ankara'ya nakliyat. Taşdelen, Nişantepe, Hamidiye ve Mehmet Akif mahallelerinden sigortalı, kapıdan kapıya ev taşıma. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/cekmekoy-ankara-nakliyat";
        return View();
    }

    [HttpGet("sancaktepe-ankara-nakliyat")]
    public IActionResult Sancaktepe()
    {
        ViewData["Title"]       = "Sancaktepe Ankara Nakliyat | Gelişen İlçeden Güvenli Taşıma";
        ViewData["Description"] = "Sancaktepe'den Ankara'ya evden eve nakliyat. Veysel Karani, Eyüp Sultan, Fatih ve Kaynarca mahallelerinden sigortalı, profesyonel taşıma. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/sancaktepe-ankara-nakliyat";
        return View();
    }

    [HttpGet("sultanbeyli-ankara-nakliyat")]
    public IActionResult Sultanbeyli()
    {
        ViewData["Title"]       = "Sultanbeyli Ankara Nakliyat | Uygun Fiyatlı Profesyonel Taşıma";
        ViewData["Description"] = "Sultanbeyli'den Ankara'ya nakliyat. Mehmet Akif, Battalpasa, Hasanpaşa ve İnönü mahallelerinden sigortalı, ekonomik ev taşıma hizmeti. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/sultanbeyli-ankara-nakliyat";
        return View();
    }

    [HttpGet("tuzla-ankara-nakliyat")]
    public IActionResult Tuzla()
    {
        ViewData["Title"]       = "Tuzla Ankara Nakliyat | OSB ve Sanayi Bölgesinden Taşıma";
        ViewData["Description"] = "Tuzla'dan Ankara'ya nakliyat. İçmeler, Mimar Sinan, Aydınlı ve Postane mahallelerinden sigortalı ev ve kurumsal ofis taşıma. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/tuzla-ankara-nakliyat";
        return View();
    }

    [HttpGet("sile-ankara-nakliyat")]
    public IActionResult Sile()
    {
        ViewData["Title"]       = "Şile Ankara Nakliyat | Karadeniz Kıyısından Profesyonel Taşıma";
        ViewData["Description"] = "Şile'den Ankara'ya evden eve nakliyat. Şile Merkez, Ağva ve Gümüşpınar mahallelerinden sigortalı, kapıdan kapıya güvenli taşıma. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/sile-ankara-nakliyat";
        return View();
    }

    [HttpGet("adalar-ankara-nakliyat")]
    public IActionResult Adalar()
    {
        ViewData["Title"]       = "Adalar Ankara Nakliyat | İstanbul Adaları'ndan Özel Taşıma";
        ViewData["Description"] = "İstanbul Adaları'ndan Ankara'ya nakliyat. Büyükada, Heybeliada ve Burgazada'dan feribot + kara kombineli, sigortalı ev taşıma. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/adalar-ankara-nakliyat";
        return View();
    }

    // ── Avrupa Yakası ──────────────────────────────────────────
    [HttpGet("sisli-ankara-nakliyat")]
    public IActionResult Sisli()
    {
        ViewData["Title"]       = "Şişli Ankara Nakliyat | Nişantaşı ve Mecidiyeköy'den Taşıma";
        ViewData["Description"] = "Şişli'den Ankara'ya nakliyat. Nişantaşı, Mecidiyeköy, Bomonti ve Harbiye mahallelerinden sigortalı, kurumsal ev ve ofis taşıma. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/sisli-ankara-nakliyat";
        return View();
    }

    [HttpGet("besiktas-ankara-nakliyat")]
    public IActionResult Besiktas()
    {
        ViewData["Title"]       = "Beşiktaş Ankara Nakliyat | Levent ve Bebek'ten Lüks Taşıma";
        ViewData["Description"] = "Beşiktaş'tan Ankara'ya evden eve nakliyat. Levent, Bebek, Etiler, Ortaköy ve Balmumcu mahallelerinden sigortalı, premium taşıma hizmeti. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/besiktas-ankara-nakliyat";
        return View();
    }

    [HttpGet("bakirkoy-ankara-nakliyat")]
    public IActionResult Bakirkoy()
    {
        ViewData["Title"]       = "Bakırköy Ankara Nakliyat | Ataköy ve Florya'dan Güvenli Taşıma";
        ViewData["Description"] = "Bakırköy'den Ankara'ya nakliyat. Ataköy, Florya, Zuhuratbaba ve Cevizlik mahallelerinden sigortalı, kapıdan kapıya ev taşıma. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/bakirkoy-ankara-nakliyat";
        return View();
    }

    [HttpGet("beylikduzu-ankara-nakliyat")]
    public IActionResult Beylikduzu()
    {
        ViewData["Title"]       = "Beylikdüzü Ankara Nakliyat | Modern Konutlardan Profesyonel Taşıma";
        ViewData["Description"] = "Beylikdüzü'nden Ankara'ya nakliyat. Gürpınar, Adnan Kahveci, Büyükşehir ve Marmara mahallelerinden sigortalı, hızlı ev taşıma. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/beylikduzu-ankara-nakliyat";
        return View();
    }

    [HttpGet("esenyurt-ankara-nakliyat")]
    public IActionResult Esenyurt()
    {
        ViewData["Title"]       = "Esenyurt Ankara Nakliyat | İstanbul'un En Kalabalık İlçesinden Taşıma";
        ViewData["Description"] = "Esenyurt'tan Ankara'ya evden eve nakliyat. Talatpaşa, Saadetdere, Pınar ve Mehterçeşme mahallelerinden sigortalı, uygun fiyatlı taşıma. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/esenyurt-ankara-nakliyat";
        return View();
    }

    [HttpGet("basaksehir-ankara-nakliyat")]
    public IActionResult Basaksehir()
    {
        ViewData["Title"]       = "Başakşehir Ankara Nakliyat | Planlı Şehirden Konforlu Taşıma";
        ViewData["Description"] = "Başakşehir'den Ankara'ya nakliyat. Kayaşehir, Bahçeşehir, Altınşehir ve Şahintepe mahallelerinden sigortalı, geniş caddeli kolay erişimli taşıma. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/basaksehir-ankara-nakliyat";
        return View();
    }

    [HttpGet("arnavutkoy-ankara-nakliyat")]
    public IActionResult Arnavutkoy()
    {
        ViewData["Title"]       = "Arnavutköy Ankara Nakliyat | Havalimanı Yakınından Hızlı Taşıma";
        ViewData["Description"] = "Arnavutköy'den Ankara'ya nakliyat. Haraçcı, Bolluca, Hadımköy ve Taşoluk mahallelerinden sigortalı, havalimanı güzergahlı ev taşıma. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/arnavutkoy-ankara-nakliyat";
        return View();
    }

    [HttpGet("avcilar-ankara-nakliyat")]
    public IActionResult Avcilar()
    {
        ViewData["Title"]       = "Avcılar Ankara Nakliyat | Üniversite İlçesinden Profesyonel Taşıma";
        ViewData["Description"] = "Avcılar'dan Ankara'ya nakliyat. Ambarlı, Firuzköy, Üniversite ve Cihangir mahallelerinden sigortalı, öğrenci ve aile taşımaları. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/avcilar-ankara-nakliyat";
        return View();
    }

    [HttpGet("buyukcekemece-ankara-nakliyat")]
    public IActionResult Buyukcekemece()
    {
        ViewData["Title"]       = "Büyükçekmece Ankara Nakliyat | Göl Kıyısından Güvenli Taşıma";
        ViewData["Description"] = "Büyükçekmece'den Ankara'ya nakliyat. Mimarsinan, Pınarca, Güzelce ve Kumburgaz mahallelerinden sigortalı, kapıdan kapıya ev taşıma. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/buyukcekemece-ankara-nakliyat";
        return View();
    }

    [HttpGet("silivri-ankara-nakliyat")]
    public IActionResult Silivri()
    {
        ViewData["Title"]       = "Silivri Ankara Nakliyat | Marmara Kıyısından Profesyonel Taşıma";
        ViewData["Description"] = "Silivri'den Ankara'ya evden eve nakliyat. Silivri Merkez, Selimpaşa, Gümüşyaka ve Ortaköy mahallelerinden sigortalı, uzun mesafe taşıma. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/silivri-ankara-nakliyat";
        return View();
    }

    [HttpGet("catalca-ankara-nakliyat")]
    public IActionResult Catalca()
    {
        ViewData["Title"]       = "Çatalca Ankara Nakliyat | İstanbul'un Batı Ucundan Taşıma";
        ViewData["Description"] = "Çatalca'dan Ankara'ya nakliyat. Çatalca Merkez, Kapaklı, Yalıköy ve İnceğiz mahallelerinden sigortalı, çiftlik ve villa taşıma hizmeti. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/catalca-ankara-nakliyat";
        return View();
    }

    [HttpGet("fatih-ankara-nakliyat")]
    public IActionResult Fatih()
    {
        ViewData["Title"]       = "Fatih Ankara Nakliyat | Tarihi Yarımadadan Güvenli Ev Taşıma";
        ViewData["Description"] = "Fatih'ten Ankara'ya nakliyat. Aksaray, Samatya, Yedikule, Kocamustafapaşa ve Balat mahallelerinden sigortalı, tarihi bina deneyimli taşıma. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/fatih-ankara-nakliyat";
        return View();
    }

    [HttpGet("beyoglu-ankara-nakliyat")]
    public IActionResult Beyoglu()
    {
        ViewData["Title"]       = "Beyoğlu Ankara Nakliyat | Taksim ve Galata'dan Profesyonel Taşıma";
        ViewData["Description"] = "Beyoğlu'ndan Ankara'ya nakliyat. Karaköy, Cihangir, Galata, Taksim ve Pera mahallelerinden sigortalı, dar sokak deneyimli ev taşıma. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/beyoglu-ankara-nakliyat";
        return View();
    }

    [HttpGet("eyupsultan-ankara-nakliyat")]
    public IActionResult Eyupsultan()
    {
        ViewData["Title"]       = "Eyüpsultan Ankara Nakliyat | Haliç Kıyısından Güvenli Taşıma";
        ViewData["Description"] = "Eyüpsultan'dan Ankara'ya nakliyat. Alibeyköy, Göktürk, Nişanca ve Silahtarağa mahallelerinden sigortalı, kapıdan kapıya ev taşıma. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/eyupsultan-ankara-nakliyat";
        return View();
    }

    [HttpGet("sariyer-ankara-nakliyat")]
    public IActionResult Sariyer()
    {
        ViewData["Title"]       = "Sarıyer Ankara Nakliyat | Boğaz Kıyısı Köylerden Lüks Taşıma";
        ViewData["Description"] = "Sarıyer'den Ankara'ya nakliyat. Yeniköy, Tarabya, Büyükdere, İstinye ve Zekeriyaköy mahallelerinden sigortalı, lüks villa taşıma. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/sariyer-ankara-nakliyat";
        return View();
    }

    [HttpGet("kagithane-ankara-nakliyat")]
    public IActionResult Kagithane()
    {
        ViewData["Title"]       = "Kağıthane Ankara Nakliyat | Kentsel Dönüşüm İlçesinden Taşıma";
        ViewData["Description"] = "Kağıthane'den Ankara'ya nakliyat. Çağlayan, Gültepe, Seyrantepe ve Hamidiye mahallelerinden sigortalı, TEM bağlantılı hızlı ev taşıma. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/kagithane-ankara-nakliyat";
        return View();
    }

    [HttpGet("kucukcekemece-ankara-nakliyat")]
    public IActionResult Kucukcekemece()
    {
        ViewData["Title"]       = "Küçükçekmece Ankara Nakliyat | Halkalı ve Atakent'ten Taşıma";
        ViewData["Description"] = "Küçükçekmece'den Ankara'ya nakliyat. Atakent, Halkalı, Cennet ve Fatih mahallelerinden sigortalı, E-5 güzergahlı hızlı ev taşıma. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/kucukcekemece-ankara-nakliyat";
        return View();
    }

    [HttpGet("bahcelievler-ankara-nakliyat")]
    public IActionResult Bahcelievler()
    {
        ViewData["Title"]       = "Bahçelievler Ankara Nakliyat | E-5 Güzergahından Hızlı Taşıma";
        ViewData["Description"] = "Bahçelievler'den Ankara'ya nakliyat. Şirinevler, Kocasinan, Zafer ve Soğanlı mahallelerinden sigortalı, metrobüs hatlı kolay ulaşımlı taşıma. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/bahcelievler-ankara-nakliyat";
        return View();
    }

    [HttpGet("bagcilar-ankara-nakliyat")]
    public IActionResult Bagcilar()
    {
        ViewData["Title"]       = "Bağcılar Ankara Nakliyat | Metrobüs Hattından Profesyonel Taşıma";
        ViewData["Description"] = "Bağcılar'dan Ankara'ya nakliyat. Kirazlı, Mahmutbey, Göztepe ve Yıldıztepe mahallelerinden sigortalı, E-5 ve metrobüs erişimli ev taşıma. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/bagcilar-ankara-nakliyat";
        return View();
    }

    [HttpGet("gungoren-ankara-nakliyat")]
    public IActionResult Gungoren()
    {
        ViewData["Title"]       = "Güngören Ankara Nakliyat | Tekstil İlçesinden Profesyonel Taşıma";
        ViewData["Description"] = "Güngören'den Ankara'ya nakliyat. Merter, Tozkoparan, Güven ve Mehmet Nesih Özmen mahallelerinden sigortalı, dar sokak deneyimli ev taşıma. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/gungoren-ankara-nakliyat";
        return View();
    }

    [HttpGet("zeytinburnu-ankara-nakliyat")]
    public IActionResult Zeytinburnu()
    {
        ViewData["Title"]       = "Zeytinburnu Ankara Nakliyat | Sanayi İlçesinden Güvenli Taşıma";
        ViewData["Description"] = "Zeytinburnu'ndan Ankara'ya nakliyat. Kazlıçeşme, Merkezefendi, Seyitnizam ve Veliefendi mahallelerinden sigortalı, tramvay erişimli ev taşıma. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/zeytinburnu-ankara-nakliyat";
        return View();
    }

    [HttpGet("bayrampasa-ankara-nakliyat")]
    public IActionResult Bayrampasa()
    {
        ViewData["Title"]       = "Bayrampaşa Ankara Nakliyat | E-5 Kavşağından Hızlı Ev Taşıma";
        ViewData["Description"] = "Bayrampaşa'dan Ankara'ya nakliyat. Kocatepe, Orta, Muratpaşa ve İsmetpaşa mahallelerinden sigortalı, merkezi konumlu hızlı taşıma. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/bayrampasa-ankara-nakliyat";
        return View();
    }

    [HttpGet("esenler-ankara-nakliyat")]
    public IActionResult Esenler()
    {
        ViewData["Title"]       = "Esenler Ankara Nakliyat | Büyük Otogar Yakınından Taşıma";
        ViewData["Description"] = "Esenler'den Ankara'ya nakliyat. Birlik, Turgut Reis, Nene Hatun ve Çiftlik mahallelerinden sigortalı, büyük otogar güzergahlı ev taşıma. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/esenler-ankara-nakliyat";
        return View();
    }

    [HttpGet("gaziosmanpasa-ankara-nakliyat")]
    public IActionResult Gaziosmanpasa()
    {
        ViewData["Title"]       = "Gaziosmanpaşa Ankara Nakliyat | Kuzey İstanbul'dan Profesyonel Taşıma";
        ViewData["Description"] = "Gaziosmanpaşa'dan Ankara'ya nakliyat. Barbaros, Karadeniz, Bağlarbaşı ve Karlıtepe mahallelerinden sigortalı, köklü ilçe deneyimli ev taşıma. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/gaziosmanpasa-ankara-nakliyat";
        return View();
    }

    [HttpGet("sultangazi-ankara-nakliyat")]
    public IActionResult Sultangazi()
    {
        ViewData["Title"]       = "Sultangazi Ankara Nakliyat | Kuzey İstanbul'dan Uygun Fiyatlı Taşıma";
        ViewData["Description"] = "Sultangazi'den Ankara'ya nakliyat. Cebeci, Uğur Mumcu, Habibler ve Sultançiftliği mahallelerinden sigortalı, ekonomik ev taşıma hizmeti. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/sultangazi-ankara-nakliyat";
        return View();
    }
}
