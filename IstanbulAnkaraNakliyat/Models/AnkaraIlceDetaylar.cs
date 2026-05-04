namespace IstanbulAnkaraNakliyat.Models;

public static class AnkaraIlceDetaylar
{
    public static string GetIlceDetay(string slug) =>
        IlceDetaylar.TryGetValue(slug, out var d) ? d : "";

    public static string GetServisDetay(string slug, ServisTipi servis) =>
        ServisDetaylar.TryGetValue((slug, servis), out var d) ? d : "";

    private static readonly Dictionary<string, string> IlceDetaylar = new()
    {
        ["cankaya"] = "Çankaya, Ankara'nın merkezi idari ve ticari kalbi olup Kızılay, Balgat, Oran ve Kavaklidere gibi farklı yaşam dokularını barındırır. Diplomatik konutların yoğun olduğu Oran ve GOP bölgelerinde büyük sitelerin servis girişleri ve asansör planlaması önceden sorgulanmaktadır. Çukurambar ve Kavaklidere'nin iş merkezi akslarında sabah 08:00–09:30 arası trafik yoğunluğu nedeniyle yükleme saatinin buna göre ayarlanması önerilir.",
        ["kecioren"] = "Keçiören, Ankara'nın en kalabalık ilçesi olup Etlik, Bağlum ve Kalaba mahallelerinde binlerce konut bloğunu barındırır. İlçedeki dar ara sokaklar zaman zaman büyük araç erişimini güçleştirse de 3,5 tonluk kamyonetimiz bu bölgeler için standart çözüm sunmaktadır. Özellikle Keçiören TOKİ bloklarında asansör kullanımı önceden koordine edilerek yükleme planı oluşturulmaktadır.",
        ["yenimahalle"] = "Yenimahalle, TEM E-80 otoyoluna en hızlı bağlantıyı sunan Ankara ilçelerinden biridir; bu coğrafi konum İstanbul taşımalarında seyir başlangıcını minimize eder. Batıkent ve Demetevler'in planlı kentsel düzeni geniş yollar ve otopark alanları sağlamakta, büyük kamyonların dahi kolayca manevra yapabilmesine imkân tanımaktadır. Ostim OSB'nin yakınlığı, bu bölgeden kurumsal ofis ve ekipman taşımalarını düzenli hale getirmiştir.",
        ["mamak"] = "Mamak, Ankara'nın doğu yakasında eğimli arazisi ve kökleşmiş semtleriyle kendine özgü bir lojistik yapısına sahiptir. Tuzluçayır ve Hüseyingazi gibi kalabalık semtlerde yüksek katlı konutlar çoğunlukla asansörlüdür; kat başına taşıma süresi hesaba katılarak güne erken başlanması önerilir. Mamak Merkez ve Kutlu mahallelerinin bir kısmında yol genişliğindeki kısıtlamalar kamyonet ile çözülmektedir.",
        ["etimesgut"] = "Etimesgut, Ankara'nın en hızlı büyüyen konut ilçelerinden biri olup Eryaman'daki TOKİ projeleri ile Elvankent sitelerinde on binlerce aile yaşamaktadır. Geniş anayollar ve organize yapı, büyük tonajlı kamyonların dahi sorunsuz çalışmasına imkân tanır; 3+1 ve üzeri daire taşımaları bu nedenle Etimesgut'ta sık gerçekleştirilmektedir. Batı Çevre Yolu'na yakın konumuyla İstanbul güzergâhına hızlı bağlantı sağlanmaktadır.",
        ["sincan"] = "Sincan, TEM E-80 otoyolunun Ankara'ya giriş noktasına fiilen en yakın ilçe olup şehirlerarası taşımalarda güzergâh avantajı sağlamaktadır. OSB'nin ağır araç altyapısına alışkın ortamı, büyük kamyon ve tır hareket planlamasını kolaylaştırmaktadır. Sincan–Fatih ve Pirinçlik mahallelerindeki yeni konut projelerinde asansörlü yapı oranı giderek artmaktadır.",
        ["altindag"] = "Altındağ, Ankara'nın tarihi çekirdeği olup Ulus, Hamamönü ve Anafartalar ticaret bölgeleri dar sokak dokusuyla bilinmektedir. Bu bölgelerde büyük kamyon erişimi güç olduğundan 3,5 tonluk kamyonet standart çözümdür; yükleme saatlerinde ticari araç kısıtlamalarına dikkat edilmektedir. Çiçek ve Atıfbey gibi yüksek katlı konut alanlarında ise asansör planlamasıyla verimli yükleme sağlanmaktadır.",
        ["golbasi"] = "Gölbaşı, Mogan ve Eymir gölleri çevresindeki villa ve müstakil konut yoğunluğuyla Ankara'nın yeşil ilçesi konumundadır. Bu yapı nedeniyle büyük eşya hacimleri ve değerli mobilya taşımaları burada sık karşılaşılan bir hizmet talebidir. Ankara–Konya yolundan Çevre Yolu'na bağlanarak TEM'e erişim sağlanmakta; sabah trafiği öncesinde çıkış önerilmektedir.",
        ["pursaklar"] = "Pursaklar, kuzey Ankara'nın gelecek vaat eden gelişim ilçesidir; İstasyon ve Saray mahallelerindeki yeni konut sitelerinde yüksek taşınma talebi yaşanmaktadır. Keçiören–Pursaklar bağlantı yolunun nispeten az trafikli olması, sabah saatlerinde hızlı çıkış imkânı sunmaktadır. Yeni yapı stoku nedeniyle asansörlü binalardaki taşımalarda planlı koordinasyon standart hâle gelmiştir.",
        ["polatli"] = "Polatlı, Ankara'nın batısında Ege ve İç Anadolu'ya açılan kapı konumundadır; ancak İstanbul güzergâhı için araçlar kuzey Ankara çevre yolundan TEM'e bağlanmaktadır. Bu ek güzergâh, Polatlı'dan İstanbul'a olan fiilî mesafeyi yaklaşık 500 km'nin üzerine çıkarmaktadır. Özellikle parsiyel ve kamyonet hizmetlerinde bu mesafe farkı fiyata yansıyabilir; keşif aşamasında net bilgi verilmektedir.",
        ["akyurt"] = "Akyurt, kuzeydoğu Ankara'da büyüyen sanayi ve konut ilçesidir; Karaağaç ve Yaylabağ gibi semt merkezleri sanayi alanlarına yakın konumdadır. Bazı köy ve bağ yollarında araç genişliği kısıtlaması bulunduğundan büyük kamyon kullanımı önceden değerlendirilmektedir. İlçe merkezine erişen ana yollar yeterli genişlikte olup sanayi taşımacılığına alışkın yapıdadır.",
        ["elmadag"] = "Elmadağ, Ankara'nın doğusunda ormanlık ve askeri alan yoğunluklu bir ilçe olup bazı güzergahlar kısıtlı erişim bariyeri içermektedir. Elmadağ Merkez ve Hasanoğlan mahallelerinin sivil konut bölgelerine kamyonet erişimi sorunsuz sağlanmaktadır. İstanbul güzergâhı için Mamak–Çankaya aksından Çevre Yolu'na bağlanılmakta olup kış aylarında dağ geçit noktaları takip edilmektedir.",
        ["beypazari"] = "Beypazarı, Osmanlı döneminden kalma tarihi konak dokusuyla Ankara'nın kültürel ilçesidir ve merkeze yaklaşık 100 km uzaklığıyla özel rota planlaması gerektirmektedir. Doğrudan Bolu otoyol güzergâhının yakınlığı, bazı durumlarda İstanbul'a daha kısa güzergâh imkânı sunabilmektedir. Tarihi yapılar nedeniyle dar sokaklar yaygındır; ağır araç girişi öncesinde adres bazlı değerlendirme yapılmaktadır.",
        ["kahramankazan"] = "Kahramankazan, OSB ve Organize Sanayi Bölgesi altyapısıyla büyük tonajlı araçlara alışkın lojistik yapısıyla öne çıkan bir ilçedir. TEM'e Sincan üzerinden doğrudan erişim, İstanbul taşımacılığında mesafe avantajı sağlamaktadır. Konut mahallelerinde de modern yapı stoku artmakta olup asansörlü binalardaki taşımalar için kapasite planlaması yapılmaktadır.",
        ["cubuk"] = "Çubuk, Ankara'ya yaklaşık 45 km uzaklıkta bağlı bir ilçe olup bazı semtleri ara yollarla bağlantılıdır. İlçe merkezi ve Ovacık gibi yakın mahallelere 3,5 ton kamyonetimiz kolayca ulaşmaktadır; şehirlerarası araç ise Çubuk çıkışında bekleyerek ikincil transferle koordineli çalışır. Kış aylarında bazı köy yollarında hava koşullarının takip edilmesi önerilmektedir.",
        ["kizilcahamam"] = "Kızılcahamam, Ankara'ya yaklaşık 80 km mesafedeki termal turizm ve ormanlık ilçesidir. İstanbul güzergâhı için Bolu üzerinden TEM'e bağlanan alternatif rota Ankara şehir merkezini tamamen bypass etmekte ve zaman kazandırmaktadır. İlçede apart otel ve termal tesis taşımaları da gerçekleştirildiğinden ticari nakliyat deneyimine sahibiz.",
        ["nallihan"] = "Nallıhan, Ankara'nın en batı ilçesi olup Bolu–TEM güzergâhına coğrafi olarak diğer Ankara ilçelerinden çok daha yakın konumdadır. Bu stratejik konum, İstanbul taşımalarında toplam yol mesafesini Ankara merkeze kıyasla azaltabilmektedir. İlçe merkezinden çıkış için Çayırhan güzergâhının trafiği sabah erken saatte oldukça serbest seyreder.",
        ["ayas"] = "Ayaş, bağları ve yayla havası ile Ankara'ya yaklaşık 60 km mesafedeki sakin bir ilçedir. İstanbul güzergâhı için araçlar Sincan veya Nallıhan üzerinden TEM'e ulaşmaktadır; bu bağlantı güzergâhında trafik yoğunluğu Ankara merkezine kıyasla oldukça az olmaktadır. Yükleme erken sabah başlatıldığında İstanbul'a aynı günde teslimat sağlanmaktadır.",
        ["bala"] = "Bala, Ankara'nın güneydoğusunda Kızılırmak havzasındaki tarım ilçesidir ve Ankara merkezine yaklaşık 80 km uzaklığıyla birleşik güzergâh planlaması gerekmektedir. Ankara Çevre Yolu'na çıkış için Çankaya aksından geçilmekte, ardından TEM'e bağlanılmaktadır. Bu kademeli güzergâh nedeniyle erken saatte başlayan yüklemeler tercih edilmektedir.",
        ["gudul"] = "Güdül, Ankara Boğazı kanyonu ve Bozan çevresindeki ormanlık arazi nedeniyle ulaşım için özellikli rota planlaması gerektiren bir ilçedir. İlçe merkezine giden yolun büyük bölümü çift yönlü trafiğe uygun olmakla birlikte bazı köy yolları dar ya da eğimlidir. Yükleme öncesinde adresin büyük araç erişimine uygunluğu mutlaka kontrol edilmektedir.",
        ["camlidere"] = "Çamlıdere, Kuzey Ankara Ormanı içinde gizlenmiş ve sınırlı karayolu bağlantılarıyla erişilen bir ilçedir. İstanbul güzergâhı için Kızılcahamam–Bolu yolu kullanılmakta olup bu rota Ankara şehir merkezini atlayarak zaman tasarrufu sağlayabilmektedir. İlçe sınırlarındaki bazı köy yollarına yalnızca kamyonet ölçeğinde araç girişi mümkündür.",
        ["haymana"] = "Haymana, Ankara'nın güneybatısındaki bozkır ve termal ilçesidir; merkezden yaklaşık 65 km uzaklıktadır. İstanbul güzergâhı için Çankaya üzerinden Çevre Yolu'na bağlanılmakta olup toplam mesafe Ankara merkez ilçeleriyle karşılaştırılabilir düzeydedir. Kış aylarında yaylaların karla kapandığı dönemlerde erken çıkış zorunludur.",
        ["evren"] = "Evren, Ankara'nın en küçük ilçesi olup coğrafi konumu itibariyle Kırıkkale ile Ankara'nın sınır bölgesinde yer almaktadır. İlçe merkezine erişim, dar ve kısmen engebeli yollardan sağlandığından her türlü taşımada 3,5 ton kamyonet standart çözümdür. Büyük araçlar ilçe girişinde bekleme yaparak ikincil araç koordinasyonu ile iç transferi tamamlamaktadır.",
        ["kalecik"] = "Kalecik, Kızılırmak vadisinde bağcılığıyla tanınan ve Ankara'ya yaklaşık 75 km uzaklıktaki küçük bir ilçedir. Kale ve vadideki tarihi konut dokusunda dar sokaklar nedeniyle büyük kamyon erişimi kısıtlıdır; kamyonet bu bölge için en uygun çözüm olmaktadır. İstanbul güzergâhı için Akyurt üzerinden kuzey Ankara Çevre Yolu'na ulaşılmaktadır.",
        ["sereflikocehisar"] = "Şereflikoçhisar, Tuz Gölü kıyısındaki ve Ankara merkezine yaklaşık 115 km mesafedeki güneydoğu ilçesidir. Bu uzaklık, taşıma maliyetlerine Ankara merkez ilçelerine kıyasla %20–30 arasında ek yansıyabilir; bu durum keşif aşamasında şeffaf biçimde müşteriyle paylaşılmaktadır. İstanbul'a giden araçlar Ankara Çevre Yolu'na çıkarak TEM'e bağlanmaktadır.",
    };

    private static readonly Dictionary<(string Ilce, ServisTipi Servis), string> ServisDetaylar = new()
    {
        // ── ÇANKAYA ──
        [("cankaya", ServisTipi.Kamyonet)]      = "Kavaklidere, Oran ve Çukurambar'daki site ve apartman girişleri için 3,5 ton kamyonetimiz ideal ölçektir; dar giriş ve otoparklarda sorunsuz manevra sağlar.",
        [("cankaya", ServisTipi.Sehirlerarasi)] = "Balgat ve GOP'taki residence ve apartmanlarda sabah 07:00 başlayan erken yüklemeyle Çankaya'dan İstanbul'a aynı gün teslimat sağlanmaktadır.",
        [("cankaya", ServisTipi.EvdenEve)]      = "Bahçelievler, Emek ve Kızılay mahallelerindeki çok katlı yapılarda asansör koordinasyonu ile kat başına süre hesaplanarak eksiksiz ev taşıma planlanmaktadır.",
        [("cankaya", ServisTipi.Ofis)]          = "Kızılay, Çukurambar ve GOP iş merkezlerinden gece veya hafta sonu ofis taşımaları için kurumsal fatura ve gizlilik anlaşması standart olarak sunulmaktadır.",
        [("cankaya", ServisTipi.Fuar)]          = "Çankaya'daki reklam ve tanıtım firmalarının CNR veya Tüyap fuar nakliyatlarında stand ve ekranlı display sistemleri özel ambalajla korunmaktadır.",
        [("cankaya", ServisTipi.Kamyon)]        = "Oran, Çayyolu ve Keklikpınarı'ndaki büyük sitelerin 3+1–4+1 dairelerinden İstanbul'a kamyon taşıması tüm mobilyayı tek seferde ve sigortalı olarak tamamlamaktadır.",
        [("cankaya", ServisTipi.Parsiyel)]      = "Çankaya'dan İstanbul'a öğrenci veya genç profesyonel taşımalarında parsiyel hizmet, birkaç parça mobilya ve kargo kutusu için en ekonomik seçenek olmaktadır.",
        [("cankaya", ServisTipi.Ambar)]         = "Yeni İstanbul konutu hazırlanırken Çankaya'daki mevcut eşyalar güvenli depomuza alınır; taşınma gününde İstanbul adresinize teslim edilir.",

        // ── KEÇİÖREN ──
        [("kecioren", ServisTipi.Kamyonet)]      = "Etlik ve Bağlum'daki toplu konut bloklarının dar arka sokaklarında 3,5 ton kamyonetimiz kolayca hareket eder; yüksek kat adreslerinde asansör koordinasyonu önceden yapılmaktadır.",
        [("kecioren", ServisTipi.Sehirlerarasi)] = "Keçiören Merkez ve Kalaba'dan sabah erken yüklemeyle başlanan şehirlerarası taşıma, trafik yoğunlaşmadan önce çevre yoluna çıkarak İstanbul'a aynı günde ulaşmaktadır.",
        [("kecioren", ServisTipi.EvdenEve)]      = "Kuşcağız ve Aktepe mahallelerindeki konutlarda ekibimiz asansör planlaması ve komşu koordinasyonu yaparak yükleme süresini minimize etmektedir.",
        [("kecioren", ServisTipi.Ofis)]          = "Keçiören'deki muhasebe, hukuk ve sağlık kliniklerinin İstanbul taşımalarında IT ekipmanı ve arşiv dolapları için gece çalışma seçeneği sunulmaktadır.",
        [("kecioren", ServisTipi.Fuar)]          = "Keçiören'den İstanbul fuar alanlarına taşınan promosyon ve satış stand materyalleri, fuar tarihinden en az 2 gün önce teslim edilmek üzere programlanmaktadır.",
        [("kecioren", ServisTipi.Kamyon)]        = "Bağlum ve Keçiören Merkez'deki 3+1 konutlardan İstanbul'a 12 ton kamyon ile tek seferde taşıma yapıldığında iki tur kamyonet masrafının önüne geçilmektedir.",
        [("kecioren", ServisTipi.Parsiyel)]      = "Keçiören'den İstanbul'a taşınacak az eşya için paylaşımlı araç haftanın belirli günleri hareket etmektedir; rezervasyon 2–3 gün öncesinden alınmaktadır.",
        [("kecioren", ServisTipi.Ambar)]         = "Keçiören'deki kiralık eviyle çıkarken İstanbul'daki yeni evinin hazır olmasını bekleyen müşteriler, eşyalarını depomuzda güvenle tutabilmektedir.",

        // ── YENİMAHALLE ──
        [("yenimahalle", ServisTipi.Kamyonet)]      = "Demetevler ve Şentepe'nin yüksek katlı bloklarında kamyonet hizmetimiz asansör planlaması ile koordineli yürütülmekte, yükleme süresi minimuma indirilmektedir.",
        [("yenimahalle", ServisTipi.Sehirlerarasi)] = "Yenimahalle'den TEM'e çok kısa bağlantı süresi sayesinde sabah yüklemesi başlayan şehirlerarası araç öğlenden önce İstanbul'a ulaşmaktadır.",
        [("yenimahalle", ServisTipi.EvdenEve)]      = "Batıkent ve Ostim çevresindeki planlı konut alanlarında geniş bina girişleri büyük mobilyaların kolay taşınmasına imkân tanımakta, aynı gün teslimat sağlanmaktadır.",
        [("yenimahalle", ServisTipi.Ofis)]          = "Ostim OSB'deki firma ofislerinden İstanbul'a kurumsal taşımalar için IT ekipmanı etiketi ve taşıma protokolü standart olarak uygulanmaktadır.",
        [("yenimahalle", ServisTipi.Fuar)]          = "Yenimahalle'deki teknik donanım firmalarının İstanbul fuarlarına taşımasında cihaz ve ekipmanlar vibrasyon emici ambalajla korunmaktadır.",
        [("yenimahalle", ServisTipi.Kamyon)]        = "İvedik'teki sanayi işletmelerinden ve Batıkent'teki büyük konutlardan İstanbul'a 12–18 ton kamyon taşıması için güzergâh kısa ve verimlidir.",
        [("yenimahalle", ServisTipi.Parsiyel)]      = "Yenimahalle'den İstanbul'a öğrenci ve bekar taşımalarında parsiyel araç servisi haftada düzenli olarak kalkış yapmaktadır.",
        [("yenimahalle", ServisTipi.Ambar)]         = "Yenimahalle'deki ev ya da ofisini boşaltıp İstanbul'a geçiş tarihi netleşmemiş müşteriler için depolama hizmeti esnek süreli olarak sunulmaktadır.",

        // ── MAMAK ──
        [("mamak", ServisTipi.Kamyonet)]      = "Tuzluçayır ve Hüseyingazi'nin eğimli mahalle dokusunda dar yollarda 3,5 ton kamyonetimiz en güvenli ve en uygun taşıma aracını oluşturmaktadır.",
        [("mamak", ServisTipi.Sehirlerarasi)] = "Mamak'tan Çankaya aksına çıkan araç, anayola kolay erişimle Ankara Çevre Yolu'nu geçerek TEM'e bağlanmakta ve aynı gün İstanbul'a teslimat sağlamaktadır.",
        [("mamak", ServisTipi.EvdenEve)]      = "Mamak Merkez ve Kutlu mahallelerinin çok katlı konutlarında asansör koordinasyonu ve kat başına mobilya taşıma süresi önceden hesaplanmaktadır.",
        [("mamak", ServisTipi.Ofis)]          = "Mamak'taki küçük ve orta ölçekli işletmelerin İstanbul ofis taşımalarında IT ve arşiv paketleme için standart kurumsal protokol uygulanmaktadır.",
        [("mamak", ServisTipi.Fuar)]          = "Mamak'taki üretim ve distribütörlük firmalarının İstanbul fuarlarına taşınan ürün ve teşhir materyalleri zamanında ve hasarsız teslim için planlanmaktadır.",
        [("mamak", ServisTipi.Kamyon)]        = "Mamak'taki 3+1 ve büyük dairelerden İstanbul'a kamyon taşıması, eğimli arazi avantajını değerlendirerek yükleme saatini optimize etmektedir.",
        [("mamak", ServisTipi.Parsiyel)]      = "Mamak'tan İstanbul'a kargo kutusu veya birkaç parça mobilya göndermek için parsiyel araç hizmeti uygun fiyatlı ve zamanında teslimat imkânı sunmaktadır.",
        [("mamak", ServisTipi.Ambar)]         = "Mamak'taki konut boşaltma sürecinde eşyaların depoya alınması, yeni İstanbul adresine taşınma tarihine kadar güvenli muhafazayı garanti etmektedir.",

        // ── ETİMESGUT ──
        [("etimesgut", ServisTipi.Kamyonet)]      = "Eryaman TOKİ'nin büyük blok girişleri ve geniş park alanları, hem kamyonet hem de kamyon operasyonları için ideal bir çalışma ortamı sunmaktadır.",
        [("etimesgut", ServisTipi.Sehirlerarasi)] = "Etimesgut'tan Batı Çevre Yolu'na hızlı bağlantı, şehirlerarası araçların Ankara trafik saatlerinden etkilenmeden İstanbul'a yola çıkmasını sağlamaktadır.",
        [("etimesgut", ServisTipi.EvdenEve)]      = "Elvankent ve Göksu'daki büyük sitelerde kapıcı ve site yönetimi iletişimi ekibimiz tarafından önceden sağlanarak yükleme günü aksaksız yürütülmektedir.",
        [("etimesgut", ServisTipi.Ofis)]          = "Etimesgut'taki teknoloji ve mühendislik firmalarının İstanbul ofis taşımalarında sunucu ve ağ ekipmanlarının özel ambalajı ve güvenli nakliyatı yapılmaktadır.",
        [("etimesgut", ServisTipi.Fuar)]          = "Etimesgut'taki OEM ve distribütörlük firmalarının İstanbul fuar taşımalarında ekipman ve teşhir materyalleri için esnek zamanlama sunulmaktadır.",
        [("etimesgut", ServisTipi.Kamyon)]        = "Eryaman'daki 4+1 ve villa tarzı konutlardan İstanbul'a büyük mobilya taşımaları için 18 ton kapasiteli kamyon tek seferde eksiksiz çözüm üretmektedir.",
        [("etimesgut", ServisTipi.Parsiyel)]      = "Etimesgut'tan İstanbul'a taşınacak az eşya için haftalık düzenli parsiyel araç hizmeti vardır; eşya miktarına göre fiyat belirlenmektedir.",
        [("etimesgut", ServisTipi.Ambar)]         = "Elvankent'teki konutunu teslim etmeden önce eşyalarını depolamamıza veren müşteriler, İstanbul'daki kilit tesliminden sonra nakliyatı tamamlamaktadır.",

        // ── SİNCAN ──
        [("sincan", ServisTipi.Kamyonet)]      = "Sincan Merkez ve Fatih mahallelerindeki konutlara 3,5 ton kamyonetimiz sabah saatlerinde kolayca erişmektedir; TEM'e çok yakın konumu kısa sürede taşımayı başlatmaktadır.",
        [("sincan", ServisTipi.Sehirlerarasi)] = "Sincan'ın TEM girişine fiilen bitişik konumu, şehirlerarası araçların Ankara trafiğine hiç girmeden İstanbul'a yola çıkmasına olanak tanımaktadır.",
        [("sincan", ServisTipi.EvdenEve)]      = "Pirinçlik ve Anıt mahallelerinde yüksek katlı konut taşımalarında asansör planlaması ve komşu koordinasyonu hızlı ve sessiz yükleme sağlamaktadır.",
        [("sincan", ServisTipi.Ofis)]          = "Sincan OSB'deki firmaların İstanbul ofis veya tesis taşımalarında büyük araç altyapısı hazır güzergâhtan yararlanılmaktadır.",
        [("sincan", ServisTipi.Fuar)]          = "Sincan'ın İstanbul fuar alanlarına olan güzergâh avantajı, stand ve ekipman taşımalarını zamanında teslimat için optimize etmektedir.",
        [("sincan", ServisTipi.Kamyon)]        = "Sincan'daki 2+1 ve üzeri konutlardan İstanbul'a kamyon taşıması için en kısa Ankara çıkış güzergâhı kullanılmaktadır.",
        [("sincan", ServisTipi.Parsiyel)]      = "Sincan'dan İstanbul'a az eşya göndermek isteyenler için parsiyel araç hizmetimiz uygun fiyat ve hızlı teslimat sunmaktadır.",
        [("sincan", ServisTipi.Ambar)]         = "Sincan'daki eşya depolaması İstanbul'daki taşınma tarihine kadar güvenli kapalı depolarda muhafaza edilmektedir.",

        // ── ALTINDAĞ ──
        [("altindag", ServisTipi.Kamyonet)]      = "Hamamönü ve Ulus'un tarihi sokak dokusunda 3,5 ton kamyonetimiz standart büyük araçların ulaşamadığı pek çok adrese erişim sağlamaktadır.",
        [("altindag", ServisTipi.Sehirlerarasi)] = "Altındağ Merkez'den sabah erken yüklemeyle başlanan taşıma, Çankaya aksından Çevre Yolu'na çıkarak İstanbul'a aynı gün teslimatı tamamlamaktadır.",
        [("altindag", ServisTipi.EvdenEve)]      = "Çiçek ve Atıfbey mahallelerindeki yüksek katlı konutlarda asansör koordinasyonu ile eksiksiz ev taşıma sağlanmaktadır.",
        [("altindag", ServisTipi.Ofis)]          = "Anafartalar ticaret bölgesindeki işletme taşımalarında ticari araç gece kısıtlamalarına uygun saat planlaması yapılmaktadır.",
        [("altindag", ServisTipi.Fuar)]          = "Altındağ'daki üretim ve satış firmalarının İstanbul fuar taşımalarında ürün ve teşhir materyalleri için titiz paketleme uygulanmaktadır.",
        [("altindag", ServisTipi.Kamyon)]        = "Altındağ'ın yüksek katlı sosyal konut yapılarından 3+1 daire taşımaları 12 ton kamyon ile tek seferde tamamlanmaktadır.",
        [("altindag", ServisTipi.Parsiyel)]      = "Altındağ'dan İstanbul'a birkaç parça eşya veya kargo gönderimi parsiyel araç hizmetiyle ekonomik biçimde gerçekleştirilmektedir.",
        [("altindag", ServisTipi.Ambar)]         = "Altındağ'daki konut veya iş yerinden çıkıp İstanbul'a geçiş tarihini bekleyen müşteriler için esnek depolama hizmeti sunulmaktadır.",

        // ── GÖLBAŞI ──
        [("golbasi", ServisTipi.Kamyonet)]      = "Gölbaşı'ndaki müstakil ve villa bölgelerinden taşınan büyük antika veya tasarım mobilyalar için özel ambalaj ve kamyonet hizmeti titizlikle uygulanmaktadır.",
        [("golbasi", ServisTipi.Sehirlerarasi)] = "Gölbaşı'ndan Konya yolu üzerinden Çevre Yolu'na bağlanan güzergâh, sabah 07:00'de erken trafik öncesinde çıkışa en uygun saattir.",
        [("golbasi", ServisTipi.EvdenEve)]      = "Mogan Gölü çevresindeki villaların geniş eşya hacmini kapsayan ev taşımalarında 12 ton kamyon kapasitesiyle tek seferlik nakliyat sağlanmaktadır.",
        [("golbasi", ServisTipi.Ofis)]          = "Gölbaşı'ndaki teknopolis ve serbest bölge firmalarının İstanbul ofis taşımalarında güvenli sunucu ve ekipman nakliyesi için standart IT protokolü uygulanmaktadır.",
        [("golbasi", ServisTipi.Fuar)]          = "Gölbaşı'ndaki ihracat ve teknoloji firmalarının İstanbul fuar ekipman taşımalarında erken rezervasyon ile tarih garantisi verilmektedir.",
        [("golbasi", ServisTipi.Kamyon)]        = "Mogan çevresindeki 4+1 ve villa konutlardan İstanbul'a 18 ton kamyon ile büyük mobilya taşıması tek seferde tamamlanmaktadır.",
        [("golbasi", ServisTipi.Parsiyel)]      = "Gölbaşı'ndan İstanbul'a az eşya için parsiyel araç hizmetimiz haftanın belirli günleri hareket etmektedir.",
        [("golbasi", ServisTipi.Ambar)]         = "Gölbaşı'ndan taşınan eşyalar İstanbul konuta hazır olana kadar klimalı ve güvenlikli depolarda saklanmaktadır.",

        // ── PURSAKLAR ──
        [("pursaklar", ServisTipi.Kamyonet)]      = "Pursaklar İstasyon ve Saray mahallelerindeki yeni konut sitelerinden yapılan taşımalarda asansörlü bina avantajıyla hızlı yükleme gerçekleştirilmektedir.",
        [("pursaklar", ServisTipi.Sehirlerarasi)] = "Pursaklar'dan Keçiören aksına geçiş sonrasında Çevre Yolu'na çıkılmakta, şehirlerarası araç İstanbul'a aynı gün teslimatı tamamlamaktadır.",
        [("pursaklar", ServisTipi.EvdenEve)]      = "Karacaören ve Hacıhasan mahallelerindeki konutlarda tam kapsamlı ev taşıma hizmetimiz ambalaj ve montaj dahil sunulmaktadır.",
        [("pursaklar", ServisTipi.Ofis)]          = "Pursaklar'daki ticari işletmelerin İstanbul ofis taşımalarında IT ekipmanı ve arşiv koruması için standart kurumsal paket uygulanmaktadır.",
        [("pursaklar", ServisTipi.Fuar)]          = "Pursaklar'daki firmalar için İstanbul fuarlarına yönelik stand ve ekipman taşımalarında fuar tarihi bazlı esnek planlama yapılmaktadır.",
        [("pursaklar", ServisTipi.Kamyon)]        = "Pursaklar'ın yeni konut sitelerindeki 3+1 ve 4+1 dairelerden büyük mobilya taşımaları kamyon ile tek seferde tamamlanmaktadır.",
        [("pursaklar", ServisTipi.Parsiyel)]      = "Pursaklar'dan İstanbul'a az eşya için parsiyel araç hizmeti 2 gün öncesinden rezervasyonla verilmektedir.",
        [("pursaklar", ServisTipi.Ambar)]         = "Pursaklar'daki eşyalar kısa ya da uzun süreli depolama seçeneğiyle güvenli depomuza alınmakta, İstanbul'a hazır olunduğunda teslim edilmektedir.",

        // ── POLATLI ──
        [("polatli", ServisTipi.Kamyonet)]      = "Polatlı Merkez ve Yenidoğan mahallelerinden İstanbul'a kamyonet taşıması ek mesafe nedeniyle sabah 06:00–07:00 gibi erken başlatılması önerilmektedir.",
        [("polatli", ServisTipi.Sehirlerarasi)] = "Polatlı'dan İstanbul'a şehirlerarası nakliyat yaklaşık 500 km güzergâh nedeniyle fiyat ve süre açısından Ankara merkez ilçelerinden farklılaşmaktadır; keşif aşamasında net bilgi verilmektedir.",
        [("polatli", ServisTipi.EvdenEve)]      = "Polatlı'nın Seymen ve Yenikent mahallelerindeki evden eve taşımalarında erken yükleme başlangıcıyla aynı gün İstanbul'a teslimat yapılabilmektedir.",
        [("polatli", ServisTipi.Ofis)]          = "Polatlı'daki tarımsal ekipman ve ticaret firmalarının İstanbul ofis taşımalarında geniş araç kapasitesi ve esnek tarih seçeneği sunulmaktadır.",
        [("polatli", ServisTipi.Fuar)]          = "Polatlı'dan İstanbul fuarlarına uzun mesafe fuar taşımacılığı için önceden rezervasyon ve kesin tarih belirlenmesi gereklidir.",
        [("polatli", ServisTipi.Kamyon)]        = "Polatlı'dan İstanbul'a büyük konut taşımalarında kamyon hizmeti ek mesafe nedeniyle sabah erken hareketle planlanmaktadır.",
        [("polatli", ServisTipi.Parsiyel)]      = "Polatlı'dan İstanbul'a parsiyel araç hizmetinde ek mesafe fiyata yansımakta olup bu durum keşiften önce şeffafça bildirilmektedir.",
        [("polatli", ServisTipi.Ambar)]         = "Polatlı'daki eşyalar depolanarak İstanbul'daki taşınma günü için bekletilmektedir; mesafe farkı depolama hizmetini cazip kılmaktadır.",

        // ── AKYURT ──
        [("akyurt", ServisTipi.Kamyonet)]      = "Akyurt Merkez ve Karaağaç mahallelerindeki konut alanlarına 3,5 ton kamyonetimiz kolayca ulaşmakta, bazı sanayi alanı içi adreslerde büyük araç kullanılmaktadır.",
        [("akyurt", ServisTipi.Sehirlerarasi)] = "Akyurt'tan Pursaklar aksından kuzey Çevre Yolu'na geçilerek İstanbul'a şehirlerarası taşıma aynı günde tamamlanmaktadır.",
        [("akyurt", ServisTipi.EvdenEve)]      = "Akyurt'taki konutlarda evden eve taşıma için eksiksiz keşif yapılarak eşya miktarı ve adres erişimi önceden değerlendirilmektedir.",
        [("akyurt", ServisTipi.Ofis)]          = "Akyurt OSB'deki firmaların İstanbul ofis taşımalarında büyük araç altyapısı kullanılmakta, kurumsal protokol uygulanmaktadır.",
        [("akyurt", ServisTipi.Fuar)]          = "Akyurt'taki sanayi firmalarının İstanbul fuar taşımalarında ürün ve teşhir materyalleri sigortalı olarak nakliyatı yapılmaktadır.",
        [("akyurt", ServisTipi.Kamyon)]        = "Akyurt'taki 2+1 ve üzeri konutlardan İstanbul'a 12 ton kamyon ile tek seferlik taşıma tamamlanmaktadır.",
        [("akyurt", ServisTipi.Parsiyel)]      = "Akyurt'tan İstanbul'a birkaç parça eşya için parsiyel araç hizmeti uygun maliyetli ve hızlı teslimat sunmaktadır.",
        [("akyurt", ServisTipi.Ambar)]         = "Akyurt'taki eşyaların depolanması sonrasında İstanbul'a taşınma tarihine kadar güvenli muhafaza sağlanmaktadır.",

        // ── ELMADAĞ ──
        [("elmadag", ServisTipi.Kamyonet)]      = "Elmadağ Merkez ve Hasanoğlan'daki sivil konut adreslerine 3,5 ton kamyonetimiz sorunsuz erişim sağlarken askeri bölge sınırları dışındaki güzergahlardan hareket edilmektedir.",
        [("elmadag", ServisTipi.Sehirlerarasi)] = "Elmadağ'dan Mamak aksından Çankaya Çevre Yolu'na ulaşan araç, İstanbul'a şehirlerarası taşımayı aynı gün tamamlamaktadır.",
        [("elmadag", ServisTipi.EvdenEve)]      = "Balışeyh ve Elmaağaç mahallelerindeki evden eve taşımalar için önceden güzergah ve erişim planlaması yapılmaktadır.",
        [("elmadag", ServisTipi.Ofis)]          = "Elmadağ'daki küçük ölçekli işletmelerin İstanbul ofis taşımalarında IT ekipmanı ve arşiv koruması standart olarak sağlanmaktadır.",
        [("elmadag", ServisTipi.Fuar)]          = "Elmadağ'daki firmalar için İstanbul fuar taşımalarında zamanında teslimat ve özel ambalaj garantisi verilmektedir.",
        [("elmadag", ServisTipi.Kamyon)]        = "Elmadağ'dan İstanbul'a büyük daire taşımalarında 12 ton kamyon ile erken sabah başlayan yükleme aynı gün teslimata olanak tanımaktadır.",
        [("elmadag", ServisTipi.Parsiyel)]      = "Elmadağ'dan İstanbul'a az eşya için parsiyel araç hizmeti rezervasyona dayalı olarak sunulmaktadır.",
        [("elmadag", ServisTipi.Ambar)]         = "Elmadağ'daki eşyaların depolanması, İstanbul taşınma tarihinin netleşmesi beklenirken güvenli çözüm sunmaktadır.",

        // ── BEYPAZARI ──
        [("beypazari", ServisTipi.Kamyonet)]      = "Beypazarı'ndaki tarihi konak ve yöresel evlerden taşınan antika ve değerli eşyalar özel ambalajla korunarak kamyonet ile İstanbul'a ulaştırılmaktadır.",
        [("beypazari", ServisTipi.Sehirlerarasi)] = "Beypazarı'ndan Bolu yolu üzerinden TEM'e bağlanan güzergâh, Ankara şehir merkezini bypass etmekte ve taşıma süresini optimize etmektedir.",
        [("beypazari", ServisTipi.EvdenEve)]      = "Beypazarı'ndaki tarihi evlerin dar girişleri için ev taşıma planlaması önceden yapılmakta, hassas mobilya için özel paketleme uygulanmaktadır.",
        [("beypazari", ServisTipi.Ofis)]          = "Beypazarı'ndaki işletmelerin İstanbul ofis taşımalarında ek mesafe nedeniyle sabah erken hareket ve gün içi teslimat planlanmaktadır.",
        [("beypazari", ServisTipi.Fuar)]          = "Beypazarı'ndan İstanbul fuar taşımalarında Bolu güzergâhı kullanılarak taşıma süresi minimize edilmektedir.",
        [("beypazari", ServisTipi.Kamyon)]        = "Beypazarı'ndaki büyük konakların eşya hacmi için 12 ton kamyon ile tek seferlik İstanbul taşıması tamamlanmaktadır.",
        [("beypazari", ServisTipi.Parsiyel)]      = "Beypazarı'ndan İstanbul'a parsiyel araç hizmeti ek mesafe gözetilerek fiyatlandırılmakta, keşif aşamasında bildirilmektedir.",
        [("beypazari", ServisTipi.Ambar)]         = "Beypazarı'ndaki eşyaların depolanması ve daha sonra İstanbul'a teslimi için esnek tarih seçeneği sunulmaktadır.",

        // ── KAHRAMANKAZAN ──
        [("kahramankazan", ServisTipi.Kamyonet)]      = "Kahramankazan Merkez ve Yakuplu mahallelerindeki konutlara kamyonetimiz kolayca ulaşmakta, OSB yakınlığındaki adreslerde büyük araç altyapısı da hazırdır.",
        [("kahramankazan", ServisTipi.Sehirlerarasi)] = "Kahramankazan'dan Sincan aksına geçilerek TEM'e bağlanan güzergâh şehirlerarası taşımaları zaman açısından verimli kılmaktadır.",
        [("kahramankazan", ServisTipi.EvdenEve)]      = "Kazan Merkez'deki konutlarda evden eve taşıma hizmetimiz sabah erken başlayan yüklemeyle aynı gün İstanbul'da tamamlanmaktadır.",
        [("kahramankazan", ServisTipi.Ofis)]          = "Kahramankazan OSB'deki firmalar için İstanbul'a ofis taşıması büyük araç altyapısı ve kurumsal protokol ile gerçekleştirilmektedir.",
        [("kahramankazan", ServisTipi.Fuar)]          = "Kahramankazan'daki sanayi firmalarının İstanbul fuar taşımalarında sigortalı ekipman nakliyatı planlanmaktadır.",
        [("kahramankazan", ServisTipi.Kamyon)]        = "Kahramankazan'daki büyük dairelerden İstanbul'a 12 ton kamyon ile tek seferlik taşıma TEM güzergahıyla hızla tamamlanmaktadır.",
        [("kahramankazan", ServisTipi.Parsiyel)]      = "Kahramankazan'dan İstanbul'a az eşya için parsiyel araç hizmeti haftalık düzenli sefer ile sunulmaktadır.",
        [("kahramankazan", ServisTipi.Ambar)]         = "Kahramankazan'daki eşyalar güvenli depolama hizmetiyle İstanbul taşınma tarihine kadar muhafaza edilmektedir.",

        // ── ÇUBUK ──
        [("cubuk", ServisTipi.Kamyonet)]      = "Çubuk Merkez ve Ovacık mahallelerinin ara yollarında 3,5 ton kamyonetimiz en güvenli ve uygun ölçekli araç olarak hizmet vermektedir.",
        [("cubuk", ServisTipi.Sehirlerarasi)] = "Çubuk'tan Pursaklar üzerinden Çevre Yolu'na ulaşan şehirlerarası araç, İstanbul'a aynı gün teslimatı tamamlamaktadır; sabah erken başlangıç önerilmektedir.",
        [("cubuk", ServisTipi.EvdenEve)]      = "Çubuk'taki evden eve taşımalar için yükleme öncesinde adres ve yol güzergahı değerlendirmesi yapılmakta, en uygun araç seçilmektedir.",
        [("cubuk", ServisTipi.Ofis)]          = "Çubuk'taki işletmelerin İstanbul taşımalarında IT ekipmanı ve arşiv için standart koruma uygulanmaktadır.",
        [("cubuk", ServisTipi.Fuar)]          = "Çubuk'tan İstanbul fuar taşımalarında önceden tarih planlaması yapılarak kalkış saati ve rota belirlenmektedir.",
        [("cubuk", ServisTipi.Kamyon)]        = "Çubuk'taki büyük dairelerden İstanbul'a kamyon taşıması için sabah erken başlangıç ve mola planlaması yapılmaktadır.",
        [("cubuk", ServisTipi.Parsiyel)]      = "Çubuk'tan İstanbul'a az eşya için parsiyel araç hizmetimiz rezervasyona dayalı olarak verilmektedir.",
        [("cubuk", ServisTipi.Ambar)]         = "Çubuk'taki eşyaların kısa ya da uzun süreli depolanması ve İstanbul'a teslimi için esnek tarih seçeneği sunulmaktadır.",

        // ── KIZILCAHAMAM ──
        [("kizilcahamam", ServisTipi.Kamyonet)]      = "Kızılcahamam Merkez ve Çeltikçi mahallelerindeki konutlara kamyonetimiz Çubuk güzergahından sorunsuz erişmektedir.",
        [("kizilcahamam", ServisTipi.Sehirlerarasi)] = "Kızılcahamam'dan Bolu–TEM güzergahı kullanılarak İstanbul'a şehirlerarası taşıma, Ankara şehir merkezini bypass eden en hızlı rotayı sunmaktadır.",
        [("kizilcahamam", ServisTipi.EvdenEve)]      = "Kızılcahamam'ın termal bölgesindeki konutlardan ev taşıma planlaması yapılmakta, ağır mobilyalar için özel ekip hazır tutulmaktadır.",
        [("kizilcahamam", ServisTipi.Ofis)]          = "Kızılcahamam'daki termal ve turizm tesislerinden İstanbul ofis veya tesis taşımalarında esnek tarih planlaması yapılmaktadır.",
        [("kizilcahamam", ServisTipi.Fuar)]          = "Kızılcahamam'dan İstanbul fuarlarına Bolu güzergahı üzerinden taşıma yapılmakta, teslimat tarihinde kesinlik sağlanmaktadır.",
        [("kizilcahamam", ServisTipi.Kamyon)]        = "Kızılcahamam'daki büyük konutlardan İstanbul'a kamyon ile taşıma için Bolu yolunun güzergah avantajından yararlanılmaktadır.",
        [("kizilcahamam", ServisTipi.Parsiyel)]      = "Kızılcahamam'dan İstanbul'a az eşya için parsiyel araç hizmeti rezervasyon ile verilmektedir.",
        [("kizilcahamam", ServisTipi.Ambar)]         = "Kızılcahamam'daki eşyaların güvenli depolanması ve daha sonra İstanbul'a teslimatı esnek tarihle planlanmaktadır.",

        // ── NALLIHAN ──
        [("nallihan", ServisTipi.Kamyonet)]      = "Nallıhan Merkez ve Çayırhan mahallelerinden İstanbul'a kamyonet taşıması, Bolu güzergahının coğrafi avantajıyla kısa sürede tamamlanmaktadır.",
        [("nallihan", ServisTipi.Sehirlerarasi)] = "Nallıhan'dan TEM'e olan kısa mesafe, şehirlerarası araçların Ankara trafiğine girmeden İstanbul'a ulaşmasını sağlayan nadir bir avantaj sunmaktadır.",
        [("nallihan", ServisTipi.EvdenEve)]      = "Nallıhan'daki evden eve taşımalar için yükleme sabah başlatılarak öğleden sonra İstanbul'da teslimat yapılmaktadır.",
        [("nallihan", ServisTipi.Ofis)]          = "Nallıhan'daki işletmelerin İstanbul taşımalarında kurumsal ekipman güvenliği için standart protokol uygulanmaktadır.",
        [("nallihan", ServisTipi.Fuar)]          = "Nallıhan'ın TEM'e yakınlığı fuar taşımalarında zaman avantajı sağlamakta; erken rezervasyonla tarih garantisi verilmektedir.",
        [("nallihan", ServisTipi.Kamyon)]        = "Nallıhan'daki büyük konutlardan İstanbul'a kamyon taşıması TEM'e yakın konumu sayesinde hızlıca tamamlanmaktadır.",
        [("nallihan", ServisTipi.Parsiyel)]      = "Nallıhan'dan İstanbul'a az eşya için parsiyel araç hizmeti haftanın belirlenen günlerinde verilmektedir.",
        [("nallihan", ServisTipi.Ambar)]         = "Nallıhan'daki eşyaların İstanbul'a taşınma gününe kadar depoda güvenle muhafaza edilmesi esnek tarihli olarak planlanmaktadır.",

        // ── AYAŞ ──
        [("ayas", ServisTipi.Kamyonet)]      = "Ayaş Merkez ve Belpınar mahallelerinden İstanbul'a kamyonet taşıması sabah 07:00'de başlatılarak TEM'e Sincan aksından çıkılmaktadır.",
        [("ayas", ServisTipi.Sehirlerarasi)] = "Ayaş'tan Sincan üzerinden TEM'e bağlanan güzergâh şehirlerarası araçların aynı gün İstanbul'a ulaşmasını sağlamaktadır.",
        [("ayas", ServisTipi.EvdenEve)]      = "Ayaş'taki evden eve taşımalar için eşya hacmi ve daire büyüklüğüne göre araç seçimi yapılmakta, kapıdan kapıya hizmet sunulmaktadır.",
        [("ayas", ServisTipi.Ofis)]          = "Ayaş'taki işletmelerin İstanbul taşımalarında IT ve arşiv ekipmanları için kurumsal paket uygulanmaktadır.",
        [("ayas", ServisTipi.Fuar)]          = "Ayaş'tan İstanbul fuar taşımalarında zamanında teslimat için sabah erken başlangıç planlanmaktadır.",
        [("ayas", ServisTipi.Kamyon)]        = "Ayaş'taki büyük dairelerden İstanbul'a kamyon ile tek seferlik taşıma TEM güzergahı üzerinden tamamlanmaktadır.",
        [("ayas", ServisTipi.Parsiyel)]      = "Ayaş'tan İstanbul'a az eşya için parsiyel araç hizmeti talebe göre rezervasyonla verilmektedir.",
        [("ayas", ServisTipi.Ambar)]         = "Ayaş'taki eşyaların depolama hizmetiyle bekletilmesi ve İstanbul'a zamanında teslimi için esnek plan sunulmaktadır.",

        // ── BALA ──
        [("bala", ServisTipi.Kamyonet)]      = "Bala Merkez ve Hacılar mahallelerinden İstanbul'a kamyonet taşıması Ankara çevre yolundan TEM'e erişimle sabah erken başlatılmaktadır.",
        [("bala", ServisTipi.Sehirlerarasi)] = "Bala'nın Ankara Çevre Yolu güzergahı üzerinden TEM'e bağlanması şehirlerarası taşımada aynı gün teslimata imkân tanımaktadır.",
        [("bala", ServisTipi.EvdenEve)]      = "Bala'daki evden eve taşımalar için daire keşfi ve eşya miktarı önceden değerlendirilerek araç kapasitesi belirlenmektedir.",
        [("bala", ServisTipi.Ofis)]          = "Bala'daki küçük işletmelerin İstanbul ofis taşımalarında IT ve arşiv için standart kurumsal protokol uygulanmaktadır.",
        [("bala", ServisTipi.Fuar)]          = "Bala'dan İstanbul fuar taşımasında ek mesafe gözetilerek sabah erken kalkış ve zamanında teslimat planlanmaktadır.",
        [("bala", ServisTipi.Kamyon)]        = "Bala'daki büyük konutlardan İstanbul'a kamyon ile tek seferlik taşıma güneydoğu çevre yolundan TEM'e bağlanarak tamamlanmaktadır.",
        [("bala", ServisTipi.Parsiyel)]      = "Bala'dan İstanbul'a az eşya için parsiyel araç hizmetimiz mesafe farkı gözetilerek fiyatlandırılmaktadır.",
        [("bala", ServisTipi.Ambar)]         = "Bala'daki eşyaların depolanması ve İstanbul'a zamanında teslimi için esnek tarihli depolama hizmeti sunulmaktadır.",

        // ── GÜDÜL ──
        [("gudul", ServisTipi.Kamyonet)]      = "Güdül Merkez ve Kabaklar mahallelerine erişen 3,5 ton kamyonetimiz dar ve virajlı yollarda güvenle manevra yapabilmektedir.",
        [("gudul", ServisTipi.Sehirlerarasi)] = "Güdül'den Beypazarı aksından Bolu–TEM güzergahına bağlanan rota, Ankara şehir merkezini bypass ederek İstanbul'a hızlı erişim sağlamaktadır.",
        [("gudul", ServisTipi.EvdenEve)]      = "Güdül'deki evden eve taşımalar için araç erişimi önceden değerlendirilmekte; dar yollu adresler için kamyonet standart çözüm olmaktadır.",
        [("gudul", ServisTipi.Ofis)]          = "Güdül'deki küçük ölçekli işletmelerin İstanbul taşımalarında IT ekipmanı koruması için standart paket sunulmaktadır.",
        [("gudul", ServisTipi.Fuar)]          = "Güdül'den İstanbul fuar taşımalarında güzergah planlaması önceden yapılarak zamanında teslimat garantisi verilmektedir.",
        [("gudul", ServisTipi.Kamyon)]        = "Güdül'deki büyük konutlardan İstanbul'a kamyon taşıması için araç erişimi önceden değerlendirilmektedir.",
        [("gudul", ServisTipi.Parsiyel)]      = "Güdül'den İstanbul'a az eşya için parsiyel araç hizmeti talebe dayalı olarak planlanmaktadır.",
        [("gudul", ServisTipi.Ambar)]         = "Güdül'deki eşyaların kısa süreli depolanması ve İstanbul'a teslimi için esnek plan sunulmaktadır.",

        // ── ÇAMLIDERE ──
        [("camlidere", ServisTipi.Kamyonet)]      = "Çamlıdere Merkez ve Çamkoru mahallelerine erişen 3,5 ton kamyonetimiz ormanlık alanlardaki dar ve kıvrımlı yollarda güvenle çalışmaktadır.",
        [("camlidere", ServisTipi.Sehirlerarasi)] = "Çamlıdere'den Kızılcahamam–Bolu yolu üzerinden TEM'e bağlanan güzergah Ankara şehir merkezini tamamen atlayarak İstanbul'a ulaşmaktadır.",
        [("camlidere", ServisTipi.EvdenEve)]      = "Çamlıdere'nin sınırlı erişim yolları nedeniyle ev taşıma planlaması araç erişim değerlendirmesiyle başlatılmaktadır.",
        [("camlidere", ServisTipi.Ofis)]          = "Çamlıdere'deki işletmelerin İstanbul taşımalarında ek mesafe gözetilerek esnek tarih planlaması yapılmaktadır.",
        [("camlidere", ServisTipi.Fuar)]          = "Çamlıdere'den İstanbul fuar taşımalarında Bolu güzergahı kullanılarak taşıma süresi optimize edilmektedir.",
        [("camlidere", ServisTipi.Kamyon)]        = "Çamlıdere'deki büyük konutlardan İstanbul'a kamyon erişiminde ilçe girişinde ikincil araç koordinasyonu gerekebilmektedir.",
        [("camlidere", ServisTipi.Parsiyel)]      = "Çamlıdere'den İstanbul'a parsiyel araç hizmeti talep bazlı olarak planlanmakta, ek mesafe fiyata yansımaktadır.",
        [("camlidere", ServisTipi.Ambar)]         = "Çamlıdere'deki eşyaların depolanması ve İstanbul'a zamanında teslimi için esnek tarihli depolama seçeneği sunulmaktadır.",

        // ── HAYMANA ──
        [("haymana", ServisTipi.Kamyonet)]      = "Haymana Merkez ve Yeşilyurt mahallelerinden İstanbul'a kamyonet taşıması Çankaya aksından Çevre Yolu'na bağlanarak sabah başlatılmaktadır.",
        [("haymana", ServisTipi.Sehirlerarasi)] = "Haymana'dan Ankara Çevre Yolu üzerinden TEM'e ulaşan şehirlerarası araç İstanbul'a aynı gün teslimata ulaşmaktadır.",
        [("haymana", ServisTipi.EvdenEve)]      = "Haymana'nın güneybatı konumuna rağmen evden eve taşıma planlaması erken başlangıçla aynı gün teslimatı mümkün kılmaktadır.",
        [("haymana", ServisTipi.Ofis)]          = "Haymana'daki işletmelerin İstanbul ofis taşımalarında IT ekipmanı ve arşiv güvenliği için standart protokol uygulanmaktadır.",
        [("haymana", ServisTipi.Fuar)]          = "Haymana'dan İstanbul fuar taşımalarında ek mesafe gözetilerek sabah erken başlangıç ile zamanında teslimat sağlanmaktadır.",
        [("haymana", ServisTipi.Kamyon)]        = "Haymana'daki büyük konutlardan İstanbul'a kamyon taşıması erken başlangıçla aynı gün teslimata ulaşmaktadır.",
        [("haymana", ServisTipi.Parsiyel)]      = "Haymana'dan İstanbul'a az eşya için parsiyel araç hizmeti talep bazlı olarak verilmektedir.",
        [("haymana", ServisTipi.Ambar)]         = "Haymana'daki eşyaların depolanması ve İstanbul'a taşınma gününde teslimi için güvenli depolama sunulmaktadır.",

        // ── EVREN ──
        [("evren", ServisTipi.Kamyonet)]      = "Evren Merkez ve Boyalı mahallelerinin dar yolları için 3,5 ton kamyonetimiz standart ve tek uygun çözümdür; büyük araçlar ilçe dışında bekleme yapabilmektedir.",
        [("evren", ServisTipi.Sehirlerarasi)] = "Evren'den İstanbul'a şehirlerarası taşımada Ankara Çevre Yolu'na bağlantı için ön koordinasyon gerekmekte; sabah erken başlangıç zorunludur.",
        [("evren", ServisTipi.EvdenEve)]      = "Evren'deki evden eve taşımalar için araç erişim planlaması ve ikincil araç koordinasyonu önceden yapılmaktadır.",
        [("evren", ServisTipi.Ofis)]          = "Evren'deki küçük işletmelerin İstanbul taşımalarında ek mesafe nedeniyle sabah erken hareket planlanmaktadır.",
        [("evren", ServisTipi.Fuar)]          = "Evren'den İstanbul fuar taşımalarında güzergah ve zaman planlaması önceden titizlikle yapılmaktadır.",
        [("evren", ServisTipi.Kamyon)]        = "Evren'den İstanbul'a büyük mobilya taşıması için ikincil araç koordinasyonu ile iç transfer sonrası şehirlerarası araç devreye girmektedir.",
        [("evren", ServisTipi.Parsiyel)]      = "Evren'den İstanbul'a az eşya için parsiyel araç hizmeti talep bazlı ve koordineli olarak planlanmaktadır.",
        [("evren", ServisTipi.Ambar)]         = "Evren'deki eşyaların depolanması ve İstanbul'a koordineli teslimi için güvenli depolama hizmeti sunulmaktadır.",

        // ── KALECİK ──
        [("kalecik", ServisTipi.Kamyonet)]      = "Kalecik Merkez ve Erikli mahallelerinin vadideki dar yolları için kamyonetimiz en uygun araç seçeneğini oluşturmaktadır.",
        [("kalecik", ServisTipi.Sehirlerarasi)] = "Kalecik'ten Akyurt aksından kuzey Çevre Yolu'na ulaşan şehirlerarası araç İstanbul'a aynı gün teslimatı tamamlamaktadır.",
        [("kalecik", ServisTipi.EvdenEve)]      = "Kalecik'teki evden eve taşımalar için araç erişimi ve güzergah önceden belirlenmekte, kapıdan kapıya hizmet sunulmaktadır.",
        [("kalecik", ServisTipi.Ofis)]          = "Kalecik'teki işletmelerin İstanbul taşımalarında IT ve arşiv koruması için kurumsal standart uygulanmaktadır.",
        [("kalecik", ServisTipi.Fuar)]          = "Kalecik'ten İstanbul fuar taşımalarında güzergah ve tarih planlaması önceden yapılarak zamanında teslimat garantisi verilmektedir.",
        [("kalecik", ServisTipi.Kamyon)]        = "Kalecik'teki büyük konutlardan İstanbul'a kamyon taşıması için araç erişim planlaması ve ikincil araç koordinasyonu değerlendirilmektedir.",
        [("kalecik", ServisTipi.Parsiyel)]      = "Kalecik'ten İstanbul'a az eşya için parsiyel araç hizmeti talep bazlı olarak planlanmaktadır.",
        [("kalecik", ServisTipi.Ambar)]         = "Kalecik'teki eşyaların güvenli depolanması ve İstanbul'a zamanında teslimi için esnek tarihli hizmet sunulmaktadır.",

        // ── ŞEREFLİKOÇHİSAR ──
        [("sereflikocehisar", ServisTipi.Kamyonet)]      = "Şereflikoçhisar Merkez ve Akpınar mahallelerinden İstanbul'a kamyonet taşıması ek mesafe nedeniyle sabah 06:00–07:00 gibi erken başlatılmaktadır.",
        [("sereflikocehisar", ServisTipi.Sehirlerarasi)] = "Şereflikoçhisar'dan İstanbul'a yaklaşık 560 km şehirlerarası taşımada araç sabah erken kalkış yaparak aynı gün teslimatı tamamlamaktadır.",
        [("sereflikocehisar", ServisTipi.EvdenEve)]      = "Şereflikoçhisar'ın uzak konumu gözetilerek evden eve taşıma planlaması erken başlangıç ve aynı gün teslimat hedefiyle yapılmaktadır.",
        [("sereflikocehisar", ServisTipi.Ofis)]          = "Şereflikoçhisar'daki tuz ve tarım sektörü firmalarının İstanbul ofis taşımalarında ekipman ve arşiv için standart koruma uygulanmaktadır.",
        [("sereflikocehisar", ServisTipi.Fuar)]          = "Şereflikoçhisar'dan İstanbul fuar taşımalarında uzak mesafe nedeniyle minimum 3 gün öncesinden rezervasyon alınmaktadır.",
        [("sereflikocehisar", ServisTipi.Kamyon)]        = "Şereflikoçhisar'daki büyük konutlardan İstanbul'a kamyon taşıması ek mesafe ve erken başlangıç gerektirmektedir.",
        [("sereflikocehisar", ServisTipi.Parsiyel)]      = "Şereflikoçhisar'dan İstanbul'a parsiyel araç hizmeti uzak mesafe nedeniyle ek ücret ve ileri tarihli rezervasyonla verilmektedir.",
        [("sereflikocehisar", ServisTipi.Ambar)]         = "Şereflikoçhisar'daki eşyaların depolanması İstanbul'a taşınma tarihine kadar güvenli muhafaza için ideal çözümdür.",
    };
}
