using IstanbulAnkaraNakliyat.Models;
using Microsoft.AspNetCore.Mvc;

namespace IstanbulAnkaraNakliyat.Controllers;

/// <summary>
/// Ankara ilçesi × servis tipi kombinasyonu sayfaları (Ankara → İstanbul)
/// URL pattern: /{ilce}-istanbul-{servis}-nakliyat
/// View: Views/AnkaraIlceVariant/ServisPage.cshtml
/// </summary>
public class AnkaraIlceVariantController : Controller
{
    private static readonly Dictionary<string, (string Name, string Ozellik, string[] Mahalleler, (string N, string S)[] Yakin)>
        _ilceler = new()
    {
        ["cankaya"]           = ("Çankaya",           "Ankara'nın en kalabalık ve merkezi ilçesi, Kızılay ve Kavaklidere ile",            ["Kızılay","Oran","Balgat","Kavaklidere","Bahçelievler"],           [("Keçiören","kecioren"),("Gölbaşı","golbasi"),("Yenimahalle","yenimahalle"),("Mamak","mamak")]),
        ["kecioren"]          = ("Keçiören",          "Ankara'nın kuzeyinde köklü ve kalabalık yerleşim alanı",                           ["Etlik","Bağlum","Kalaba","Kuşcağız","Aktepe"],                    [("Çankaya","cankaya"),("Altındağ","altindag"),("Yenimahalle","yenimahalle"),("Pursaklar","pursaklar")]),
        ["yenimahalle"]       = ("Yenimahalle",       "Modern mahalleler ve sanayi bölgesiyle batı Ankara'nın gelişen ilçesi",             ["Demetevler","Batıkent","Şentepe","Ostim","İvedik"],               [("Çankaya","cankaya"),("Keçiören","kecioren"),("Sincan","sincan"),("Etimesgut","etimesgut")]),
        ["mamak"]             = ("Mamak",             "Doğu Ankara'da köklü yerleşim geçmişiyle bilinen ilçe",                            ["Şahintepe","Hüseyingazi","Kutlu","Tuzluçayır","Mamak Merkez"],    [("Çankaya","cankaya"),("Altındağ","altindag"),("Akyurt","akyurt"),("Elmadağ","elmadag")]),
        ["etimesgut"]         = ("Etimesgut",         "Modern konut projeleri ve Eryaman ile öne çıkan batı Ankara ilçesi",                ["Elvankent","Eryaman","Göksu","Yapracık","Etimesgut Merkez"],      [("Yenimahalle","yenimahalle"),("Sincan","sincan"),("Keçiören","kecioren"),("Çankaya","cankaya")]),
        ["sincan"]            = ("Sincan",            "TEM otoyolu bağlantısıyla sanayi ve konut alanlarını barındıran ilçe",              ["Sincan Merkez","Fatih","Pirinçlik","Doğukan","Anıt"],             [("Etimesgut","etimesgut"),("Yenimahalle","yenimahalle"),("Kahramankazan","kahramankazan"),("Ayaş","ayas")]),
        ["altindag"]          = ("Altındağ",          "Hamamönü ve Ulus ile Ankara'nın tarihi ve ticaret merkezi",                        ["Ulus","Hamamönü","Çiçek","Atıfbey","Anafartalar"],               [("Çankaya","cankaya"),("Keçiören","kecioren"),("Mamak","mamak"),("Pursaklar","pursaklar")]),
        ["golbasi"]           = ("Gölbaşı",           "Mogan Gölü kıyısında sakin ve yeşil yaşam sunan Ankara ilçesi",                    ["Gölbaşı Merkez","Tulumtaş","Şekerci","Yavrucak","Atatürk"],      [("Çankaya","cankaya"),("Haymana","haymana"),("Bala","bala"),("Sincan","sincan")]),
        ["pursaklar"]         = ("Pursaklar",         "Kuzey Ankara'da gelişen yeni konut alanlarıyla öne çıkan ilçe",                    ["Pursaklar Merkez","İstasyon","Saray","Karacaören","Hacıhasan"],   [("Keçiören","kecioren"),("Çubuk","cubuk"),("Akyurt","akyurt"),("Kahramankazan","kahramankazan")]),
        ["polatli"]           = ("Polatlı",           "Batı Ankara'nın büyük ve tarihi ilçesi, İnönü Savaşı'nın yaşandığı topraklar",     ["Polatlı Merkez","Yenidoğan","Seymen","Yenikent","Fatih"],         [("Sincan","sincan"),("Haymana","haymana"),("Nallıhan","nallihan"),("Ayaş","ayas")]),
        ["akyurt"]            = ("Akyurt",            "Kuzey Ankara'da sanayi ve yerleşim dengesiyle gelişen ilçe",                       ["Akyurt Merkez","Karaağaç","Yaylabağ","Soğulca","Karahisar"],      [("Pursaklar","pursaklar"),("Çubuk","cubuk"),("Kahramankazan","kahramankazan"),("Elmadağ","elmadag")]),
        ["elmadag"]           = ("Elmadağ",           "Ankara'nın doğusunda orman ve askeri alanlar içindeki sakin ilçe",                  ["Elmadağ Merkez","Hasanoğlan","Balışeyh","Elmaağaç","Yazıkent"],   [("Mamak","mamak"),("Akyurt","akyurt"),("Kalecik","kalecik"),("Çubuk","cubuk")]),
        ["beypazari"]         = ("Beypazarı",         "Tarihi Osmanlı dokusu ve el sanatlarıyla Ankara'nın batı ilçesi",                   ["Beypazarı Merkez","Doğantepe","Pazar","Kırkpınar","Güdük"],       [("Nallıhan","nallihan"),("Ayaş","ayas"),("Güdül","gudul"),("Çamlıdere","camlidere")]),
        ["kahramankazan"]     = ("Kahramankazan",     "OSB ve sanayi tesisleriyle kuzeybatı Ankara'nın üretim merkezi",                    ["Kazan Merkez","Fatih","İstasyon","Akçaören","Yakuplu"],           [("Sincan","sincan"),("Akyurt","akyurt"),("Çubuk","cubuk"),("Pursaklar","pursaklar")]),
        ["cubuk"]             = ("Çubuk",             "Turşusuyla ünlü, Ankara'nın kuzeyindeki kırsal ilçe",                              ["Çubuk Merkez","Ovacık","Karacaören","Taşpınar","Eşmişehir"],      [("Pursaklar","pursaklar"),("Akyurt","akyurt"),("Kahramankazan","kahramankazan"),("Keçiören","kecioren")]),
        ["kizilcahamam"]      = ("Kızılcahamam",      "Termal kaynakları ve ormanlık alanıyla Ankara'nın kuzey ilçesi",                    ["Kızılcahamam Merkez","Çeltikçi","Güvem","Yenice","Büyükyenice"], [("Çamlıdere","camlidere"),("Güdül","gudul"),("Çubuk","cubuk"),("Kahramankazan","kahramankazan")]),
        ["nallihan"]          = ("Nallıhan",          "Sakarya Nehri kıyısında Ankara'nın batı sınırındaki ilçe",                          ["Nallıhan Merkez","Davutoğlan","Hamidiye","Çayırhan","Seyitler"],  [("Beypazarı","beypazari"),("Ayaş","ayas"),("Polatlı","polatli"),("Güdül","gudul")]),
        ["ayas"]              = ("Ayaş",              "Bağları ve yaylaları ile Ankara'nın batısındaki sakin ilçe",                        ["Ayaş Merkez","Belpınar","Dodurga","Köseler","Yukarıçiğil"],       [("Beypazarı","beypazari"),("Nallıhan","nallihan"),("Sincan","sincan"),("Polatlı","polatli")]),
        ["bala"]              = ("Bala",              "Güney Ankara'da tarım alanları ve Kızılırmak havzasındaki ilçe",                    ["Bala Merkez","Hacılar","Karapınar","Karakaya","Güdük"],           [("Gölbaşı","golbasi"),("Haymana","haymana"),("Şereflikoçhisar","sereflikocehisar"),("Evren","evren")]),
        ["gudul"]             = ("Güdül",             "Ankara Boğazı ve doğal kanyonuyla kuzeybatı Ankara'nın sakin ilçesi",               ["Güdül Merkez","Kabaklar","Çayırhan","Bozan","Karaali"],           [("Çamlıdere","camlidere"),("Beypazarı","beypazari"),("Kızılcahamam","kizilcahamam"),("Nallıhan","nallihan")]),
        ["camlidere"]         = ("Çamlıdere",         "Ormanlık alanları ve doğal güzellikleriyle kuzeybatı Ankara ilçesi",                ["Çamlıdere Merkez","Örencik","Şahinler","Çamkoru","Yazıcık"],      [("Güdül","gudul"),("Kızılcahamam","kizilcahamam"),("Çubuk","cubuk"),("Beypazarı","beypazari")]),
        ["haymana"]           = ("Haymana",           "Termal suları ve bozkırıyla güney Ankara'nın sakin kırsal ilçesi",                  ["Haymana Merkez","Yeşilyurt","Yavrucak","Derebucak","Karacaören"],[("Gölbaşı","golbasi"),("Bala","bala"),("Polatlı","polatli"),("Çankaya","cankaya")]),
        ["evren"]             = ("Evren",             "Ankara'nın en küçük ve sakin ilçelerinden biri",                                    ["Evren Merkez","Boyalı","Karşıyaka","Erikli"],                     [("Bala","bala"),("Şereflikoçhisar","sereflikocehisar"),("Kalecik","kalecik"),("Haymana","haymana")]),
        ["kalecik"]           = ("Kalecik",           "Kızılırmak kıyısında bağları ve tarihi kalesiyle bilinen ilçe",                     ["Kalecik Merkez","Erikli","Koçubey","Delice","Çandır"],            [("Akyurt","akyurt"),("Elmadağ","elmadag"),("Çubuk","cubuk"),("Evren","evren")]),
        ["sereflikocehisar"]  = ("Şereflikoçhisar",  "Tuz Gölü kıyısında tuz üretimi ve tarımıyla güneydoğu Ankara ilçesi",               ["Şereflikoçhisar Merkez","Akpınar","Yenice","Karacaören","Cihanbeyli"],[("Bala","bala"),("Evren","evren"),("Haymana","haymana"),("Gölbaşı","golbasi")]),
    };

    private AnkaraIlceServisModel? BuildModel(string ilce, ServisTipi servis)
    {
        if (!_ilceler.TryGetValue(ilce, out var d)) return null;
        return new AnkaraIlceServisModel
        {
            IlceAdi      = d.Name,
            IlceSlug     = ilce,
            IlceOzellik  = d.Ozellik,
            Mahalleler   = d.Mahalleler,
            YakinIlceler = d.Yakin.Select(x => (x.N, x.S)).ToArray(),
            Servis       = servis
        };
    }

    // ── 8 SERVIS TİPİ ──

    [HttpGet("{ilce}-istanbul-kamyonet-nakliyat")]
    public IActionResult Kamyonet(string ilce)
    {
        var m = BuildModel(ilce, ServisTipi.Kamyonet);
        if (m is null) return NotFound();
        ViewData["Title"]       = m.SeoTitle;
        ViewData["Description"] = m.SeoDescription;
        ViewData["Canonical"]   = m.PageUrl;
        return View("ServisPage", m);
    }

    [HttpGet("{ilce}-istanbul-sehirlerarasi-nakliyat")]
    public IActionResult Sehirlerarasi(string ilce)
    {
        var m = BuildModel(ilce, ServisTipi.Sehirlerarasi);
        if (m is null) return NotFound();
        ViewData["Title"]       = m.SeoTitle;
        ViewData["Description"] = m.SeoDescription;
        ViewData["Canonical"]   = m.PageUrl;
        return View("ServisPage", m);
    }

    [HttpGet("{ilce}-istanbul-evden-eve-nakliyat")]
    public IActionResult EvdenEve(string ilce)
    {
        var m = BuildModel(ilce, ServisTipi.EvdenEve);
        if (m is null) return NotFound();
        ViewData["Title"]       = m.SeoTitle;
        ViewData["Description"] = m.SeoDescription;
        ViewData["Canonical"]   = m.PageUrl;
        return View("ServisPage", m);
    }

    [HttpGet("{ilce}-istanbul-ofis-nakliyat")]
    public IActionResult Ofis(string ilce)
    {
        var m = BuildModel(ilce, ServisTipi.Ofis);
        if (m is null) return NotFound();
        ViewData["Title"]       = m.SeoTitle;
        ViewData["Description"] = m.SeoDescription;
        ViewData["Canonical"]   = m.PageUrl;
        return View("ServisPage", m);
    }

    [HttpGet("{ilce}-istanbul-fuar-nakliyat")]
    public IActionResult Fuar(string ilce)
    {
        var m = BuildModel(ilce, ServisTipi.Fuar);
        if (m is null) return NotFound();
        ViewData["Title"]       = m.SeoTitle;
        ViewData["Description"] = m.SeoDescription;
        ViewData["Canonical"]   = m.PageUrl;
        return View("ServisPage", m);
    }

    [HttpGet("{ilce}-istanbul-kamyon-nakliyat")]
    public IActionResult Kamyon(string ilce)
    {
        var m = BuildModel(ilce, ServisTipi.Kamyon);
        if (m is null) return NotFound();
        ViewData["Title"]       = m.SeoTitle;
        ViewData["Description"] = m.SeoDescription;
        ViewData["Canonical"]   = m.PageUrl;
        return View("ServisPage", m);
    }

    [HttpGet("{ilce}-istanbul-parsiyel-nakliyat")]
    public IActionResult Parsiyel(string ilce)
    {
        var m = BuildModel(ilce, ServisTipi.Parsiyel);
        if (m is null) return NotFound();
        ViewData["Title"]       = m.SeoTitle;
        ViewData["Description"] = m.SeoDescription;
        ViewData["Canonical"]   = m.PageUrl;
        return View("ServisPage", m);
    }

    [HttpGet("{ilce}-istanbul-ambar-nakliyat")]
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
