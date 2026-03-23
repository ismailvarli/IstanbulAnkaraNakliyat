using Microsoft.AspNetCore.Mvc;

namespace IstanbulAnkaraNakliyat.Controllers;

/// <summary>
/// Ankara ilçelerinden İstanbul'a nakliyat — her ilçe ayrı action + ayrı view
/// URL pattern: /{ilce}-istanbul-nakliyat
/// Views: Views/AnkaraIlceler/{Action}.cshtml
/// </summary>
public class AnkaraIlcelerController : Controller
{
    [HttpGet("cankaya-istanbul-nakliyat")]
    public IActionResult Cankaya()
    {
        ViewData["Title"]       = "Çankaya İstanbul Nakliyat | Ankara'nın Merkezinden Güvenli Taşıma";
        ViewData["Description"] = "Çankaya'dan İstanbul'a evden eve nakliyat. Kızılay, Oran, Balgat, Kavaklidere ve Bahçelievler mahallelerinden sigortalı, kapıdan kapıya taşıma. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/cankaya-istanbul-nakliyat";
        return View();
    }

    [HttpGet("kecioren-istanbul-nakliyat")]
    public IActionResult Kecioren()
    {
        ViewData["Title"]       = "Keçiören İstanbul Nakliyat | Ankara'nın Kalabalık İlçesinden Taşıma";
        ViewData["Description"] = "Keçiören'den İstanbul'a nakliyat. Etlik, Bağlum, Kalaba, Kuşcağız ve Aktepe mahallelerinden sigortalı, profesyonel ev ve ofis taşıma. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/kecioren-istanbul-nakliyat";
        return View();
    }

    [HttpGet("yenimahalle-istanbul-nakliyat")]
    public IActionResult Yenimahalle()
    {
        ViewData["Title"]       = "Yenimahalle İstanbul Nakliyat | Batı Ankara'dan Profesyonel Taşıma";
        ViewData["Description"] = "Yenimahalle'den İstanbul'a nakliyat. Demetevler, Batıkent, Şentepe, Ostim ve İvedik mahallelerinden sigortalı, kapıdan kapıya ev taşıma. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/yenimahalle-istanbul-nakliyat";
        return View();
    }

    [HttpGet("mamak-istanbul-nakliyat")]
    public IActionResult Mamak()
    {
        ViewData["Title"]       = "Mamak İstanbul Nakliyat | Doğu Ankara'dan Güvenli Ev Taşıma";
        ViewData["Description"] = "Mamak'tan İstanbul'a nakliyat. Şahintepe, Hüseyingazi, Kutlu, Tuzluçayır ve Mamak Merkez mahallelerinden sigortalı, profesyonel taşıma. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/mamak-istanbul-nakliyat";
        return View();
    }

    [HttpGet("etimesgut-istanbul-nakliyat")]
    public IActionResult Etimesgut()
    {
        ViewData["Title"]       = "Etimesgut İstanbul Nakliyat | Eryaman ve Elvankent'ten Taşıma";
        ViewData["Description"] = "Etimesgut'tan İstanbul'a nakliyat. Elvankent, Eryaman, Göksu ve Yapracık mahallelerinden sigortalı, modern konut bölgesinden kapıdan kapıya taşıma. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/etimesgut-istanbul-nakliyat";
        return View();
    }

    [HttpGet("sincan-istanbul-nakliyat")]
    public IActionResult Sincan()
    {
        ViewData["Title"]       = "Sincan İstanbul Nakliyat | Batı Ankara Sanayi İlçesinden Taşıma";
        ViewData["Description"] = "Sincan'dan İstanbul'a nakliyat. Sincan Merkez, Fatih, Pirinçlik ve Doğukan mahallelerinden sigortalı, sanayi ve konut bölgesinden taşıma. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/sincan-istanbul-nakliyat";
        return View();
    }

    [HttpGet("altindag-istanbul-nakliyat")]
    public IActionResult Altindag()
    {
        ViewData["Title"]       = "Altındağ İstanbul Nakliyat | Hamamönü ve Ulus'tan Güvenli Taşıma";
        ViewData["Description"] = "Altındağ'dan İstanbul'a nakliyat. Ulus, Hamamönü, Çiçek, Atıfbey ve Anafartalar mahallelerinden sigortalı, tarihi ilçe deneyimli ev taşıma. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/altindag-istanbul-nakliyat";
        return View();
    }

    [HttpGet("golbasi-istanbul-nakliyat")]
    public IActionResult Golbasi()
    {
        ViewData["Title"]       = "Gölbaşı İstanbul Nakliyat | Mogan Gölü Kıyısından Güzel Taşıma";
        ViewData["Description"] = "Gölbaşı'ndan İstanbul'a nakliyat. Gölbaşı Merkez, Tulumtaş, Şekerci ve Yavrucak mahallelerinden sigortalı, sakin ilçeden profesyonel taşıma. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/golbasi-istanbul-nakliyat";
        return View();
    }

    [HttpGet("pursaklar-istanbul-nakliyat")]
    public IActionResult Pursaklar()
    {
        ViewData["Title"]       = "Pursaklar İstanbul Nakliyat | Kuzey Ankara'dan Profesyonel Taşıma";
        ViewData["Description"] = "Pursaklar'dan İstanbul'a nakliyat. Pursaklar Merkez, İstasyon, Saray ve Karacaören mahallelerinden sigortalı, kapıdan kapıya ev taşıma. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/pursaklar-istanbul-nakliyat";
        return View();
    }

    [HttpGet("polatli-istanbul-nakliyat")]
    public IActionResult Polatli()
    {
        ViewData["Title"]       = "Polatlı İstanbul Nakliyat | Batı Ankara'nın Büyük İlçesinden Taşıma";
        ViewData["Description"] = "Polatlı'dan İstanbul'a nakliyat. Polatlı Merkez, Yenidoğan, Seymen ve Yenikent mahallelerinden sigortalı, tarihî ilçeden profesyonel taşıma. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/polatli-istanbul-nakliyat";
        return View();
    }

    [HttpGet("akyurt-istanbul-nakliyat")]
    public IActionResult Akyurt()
    {
        ViewData["Title"]       = "Akyurt İstanbul Nakliyat | Kuzey Ankara'dan Güvenli Taşıma";
        ViewData["Description"] = "Akyurt'tan İstanbul'a nakliyat. Akyurt Merkez, Karaağaç, Yaylabağ ve Soğulca mahallelerinden sigortalı, sakin ilçeden kapıdan kapıya taşıma. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/akyurt-istanbul-nakliyat";
        return View();
    }

    [HttpGet("elmadag-istanbul-nakliyat")]
    public IActionResult Elmadag()
    {
        ViewData["Title"]       = "Elmadağ İstanbul Nakliyat | Ankara'nın Yeşil İlçesinden Taşıma";
        ViewData["Description"] = "Elmadağ'dan İstanbul'a nakliyat. Elmadağ Merkez, Hasanoğlan ve Balışeyh mahallelerinden sigortalı, doğa içindeki ilçeden ev taşıma. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/elmadag-istanbul-nakliyat";
        return View();
    }

    [HttpGet("beypazari-istanbul-nakliyat")]
    public IActionResult Beypazari()
    {
        ViewData["Title"]       = "Beypazarı İstanbul Nakliyat | Tarihi İlçeden Profesyonel Taşıma";
        ViewData["Description"] = "Beypazarı'ndan İstanbul'a nakliyat. Beypazarı Merkez, Doğantepe ve Pazar mahallelerinden sigortalı, tarihi doku deneyimli ev ve villa taşıma. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/beypazari-istanbul-nakliyat";
        return View();
    }

    [HttpGet("kahramankazan-istanbul-nakliyat")]
    public IActionResult Kahramankazan()
    {
        ViewData["Title"]       = "Kahramankazan İstanbul Nakliyat | OSB İlçesinden Hızlı Taşıma";
        ViewData["Description"] = "Kahramankazan'dan İstanbul'a nakliyat. Kazan Merkez, Fatih ve İstasyon mahallelerinden sigortalı, organize sanayi bölgesinden ev ve kurumsal taşıma. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/kahramankazan-istanbul-nakliyat";
        return View();
    }

    [HttpGet("cubuk-istanbul-nakliyat")]
    public IActionResult Cubuk()
    {
        ViewData["Title"]       = "Çubuk İstanbul Nakliyat | Kuzey Ankara'dan Güvenli Ev Taşıma";
        ViewData["Description"] = "Çubuk'tan İstanbul'a nakliyat. Çubuk Merkez, Ovacık, Karacaören ve Taşpınar mahallelerinden sigortalı, kırsal ilçeden kapıdan kapıya taşıma. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/cubuk-istanbul-nakliyat";
        return View();
    }

    [HttpGet("kizilcahamam-istanbul-nakliyat")]
    public IActionResult Kizilcahamam()
    {
        ViewData["Title"]       = "Kızılcahamam İstanbul Nakliyat | Kaplıca İlçesinden Taşıma";
        ViewData["Description"] = "Kızılcahamam'dan İstanbul'a nakliyat. Kızılcahamam Merkez, Çeltikçi ve Güvem mahallelerinden sigortalı, orman ilçesinden profesyonel ev taşıma. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/kizilcahamam-istanbul-nakliyat";
        return View();
    }

    [HttpGet("nallihan-istanbul-nakliyat")]
    public IActionResult Nallihan()
    {
        ViewData["Title"]       = "Nallıhan İstanbul Nakliyat | Sakarya Kıyısından Güvenli Taşıma";
        ViewData["Description"] = "Nallıhan'dan İstanbul'a nakliyat. Nallıhan Merkez, Davutoğlan ve Hamidiye mahallelerinden sigortalı, batı Ankara'dan kapıdan kapıya ev taşıma. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/nallihan-istanbul-nakliyat";
        return View();
    }

    [HttpGet("ayas-istanbul-nakliyat")]
    public IActionResult Ayas()
    {
        ViewData["Title"]       = "Ayaş İstanbul Nakliyat | Bağ Evlerinden Profesyonel Taşıma";
        ViewData["Description"] = "Ayaş'tan İstanbul'a nakliyat. Ayaş Merkez, Belpınar ve Dodurga mahallelerinden sigortalı, üzüm bağı ilçesinden kapıdan kapıya ev taşıma. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/ayas-istanbul-nakliyat";
        return View();
    }

    [HttpGet("bala-istanbul-nakliyat")]
    public IActionResult Bala()
    {
        ViewData["Title"]       = "Bala İstanbul Nakliyat | Güney Ankara'dan Güvenli Ev Taşıma";
        ViewData["Description"] = "Bala'dan İstanbul'a nakliyat. Bala Merkez, Hacılar ve Karapınar mahallelerinden sigortalı, tarım ilçesinden kapıdan kapıya profesyonel taşıma. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/bala-istanbul-nakliyat";
        return View();
    }

    [HttpGet("gudul-istanbul-nakliyat")]
    public IActionResult Gudul()
    {
        ViewData["Title"]       = "Güdül İstanbul Nakliyat | Kanyon İlçesinden Profesyonel Taşıma";
        ViewData["Description"] = "Güdül'den İstanbul'a nakliyat. Güdül Merkez, Kabaklar ve Çayırhan mahallelerinden sigortalı, doğal güzellikler içindeki ilçeden ev taşıma. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/gudul-istanbul-nakliyat";
        return View();
    }

    [HttpGet("camlidere-istanbul-nakliyat")]
    public IActionResult Camlidere()
    {
        ViewData["Title"]       = "Çamlıdere İstanbul Nakliyat | Orman İlçesinden Güvenli Taşıma";
        ViewData["Description"] = "Çamlıdere'den İstanbul'a nakliyat. Çamlıdere Merkez, Örencik ve Şahinler mahallelerinden sigortalı, kuzeybatı Ankara'dan kapıdan kapıya ev taşıma. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/camlidere-istanbul-nakliyat";
        return View();
    }

    [HttpGet("haymana-istanbul-nakliyat")]
    public IActionResult Haymana()
    {
        ViewData["Title"]       = "Haymana İstanbul Nakliyat | Kaplıca ve Bozkırdan Güvenli Taşıma";
        ViewData["Description"] = "Haymana'dan İstanbul'a nakliyat. Haymana Merkez, Yeşilyurt ve Yavrucak mahallelerinden sigortalı, güney Ankara'dan kapıdan kapıya profesyonel taşıma. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/haymana-istanbul-nakliyat";
        return View();
    }

    [HttpGet("evren-istanbul-nakliyat")]
    public IActionResult Evren()
    {
        ViewData["Title"]       = "Evren İstanbul Nakliyat | Ankara'nın Sakin İlçesinden Taşıma";
        ViewData["Description"] = "Evren'den İstanbul'a nakliyat. Evren Merkez ve Boyalı mahallelerinden sigortalı, Ankara'nın en küçük ilçesinden kapıdan kapıya güvenli ev taşıma. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/evren-istanbul-nakliyat";
        return View();
    }

    [HttpGet("kalecik-istanbul-nakliyat")]
    public IActionResult Kalecik()
    {
        ViewData["Title"]       = "Kalecik İstanbul Nakliyat | Kızılırmak Kıyısından Güvenli Taşıma";
        ViewData["Description"] = "Kalecik'ten İstanbul'a nakliyat. Kalecik Merkez, Erikli ve Koçubey mahallelerinden sigortalı, bağ ve tarihi kale ilçesinden kapıdan kapıya ev taşıma. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/kalecik-istanbul-nakliyat";
        return View();
    }

    [HttpGet("sereflikocehisar-istanbul-nakliyat")]
    public IActionResult Sereflikocehisar()
    {
        ViewData["Title"]       = "Şereflikoçhisar İstanbul Nakliyat | Tuz Gölü İlçesinden Taşıma";
        ViewData["Description"] = "Şereflikoçhisar'dan İstanbul'a nakliyat. Şereflikoçhisar Merkez, Akpınar ve Yenice mahallelerinden sigortalı, doğu Ankara'dan kapıdan kapıya ev taşıma. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/sereflikocehisar-istanbul-nakliyat";
        return View();
    }
}
