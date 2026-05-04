using IstanbulAnkaraNakliyat.Models;
using Microsoft.AspNetCore.Mvc;

namespace IstanbulAnkaraNakliyat.Controllers;

/// <summary>
/// İstanbul ilçesi × servis tipi kombinasyonu sayfaları
/// URL pattern: /{ilce}-ankara-{servis}-nakliyat
/// View: Views/IstanbulIlceVariant/ServisPage.cshtml
/// </summary>
public class IstanbulIlceVariantController : Controller
{
    // ── İlçe verisi (NakliyatController._istanbul + hadimkoy + ikitelli) ──
    private static readonly Dictionary<string, (string Name, string Ozellik, string[] Mahalleler, (string N, string S)[] Yakin)>
        _ilceler = new()
    {
        ["kadikoy"]       = ("Kadıköy",       "Anadolu yakasının kültür, gastronomi ve ticaret merkezi",                   ["Moda","Bostancı","Fenerbahçe","Fikirtepe","Caferağa"],          [("Üsküdar","uskudar"),("Maltepe","maltepe"),("Ataşehir","atasehir"),("Kartal","kartal")]),
        ["uskudar"]       = ("Üsküdar",       "Tarihi ve doğal güzellikleriyle İstanbul'un gözde ilçesi",                  ["Çengelköy","Kandilli","Beylerbeyi","Kuzguncuk","Salacak"],      [("Kadıköy","kadikoy"),("Beykoz","beykoz"),("Ümraniye","umraniye"),("Ataşehir","atasehir")]),
        ["umraniye"]      = ("Ümraniye",      "Anadolu yakasının hızla gelişen modern yaşam merkezi",                     ["Armağanevler","Siteler","İnkılap","Yunus Emre","Namık Kemal"], [("Ataşehir","atasehir"),("Çekmeköy","cekmekoy"),("Sancaktepe","sancaktepe"),("Üsküdar","uskudar")]),
        ["maltepe"]       = ("Maltepe",       "Deniz manzaralı ve gelişmiş altyapısıyla Anadolu yakası ilçesi",           ["Bağlarbaşı","Cevizli","Gülensu","Küçükyalı","Altayçeşme"],    [("Kadıköy","kadikoy"),("Kartal","kartal"),("Pendik","pendik"),("Ataşehir","atasehir")]),
        ["pendik"]        = ("Pendik",        "Havalimanına yakınlığıyla stratejik konumlu Anadolu ilçesi",               ["Kurtköy","Kaynarca","Dolayoba","Yenişehir","Şeyhli"],           [("Kartal","kartal"),("Tuzla","tuzla"),("Maltepe","maltepe"),("Sancaktepe","sancaktepe")]),
        ["kartal"]        = ("Kartal",        "Sanayi ve konutun iç içe geçtiği dinamik Anadolu yakası ilçesi",          ["Soğanlık","Yakacık","Uğur Mumcu","Cevizli","Karlıktepe"],      [("Maltepe","maltepe"),("Pendik","pendik"),("Sultanbeyli","sultanbeyli"),("Ümraniye","umraniye")]),
        ["atasehir"]      = ("Ataşehir",      "İstanbul'un yükselen finans ve yaşam merkezi",                             ["Ataşehir Merkez","İçerenköy","Ferhatpaşa","Küçükbakkalköy","Yenisahra"],[("Kadıköy","kadikoy"),("Ümraniye","umraniye"),("Maltepe","maltepe"),("Üsküdar","uskudar")]),
        ["beykoz"]        = ("Beykoz",        "Boğaz'ın Anadolu yakasındaki yeşil ve sakin ilçesi",                      ["Çubuklu","Paşabahçe","Anadoluhisarı","Riva","Polonezköy"],     [("Üsküdar","uskudar"),("Çekmeköy","cekmekoy"),("Sarıyer","sariyer"),("Ümraniye","umraniye")]),
        ["cekmekoy"]      = ("Çekmeköy",      "İstanbul'un doğusunda huzurlu ve yeşil bir yaşam sunan ilçe",             ["Çekmeköy Merkez","Mehmet Akif","Nişantepe","Taşdelen","Hamidiye"],[("Ümraniye","umraniye"),("Sancaktepe","sancaktepe"),("Beykoz","beykoz"),("Sultanbeyli","sultanbeyli")]),
        ["sancaktepe"]    = ("Sancaktepe",    "Gelişmekte olan altyapısıyla Anadolu yakasının yeni cazibe merkezi",      ["Sancaktepe Merkez","Kaynarca","Veysel Karani","Fatih","Eyüp Sultan"],[("Ümraniye","umraniye"),("Çekmeköy","cekmekoy"),("Kartal","kartal"),("Sultanbeyli","sultanbeyli")]),
        ["sultanbeyli"]   = ("Sultanbeyli",   "İstanbul Anadolu yakasında konut yoğunluğu yüksek ilçe",                  ["Sultanbeyli Merkez","Mehmet Akif","Battalpasa","Hasanpaşa","İnönü"],[("Kartal","kartal"),("Pendik","pendik"),("Sancaktepe","sancaktepe"),("Ümraniye","umraniye")]),
        ["tuzla"]         = ("Tuzla",         "Sanayi tesisleri ve sahil şeridiyle öne çıkan güneydoğu ilçesi",          ["İçmeler","Mimar Sinan","Aydınlı","Postane","Tepeören"],         [("Pendik","pendik"),("Kartal","kartal"),("Sancaktepe","sancaktepe"),("Maltepe","maltepe")]),
        ["sile"]          = ("Şile",          "Karadeniz kıyısındaki doğal ve sakin İstanbul ilçesi",                    ["Şile Merkez","Ağva","Gümüşpınar","Doğancalı","Hacıllı"],        [("Beykoz","beykoz"),("Çekmeköy","cekmekoy"),("Ümraniye","umraniye"),("Sancaktepe","sancaktepe")]),
        ["adalar"]        = ("Adalar",        "İstanbul'un araçsız yaşam alanları, Prens Adaları",                       ["Büyükada","Heybeliada","Burgazada","Kınalıada"],                [("Kadıköy","kadikoy"),("Pendik","pendik"),("Tuzla","tuzla"),("Maltepe","maltepe")]),
        ["sisli"]         = ("Şişli",         "Nişantaşı ve Mecidiyeköy'ün lüks ve iş dünyasını barındıran ilçe",       ["Mecidiyeköy","Bomonti","Harbiye","Nişantaşı","Kurtuluş"],      [("Beşiktaş","besiktas"),("Kağıthane","kagithane"),("Beyoğlu","beyoglu"),("Sarıyer","sariyer")]),
        ["besiktas"]      = ("Beşiktaş",      "Boğaz kıyısında konumlanan İstanbul'un en prestijli ilçesi",             ["Levent","Balmumcu","Etiler","Bebek","Ortaköy"],                 [("Şişli","sisli"),("Sarıyer","sariyer"),("Kağıthane","kagithane"),("Beyoğlu","beyoglu")]),
        ["bakirkoy"]      = ("Bakırköy",      "Sahil şeridi ve alışveriş merkezleriyle öne çıkan prestijli ilçe",       ["Ataköy","Florya","Zuhuratbaba","Cevizlik","Osmaniye"],          [("Zeytinburnu","zeytinburnu"),("Küçükçekmece","kucukcekemece"),("Bahçelievler","bahcelievler"),("Güngören","gungoren")]),
        ["beylikduzu"]    = ("Beylikdüzü",    "Modern konut projeleri ve alışveriş merkezleriyle öne çıkan batı ilçesi", ["Beylikdüzü Merkez","Gürpınar","Büyükşehir","Adnan Kahveci","Marmara"],[("Esenyurt","esenyurt"),("Avcılar","avcilar"),("Büyükçekmece","buyukcekemece"),("Küçükçekmece","kucukcekemece")]),
        ["esenyurt"]      = ("Esenyurt",      "İstanbul'un en hızlı büyüyen ve en kalabalık ilçelerinden biri",         ["Esenyurt Merkez","Talatpaşa","Saadetdere","Pınar","Mehterçeşme"],[("Avcılar","avcilar"),("Küçükçekmece","kucukcekemece"),("Büyükçekmece","buyukcekemece"),("Arnavutköy","arnavutkoy")]),
        ["basaksehir"]    = ("Başakşehir",    "Modern planlı yapısı ve geniş yeşil alanlarıyla öne çıkan ilçe",         ["Başakşehir Merkez","Kayaşehir","Bahçeşehir","Altınşehir","Şahintepe"],[("Esenyurt","esenyurt"),("Küçükçekmece","kucukcekemece"),("Arnavutköy","arnavutkoy"),("Bağcılar","bagcilar")]),
        ["arnavutkoy"]    = ("Arnavutköy",    "İstanbul Havalimanı yakınlığıyla değer kazanan kuzey ilçesi",            ["Arnavutköy Merkez","Haraçcı","Bolluca","Hadımköy","Taşoluk"],   [("Başakşehir","basaksehir"),("Esenyurt","esenyurt"),("Büyükçekmece","buyukcekemece"),("Eyüpsultan","eyupsultan")]),
        ["hadimkoy"]      = ("Hadımköy",      "TEM otoyoluna ve İstanbul Havalimanı'na yakın sanayi merkezi",           ["Hadımköy Merkez","Hadımköy OSB","Taşoluk","Bolluca","Haraçcı"], [("Arnavutköy","arnavutkoy"),("Başakşehir","basaksehir"),("Esenyurt","esenyurt"),("Büyükçekmece","buyukcekemece")]),
        ["ikitelli"]      = ("İkitelli",      "Büyük organize sanayi bölgesi ve çevresiyle gelişen batı İstanbul ilçesi",["İkitelli OSB","Kazım Karabekir","Ziya Gökalp","Kanarya","Mehmet Akif"],[("Başakşehir","basaksehir"),("Bağcılar","bagcilar"),("Küçükçekmece","kucukcekemece"),("Esenler","esenler")]),
        ["avcilar"]       = ("Avcılar",       "İstanbul üniversiteleri kampüsü ve sanayi bölgesiyle tanınan ilçe",      ["Ambarlı","Cihangir","Firuzköy","Tahtakale","Üniversite"],       [("Küçükçekmece","kucukcekemece"),("Esenyurt","esenyurt"),("Büyükçekmece","buyukcekemece"),("Beylikdüzü","beylikduzu")]),
        ["buyukcekemece"]  = ("Büyükçekmece", "Plajları ve göl kıyısıyla İstanbul'un batısındaki sakin ilçe",           ["Mimarsinan","Pınarca","Güzelce","Karaağaç","Kumburgaz"],        [("Esenyurt","esenyurt"),("Avcılar","avcilar"),("Silivri","silivri"),("Arnavutköy","arnavutkoy")]),
        ["silivri"]       = ("Silivri",       "Marmara kıyısında yazlık ve tarım alanlarıyla İstanbul'un batı kapısı",  ["Silivri Merkez","Selimpaşa","Ortaköy","Gümüşyaka","Alibey"],    [("Büyükçekmece","buyukcekemece"),("Çatalca","catalca"),("Avcılar","avcilar"),("Esenyurt","esenyurt")]),
        ["catalca"]       = ("Çatalca",       "İstanbul'un en büyük yüzölçümlü ilçesi, doğa ve kırsal yaşam alanı",    ["Çatalca Merkez","Kapaklı","Yalıköy","Ferhatpaşa","İnceğiz"],    [("Silivri","silivri"),("Büyükçekmece","buyukcekemece"),("Arnavutköy","arnavutkoy"),("Esenyurt","esenyurt")]),
        ["kucukcekemece"] = ("Küçükçekmece",  "Göl kıyısındaki modern konut projeleriyle büyüyen Avrupa yakası ilçesi", ["Atakent","Halkalı","İnönü","Cennet","Fatih"],                    [("Bakırköy","bakirkoy"),("Esenyurt","esenyurt"),("Avcılar","avcilar"),("Bağcılar","bagcilar")]),
        ["gungoren"]      = ("Güngören",      "Tekstil atölyeleri ve çarşılarıyla tanınan yoğun nüfuslu ilçe",         ["Güngören Merkez","Tozkoparan","Güven","Mehmet Nesih Özmen","Merter"],[("Zeytinburnu","zeytinburnu"),("Bağcılar","bagcilar"),("Bahçelievler","bahcelievler"),("Bakırköy","bakirkoy")]),
        ["bahcelievler"]  = ("Bahçelievler",  "Konut yoğunluğu yüksek, ulaşım ağıyla merkezi Avrupa yakası ilçesi",   ["Kocasinan","Soğanlı","Zafer","Şirinevler","Cumhuriyet"],        [("Bağcılar","bagcilar"),("Güngören","gungoren"),("Bakırköy","bakirkoy"),("Bayrampaşa","bayrampasa")]),
        ["bagcilar"]      = ("Bağcılar",      "İstanbul'un en kalabalık ilçelerinden biri, gelişmiş ulaşım ağına sahip",["Bağcılar Merkez","Kirazlı","Göztepe","Yıldıztepe","Mahmutbey"], [("Güngören","gungoren"),("Bahçelievler","bahcelievler"),("Esenler","esenler"),("Bayrampaşa","bayrampasa")]),
        ["esenler"]       = ("Esenler",       "Otogar yakınlığıyla ulaşım avantajlı İstanbul ilçesi",                  ["Birlik","Turgut Reis","Nene Hatun","Çiftlik","Kemer"],          [("Bağcılar","bagcilar"),("Bayrampaşa","bayrampasa"),("Gaziosmanpaşa","gaziosmanpasa"),("Sultangazi","sultangazi")]),
        ["bayrampasa"]    = ("Bayrampaşa",    "E-5 ve TEM bağlantısıyla merkezi konumda, yoğun trafiğe yakın ilçe",    ["Bayrampaşa Merkez","Kocatepe","Orta","Muratpaşa","İsmetpaşa"], [("Zeytinburnu","zeytinburnu"),("Bağcılar","bagcilar"),("Esenler","esenler"),("Gaziosmanpaşa","gaziosmanpasa")]),
        ["gaziosmanpasa"] = ("Gaziosmanpaşa", "Köklü yerleşim geçmişiyle İstanbul'un kuzey Avrupa yakası ilçesi",      ["Karadeniz","Barbaros","Yenidoğan","Bağlarbaşı","Karlıtepe"],    [("Sultangazi","sultangazi"),("Esenler","esenler"),("Bayrampaşa","bayrampasa"),("Eyüpsultan","eyupsultan")]),
        ["sultangazi"]    = ("Sultangazi",    "Kuzey İstanbul'da hızla gelişen modern konut ilçesi",                    ["Cebeci","Uğur Mumcu","Sultançiftliği","Habibler","Malkoçoğlu"],  [("Gaziosmanpaşa","gaziosmanpasa"),("Eyüpsultan","eyupsultan"),("Arnavutköy","arnavutkoy"),("Esenler","esenler")]),
        ["kagithane"]     = ("Kağıthane",     "Yenilenen kentsel dönüşüm projeleriyle değer kazanan merkezi ilçe",      ["Çağlayan","Gültepe","Seyrantepe","Hamidiye","Ortabayır"],       [("Şişli","sisli"),("Beyoğlu","beyoglu"),("Gaziosmanpaşa","gaziosmanpasa"),("Sarıyer","sariyer")]),
        ["beyoglu"]       = ("Beyoğlu",       "Taksim, Galata ve Karaköy ile İstanbul'un tarihi kültür merkezi",        ["Karaköy","Cihangir","Galata","Taksim","Pera"],                  [("Şişli","sisli"),("Kağıthane","kagithane"),("Fatih","fatih"),("Beşiktaş","besiktas")]),
        ["fatih"]         = ("Fatih",         "Tarihi yarımadada İstanbul'un en köklü ve tarihi ilçesi",                ["Aksaray","Samatya","Yedikule","Kocamustafapaşa","Balat"],       [("Zeytinburnu","zeytinburnu"),("Beyoğlu","beyoglu"),("Eyüpsultan","eyupsultan"),("Bayrampaşa","bayrampasa")]),
        ["eyupsultan"]    = ("Eyüpsultan",    "Tarihi dokusuyla İstanbul'un manevi merkezi, Haliç kıyısı ilçesi",       ["Alibeyköy","Göktürk","Nişanca","Düğmeciler","Silahtarağa"],     [("Fatih","fatih"),("Sultangazi","sultangazi"),("Gaziosmanpaşa","gaziosmanpasa"),("Kağıthane","kagithane")]),
        ["sariyer"]       = ("Sarıyer",       "Boğaz kıyısı köyleri ve doğal güzellikleriyle İstanbul'un kuzeyindeki ilçe",["Yeniköy","Tarabya","Büyükdere","İstinye","Zekeriyaköy"],  [("Beşiktaş","besiktas"),("Kağıthane","kagithane"),("Beykoz","beykoz"),("Arnavutköy","arnavutkoy")]),
        ["zeytinburnu"]   = ("Zeytinburnu",   "İstanbul'un köklü sanayi ve tekstil ilçesi",                             ["Kazlıçeşme","Merkezefendi","Nuripaşa","Seyitnizam","Veliefendi"],[("Bakırköy","bakirkoy"),("Fatih","fatih"),("Güngören","gungoren"),("Bayrampaşa","bayrampasa")]),
    };

    private IstanbulIlceServisModel? BuildModel(string ilce, ServisTipi servis)
    {
        if (!_ilceler.TryGetValue(ilce, out var d)) return null;
        return new IstanbulIlceServisModel
        {
            IlceAdi      = d.Name,
            IlceSlug     = ilce,
            IlceOzellik  = d.Ozellik,
            Mahalleler   = d.Mahalleler,
            YakinIlceler = d.Yakin.Select(x => (x.N, x.S)).ToArray(),
            Servis       = servis
        };
    }

    // ── 8 SERVIS TİPİ — her biri tüm geçerli ilçe sluglarını karşılar ──

    [HttpGet("{ilce}-ankara-kamyonet-nakliyat")]
    public IActionResult Kamyonet(string ilce)
    {
        var m = BuildModel(ilce, ServisTipi.Kamyonet);
        if (m is null) return NotFound();
        ViewData["Title"]       = m.SeoTitle;
        ViewData["Description"] = m.SeoDescription;
        ViewData["Canonical"]   = m.PageUrl;
        return View("ServisPage", m);
    }

    [HttpGet("{ilce}-ankara-sehirlerarasi-nakliyat")]
    public IActionResult Sehirlerarasi(string ilce)
    {
        var m = BuildModel(ilce, ServisTipi.Sehirlerarasi);
        if (m is null) return NotFound();
        ViewData["Title"]       = m.SeoTitle;
        ViewData["Description"] = m.SeoDescription;
        ViewData["Canonical"]   = m.PageUrl;
        return View("ServisPage", m);
    }

    [HttpGet("{ilce}-ankara-evden-eve-nakliyat")]
    public IActionResult EvdenEve(string ilce)
    {
        var m = BuildModel(ilce, ServisTipi.EvdenEve);
        if (m is null) return NotFound();
        ViewData["Title"]       = m.SeoTitle;
        ViewData["Description"] = m.SeoDescription;
        ViewData["Canonical"]   = m.PageUrl;
        return View("ServisPage", m);
    }

    [HttpGet("{ilce}-ankara-ofis-nakliyat")]
    public IActionResult Ofis(string ilce)
    {
        var m = BuildModel(ilce, ServisTipi.Ofis);
        if (m is null) return NotFound();
        ViewData["Title"]       = m.SeoTitle;
        ViewData["Description"] = m.SeoDescription;
        ViewData["Canonical"]   = m.PageUrl;
        return View("ServisPage", m);
    }

    [HttpGet("{ilce}-ankara-fuar-nakliyat")]
    public IActionResult Fuar(string ilce)
    {
        var m = BuildModel(ilce, ServisTipi.Fuar);
        if (m is null) return NotFound();
        ViewData["Title"]       = m.SeoTitle;
        ViewData["Description"] = m.SeoDescription;
        ViewData["Canonical"]   = m.PageUrl;
        return View("ServisPage", m);
    }

    [HttpGet("{ilce}-ankara-kamyon-nakliyat")]
    public IActionResult Kamyon(string ilce)
    {
        var m = BuildModel(ilce, ServisTipi.Kamyon);
        if (m is null) return NotFound();
        ViewData["Title"]       = m.SeoTitle;
        ViewData["Description"] = m.SeoDescription;
        ViewData["Canonical"]   = m.PageUrl;
        return View("ServisPage", m);
    }

    [HttpGet("{ilce}-ankara-parsiyel-nakliyat")]
    public IActionResult Parsiyel(string ilce)
    {
        var m = BuildModel(ilce, ServisTipi.Parsiyel);
        if (m is null) return NotFound();
        ViewData["Title"]       = m.SeoTitle;
        ViewData["Description"] = m.SeoDescription;
        ViewData["Canonical"]   = m.PageUrl;
        return View("ServisPage", m);
    }

    [HttpGet("{ilce}-ankara-ambar-nakliyat")]
    public IActionResult Ambar(string ilce)
    {
        var m = BuildModel(ilce, ServisTipi.Ambar);
        if (m is null) return NotFound();
        ViewData["Title"]       = m.SeoTitle;
        ViewData["Description"] = m.SeoDescription;
        ViewData["Canonical"]   = m.PageUrl;
        return View("ServisPage", m);
    }

    // ── Sitemap için slug listesi ──
    public static IReadOnlyList<string> Sluglar => _ilceler.Keys.ToList();
    public static readonly string[] ServisSluglar = ["kamyonet","sehirlerarasi","evden-eve","ofis","fuar","kamyon","parsiyel","ambar"];
}
