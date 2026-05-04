using IstanbulAnkaraNakliyat.Models;
using Microsoft.AspNetCore.Mvc;

namespace IstanbulAnkaraNakliyat.Controllers;

public class NakliyatController : Controller
{
    // ══════════════════════════════════════════════════════════════
    //  İSTANBUL İLÇELERİ  →  ANKARA
    // ══════════════════════════════════════════════════════════════
    private static readonly Dictionary<string, (string Name, string Ozellik, string[] Mahalleler, (string N, string S)[] Yakin)>
        _istanbul = new()
    {
        // ── Anadolu Yakası ─────────────────────────────────────
        ["kadikoy"] = ("Kadıköy",
            "Anadolu yakasının kültür, gastronomi ve ticaret merkezi",
            ["Moda", "Bostancı", "Fenerbahçe", "Fikirtepe", "Caferağa"],
            [("Üsküdar","uskudar"),("Maltepe","maltepe"),("Ataşehir","atasehir"),("Kartal","kartal")]),

        ["uskudar"] = ("Üsküdar",
            "Tarihi ve doğal güzellikleriyle İstanbul'un gözde ilçesi",
            ["Çengelköy", "Kandilli", "Beylerbeyi", "Kuzguncuk", "Salacak"],
            [("Kadıköy","kadikoy"),("Beykoz","beykoz"),("Ümraniye","umraniye"),("Ataşehir","atasehir")]),

        ["umraniye"] = ("Ümraniye",
            "Anadolu yakasının hızla gelişen modern yaşam merkezi",
            ["Armağanevler", "Siteler", "İnkılap", "Yunus Emre", "Namık Kemal"],
            [("Ataşehir","atasehir"),("Çekmeköy","cekmekoy"),("Sancaktepe","sancaktepe"),("Üsküdar","uskudar")]),

        ["maltepe"] = ("Maltepe",
            "Deniz manzaralı ve gelişmiş altyapısıyla Anadolu yakası ilçesi",
            ["Bağlarbaşı", "Cevizli", "Gülensu", "Küçükyalı", "Altayçeşme"],
            [("Kadıköy","kadikoy"),("Kartal","kartal"),("Pendik","pendik"),("Ataşehir","atasehir")]),

        ["pendik"] = ("Pendik",
            "Havalimanına yakınlığıyla stratejik konumlu Anadolu ilçesi",
            ["Kurtköy", "Kaynarca", "Dolayoba", "Yenişehir", "Şeyhli"],
            [("Kartal","kartal"),("Tuzla","tuzla"),("Maltepe","maltepe"),("Sancaktepe","sancaktepe")]),

        ["kartal"] = ("Kartal",
            "Sanayi ve konutun iç içe geçtiği dinamik Anadolu yakası ilçesi",
            ["Soğanlık", "Yakacık", "Uğur Mumcu", "Cevizli", "Karlıktepe"],
            [("Maltepe","maltepe"),("Pendik","pendik"),("Sultanbeyli","sultanbeyli"),("Ümraniye","umraniye")]),

        ["atasehir"] = ("Ataşehir",
            "İstanbul'un yükselen finans ve yaşam merkezi",
            ["Ataşehir Merkez", "İçerenköy", "Ferhatpaşa", "Küçükbakkalköy", "Yenisahra"],
            [("Kadıköy","kadikoy"),("Ümraniye","umraniye"),("Maltepe","maltepe"),("Üsküdar","uskudar")]),

        ["beykoz"] = ("Beykoz",
            "Boğaz'ın Anadolu yakasındaki yeşil ve sakin ilçesi",
            ["Çubuklu", "Paşabahçe", "Anadoluhisarı", "Riva", "Polonezköy"],
            [("Üsküdar","uskudar"),("Çekmeköy","cekmekoy"),("Sarıyer","sariyer"),("Ümraniye","umraniye")]),

        ["cekmekoy"] = ("Çekmeköy",
            "İstanbul'un doğusunda huzurlu ve yeşil bir yaşam sunulan ilçe",
            ["Çekmeköy Merkez", "Mehmet Akif", "Nişantepe", "Taşdelen", "Hamidiye"],
            [("Ümraniye","umraniye"),("Sancaktepe","sancaktepe"),("Beykoz","beykoz"),("Sultanbeyli","sultanbeyli")]),

        ["sancaktepe"] = ("Sancaktepe",
            "Gelişmekte olan altyapısıyla Anadolu yakasının yeni cazibe merkezi",
            ["Sancaktepe Merkez", "Kaynarca", "Veysel Karani", "Fatih", "Eyüp Sultan"],
            [("Ümraniye","umraniye"),("Çekmeköy","cekmekoy"),("Kartal","kartal"),("Sultanbeyli","sultanbeyli")]),

        ["sultanbeyli"] = ("Sultanbeyli",
            "İstanbul Anadolu yakasında konut yoğunluğu yüksek ilçe",
            ["Sultanbeyli Merkez", "Mehmet Akif", "Battalpasa", "Hasanpaşa", "İnönü"],
            [("Kartal","kartal"),("Pendik","pendik"),("Sancaktepe","sancaktepe"),("Ümraniye","umraniye")]),

        ["tuzla"] = ("Tuzla",
            "Sanayi tesisleri ve sahil şeridiyle öne çıkan güneydoğu ilçesi",
            ["İçmeler", "Mimar Sinan", "Aydınlı", "Postane", "Tepeören"],
            [("Pendik","pendik"),("Kartal","kartal"),("Sancaktepe","sancaktepe"),("Maltepe","maltepe")]),

        ["sile"] = ("Şile",
            "Karadeniz kıyısındaki doğal ve sakin İstanbul ilçesi",
            ["Şile Merkez", "Ağva", "Gümüşpınar", "Doğancalı", "Hacıllı"],
            [("Beykoz","beykoz"),("Çekmeköy","cekmekoy"),("Ümraniye","umraniye"),("Sancaktepe","sancaktepe")]),

        // ── Avrupa Yakası ─────────────────────────────────────
        ["zeytinburnu"] = ("Zeytinburnu",
            "İstanbul'un köklü sanayi ve tekstil ilçesi",
            ["Kazlıçeşme", "Merkezefendi", "Nuripaşa", "Seyitnizam", "Veliefendi"],
            [("Bakırköy","bakirkoy"),("Fatih","fatih"),("Güngören","gungoren"),("Bayrampaşa","bayrampasa")]),

        ["bakirkoy"] = ("Bakırköy",
            "Sahil şeridi ve alışveriş merkezleriyle öne çıkan prestijli Avrupa yakası ilçesi",
            ["Ataköy", "Florya", "Zuhuratbaba", "Cevizlik", "Osmaniye"],
            [("Zeytinburnu","zeytinburnu"),("Küçükçekmece","kucukcekemece"),("Bahçelievler","bahcelievler"),("Güngören","gungoren")]),

        ["kucukcekemece"] = ("Küçükçekmece",
            "Göl kıyısındaki modern konut projeleriyle büyüyen Avrupa yakası ilçesi",
            ["Atakent", "Halkalı", "İnönü", "Cennet", "Fatih"],
            [("Bakırköy","bakirkoy"),("Esenyurt","esenyurt"),("Avcılar","avcilar"),("Bağcılar","bagcilar")]),

        ["gungoren"] = ("Güngören",
            "Tekstil atölyeleri ve çarşılarıyla tanınan yoğun nüfuslu ilçe",
            ["Güngören Merkez", "Tozkoparan", "Güven", "Mehmet Nesih Özmen", "Merter"],
            [("Zeytinburnu","zeytinburnu"),("Bağcılar","bagcilar"),("Bahçelievler","bahcelievler"),("Bakırköy","bakirkoy")]),

        ["bahcelievler"] = ("Bahçelievler",
            "Konut yoğunluğu yüksek, ulaşım ağıyla merkezi Avrupa yakası ilçesi",
            ["Kocasinan", "Soğanlı", "Zafer", "Şirinevler", "Cumhuriyet"],
            [("Bağcılar","bagcilar"),("Güngören","gungoren"),("Bakırköy","bakirkoy"),("Bayrampaşa","bayrampasa")]),

        ["bagcilar"] = ("Bağcılar",
            "İstanbul'un en kalabalık ilçelerinden biri, gelişmiş ulaşım ağına sahip",
            ["Bağcılar Merkez", "Kirazlı", "Göztepe", "Yıldıztepe", "Mahmutbey"],
            [("Güngören","gungoren"),("Bahçelievler","bahcelievler"),("Esenler","esenler"),("Bayrampaşa","bayrampasa")]),

        ["esenler"] = ("Esenler",
            "Otogar yakınlığıyla ulaşım avantajlı İstanbul ilçesi",
            ["Birlik", "Turgut Reis", "Nene Hatun", "Çiftlik", "Kemer"],
            [("Bağcılar","bagcilar"),("Bayrampaşa","bayrampasa"),("Gaziosmanpaşa","gaziosmanpasa"),("Sultangazi","sultangazi")]),

        ["bayrampasa"] = ("Bayrampaşa",
            "E-5 ve TEM bağlantısıyla merkezi konumda, yoğun trafiğe yakın ilçe",
            ["Bayrampaşa Merkez", "Kocatepe", "Orta", "Muratpaşa", "İsmetpaşa"],
            [("Zeytinburnu","zeytinburnu"),("Bağcılar","bagcilar"),("Esenler","esenler"),("Gaziosmanpaşa","gaziosmanpasa")]),

        ["gaziosmanpasa"] = ("Gaziosmanpaşa",
            "Köklü yerleşim geçmişiyle İstanbul'un kuzey Avrupa yakası ilçesi",
            ["Karadeniz", "Barbaros", "Yenidoğan", "Bağlarbaşı", "Karlıtepe"],
            [("Sultangazi","sultangazi"),("Esenler","esenler"),("Bayrampaşa","bayrampasa"),("Eyüpsultan","eyupsultan")]),

        ["sultangazi"] = ("Sultangazi",
            "Kuzey İstanbul'da hızla gelişen modern konut ilçesi",
            ["Cebeci", "Uğur Mumcu", "Sultançiftliği", "Habibler", "Malkoçoğlu"],
            [("Gaziosmanpaşa","gaziosmanpasa"),("Eyüpsultan","eyupsultan"),("Arnavutköy","arnavutkoy"),("Esenler","esenler")]),

        ["kagithane"] = ("Kağıthane",
            "Yenilenen kentsel dönüşüm projeleriyle değer kazanan merkezi ilçe",
            ["Çağlayan", "Gültepe", "Seyrantepe", "Hamidiye", "Ortabayır"],
            [("Şişli","sisli"),("Beyoğlu","beyoglu"),("Gaziosmanpaşa","gaziosmanpasa"),("Sarıyer","sariyer")]),

        ["besiktas"] = ("Beşiktaş",
            "Boğaz kıyısında konumlanan İstanbul'un en prestijli ilçesi",
            ["Levent", "Balmumcu", "Etiler", "Bebek", "Ortaköy"],
            [("Şişli","sisli"),("Sarıyer","sariyer"),("Kağıthane","kagithane"),("Beyoğlu","beyoglu")]),

        ["sisli"] = ("Şişli",
            "Nişantaşı ve Mecidiyeköy'ün lüks ve iş dünyasını barındıran ilçe",
            ["Mecidiyeköy", "Bomonti", "Harbiye", "Nişantaşı", "Kurtuluş"],
            [("Beşiktaş","besiktas"),("Kağıthane","kagithane"),("Beyoğlu","beyoglu"),("Sarıyer","sariyer")]),

        ["beyoglu"] = ("Beyoğlu",
            "Taksim, Galata ve Karaköy ile İstanbul'un tarihi kültür merkezi",
            ["Karaköy", "Cihangir", "Galata", "Taksim", "Pera"],
            [("Şişli","sisli"),("Kağıthane","kagithane"),("Fatih","fatih"),("Beşiktaş","besiktas")]),

        ["fatih"] = ("Fatih",
            "Tarihi yarımadada İstanbul'un en köklü ve tarihi ilçesi",
            ["Aksaray", "Samatya", "Yedikule", "Kocamustafapaşa", "Balat"],
            [("Zeytinburnu","zeytinburnu"),("Beyoğlu","beyoglu"),("Eyüpsultan","eyupsultan"),("Bayrampaşa","bayrampasa")]),

        ["eyupsultan"] = ("Eyüpsultan",
            "Tarihi dokusuyla İstanbul'un manevi merkezi, Haliç kıyısı ilçesi",
            ["Alibeyköy", "Göktürk", "Nişanca", "Düğmeciler", "Silahtarağa"],
            [("Fatih","fatih"),("Sultangazi","sultangazi"),("Gaziosmanpaşa","gaziosmanpasa"),("Kağıthane","kagithane")]),

        ["sariyer"] = ("Sarıyer",
            "Boğaz kıyısı köyleri ve doğal güzellikleriyle İstanbul'un kuzeyindeki ilçe",
            ["Yeniköy", "Tarabya", "Büyükdere", "İstinye", "Zekeriyaköy"],
            [("Beşiktaş","besiktas"),("Kağıthane","kagithane"),("Beykoz","beykoz"),("Arnavutköy","arnavutkoy")]),

        ["avcilar"] = ("Avcılar",
            "İstanbul üniversiteleri kampüsü ve sanayi bölgesi ile tanınan ilçe",
            ["Ambarlı", "Cihangir", "Firuzköy", "Tahtakale", "Üniversite"],
            [("Küçükçekmece","kucukcekemece"),("Esenyurt","esenyurt"),("Büyükçekmece","buyukcekemece"),("Beylikdüzü","beylikduzu")]),

        ["beylikduzu"] = ("Beylikdüzü",
            "Modern konut projeleri ve alışveriş merkezleriyle öne çıkan batı İstanbul ilçesi",
            ["Beylikdüzü Merkez", "Gürpınar", "Büyükşehir", "Adnan Kahveci", "Marmara"],
            [("Esenyurt","esenyurt"),("Avcılar","avcilar"),("Büyükçekmece","buyukcekemece"),("Küçükçekmece","kucukcekemece")]),

        ["esenyurt"] = ("Esenyurt",
            "İstanbul'un en hızlı büyüyen ve en kalabalık ilçelerinden biri",
            ["Esenyurt Merkez", "Talatpaşa", "Saadetdere", "Pınar", "Mehterçeşme"],
            [("Avcılar","avcilar"),("Küçükçekmece","kucukcekemece"),("Büyükçekmece","buyukcekemece"),("Arnavutköy","arnavutkoy")]),

        ["buyukcekemece"] = ("Büyükçekmece",
            "Plajları ve göl kıyısıyla İstanbul'un batısındaki sakin ilçe",
            ["Mimarsinan", "Pınarca", "Güzelce", "Karaağaç", "Kumburgaz"],
            [("Esenyurt","esenyurt"),("Avcılar","avcilar"),("Silivri","silivri"),("Arnavutköy","arnavutkoy")]),

        ["basaksehir"] = ("Başakşehir",
            "Modern planlı yapısı ve geniş yeşil alanlarıyla öne çıkan ilçe",
            ["Başakşehir Merkez", "Kayaşehir", "Bahçeşehir", "Altınşehir", "Şahintepe"],
            [("Esenyurt","esenyurt"),("Küçükçekmece","kucukcekemece"),("Arnavutköy","arnavutkoy"),("Bağcılar","bagcilar")]),

        ["arnavutkoy"] = ("Arnavutköy",
            "İstanbul Havalimanı yakınlığıyla değer kazanan kuzey ilçesi",
            ["Arnavutköy Merkez", "Haraçcı", "Bolluca", "Hadımköy", "Taşoluk"],
            [("Başakşehir","basaksehir"),("Esenyurt","esenyurt"),("Büyükçekmece","buyukcekemece"),("Eyüpsultan","eyupsultan")]),

        ["silivri"] = ("Silivri",
            "Marmara kıyısında yazlık ve tarım alanlarıyla İstanbul'un batı kapısı",
            ["Silivri Merkez", "Selimpaşa", "Ortaköy", "Gümüşyaka", "Alibey"],
            [("Büyükçekmece","buyukcekemece"),("Çatalca","catalca"),("Avcılar","avcilar"),("Esenyurt","esenyurt")]),

        ["catalca"] = ("Çatalca",
            "İstanbul'un en büyük yüzölçümlü ilçesi, doğa ve kırsal yaşam alanı",
            ["Çatalca Merkez", "Kapaklı", "Yalıköy", "Ferhatpaşa", "İnceğiz"],
            [("Silivri","silivri"),("Büyükçekmece","buyukcekemece"),("Arnavutköy","arnavutkoy"),("Esenyurt","esenyurt")]),

        ["adalar"] = ("Adalar",
            "İstanbul Adaları — araçsız yaşamın sembolü, eşsiz tatil destinasyonu",
            ["Büyükada", "Heybeliada", "Burgazada", "Kınalıada"],
            [("Kadıköy","kadikoy"),("Pendik","pendik"),("Tuzla","tuzla"),("Maltepe","maltepe")]),
    };

    // ══════════════════════════════════════════════════════════════
    //  ANKARA İLÇELERİ  →  İSTANBUL
    // ══════════════════════════════════════════════════════════════
    private static readonly Dictionary<string, (string Name, string Ozellik, string[] Mahalleler, (string N, string S)[] Yakin)>
        _ankara = new()
    {
        ["cankaya"] = ("Çankaya",
            "Ankara'nın merkezi ve en kalabalık ilçesi, büyükelçilikler yurdu",
            ["Kızılay", "Kavaklidere", "Oran", "Balgat", "Bahçelievler"],
            [("Keçiören","kecioren"),("Yenimahalle","yenimahalle"),("Mamak","mamak"),("Altındağ","altindag")]),

        ["kecioren"] = ("Keçiören",
            "Ankara'nın en kalabalık ilçesi, sosyal donatıları güçlü konut merkezi",
            ["Etlik", "Bağlum", "Kalaba", "Kuşcağız", "Aktepe"],
            [("Çankaya","cankaya"),("Yenimahalle","yenimahalle"),("Altındağ","altindag"),("Pursaklar","pursaklar")]),

        ["yenimahalle"] = ("Yenimahalle",
            "Sanayi ve konutun harmanlandığı batı Ankara'nın gelişmekte olan ilçesi",
            ["Demetevler", "Şentepe", "Batıkent", "Ostim", "İvedik"],
            [("Çankaya","cankaya"),("Keçiören","kecioren"),("Sincan","sincan"),("Etimesgut","etimesgut")]),

        ["mamak"] = ("Mamak",
            "Ankara'nın doğusunda konumlanan, büyüyen kentsel dönüşüm ilçesi",
            ["Mamak Merkez", "Şahintepe", "Hüseyingazi", "Kutlu", "Tuzluçayır"],
            [("Çankaya","cankaya"),("Altındağ","altindag"),("Keçiören","kecioren"),("Akyurt","akyurt")]),

        ["etimesgut"] = ("Etimesgut",
            "Ankara'nın modern konut projelerine ev sahipliği yapan batı ilçesi",
            ["Elvankent", "Eryaman", "Göksu", "Etimesgut Merkez", "Yapracık"],
            [("Yenimahalle","yenimahalle"),("Sincan","sincan"),("Çankaya","cankaya"),("Gölbaşı","golbasi")]),

        ["sincan"] = ("Sincan",
            "Sanayi bölgesi ve toplu konutlarıyla büyüyen batı Ankara ilçesi",
            ["Sincan Merkez", "Fatih", "Pirinçlik", "İstasyon", "Doğukan"],
            [("Etimesgut","etimesgut"),("Yenimahalle","yenimahalle"),("Keçiören","kecioren"),("Kahramankazan","kahramankazan")]),

        ["altindag"] = ("Altındağ",
            "Ankara'nın tarihi ilçesi, Hamamönü ve Ulus'un yer aldığı merkezi bölge",
            ["Ulus", "Hamamönü", "Çiçek", "Atıfbey", "Anafartalar"],
            [("Çankaya","cankaya"),("Keçiören","kecioren"),("Mamak","mamak"),("Yenimahalle","yenimahalle")]),

        ["golbasi"] = ("Gölbaşı",
            "Mogan ve Eymir göllerinin bulunduğu, doğasıyla öne çıkan güney Ankara ilçesi",
            ["Gölbaşı Merkez", "Tulumtaş", "Şekerci", "Yavrucak", "Yumrubel"],
            [("Çankaya","cankaya"),("Etimesgut","etimesgut"),("Haymana","haymana"),("Polatlı","polatli")]),

        ["pursaklar"] = ("Pursaklar",
            "Ankara'nın kuzeyindeki yeni gelişim alanlarına sahip konut ilçesi",
            ["Pursaklar Merkez", "İstasyon", "Saray", "Fatih", "Karacaören"],
            [("Keçiören","kecioren"),("Akyurt","akyurt"),("Çubuk","cubuk"),("Kahramankazan","kahramankazan")]),

        ["polatli"] = ("Polatlı",
            "Tarım alanları ve tarihî önemiyle batı Ankara'nın büyük ilçesi",
            ["Polatlı Merkez", "Yenidoğan", "Seymen", "Yenikent"],
            [("Gölbaşı","golbasi"),("Haymana","haymana"),("Etimesgut","etimesgut"),("Sincan","sincan")]),

        ["akyurt"] = ("Akyurt",
            "Ankara'nın kuzeyinde konumlanan sakin ve gelişen ilçe",
            ["Akyurt Merkez", "Karaağaç", "Yaylabağ", "Soğulca"],
            [("Keçiören","kecioren"),("Pursaklar","pursaklar"),("Mamak","mamak"),("Çubuk","cubuk")]),

        ["elmadag"] = ("Elmadağ",
            "Doğa ile iç içe, Ankara'nın kuzeydoğusunda konumlanan ilçe",
            ["Elmadağ Merkez", "Hasanoğlan", "Balışeyh", "Karaözü"],
            [("Mamak","mamak"),("Akyurt","akyurt"),("Keçiören","kecioren"),("Çubuk","cubuk")]),

        ["beypazari"] = ("Beypazarı",
            "Tarihi evleri, gümüş takıları ve güveci ile ünlü batı Ankara ilçesi",
            ["Beypazarı Merkez", "Doğantepe", "Pazar", "Yenipazar"],
            [("Nallıhan","nallihan"),("Güdül","gudul"),("Çamlıdere","camlidere"),("Ayaş","ayas")]),

        ["kahramankazan"] = ("Kahramankazan",
            "Ankara'ya yakın konumuyla gelişen organize sanayi ve lojistik ilçesi",
            ["Kazan Merkez", "Fatih", "İstasyon", "Malıköy"],
            [("Sincan","sincan"),("Keçiören","kecioren"),("Pursaklar","pursaklar"),("Çubuk","cubuk")]),

        ["cubuk"] = ("Çubuk",
            "Turşusuyla ünlü, Ankara'nın kuzeyinde kırsal ve kentsel hayatın iç içe geçtiği ilçe",
            ["Çubuk Merkez", "Ovacık", "Karacaören", "Taşpınar"],
            [("Pursaklar","pursaklar"),("Akyurt","akyurt"),("Kahramankazan","kahramankazan"),("Elmadağ","elmadag")]),

        ["kizilcahamam"] = ("Kızılcahamam",
            "Şifalı kaplıcaları ve çam ormanlarıyla tanınan kuzey Ankara ilçesi",
            ["Kızılcahamam Merkez", "Çeltikçi", "Güvem", "Karakaya"],
            [("Çamlıdere","camlidere"),("Güdül","gudul"),("Kahramankazan","kahramankazan"),("Nallıhan","nallihan")]),

        ["nallihan"] = ("Nallıhan",
            "Sakarya nehri kıyısında doğal güzelliklere sahip batı Ankara ilçesi",
            ["Nallıhan Merkez", "Davutoğlan", "Emremsultan", "Hamidiye"],
            [("Beypazarı","beypazari"),("Ayaş","ayas"),("Kızılcahamam","kizilcahamam"),("Çamlıdere","camlidere")]),

        ["ayas"] = ("Ayaş",
            "Bağ evleri ve üzüm bağlarıyla batı Ankara'nın neşeli ilçesi",
            ["Ayaş Merkez", "Belpınar", "Dodurga", "Karaören"],
            [("Beypazarı","beypazari"),("Kahramankazan","kahramankazan"),("Nallıhan","nallihan"),("Sincan","sincan")]),

        ["bala"] = ("Bala",
            "Geniş tarım alanları ve sessiz doğasıyla güney Ankara'nın sakin ilçesi",
            ["Bala Merkez", "Hacılar", "Karapınar", "Köprüköy"],
            [("Haymana","haymana"),("Polatlı","polatli"),("Gölbaşı","golbasi"),("Şereflikoçhisar","sereflikocehisar")]),

        ["gudul"] = ("Güdül",
            "Tarihi kalesi ve kanyonlarıyla doğa severlerini çeken küçük Ankara ilçesi",
            ["Güdül Merkez", "Kabaklar", "Çayırhan", "Dağyoncalı"],
            [("Beypazarı","beypazari"),("Kızılcahamam","kizilcahamam"),("Çamlıdere","camlidere"),("Nallıhan","nallihan")]),

        ["camlidere"] = ("Çamlıdere",
            "Orman örtüsü ve temiz hava ile Ankara'nın yeşil kuzeybatı ilçesi",
            ["Çamlıdere Merkez", "Örencik", "Şahinler", "Demirciören"],
            [("Kızılcahamam","kizilcahamam"),("Güdül","gudul"),("Beypazarı","beypazari"),("Nallıhan","nallihan")]),

        ["haymana"] = ("Haymana",
            "Kaplıcaları ve bozkır manzarasıyla güney Ankara'nın özgün ilçesi",
            ["Haymana Merkez", "Yeşilyurt", "Yavrucak", "Keskin"],
            [("Polatlı","polatli"),("Gölbaşı","golbasi"),("Bala","bala"),("Çankaya","cankaya")]),

        ["evren"] = ("Evren",
            "Ankara'nın en küçük ilçelerinden biri, sakin kırsal yaşam sunuyor",
            ["Evren Merkez", "Boyalı", "Güvendik"],
            [("Bala","bala"),("Haymana","haymana"),("Şereflikoçhisar","sereflikocehisar"),("Polatlı","polatli")]),

        ["kalecik"] = ("Kalecik",
            "Kızılırmak kıyısındaki üzüm bağları ve tarihi kalesiyle ilçe",
            ["Kalecik Merkez", "Erikli", "Koçubey", "Kuruca"],
            [("Akyurt","akyurt"),("Elmadağ","elmadag"),("Çubuk","cubuk"),("Pursaklar","pursaklar")]),

        ["sereflikocehisar"] = ("Şereflikoçhisar",
            "Tuz gölü ve tuz üretimiyle Türkiye'de önemli bir konuma sahip doğu Ankara ilçesi",
            ["Şereflikoçhisar Merkez", "Akpınar", "Çiçekdağı", "Yenice"],
            [("Bala","bala"),("Haymana","haymana"),("Evren","evren"),("Polatlı","polatli")]),
    };

    // ══════════════════════════════════════════════════════════════
    //  ANA GÜZERGAH SAYFALARI
    // ══════════════════════════════════════════════════════════════
    [HttpGet("istanbul-ankara-nakliyat")]
    public IActionResult IstanbulAnkara()
    {
        ViewData["Title"]       = "İstanbul Ankara Nakliyat | Profesyonel Ev & Ofis Taşıma";
        ViewData["Description"] = "İstanbul'un tüm ilçelerinden Ankara'ya evden eve nakliyat, ofis taşıma ve parça eşya hizmeti. Sigortalı araçlar, uzman ekip. Ücretsiz teklif: 0532 543 68 37";
        ViewData["IstanbulIlceleri"] = _istanbul.Select(kv => (kv.Key, kv.Value.Name)).ToList();
        return View();
    }

    [HttpGet("ankara-istanbul-nakliyat")]
    public IActionResult AnkaraIstanbul()
    {
        ViewData["Title"]       = "Ankara İstanbul Nakliyat | Profesyonel Ev & Ofis Taşıma";
        ViewData["Description"] = "Ankara'nın tüm ilçelerinden İstanbul'a evden eve nakliyat, ofis taşıma ve parça eşya hizmeti. Sigortalı araçlar, uzman ekip. Ücretsiz teklif: 0532 543 68 37";
        ViewData["AnkaraIlceleri"] = _ankara.Select(kv => (kv.Key, kv.Value.Name)).ToList();
        return View();
    }

    [HttpGet("ankara-istanbul-evden-eve-nakliyat")]
    public IActionResult AnkaraIstanbulEvdenEve()
    {
        ViewData["Title"]       = "Ankara İstanbul Evden Eve Nakliyat | Kapıdan Kapıya 2026";
        ViewData["Description"] = "Ankara'dan İstanbul'a evden eve nakliyat. Ambalaj, söküm-montaj, sigorta dahil kapıdan kapıya ev taşıma. 2+1 daire 12.000 ₺'den: 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/ankara-istanbul-evden-eve-nakliyat";
        return View();
    }

    [HttpGet("ankara-istanbul-kamyonet-nakliyat")]
    public IActionResult AnkaraIstanbulKamyonet()
    {
        ViewData["Title"]       = "Ankara İstanbul Kamyonet Nakliyat | 1+1 & Küçük Yükler 2026";
        ViewData["Description"] = "Ankara'dan İstanbul'a kamyonet ile nakliyat. 1+1 daire, stüdyo ve öğrenci eşyası için ekonomik, hızlı taşıma. 4.500 ₺'den başlar: 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/ankara-istanbul-kamyonet-nakliyat";
        return View();
    }

    [HttpGet("istanbul-ankara-kamyonet-nakliyat")]
    public IActionResult IstanbulAnkaraKamyonet()
    {
        ViewData["Title"]       = "İstanbul Ankara Kamyonet Nakliyat | 1+1 & Küçük Yükler 2026";
        ViewData["Description"] = "İstanbul'dan Ankara'ya kamyonet ile nakliyat. 1+1 daire, stüdyo ve öğrenci eşyası için ekonomik, hızlı taşıma. 4.500 ₺'den başlayan fiyatlar: 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/istanbul-ankara-kamyonet-nakliyat";
        return View();
    }

    [HttpGet("istanbul-ankara-evden-eve-nakliyat")]
    public IActionResult IstanbulAnkaraEvdenEve()
    {
        ViewData["Title"]       = "İstanbul Ankara Evden Eve Nakliyat | Kapıdan Kapıya 2026";
        ViewData["Description"] = "İstanbul'dan Ankara'ya evden eve nakliyat. Ambalaj, söküm-montaj, sigorta dahil kapıdan kapıya ev taşıma. 2+1 daire 12.000 ₺'den: 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/istanbul-ankara-evden-eve-nakliyat";
        return View();
    }

    [HttpGet("istanbul-ankara-nakliyat-fiyatlari")]
    public IActionResult IstanbulAnkaraFiyatlari()
    {
        ViewData["Title"]       = "İstanbul Ankara Nakliyat Fiyatları 2026 | Güncel Taşıma Ücretleri";
        ViewData["Description"] = "İstanbul'dan Ankara'ya nakliyat fiyatları 2026. 1+1'den villaya, parsiyelden tam araca tüm fiyatlar. Gizli ücret yok, net teklif: 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/istanbul-ankara-nakliyat-fiyatlari";
        return View();
    }

    [HttpGet("istanbul-ankara-ucuz-nakliyat")]
    public IActionResult IstanbulAnkaraUcuz()
    {
        ViewData["Title"]       = "İstanbul Ankara Ucuz Nakliyat | Ekonomik Taşıma Seçenekleri 2026";
        ViewData["Description"] = "İstanbul'dan Ankara'ya uygun fiyatlı nakliyat. Parsiyel, kamyonet, sezon dışı ve paket indirimleri. Sigortalı, güvenilir ekonomik taşıma: 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/istanbul-ankara-ucuz-nakliyat";
        return View();
    }

    [HttpGet("istanbul-ankara-parca-esya-tasima")]
    public IActionResult IstanbulAnkaraParcaEsya()
    {
        ViewData["Title"]       = "İstanbul Ankara Parça Eşya Taşıma | Parsiyel Nakliyat 2026";
        ViewData["Description"] = "İstanbul'dan Ankara'ya parça eşya ve parsiyel taşıma. Tek koliden mobilyaya, koltuktan beyaz eşyaya sigortalı taşıma. 1.500 ₺'den başlar: 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/istanbul-ankara-parca-esya-tasima";
        return View();
    }

    [HttpGet("istanbul-ankara-ofis-tasimaciligi")]
    public IActionResult IstanbulAnkaraOfisTasimaciligi()
    {
        ViewData["Title"]       = "İstanbul Ankara Ofis Taşımacılığı | Kurumsal Nakliyat 2026";
        ViewData["Description"] = "İstanbul'dan Ankara'ya kurumsal ofis taşıma. IT ekipmanı, sunucu, arşiv, kasa dahil. Gece ve hafta sonu seçeneği. İş sürekliliği öncelikli: 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/istanbul-ankara-ofis-tasimaciligi";
        return View();
    }

    [HttpGet("istanbul-ankara-fuar-nakliyat")]
    public IActionResult IstanbulAnkaraFuar()
    {
        ViewData["Title"]       = "İstanbul Ankara Fuar Nakliyat | Stand ve Sergi Malzemesi Taşıma 2026";
        ViewData["Description"] = "İstanbul'dan Ankara'ya fuar ve sergi malzemesi nakliyatı. Stand, display sistemi, vitrin, promo malzeme ve elektronik taşıma. Fuar öncesi zamanında teslimat: 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/istanbul-ankara-fuar-nakliyat";
        return View();
    }

    [HttpGet("istanbul-ankara-kamyon-nakliyat")]
    public IActionResult IstanbulAnkaraKamyon()
    {
        ViewData["Title"]       = "İstanbul Ankara Kamyon Nakliyat | 2+1, 3+1 Büyük Ev Taşıma 2026";
        ViewData["Description"] = "İstanbul'dan Ankara'ya kamyon ile büyük ev ve ofis taşıma. 2+1, 3+1 ve villa için tam araçlı sigortalı nakliyat. C Tipi belgeli hizmet: 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/istanbul-ankara-kamyon-nakliyat";
        return View();
    }

    [HttpGet("istanbul-ankara-parsiyel-nakliyat")]
    public IActionResult IstanbulAnkaraParsiyel()
    {
        ViewData["Title"]       = "İstanbul Ankara Parsiyel Nakliyat | Parça Eşya Paylaşımlı Taşıma 2026";
        ViewData["Description"] = "İstanbul'dan Ankara'ya parsiyel nakliyat. Az eşyanız için paylaşımlı araç seçeneği. Tek koliden mobilyaya sigortalı, ekonomik taşıma. 1.200 ₺'den: 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/istanbul-ankara-parsiyel-nakliyat";
        return View();
    }

    [HttpGet("istanbul-ankara-ambar-nakliyat")]
    public IActionResult IstanbulAnkaraAmbar()
    {
        ViewData["Title"]       = "İstanbul Ankara Ambar Nakliyat | Depolama + Taşıma Kombine 2026";
        ViewData["Description"] = "İstanbul'dan Ankara'ya ambar nakliyat hizmeti. Güvenli eşya depolama ve şehirlerarası taşıma birleşik hizmet. Esnek teslim tarihleri: 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/istanbul-ankara-ambar-nakliyat";
        return View();
    }

    [HttpGet("ankara-istanbul-kamyon-nakliyat")]
    public IActionResult AnkaraIstanbulKamyon()
    {
        ViewData["Title"]       = "Ankara İstanbul Kamyon Nakliyat | 2+1, 3+1 Büyük Ev Taşıma 2026";
        ViewData["Description"] = "Ankara'dan İstanbul'a kamyon ile büyük ev ve ofis taşıma. 2+1, 3+1 ve villa için tam araçlı sigortalı nakliyat. Anadolu ve Avrupa yakasına teslimat: 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/ankara-istanbul-kamyon-nakliyat";
        return View();
    }

    [HttpGet("ankara-istanbul-ambar-nakliyat")]
    public IActionResult AnkaraIstanbulAmbar()
    {
        ViewData["Title"]       = "Ankara İstanbul Ambar Nakliyat | Depolama + Taşıma Kombine 2026";
        ViewData["Description"] = "Ankara'dan İstanbul'a ambar nakliyat hizmeti. Güvenli eşya depolama ve şehirlerarası taşıma birleşik çözüm. Esnek teslim tarihleri: 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/ankara-istanbul-ambar-nakliyat";
        return View();
    }

    [HttpGet("ankara-istanbul-fuar-nakliyat")]
    public IActionResult AnkaraIstanbulFuar()
    {
        ViewData["Title"]       = "Ankara İstanbul Fuar Nakliyat | Stand ve Sergi Malzemesi Taşıma 2026";
        ViewData["Description"] = "Ankara'dan İstanbul'a fuar ve sergi malzemesi nakliyatı. ATO, Armada, Başkent Kongre'den CNR Expo ve Tüyap'a stand taşıma. Zamanında teslimat: 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/ankara-istanbul-fuar-nakliyat";
        return View();
    }

    [HttpGet("ankara-istanbul-ofis-nakliyat")]
    public IActionResult AnkaraIstanbulOfis()
    {
        ViewData["Title"]       = "Ankara İstanbul Ofis Nakliyat | Kurumsal Taşıma Hizmeti 2026";
        ViewData["Description"] = "Ankara'dan İstanbul'a kurumsal ofis taşıma. IT ekipmanı, sunucu, arşiv ve kasa dahil. Hafta sonu ve gece taşıma seçeneği. İş sürekliliği: 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/ankara-istanbul-ofis-nakliyat";
        return View();
    }

    [HttpGet("ankara-istanbul-parsiyel-nakliyat")]
    public IActionResult AnkaraIstanbulParsiyel()
    {
        ViewData["Title"]       = "Ankara İstanbul Parsiyel Nakliyat | Parça Eşya Paylaşımlı Taşıma 2026";
        ViewData["Description"] = "Ankara'dan İstanbul'a parsiyel nakliyat. Az eşyanız için paylaşımlı araç seçeneği. Tek parçadan başlayan sigortalı, ekonomik taşıma. 0532 543 68 37";
        ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/ankara-istanbul-parsiyel-nakliyat";
        return View();
    }

    // ── Tüm ilçe listesi (sitemap için) ─────────────────────────
    public static IReadOnlyList<string> IstanbulSlugs => _istanbul.Keys.ToList();
    public static IReadOnlyList<string> AnkaraSlugs   => _ankara.Keys.ToList();

    // ── İlçe verisi (dış controller erişimi için) ────────────────
    public static (string Name, string Ozellik, string[] Mahalleler, (string N, string S)[] Yakin)? GetIstanbul(string slug)
        => _istanbul.TryGetValue(slug, out var d) ? d : null;
    public static (string Name, string Ozellik, string[] Mahalleler, (string N, string S)[] Yakin)? GetAnkara(string slug)
        => _ankara.TryGetValue(slug, out var d) ? d : null;
}
