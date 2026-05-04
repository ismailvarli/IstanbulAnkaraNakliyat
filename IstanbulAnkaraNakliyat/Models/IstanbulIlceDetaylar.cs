namespace IstanbulAnkaraNakliyat.Models;

public static class IstanbulIlceDetaylar
{
    public static string GetIlceDetay(string slug) =>
        IlceDetaylar.TryGetValue(slug, out var d) ? d : "";

    public static string GetServisDetay(string slug, ServisTipi servis) =>
        ServisDetaylar.TryGetValue((slug, servis), out var d) ? d : "";

    private static readonly Dictionary<string, string> IlceDetaylar = new()
    {
        // ── GRUP 1: Anadolu Yakası Ana İlçeler ──
        ["kadikoy"]    = "Kadıköy, Moda'nın butik sokakları, Fikirtepe'nin kentsel dönüşüm yapıları ve Bostancı'nın sahil hattıyla birbirinden farklı yapı dokularını barındıran Anadolu yakasının en merkezi ilçesidir. Fikirtepe ve Göztepe'deki yeni konut projelerinde asansör koordinasyonu standarttır; Moda ve Kalamış'taki tarihi apartmanlarda kat başına taşıma süresi önceden hesaplanmaktadır. E-5 ve D-100 bağlantısıyla TEM girişine Ümraniye aksından 15–20 dakikada ulaşılmaktadır. Sabah 07:00 öncesi başlayan yüklemeler, köprü trafiğine yakalanmadan Ankara güzergâhına rahatça girmektedir.",
        ["uskudar"]    = "Üsküdar, Çengelköy, Kandilli, Kuzguncuk ve Beylerbeyi gibi Boğaz kıyısına yerleşmiş tarihi mahallelerinde yalı ve köşk dokusunu barındıran, kendine özgü bir lojistik yapısına sahip ilçedir. Bu tarihi bölgelerde büyük kamyon erişimi dar sokaklar nedeniyle kısıtlı olduğundan 3,5 ton kamyonetimiz standart çözüm olarak kullanılmakta; gerektiğinde ikincil araç transferiyle hizmet tamamlanmaktadır. Selimiye ve Altunizade'deki modern rezidans projelerinde ise geniş bina girişleri büyük mobilyaların sorunsuz taşınmasına imkân tanımaktadır. TEM bağlantısı Kadıköy–Ümraniye aksından sağlanmakta olup sabah erken çıkış tercih edilmektedir.",
        ["umraniye"]   = "Ümraniye, TEM E-5 güzergâhına en yakın Anadolu yakası ilçelerinden biri olup şehirlerarası taşımalarda coğrafi avantaj sağlamaktadır. Armağanevler, Siteler ve İnkılap mahallelerindeki planlı konut blokları geniş bina girişleri ve modern asansörler barındırmakta; yükleme operasyonları verimli biçimde planlanabilmektedir. İlçe genelinde hız kazanan kentsel dönüşüm, eski ve yeni yapılarda farklı lojistik deneyimi gerektirmektedir. TEM girişine 5–10 dakikada ulaşılabilmesi, Ankara taşımalarında gecikme riskini minimize etmektedir.",
        ["maltepe"]    = "Maltepe, Küçükyalı'nın sahil hattından Altayçeşme'nin platolarına uzanan karma bir konut ve ticaret ilçesidir. E-5 üzerinde yer alan ilçede Ankara güzergâhına doğrudan bağlantı sağlanmaktadır; Bağlarbaşı ve Cevizli'deki yüksek katlı yapılarda asansör koordinasyonu ile yükleme süreleri optimize edilmektedir. Küçükyalı sahil kesimindeki dar ve tek yönlü sokaklar için 3,5 ton kamyonet tercih edilmekte; platform yüksekliğine göre yükleme noktası önceden belirlenmektedir. Gülensu ve Altayçeşme mahallelerinde geniş anayollar kamyon erişimine de elverişlidir.",
        ["pendik"]     = "Pendik, Kurtköy'ün büyük konut sitelerinden Yenişehir'in ticaret bölgelerine, sahil şeridinden Sabiha Gökçen Havalimanı yakınlığına kadar geniş bir yapı çeşitliliğine sahip Anadolu yakası ilçesidir. Dolayoba ve Kaynarca'daki sitelerde geniş araç erişim yolları kamyon ve büyük araçlar için uygundur; Kurtköy'ün TEM bağlantısı şehirlerarası yüklemelerde zaman avantajı sağlamaktadır. Özellikle Şeyhli ve Yenişehir'deki yeni konut projelerinde asansörlü yapı oranı yüksektir. Sabiha Gökçen yakınlığı, uçuşla gelen ekip veya ekipman koordinasyonunu da kolaylaştırmaktadır.",
        ["kartal"]     = "Kartal, Soğanlık'ın yoğun konut dokusundan Yakacık'ın daha sakin yapısına uzanan, sanayi altyapısına alışkın bir Anadolu yakası ilçesidir. E-5 ve D-100'a doğrudan cephesi bulunan ilçede büyük araç geçişleri yaygındır; sanayi bölgelerinden kaynaklanan nakliyat talebi ekibi deneyimli kılmaktadır. Karlıktepe ve Uğur Mumcu'nun bazı iç sokaklarında kamyonet kullanımı önerilmekte; ana arterlere yakın adreslerde ise kamyon erişimi sorunsuz sağlanmaktadır. TEM Kurtköy güzergâhından 15–20 dakikada Ankara yoluna girilmektedir.",
        ["atasehir"]   = "Ataşehir, İstanbul'un yükselen finans ve yaşam merkezi olup İçerenköy'ün iş kuleleri, Küçükbakkalköy'ün rezidans siteleri ve Ferhatpaşa'nın gelişen konut bölgeleriyle yüksek değerli taşımaları sıklıkla barındırmaktadır. Modern yapı stoğunun egemen olduğu ilçede asansörlü binalarda yükleme operasyonları verimli planlanabilmekte; geniş bina girişleri büyük mobilyaların hasarsız taşınmasına imkân tanımaktadır. Kurumsal iş merkezi yoğunluğu nedeniyle hafta sonu ve gece ofis taşımaları ilçede sıkça tercih edilmektedir. E-5 ve TEM'e Ümraniye üzerinden erişim, Ataşehir'den Ankara güzergâhını kısaltmaktadır.",
        ["beykoz"]     = "Beykoz, Çubuklu ve Paşabahçe'nin Boğaz kıyı mahalleleri ile Riva ve Polonezköy'ün kırsal kesimlerinden oluşan, dar ve kıvrımlı yollara sahip doğal bir İstanbul ilçesidir. Büyük kamyon erişimi bazı köy ve çıkmaz sokaklarda kısıtlı olduğundan 3,5 ton kamyonet standart araç olarak kullanılmakta; gerektiğinde ikincil taşıma ile kombine çözüm üretilmektedir. İlçe merkezinden TEM'e Ümraniye ve Çekmeköy aksından ulaşılmaktadır; sabah erken çıkış Boğaz güzergâhındaki trafik sıkışıklığını aşmayı sağlamaktadır. Riva ve Polonezköy gibi uzak noktalarda adres bazlı güzergâh değerlendirmesi yapılmaktadır.",
        ["cekmekoy"]   = "Çekmeköy, Nişantepe, Taşdelen ve Hamidiye gibi yeşil ve sakin mahallelerinde müstakil ev, köşk ve küçük site taşımalarına sıkça ev sahipliği yapmaktadır. İlçedeki bazı villa ve müstakil konut bölgelerinde yol genişliği büyük araç erişimini güçleştirebileceğinden adres bazlı değerlendirme yapılmaktadır. Mehmet Akif ve Çekmeköy Merkez'deki apartman bloklarında asansör koordinasyonu standarttır. TEM'e Ümraniye–Çekmeköy güzergâhından ulaşılmakta olup sabah çıkışında yoğunluk kavşak geçildikten sonra hızla azalmaktadır.",

        // ── GRUP 2: Anadolu Yakası Doğu + Avrupa Yakası Prestijli ──
        ["sancaktepe"]  = "Sancaktepe, Veysel Karani ve Fatih mahallelerindeki toplu konut projeleriyle hızla gelişen, Anadolu yakasının yeni cazibe merkezi konumundaki ilçedir. Sancaktepe Merkez'deki planlı yapı stoku asansörlü binaları ağırlıklı olarak barındırmakta; yükleme operasyonları verimli biçimde planlanabilmektedir. Ümraniye ve Kartal güzergâhlarından TEM'e bağlantı sağlanmakta olup sabah trafiği sakinleştiğinde çıkış tercih edilmektedir. Kaynarca ve Eyüp Sultan mahallelerindeki sitelerde geniş araç erişim yolları büyük araçlar için de uygundur.",
        ["sultanbeyli"] = "Sultanbeyli, İstanbul Anadolu yakasının en yoğun konut nüfusuna sahip ilçelerinden biri olup Mehmet Akif, Battalpasa ve Hasanpaşa mahallelerinde binlerce konut bloğu bulunmaktadır. İlçe genelinde sokak dokusu yoğun ve zaman zaman dar olduğundan 3,5 ton kamyonet ağırlıklı olarak tercih edilmekte; büyük daireler için ise asansör planlamasıyla kamyon erişimi sağlanmaktadır. E-5 ve D-100'a Kartal aksından ulaşılmakta; TEM Kurtköy bağlantısı ile Ankara yoluna giriş yapılmaktadır. Sabah trafiğine yakalanmamak için yüklemenin 07:00'den önce tamamlanması önerilmektedir.",
        ["tuzla"]       = "Tuzla, İçmeler sahil şeridinden Mimar Sinan'ın organize sanayi bölgelerine uzanan, sanayi ve konutun iç içe geçtiği İstanbul'un güneydoğu ilçesidir. OSB'ye alışkın lojistik altyapı büyük tonajlı araçların hareketini kolaylaştırmakta; Aydınlı ve Postane mahallelerindeki konut bölgelerine ise 3,5 ton kamyonetle erişilmektedir. D-100 ve E-5'e doğrudan bağlantısı bulunan ilçede TEM girişine Kurtköy üzerinden 20 dakikada ulaşılmaktadır. Özellikle kurumsal ofis ve sanayi tesis taşımalarında ilçenin büyük araç deneyimi belirleyici avantaj sağlamaktadır.",
        ["sile"]        = "Şile, Karadeniz kıyısında doğal güzellikleri ve yazlık konutlarıyla tanınan, İstanbul'un en uzak ilçelerinden biridir. İlçe merkezine ulaşım için E-80'den Kurtköy–Şile yolu kullanılmakta; bu güzergâh hem kalıcı konut hem de yaz döneminde yoğunlaşan yazlık taşımalarına hizmet etmektedir. Büyük araç erişimi ilçe merkezi ve ana sokaklar için uygundur; köy bölgelerinde ve bazı kıyı mahallelerinde kamyonet tercih edilmektedir. Ankara güzergâhı için Ümraniye aksından TEM'e ulaşılmakta olup uzun güzergâh nedeniyle sabah erken çıkış zorunludur.",
        ["adalar"]      = "Adalar, motorlu taşıtların yasak olduğu Büyükada, Heybeliada, Burgazada ve Kınalıada'dan oluşan İstanbul'un özgün ilçesidir. Taşımacılık araçların adaya girişinin yasak olması nedeniyle özel koordinasyon gerekmektedir: eşyalar karşı yakada kıyıya bırakılmakta, adanın içinde fayton veya belediye aracıyla son noktaya ulaştırılmaktadır. Ankara nakliyatları için eşyalar Kadıköy veya Pendik iskelesi üzerinden kara bağlantısına alınmakta; bu transfer süreci rezervasyon aşamasında planlı biçimde yönetilmektedir. Taşıma süresi ve maliyeti adadan kıta bağlantısına olan mesafeye göre değişmektedir.",
        ["sisli"]       = "Şişli, Nişantaşı'nın lüks konut dokusu, Mecidiyeköy'ün iş kuleleri ve Bomonti'nin dönüşen sanayi alanlarıyla İstanbul'un prestijli Avrupa yakası ilçelerinden biridir. Mecidiyeköy ve Levent aksında yoğun araç trafiği nedeniyle büyük kamyonlar için gece veya sabah erken yükleme saati tercih edilmektedir. TEM ve E-5'e Zincirlikuyu–TEM bağlantısından ya da Maslak aksından ulaşılmaktadır. Nişantaşı'nın tarihi apartmanlarında asansör kapasitesi sınırlı olabilmekte; kat başına taşıma süresi ve ekip sayısı önceden planlanmaktadır.",
        ["besiktas"]    = "Beşiktaş, Boğaz kıyısındaki Ortaköy ve Bebek'in köklü mahalle dokusu ile Levent ve Etiler'in modern rezidans ve iş merkezlerini bir arada barındıran İstanbul'un en prestijli ilçesidir. Bebek, Arnavutköy ve Ortaköy'ün Boğaz yalı sokakları büyük araç erişimi için dar olabilmektedir; bu bölgelerde 3,5 ton kamyonet veya kombinasyon taşıma uygulanmaktadır. Levent ve Balmumcu'daki modern yapılarda geniş bina girişleri büyük mobilyaların hasarsız taşınmasına imkân tanımaktadır. TEM'e Maslak aksından ulaşılmakta olup sabah mesai öncesi çıkış Boğaz trafiğini aşmayı sağlamaktadır.",
        ["bakirkoy"]    = "Bakırköy, Ataköy'ün prestijli sahil sitelerinden Florya'nın köklü konut dokusuna uzanan, gelişmiş altyapısıyla Avrupa yakasının merkezi ilçesidir. Ataköy ve Florya'daki büyük sitelerde geniş araç erişim yolları ve asansörlü yapılar yükleme operasyonlarını kolaylaştırmaktadır. E-5 üzerinde konumlanan ilçe, Ankara güzergâhına D-100 ve TEM bağlantısından hızla erişim sağlamaktadır. Zuhuratbaba ve Cevizlik mahallelerindeki daha eski apartman yapılarında merdiven taşıması için ek süre hesaba katılmaktadır.",
        ["beylikduzu"]  = "Beylikdüzü, Büyükşehir ve Adnan Kahveci mahallelerindeki büyük konut siteleri ile alışveriş merkezi yoğunluğuyla İstanbul'un batısındaki modern ilçesidir. Geniş anayollar ve planlı kentsel yapı, hem kamyonet hem kamyon operasyonları için ideal çalışma ortamı sunmaktadır. TEM'e Esenyurt aksından yaklaşık 15 dakikada ulaşılmakta; sabah trafiği Metrobüs güzergâhının ilçeyi kesen aksında yoğunlaşmaktadır. Özellikle büyük sitelerdeki 2+1 ve 3+1 dairelerde yükleme asansörü koordinasyonuyla verimli taşıma süresi sağlanmaktadır.",

        // ── GRUP 3: Batı / Kuzey İstanbul ──
        ["esenyurt"]       = "Esenyurt, İstanbul'un en hızlı büyüyen ve en kalabalık ilçelerinden biri olup Talatpaşa, Saadetdere ve Pınar mahallelerindeki yoğun konut yapısıyla öne çıkmaktadır. Sabah ve akşam saatlerinde araç trafiği yoğunlaşmakta; taşıma operasyonları için 07:00 öncesi yükleme başlatılması önerilmektedir. TEM'e Avcılar veya Başakşehir aksından ulaşılmaktadır. Yeni konut bloklarının çoğunda asansörlü yapı standardı bulunmakta; eski stokta ise kat başına taşıma süresi önceden hesaplanmaktadır.",
        ["basaksehir"]     = "Başakşehir, Bahçeşehir, Kayaşehir ve Altınşehir'deki planlı yapısıyla İstanbul'un modern ve düzenli Avrupa yakası ilçelerinden biridir. Geniş bina girişleri, asansörlü yapılar ve araç erişimine uygun yollar yükleme operasyonlarını kolaylaştırmaktadır. TEM'e doğrudan bağlantısı bulunan ilçe, İstanbul'dan Ankara güzergâhına en kısa çıkışlardan birini sunmaktadır. Büyük kamyon ve şehirlerarası araçlar için ideal güzergâh konumundadır; sabah yüklemesiyle öğleden önce TEM'e girilmektedir.",
        ["arnavutkoy"]     = "Arnavutköy, İstanbul Havalimanı'na sıfır mesafedeki konumuyla ulaşım açısından stratejik bir ilçedir. Bolluca ve Haraçcı mahallelerindeki yeni konut projelerinde asansörlü yapılar yaygındır. TEM'e Arnavutköy çevreyolu üzerinden yaklaşık 15–20 dakikada ulaşılmaktadır. Özellikle İstanbul Havalimanı personeli ve yakın çevresindeki konut taşımalarında yoğun talep yaşanmaktadır.",
        ["hadimkoy"]       = "Hadımköy, TEM otoyoluna ve İstanbul Havalimanı'na fiilen en yakın sanayi ve lojistik merkezidir. OSB'nin büyük araç altyapısına alışkın ortamı, hem ticari hem konut taşımacılığını kolaylaştırmaktadır. TEM girişine 5 dakikadan kısa sürede ulaşılabilmesi, Ankara taşımalarında trafik riskini sıfıra indirmektedir. Hadımköy Merkez mahallelerindeki konut bölgelerine kamyonet erişimi sorunsuz sağlanmakta; yeni sitelerde ise geniş araç yolları kamyon operasyonlarına elverişlidir.",
        ["ikitelli"]       = "İkitelli, İstanbul'un en büyük organize sanayi bölgelerinden birini barındıran ve çevresinde hızla konutlaşan batı ilçesidir. OSB'nin büyük araç altyapısı kurumsal taşımacılık için ideal ortam sunmakta; Kazım Karabekir ve Ziya Gökalp mahallelerindeki konut bölgelerine ise kamyonet erişimi sorunsuz sağlanmaktadır. TEM'e Başakşehir ve Küçükçekmece aksından bağlantı kurulmakta; sabah saatlerinde OSB giriş çıkışı yoğun olduğundan yükleme saatinin buna göre planlanması önerilmektedir. Kanarya ve Mehmet Akif mahallelerindeki yeni yapılarda asansörlü bina oranı artmaktadır.",
        ["avcilar"]        = "Avcılar, Ambarlı'nın limanı ve sanayi bölgesiyle birlikte Marmara kıyısındaki üniversite kampüsü çevresinde gelişen, karma yapılı bir Avrupa yakası ilçesidir. Ambarlı ve Firuzköy'deki sanayi bölgelerinde büyük araç trafiğine alışkın altyapı bulunmakta; konut mahallelerinde ise 3,5 ton kamyonet ağırlıklı olarak kullanılmaktadır. E-5'e hızla ulaşılabilmekte, TEM bağlantısı Küçükçekmece veya Esenyurt aksından sağlanmaktadır. Üniversite kampüsü nedeniyle öğrenci taşımalarında parsiyel araç talebi yoğundur.",
        ["buyukcekemece"]  = "Büyükçekmece, Mimarsinan ve Kumburgaz'ın yazlık sahil siteleriyle Pınarca ve Güzelce'nin kalıcı konut alanlarını barındıran İstanbul'un batısındaki sakin ilçesidir. Sahil kesimindeki sitelerde geniş araç yolları ve planlı parsel yapısı büyük taşıma araçlarının hareketini kolaylaştırmaktadır. E-5 ve TEM'e Avcılar veya Esenyurt aksından bağlanılmakta; Ankara güzergâhına sakin sabah saatlerinde çıkış önerilmektedir. Yaz sezonunda yazlık konut taşımalarında talep artmakta; erken rezervasyon önerilmektedir.",
        ["silivri"]        = "Silivri, Marmara kıyısındaki geniş yazlık konut siteleri ve bağ evi bölgeleriyle İstanbul'un en batı ilçesi konumundadır. Selimpaşa ve Gümüşyaka'daki siteler büyük araç erişimine uygun geniş yollara sahipken bağ bölgelerinde kamyonet tercih edilmektedir. E-5 ve TEM'e Büyükçekmece güzergâhından ulaşılmakta; Ankara mesafesi İstanbul merkezine kıyasla benzer düzeyde kalmaktadır. Özellikle kış–yaz arası geçiş dönemlerinde yazlık–şehir taşıma talebi yoğunlaşmaktadır.",
        ["catalca"]        = "Çatalca, İstanbul'un yüzölçümü en büyük ilçesi olup orman alanları, kırsal köyler ve küçük yerleşim merkezlerinden oluşmaktadır. İlçe merkezine ve büyük mahallelere ana karayolu üzerinden kamyon erişimi mümkün olsa da köy yollarında kamyonet ile hizmet verilmektedir. E-5 ve TEM'e Silivri veya Büyükçekmece üzerinden bağlanılmakta; Ankara güzergâhına girerken bu şeritler kullanılmaktadır. Taşımadan önce adres bazlı araç erişim değerlendirmesi yapılması önerilmektedir.",

        // ── GRUP 4: Avrupa Yakası Orta ──
        ["kucukcekemece"] = "Küçükçekmece, Atakent ve Halkalı'nın modern konut siteleri ile İnönü ve Cennet mahallelerinin köklü yapı stoğuyla Avrupa yakasının göl kıyısındaki dinamik ilçesidir. Halkalı'nın tren bağlantısı ve E-5 üzerindeki konumu, nakliyat araçlarının ilçeyi hızla terk etmesine imkân tanımaktadır. TEM'e Esenyurt veya Bakırköy aksından ulaşılmaktadır; sabah yüklemesiyle Ankara güzergâhına sorunsuz girilmektedir. Atakent'teki büyük sitelerde geniş bina girişleri kamyon erişimine elverişliyken eski yapılarda kamyonet ile hizmet verilmektedir.",
        ["gungoren"]      = "Güngören, Güngören Merkez, Tozkoparan ve Merter mahallelerinde tekstil atölyeleri, ticarethaneler ve yoğun konut dokusunu bir arada barındıran İstanbul'un kalabalık ilçelerinden biridir. İlçe genelinde dar iç sokaklar yaygın olduğundan 3,5 ton kamyonet büyük dairelerde bile tercih sebebi olmaktadır; geniş mobil ekip koordinasyonu ile yükleme hızlandırılmaktadır. E-5 ve TEM bağlantısı Bakırköy veya Bağcılar aksından sağlanmaktadır. Sabah yükleme trafikten önce tamamlandığında Ankara güzergâhına saat 09:00'da girilmektedir.",
        ["bahcelievler"]  = "Bahçelievler, Kocasinan, Şirinevler ve Zafer mahallelerindeki yoğun konut bloklarıyla Avrupa yakasının merkezi ilçelerinden biridir. E-5 üzerindeki konumu Ankara güzergâhına doğrudan bağlantı sağlamakta; Şirinevler bağlantısıyla TEM'e de hızla ulaşılmaktadır. Yüksek yapı yoğunluğu nedeniyle sabah 07:00 öncesi yükleme başlatılması araç çıkışını kolaylaştırmaktadır. İlçedeki çok katlı konut yapılarının büyük bölümünde asansörlü bina standardı bulunmaktadır.",
        ["bagcilar"]      = "Bağcılar, İstanbul'un en kalabalık ilçelerinden biri olup Bağcılar Merkez, Göztepe ve Kirazlı mahallelerinde binlerce konut bloğu bulunmaktadır. İlçe genelinde trafik sabah ve akşam saatlerinde çok yoğunlaşmakta; taşıma araçları için 07:00 öncesi yükleme önerilmektedir. TEM'e Esenyurt veya Bağcılar çevreyolundan bağlanılmaktadır. Yeni yapılarda asansörlü bina standardı yaygınlaşmış olsa da eski stoktaki kat taşımalarında ek süre ve ekip planlanmaktadır.",
        ["esenler"]       = "Esenler, İstanbul Büyük Otogar'ına sıfır mesafesiyle şehirlerarası ulaşımın merkezi konumunda bir ilçedir. Otogara alışkın büyük araç trafiği, nakliyat araçlarının ilçede rahatça hareket etmesini sağlamaktadır. TEM'e Bağcılar veya Bayrampaşa aksından bağlanılmakta olup sabah saatlerinde erken çıkış önerilmektedir. Kemer ve Çiftlik mahallelerindeki yeni yapılarda asansörlü bina standardı artmaktadır.",
        ["bayrampasa"]    = "Bayrampaşa, E-5 ve TEM akslarına yakın konumuyla nakliyat araçlarının Ankara güzergâhına hızla ulaşabildiği bir Avrupa yakası ilçesidir. Bayrampaşa Merkez ve Kocatepe mahallelerindeki yüksek katlı konutlarda asansör koordinasyonu standarttır. İlçe içi bazı dar sokaklarda büyük kamyon erişimi kısıtlı olabildiğinden adres bazlı araç seçimi yapılmaktadır. TEM'e Zeytinburnu veya Esenler güzergâhından kısa sürede ulaşılmaktadır.",
        ["gaziosmanpasa"] = "Gaziosmanpaşa, Barbaros, Karadeniz ve Yenidoğan mahallelerindeki köklü yerleşim dokusunu barındıran kuzey Avrupa yakası ilçesidir. İlçe içi sokak dokusu yoğun olduğundan 3,5 ton kamyonet çoğu mahallede standart çözüm olmaktadır; geniş arterlere yakın adreslerde kamyon erişimi de mümkündür. TEM'e Sultangazi veya Eyüpsultan güzergâhından ulaşılmaktadır. Özellikle Yenidoğan'daki kentsel dönüşüm projeleriyle birlikte asansörlü yeni yapılarda taşıma talebi artmaktadır.",

        // ── GRUP 5: Tarihi / Kuzey Avrupa Yakası ──
        ["sultangazi"]    = "Sultangazi, Cebeci, Uğur Mumcu ve Sultançiftliği mahallelerindeki planlı konut yapısıyla kuzey İstanbul'un hızla gelişen ilçesidir. Yeni konut projelerinde asansörlü yapı standardı yaygındır; eski stokta kat başına taşıma süresi önceden hesaplanmaktadır. TEM'e Arnavutköy veya Eyüpsultan üzerinden ulaşılmakta; sabah yüklemesinde Ankara güzergâhına sorunsuz çıkılmaktadır. Habibler ve Malkoçoğlu mahallelerindeki bazı dar sokaklarda kamyonet tercih edilmekte, geniş arterlere yakın adreslerde ise kamyon erişimi sağlanmaktadır.",
        ["kagithane"]     = "Kağıthane, Çağlayan, Gültepe ve Seyrantepe mahallelerindeki kentsel dönüşüm projeleriyle son yıllarda yenilenen ve değer kazanan merkezi bir İstanbul ilçesidir. İlçe içinde bazı dar ve eğimli sokaklar bulunmakla birlikte ana arterler ve Seyrantepe aksı büyük araç erişimine elverişlidir. TEM'e Maslak aksından ya da Gaziosmanpaşa üzerinden ulaşılmaktadır. Yeni yapılarda asansörlü bina standardı yaygınlaşmış olup eski stoktaki kat taşımalarında ek süre hesaba katılmaktadır.",
        ["beyoglu"]       = "Beyoğlu, Taksim, Cihangir, Galata ve Karaköy gibi İstanbul'un en tarihi ve kültürel mahallelerini barındıran, eğimli arazisiyle kendine özgü bir lojistik yapısına sahip ilçedir. Dar ve eğimli sokaklar, kaldırım taşlı yollar ve bazı bölgelerdeki araç kısıtlamaları nedeniyle büyük kamyon erişimi sınırlıdır; 3,5 ton kamyonet standart çözüm olmaktadır. Nişantaşı ve Harbiye aksındaki geniş caddelerde daha büyük araç geçişi mümkündür. TEM'e Maslak veya Şişli aksından ulaşılmakta; sabah erken çıkış turist trafiğini atlatmayı sağlamaktadır.",
        ["fatih"]         = "Fatih, Aksaray, Samatya, Yedikule ve Balat gibi tarihi yarımadanın en yoğun ve köklü mahallelerini barındıran İstanbul'un en eski ilçesidir. Tarihi yarımadadaki dar sokak dokusu ve trafik düzenlemeleri nedeniyle büyük araç geçişleri belirli gün ve saatlere tabidir; 3,5 ton kamyonet büyük çoğunlukta standart çözümdür. Kocamustafapaşa ve Yenibosna akslarına yakın adreslerde ise uygun saatlerle kamyon erişimi sağlanabilmektedir. TEM bağlantısı Zeytinburnu veya Bayrampaşa güzergâhından kurulmaktadır.",
        ["eyupsultan"]    = "Eyüpsultan, Alibeyköy'ün kalabalık konut bölgeleri ile Göktürk'ün lüks müstakil villa alanlarını aynı anda barındıran tarihi bir İstanbul ilçesidir. Alibeyköy ve Nişanca mahallelerinde yoğun konut dokusu nedeniyle dar sokaklarda kamyonet ağırlıklı hizmet verilmekte; Göktürk'te ise geniş parsel ve yollar büyük araç erişimine elverişlidir. TEM'e Arnavutköy veya Sultangazi aksından ulaşılmaktadır. Özellikle Göktürk villa bölgesinden değerli ve büyük mobilya taşımalarında özel ambalaj uygulanmaktadır.",
        ["sariyer"]       = "Sarıyer, Yeniköy, Tarabya, Büyükdere ve Zekeriyaköy gibi Boğaz kıyısı ve kuzey İstanbul ormanlarına dayanan huzurlu mahallelerini barındıran ilçedir. Boğaz kıyısındaki yalı ve yüksek değerli konutlarda dar ve köklü sokak dokusu büyük araç erişimini güçleştirmektedir; 3,5 ton kamyonet standart araç olmaktadır. İstinye ve Büyükdere caddesindeki modern yapılarda geniş bina girişleri daha büyük araçlara imkân tanımaktadır. TEM'e Maslak aksından ulaşılmakta; sabah erken çıkış Boğaz güzergâhındaki yoğunluğu atlatmayı sağlamaktadır.",
        ["zeytinburnu"]   = "Zeytinburnu, Kazlıçeşme'nin deri ve tekstil sanayi geçmişinden Merkezefendi'nin modern konut projelerine uzanan köklü bir sanayi ve konut ilçesidir. E-5 üzerinde konumlanan ilçede Ankara güzergâhına doğrudan erişim sağlanmakta; geniş sanayi arterleri büyük araç geçişine elverişlidir. Seyitnizam ve Veliefendi mahallelerindeki konut bloklarında asansör koordinasyonu standarttır. Nuripaşa ve Kazlıçeşme'nin kısmen dar sanayi sokaklarında ise kamyonet tercih edilmektedir.",
    };

    private static readonly Dictionary<(string Ilce, ServisTipi Servis), string> ServisDetaylar = new()
    {
        // ── KADIKOY ──
        [("kadikoy", ServisTipi.Kamyonet)]      = "Moda ve Kalamış'ın dar sokaklarında 3,5 ton kamyonetimiz sorunsuz çalışır; Fikirtepe'deki yeni yapılarda asansör koordinasyonuyla hızlı yükleme tamamlanarak Ankara yoluna çıkılmaktadır.",
        [("kadikoy", ServisTipi.Sehirlerarasi)] = "Kadıköy'den sabah 07:00'de başlayan yüklemeyle Ümraniye aksından TEM'e çıkan araç, Ankara'ya aynı gün teslimatı tamamlamaktadır.",
        [("kadikoy", ServisTipi.EvdenEve)]      = "Caferağa ve Fenerbahçe'deki eski apartmanlarda asansör ve merdiven taşıması kombine edilerek büyük mobilyalar hasarsız indirilmekte, aynı gün Ankara adresine teslim edilmektedir.",
        [("kadikoy", ServisTipi.Ofis)]          = "Kadıköy'deki finans, hukuk ve kreatif ofislerin Ankara'ya kurumsal taşımalarında IT ekipmanı etiketi ve gizlilik anlaşması standart olarak sunulmaktadır.",
        [("kadikoy", ServisTipi.Fuar)]          = "Kadıköy'deki tasarım ve reklam ajanslarının stand ve display sistemleri özel ambalajla Ankara fuar alanına taşınmakta; fuar açılışından 2 gün önce teslim edilmektedir.",
        [("kadikoy", ServisTipi.Kamyon)]        = "Bostancı ve Erenköy'deki büyük 3+1–4+1 dairelerden Ankara'ya 12 ton kapalı kasalı kamyon ile tek seferlik sigortalı taşıma yapılmaktadır.",
        [("kadikoy", ServisTipi.Parsiyel)]      = "Kadıköy'den Ankara'ya yalnızca birkaç parça mobilya veya kargo kutusu göndermek için paylaşımlı parsiyel araç ekonomik ve zamanında teslimat imkânı sunmaktadır.",
        [("kadikoy", ServisTipi.Ambar)]         = "Kadıköy'deki evi boşaltırken Ankara'daki yeni konuta taşınma tarihi netleşmemiş müşteriler eşyalarını güvenli depomuzda belirli süre tutabilmektedir.",

        // ── ÜSKÜDAR ──
        [("uskudar", ServisTipi.Kamyonet)]      = "Çengelköy ve Kandilli'nin yalı mahallelerindeki dar sokaklarda büyük kamyon erişimi kısıtlı olduğundan 3,5 ton kamyonetimiz standart çözüm olarak kullanılmaktadır.",
        [("uskudar", ServisTipi.Sehirlerarasi)] = "Üsküdar'dan Selimiye aksıyla Ümraniye üzerinden TEM'e bağlanan araç, sabah yüklemesiyle Ankara'ya aynı günde teslimatı tamamlamaktadır.",
        [("uskudar", ServisTipi.EvdenEve)]      = "Altunizade ve Acıbadem'deki modern yapılarda asansör koordinasyonu, Kuzguncuk gibi tarihi semtlerde ise kat kat taşıma ile kapsamlı ev nakliyesi tamamlanmaktadır.",
        [("uskudar", ServisTipi.Ofis)]          = "Altunizade iş merkezlerinden Ankara'ya kurumsal ofis taşımalarında IT ekipmanı paketleme ve gece çalışma seçeneği standart olarak sunulmaktadır.",
        [("uskudar", ServisTipi.Fuar)]          = "Üsküdar'daki firma veya ajansların Ankara fuar alanlarına taşınan stand ve promosyon materyalleri özel koruyucu ambalajla hazırlanmaktadır.",
        [("uskudar", ServisTipi.Kamyon)]        = "Beylerbeyi ve Çengelköy'deki yalı ve büyük konutlardan Ankara'ya değerli mobilya taşımalarında kapalı kasalı kamyon ile tam koruma sağlanmaktadır.",
        [("uskudar", ServisTipi.Parsiyel)]      = "Üsküdar'dan Ankara'ya birkaç parça eşya veya kargo göndermek için parsiyel araç hizmetimiz uygun fiyatlı ve zamanında teslimat sunmaktadır.",
        [("uskudar", ServisTipi.Ambar)]         = "Üsküdar'daki evi boşaltıp Ankara'ya taşınma tarihini bekleyen müşteriler eşyalarını esnek süreli depomuzda güvenle saklayabilmektedir.",

        // ── ÜMRANİYE ──
        [("umraniye", ServisTipi.Kamyonet)]      = "Armağanevler ve Yunus Emre mahallelerindeki konut bloklarında 3,5 ton kamyonetimiz asansör koordinasyonuyla hızlı yükleme tamamlar; TEM girişine 10 dakikada ulaşılmaktadır.",
        [("umraniye", ServisTipi.Sehirlerarasi)] = "Ümraniye'nin TEM girişine yakınlığı, şehirlerarası araçların İstanbul trafiğine girmeden Ankara yoluna çıkmasını ve teslimat süresini kısaltmaktadır.",
        [("umraniye", ServisTipi.EvdenEve)]      = "İnkılap ve Siteler mahallelerindeki geniş girişli yeni yapılarda ekibimiz asansör planlaması ve komşu koordinasyonuyla akıcı ev taşıması gerçekleştirmektedir.",
        [("umraniye", ServisTipi.Ofis)]          = "Ümraniye'deki teknoloji ve finans firmalarının Ankara'ya kurumsal taşımalarında sunucu, ağ cihazı ve arşiv etiketi standart kurumsal protokolle yönetilmektedir.",
        [("umraniye", ServisTipi.Fuar)]          = "Ümraniye'deki teknik ve elektronik firmalarının Ankara fuar alanlarına taşınan ekipmanları vibrasyon emici ambalajla korunmaktadır.",
        [("umraniye", ServisTipi.Kamyon)]        = "Ümraniye'deki 3+1 ve üzeri dairelerden Ankara'ya 12–18 ton kamyon ile tek seferlik büyük ev taşıması TEM güzergâhını etkin biçimde kullanmaktadır.",
        [("umraniye", ServisTipi.Parsiyel)]      = "Ümraniye'den Ankara'ya az eşya için paylaşımlı araç hizmetimiz haftanın belirli günleri düzenli sefer yapmaktadır.",
        [("umraniye", ServisTipi.Ambar)]         = "Ümraniye'deki konut veya ofisin boşaltılmasından sonra Ankara'daki yeni adrese geçiş tarihine kadar eşyalar güvenli depomuzda muhafaza edilmektedir.",

        // ── MALTEPE ──
        [("maltepe", ServisTipi.Kamyonet)]      = "Küçükyalı ve Cevizli'nin dar sahil sokaklarında 3,5 ton kamyonetimiz büyük araçların giremeyeceği bölgelere erişerek hızlı yükleme tamamlamaktadır.",
        [("maltepe", ServisTipi.Sehirlerarasi)] = "Maltepe'den E-5 aksıyla Ankara güzergâhına çıkan araç, sabah yüklemesiyle aynı gün Ankara adresine teslimat sağlamaktadır.",
        [("maltepe", ServisTipi.EvdenEve)]      = "Bağlarbaşı ve Altayçeşme mahallelerindeki çok katlı yapılarda asansör koordinasyonu ve büyük mobilya söküm-montajı dahil kapsamlı ev taşıması yapılmaktadır.",
        [("maltepe", ServisTipi.Ofis)]          = "Maltepe'deki iş yeri ve küçük ölçekli ofislerin Ankara'ya taşımalarında IT paketleme ve gece çalışma seçeneği sunulmaktadır.",
        [("maltepe", ServisTipi.Fuar)]          = "Maltepe'deki işletmelerin Ankara fuar ve sergi etkinliklerine taşınan ürün ve stand materyalleri zamanında teslim için planlanmaktadır.",
        [("maltepe", ServisTipi.Kamyon)]        = "Gülensu ve Altayçeşme'deki büyük dairelerden Ankara'ya 12 ton kamyon ile tek seferlik taşıma yapılmaktadır; geniş anayollar kamyon erişimine elvermektedir.",
        [("maltepe", ServisTipi.Parsiyel)]      = "Maltepe'den Ankara'ya birkaç parça mobilya veya kargo kutusu göndermek için parsiyel araç hizmeti ekonomik ve zamanında teslimat sunar.",
        [("maltepe", ServisTipi.Ambar)]         = "Maltepe'deki evi boşaltıp Ankara'daki yeni konuta geçiş tarihini bekleyen müşteriler eşyalarını kısa veya uzun süreli depomuzda güvenle tutabilmektedir.",

        // ── PENDİK ──
        [("pendik", ServisTipi.Kamyonet)]      = "Dolayoba ve Kaynarca'nın siteleri ile Yenişehir mahallelerinde 3,5 ton kamyonetimiz dar sokak ve site girişlerine sorunsuz erişmektedir.",
        [("pendik", ServisTipi.Sehirlerarasi)] = "Pendik'ten Kurtköy üzerinden TEM'e çıkan araç sabah yüklemesiyle Ankara'ya aynı gün teslimat tamamlar; Sabiha Gökçen yakınlığı ekstra lojistik esneklik sağlar.",
        [("pendik", ServisTipi.EvdenEve)]      = "Şeyhli ve Yenişehir'deki yeni asansörlü binalarda ekibimiz hızlı yükleme gerçekleştirmekte; kapıdan kapıya ambalaj ve montaj dahil ev taşıması yapılmaktadır.",
        [("pendik", ServisTipi.Ofis)]          = "Pendik'teki teknoloji ve lojistik firmalarının Ankara'ya kurumsal taşımalarında IT ekipmanı güvenli paketleme ve etiketiyle nakliyesi yapılmaktadır.",
        [("pendik", ServisTipi.Fuar)]          = "Pendik'teki firmalar için Ankara fuar alanlarına stand ve ekipman taşımalarında fuar tarihi bazlı rezervasyon ile zamanında teslimat garanti edilmektedir.",
        [("pendik", ServisTipi.Kamyon)]        = "Kurtköy siteleri ve Kaynarca'daki büyük dairelerden Ankara'ya 12–18 ton kamyon ile tek seferlik büyük ev taşıması verimli yürütülmektedir.",
        [("pendik", ServisTipi.Parsiyel)]      = "Pendik'ten Ankara'ya az eşya veya tekli parça göndermek için paylaşımlı parsiyel araç hizmetimiz uygun fiyatlı seçenek sunmaktadır.",
        [("pendik", ServisTipi.Ambar)]         = "Pendik'teki evi boşaltıp Ankara'daki yeni konuta geçiş tarihi netleşmemiş müşteriler için esnek süreli depolama hizmeti mevcuttur.",

        // ── KARTAL ──
        [("kartal", ServisTipi.Kamyonet)]      = "Karlıktepe ve Uğur Mumcu'nun dar iç sokaklarında 3,5 ton kamyonetimiz kolayca hareket eder; E-5 üzerindeki yükleme noktalarında büyük araç sorunsuz çalışmaktadır.",
        [("kartal", ServisTipi.Sehirlerarasi)] = "Kartal'dan E-5 ve TEM Kurtköy güzergâhından 15–20 dakikada Ankara yoluna çıkan araç, sabah yüklemesiyle aynı gün teslimatı tamamlamaktadır.",
        [("kartal", ServisTipi.EvdenEve)]      = "Soğanlık ve Yakacık'taki çok katlı konutlarda asansör koordinasyonu ile ekibimiz büyük mobilyaları söküp Ankara'daki yeni adrese monte etmektedir.",
        [("kartal", ServisTipi.Ofis)]          = "Kartal'daki sanayi işletmeleri ve ticari ofislerin Ankara'ya taşımalarında kurumsal fatura ve hafta sonu çalışma seçeneği sunulmaktadır.",
        [("kartal", ServisTipi.Fuar)]          = "Kartal sanayi bölgesindeki firmalar için Ankara fuarlarına taşınan ürün ve ekipmanlar özel ambalajla zamanında teslim edilmektedir.",
        [("kartal", ServisTipi.Kamyon)]        = "Soğanlık ve Esentepe'deki büyük 3+1 ve 4+1 dairelerden Ankara'ya 12 ton kamyon ile tek seferlik sigortalı taşıma yapılmaktadır.",
        [("kartal", ServisTipi.Parsiyel)]      = "Kartal'dan Ankara'ya kargo kutusu veya birkaç parça mobilya için parsiyel araç hizmetimiz ekonomik ve zamanında teslimat sunar.",
        [("kartal", ServisTipi.Ambar)]         = "Kartal'daki evi veya iş yerini boşaltıp Ankara'ya geçiş tarihini bekleyen müşteriler için güvenli esnek süreli depolama mevcuttur.",

        // ── ATAŞEHİR ──
        [("atasehir", ServisTipi.Kamyonet)]      = "İçerenköy ve Küçükbakkalköy'deki rezidans site girişlerinde 3,5 ton kamyonetimiz dar manevra alanlarına rahatlıkla uyum sağlamaktadır.",
        [("atasehir", ServisTipi.Sehirlerarasi)] = "Ataşehir'den E-5 ve TEM'e Ümraniye aksından çok kısa sürede çıkılarak, sabah yüklemesiyle Ankara'ya aynı gün teslimat sağlanmaktadır.",
        [("atasehir", ServisTipi.EvdenEve)]      = "Ferhatpaşa ve Yenisahra'daki modern konutlarda asansör koordinasyonu ile kapsamlı ev taşıması yapılmakta; büyük mobilyalar Ankara'da monte edilmektedir.",
        [("atasehir", ServisTipi.Ofis)]          = "Ataşehir Merkez ve Küçükbakkalköy'deki iş merkezlerinden Ankara'ya kurumsal ofis taşımalarında gece/hafta sonu seçeneği ve IT protokolü standart olarak uygulanmaktadır.",
        [("atasehir", ServisTipi.Fuar)]          = "Ataşehir'deki finans ve teknoloji firmalarının Ankara fuar alanlarına taşınan ekipman ve stand materyalleri özel ambalajla korunmaktadır.",
        [("atasehir", ServisTipi.Kamyon)]        = "Ataşehir'deki 3+1–4+1 rezidans dairelerden Ankara'ya büyük mobilya ve beyaz eşya 12–18 ton kamyon ile tek seferde sigortalı taşınmaktadır.",
        [("atasehir", ServisTipi.Parsiyel)]      = "Ataşehir'den Ankara'ya az eşya için parsiyel araç hizmetimiz ekonomik biçimde belirli günlerde düzenli sefer yaparak teslimat sunar.",
        [("atasehir", ServisTipi.Ambar)]         = "Ataşehir'deki evi boşaltıp Ankara'daki yeni konuta geçiş tarihi netleşmemiş müşteriler için esnek süreli güvenli depolama mevcuttur.",

        // ── BEYKOZ ──
        [("beykoz", ServisTipi.Kamyonet)]      = "Çubuklu ve Paşabahçe'nin Boğaz kıyısındaki dar sokaklarında 3,5 ton kamyonetimiz büyük araçların ulaşamadığı adreslere de erişim sağlamaktadır.",
        [("beykoz", ServisTipi.Sehirlerarasi)] = "Beykoz'dan Ümraniye–Çekmeköy aksından TEM'e bağlanan araç, sabah erken yüklemeyle Ankara'ya aynı gün teslimatı tamamlamaktadır.",
        [("beykoz", ServisTipi.EvdenEve)]      = "Beykoz Merkez ve Anadoluhisarı'nın çok katlı yapılarında asansör koordinasyonu, köy mahallelerinde ise kamyonet transferiyle kapsamlı ev taşıması yapılmaktadır.",
        [("beykoz", ServisTipi.Ofis)]          = "Beykoz'daki işletmelerin Ankara'ya kurumsal ofis taşımalarında IT paketleme ve güvenli arşiv nakliyesi için standart protokol uygulanmaktadır.",
        [("beykoz", ServisTipi.Fuar)]          = "Beykoz'daki firmalar için Ankara fuar alanlarına taşınan stand ve ekipmanlar özel ambalaj ve fuar tarihine uygun planlama ile teslim edilmektedir.",
        [("beykoz", ServisTipi.Kamyon)]        = "Paşabahçe ve Çubuklu'daki büyük konutlardan Ankara'ya değerli mobilya ve büyük ev eşyaları kapalı kasalı kamyon ile sigortalı taşınmaktadır.",
        [("beykoz", ServisTipi.Parsiyel)]      = "Beykoz'dan Ankara'ya birkaç parça eşya veya kargo göndermek için parsiyel araç hizmeti ekonomik çözüm sunmaktadır.",
        [("beykoz", ServisTipi.Ambar)]         = "Beykoz'daki evi boşaltırken Ankara'daki yeni konuta geçiş tarihi bekleniyor ise eşyalar güvenli depomuzda esnek süreyle muhafaza edilmektedir.",

        // ── ÇEKMEKÖY ──
        [("cekmekoy", ServisTipi.Kamyonet)]      = "Nişantepe ve Hamidiye'nin sakin mahallelerindeki müstakil ev ve sitelerden yapılan taşımalarda 3,5 ton kamyonetimiz dar yollarda sorunsuz hareket etmektedir.",
        [("cekmekoy", ServisTipi.Sehirlerarasi)] = "Çekmeköy'den Ümraniye aksıyla TEM'e bağlanan araç, sabah yüklemesiyle Ankara'ya aynı gün teslimat sağlamakta; Ümraniye kavşağı geçildikten sonra yol açık akmaktadır.",
        [("cekmekoy", ServisTipi.EvdenEve)]      = "Mehmet Akif ve Çekmeköy Merkez'deki apartmanlarda asansör koordinasyonuyla kapsamlı ev taşıması yapılmakta; büyük mobilyalar Ankara'daki yeni adrese monte edilmektedir.",
        [("cekmekoy", ServisTipi.Ofis)]          = "Çekmeköy'deki küçük ve orta ölçekli işletmelerin Ankara'ya taşımalarında IT ekipmanı ve arşiv için kurumsal paket ve gece seçeneği sunulmaktadır.",
        [("cekmekoy", ServisTipi.Fuar)]          = "Çekmeköy'deki firmalar için Ankara fuar ve sergi taşımalarında stand ve promosyon materyalleri zamanında teslim garantisiyle taşınmaktadır.",
        [("cekmekoy", ServisTipi.Kamyon)]        = "Taşdelen ve Nişantepe'deki müstakil konutlardan büyük mobilya ve villa eşyalarının Ankara'ya kamyon ile tek seferlik taşıması yapılmaktadır.",
        [("cekmekoy", ServisTipi.Parsiyel)]      = "Çekmeköy'den Ankara'ya kargo veya birkaç parça mobilya göndermek için parsiyel araç hizmetimiz uygun fiyatlı seçenek sunmaktadır.",
        [("cekmekoy", ServisTipi.Ambar)]         = "Çekmeköy'deki evi boşaltıp Ankara'ya taşınma tarihini bekleyen müşteriler için güvenli esnek süreli depolama hizmetimiz mevcuttur.",

        // ── SANCAKTEPE ──
        [("sancaktepe", ServisTipi.Kamyonet)]      = "Veysel Karani ve Fatih mahallelerindeki sitelerde 3,5 ton kamyonetimiz geniş bina girişleri ve asansörlü yapılar sayesinde hızlı yükleme tamamlamaktadır.",
        [("sancaktepe", ServisTipi.Sehirlerarasi)] = "Sancaktepe'den Ümraniye aksıyla TEM'e bağlanan araç, sabah yüklemesiyle Ankara'ya aynı gün teslimatı tamamlamaktadır.",
        [("sancaktepe", ServisTipi.EvdenEve)]      = "Sancaktepe Merkez ve Kaynarca'daki konutlarda asansör planlaması ile kapsamlı ev taşıması yapılmakta; büyük mobilyalar Ankara'daki yeni adrese monte edilmektedir.",
        [("sancaktepe", ServisTipi.Ofis)]          = "Sancaktepe'deki ticari işletmelerin Ankara'ya kurumsal taşımalarında IT ekipmanı paketleme ve gece çalışma seçeneği sunulmaktadır.",
        [("sancaktepe", ServisTipi.Fuar)]          = "Sancaktepe'deki firmalar için Ankara fuar alanlarına stand ve ekipman taşımalarında fuar tarihi bazlı planlama ile zamanında teslimat sağlanmaktadır.",
        [("sancaktepe", ServisTipi.Kamyon)]        = "Sancaktepe'deki 3+1 ve büyük dairelerden Ankara'ya 12 ton kamyon ile tek seferlik büyük ev taşıması verimli yürütülmektedir.",
        [("sancaktepe", ServisTipi.Parsiyel)]      = "Sancaktepe'den Ankara'ya birkaç parça mobilya veya kargo kutusu göndermek için parsiyel araç hizmetimiz ekonomik çözüm sunar.",
        [("sancaktepe", ServisTipi.Ambar)]         = "Sancaktepe'deki evi boşaltıp Ankara'daki yeni konuta geçiş tarihi netleşmemiş müşteriler için esnek süreli depolama mevcuttur.",

        // ── SULTANBEYLİ ──
        [("sultanbeyli", ServisTipi.Kamyonet)]      = "Sultanbeyli'nin yoğun konut dokusunda dar sokaklara uyum sağlayan 3,5 ton kamyonetimiz büyük araçların giremediği bölgelerde de kesintisiz hizmet vermektedir.",
        [("sultanbeyli", ServisTipi.Sehirlerarasi)] = "Sultanbeyli'den Kartal aksıyla E-5 ve TEM Kurtköy güzergâhından Ankara yoluna çıkan araç sabah yüklemesiyle aynı gün teslimat tamamlamaktadır.",
        [("sultanbeyli", ServisTipi.EvdenEve)]      = "Mehmet Akif ve İnönü mahallelerindeki yüksek katlı yapılarda asansör koordinasyonu ve ekip planlamasıyla kapsamlı ev taşıması gerçekleştirilmektedir.",
        [("sultanbeyli", ServisTipi.Ofis)]          = "Sultanbeyli'deki küçük ve orta ölçekli işletmelerin Ankara'ya taşımalarında IT paketleme ve kurumsal fatura ile profesyonel hizmet sunulmaktadır.",
        [("sultanbeyli", ServisTipi.Fuar)]          = "Sultanbeyli'deki işletmeler için Ankara fuar alanlarına taşınan stand ve ürün materyalleri özel ambalajla zamanında teslim edilmektedir.",
        [("sultanbeyli", ServisTipi.Kamyon)]        = "Sultanbeyli'deki 3+1 konutlardan Ankara'ya kamyon ile tek seferlik büyük ev taşıması, birden fazla kamyonet seferine kıyasla ekonomik çözüm sunar.",
        [("sultanbeyli", ServisTipi.Parsiyel)]      = "Sultanbeyli'den Ankara'ya az eşya için parsiyel araç hizmetimiz uygun fiyatlı ve belirli günlerde düzenli sefer yaparak teslimat sunar.",
        [("sultanbeyli", ServisTipi.Ambar)]         = "Sultanbeyli'deki evi boşaltıp Ankara'ya geçiş tarihini bekleyen müşteriler için güvenli esnek süreli depolama hizmetimiz mevcuttur.",

        // ── TUZLA ──
        [("tuzla", ServisTipi.Kamyonet)]      = "Aydınlı ve Postane mahallelerindeki konut bölgelerine 3,5 ton kamyonetimiz sorunsuz erişmekte; sanayi bölgelerine alışkın ekip hızlı yükleme sağlamaktadır.",
        [("tuzla", ServisTipi.Sehirlerarasi)] = "Tuzla'nın D-100 bağlantısı ve TEM Kurtköy güzergâhı sayesinde şehirlerarası araçlar Ankara yoluna kısa sürede çıkmakta ve aynı gün teslimat tamamlanmaktadır.",
        [("tuzla", ServisTipi.EvdenEve)]      = "İçmeler ve Mimar Sinan'daki konutlarda asansör koordinasyonu ve büyük mobilya söküm-montajı dahil kapsamlı ev taşıması yapılmaktadır.",
        [("tuzla", ServisTipi.Ofis)]          = "Tuzla OSB'deki firmalar ve İçmeler'deki ofislerin Ankara'ya kurumsal taşımalarında IT ekipmanı ve sunucu için özel güvenlik protokolü uygulanmaktadır.",
        [("tuzla", ServisTipi.Fuar)]          = "Tuzla sanayi bölgesindeki firmalar için Ankara fuar alanlarına taşınan ürün ve teknik ekipmanlar vibrasyon emici ambalajla korunmaktadır.",
        [("tuzla", ServisTipi.Kamyon)]        = "Tuzla'daki sanayi tesisleri veya büyük konutlardan Ankara'ya 12–18 ton kamyon ile tek seferlik taşıma, büyük araç altyapısına alışkın güzergâhtan geçmektedir.",
        [("tuzla", ServisTipi.Parsiyel)]      = "Tuzla'dan Ankara'ya kargo veya birkaç parça mobilya göndermek için parsiyel araç hizmeti ekonomik ve zamanında teslimat sunar.",
        [("tuzla", ServisTipi.Ambar)]         = "Tuzla'daki evi veya iş yerini boşaltıp Ankara'ya geçiş tarihini bekleyen müşteriler için esnek süreli güvenli depolama mevcuttur.",

        // ── ŞİLE ──
        [("sile", ServisTipi.Kamyonet)]      = "Şile Merkez ve Ağva mahallelerindeki konutlara 3,5 ton kamyonetimiz kolayca erişmekte; uzak mesafe nedeniyle yükleme sabah erken saatte başlatılmaktadır.",
        [("sile", ServisTipi.Sehirlerarasi)] = "Şile'den E-80 Kurtköy güzergâhıyla Ümraniye'ye, oradan TEM'e bağlanan araç sabah erken yüklemeyle Ankara'ya aynı gün ulaşabilmektedir.",
        [("sile", ServisTipi.EvdenEve)]      = "Şile'deki yazlık ve müstakil konutlardan Ankara'ya kapıdan kapıya ev taşıması için yükleme planlaması erken saatte başlatılmaktadır.",
        [("sile", ServisTipi.Ofis)]          = "Şile'deki küçük işletmelerin Ankara'ya taşımalarında IT paketleme ve kurumsal fatura ile profesyonel hizmet sunulmaktadır.",
        [("sile", ServisTipi.Fuar)]          = "Şile'deki firmalar için Ankara fuar taşımalarında uzun güzergâh nedeniyle kalkış günü bir gün öne alınarak zamanında teslimat garanti edilmektedir.",
        [("sile", ServisTipi.Kamyon)]        = "Şile'deki büyük yazlık veya müstakil konutlardan Ankara'ya kamyon ile tek seferlik sigortalı taşıma yapılmaktadır.",
        [("sile", ServisTipi.Parsiyel)]      = "Şile'den Ankara'ya az eşya veya kargo göndermek için parsiyel araç hizmetimiz ekonomik çözüm sunar; uzak mesafe telafi edilerek fiyat belirlenmektedir.",
        [("sile", ServisTipi.Ambar)]         = "Şile'deki evi veya yazlık konutu boşaltıp Ankara'ya geçiş tarihi netleşmemiş müşteriler için esnek süreli depolama hizmetimiz mevcuttur.",

        // ── ADALAR ──
        [("adalar", ServisTipi.Kamyonet)]      = "Büyükada ve Heybeliada'dan Ankara'ya taşımalarda eşyalar iskeleye kamyonetimizle alınmakta, araç kara bağlantısına çıktıktan sonra Ankara güzergâhına devam edilmektedir.",
        [("adalar", ServisTipi.Sehirlerarasi)] = "Adalar'dan Ankara'ya şehirlerarası taşımada iskele–kara transferi önceden koordine edilmekte; kara bağlantısından Ankara'ya aynı gün teslimat hedeflenmektedir.",
        [("adalar", ServisTipi.EvdenEve)]      = "Büyükada ve Heybeliada'daki konutlardan ev taşımasında iskele koordinasyonu, fayton planlaması ve kara transferi kapsamlı biçimde organize edilmektedir.",
        [("adalar", ServisTipi.Ofis)]          = "Adalar'daki otel veya işletmelerin Ankara'ya taşımalarında iskele–kara bağlantısı dahil planlama ile kurumsal taşıma hizmeti sunulmaktadır.",
        [("adalar", ServisTipi.Fuar)]          = "Adalar'daki işletmeler için Ankara fuar taşımalarında ekstra transfer günü planlanmakta; zamanında teslimat için rezervasyon en az 3 gün öncesinden alınmaktadır.",
        [("adalar", ServisTipi.Kamyon)]        = "Adalar'dan büyük ev eşyaları için kamyon, eşyaların iskelede yüklenmesinin ardından kara bağlantısından Ankara yoluna hareket etmektedir.",
        [("adalar", ServisTipi.Parsiyel)]      = "Adalar'dan Ankara'ya birkaç parça eşya veya kargo için iskele transferi dahil parsiyel araç hizmetimiz koordineli biçimde sunulmaktadır.",
        [("adalar", ServisTipi.Ambar)]         = "Adalar'daki konut boşaltmasında eşyalar iskele transferiyle karaya alınarak depoya konulmakta, Ankara'ya geçiş gününe kadar güvenle muhafaza edilmektedir.",

        // ── ŞİŞLİ ──
        [("sisli", ServisTipi.Kamyonet)]      = "Nişantaşı ve Kurtuluş'un tarihi apartmanlarında 3,5 ton kamyonetimiz dar arka sokak ve bina girişlerine uyum sağlamaktadır; gece yükleme için saat planlaması yapılmaktadır.",
        [("sisli", ServisTipi.Sehirlerarasi)] = "Şişli'den Zincirlikuyu–TEM aksı ya da Maslak bağlantısından Ankara yoluna çıkan araç, sabah yüklemesiyle aynı gün teslimatı tamamlamaktadır.",
        [("sisli", ServisTipi.EvdenEve)]      = "Bomonti ve Mecidiyeköy'deki yüksek katlı konutlarda asansör koordinasyonu ile büyük mobilyalar sökülerek Ankara'daki yeni adrese monte edilmektedir.",
        [("sisli", ServisTipi.Ofis)]          = "Şişli'deki iş merkezleri ve Mecidiyeköy kuleleri için gece veya hafta sonu ofis taşıması, IT ekipmanı etiketi ve kurumsal fatura ile profesyonelce yürütülmektedir.",
        [("sisli", ServisTipi.Fuar)]          = "Şişli'deki reklam, medya ve teknoloji firmalarının Ankara fuar alanlarına taşınan stand ve ekipmanlar özel ambalajla korunmakta; fuar öncesi teslim planlanmaktadır.",
        [("sisli", ServisTipi.Kamyon)]        = "Mecidiyeköy ve Harbiye'deki 3+1 ve büyük dairelerden Ankara'ya 12 ton kamyon ile tek seferlik büyük ev taşıması sabah erken yüklemeyle başlatılmaktadır.",
        [("sisli", ServisTipi.Parsiyel)]      = "Şişli'den Ankara'ya birkaç parça mobilya veya kargo kutusu için parsiyel araç hizmetimiz ekonomik ve zamanında teslimat sunar.",
        [("sisli", ServisTipi.Ambar)]         = "Şişli'deki evi boşaltıp Ankara'ya taşınma tarihini bekleyen müşteriler eşyalarını güvenli depomuzda esnek süreyle tutabilmektedir.",

        // ── BEŞİKTAŞ ──
        [("besiktas", ServisTipi.Kamyonet)]      = "Bebek ve Arnavutköy'ün Boğaz kıyısındaki dar sokaklarında 3,5 ton kamyonetimiz büyük araçların erişemeyeceği tarihi mahallelere de ulaşım sağlamaktadır.",
        [("besiktas", ServisTipi.Sehirlerarasi)] = "Beşiktaş'tan Maslak aksıyla TEM'e bağlanan araç, sabah trafiği öncesinde yüklemeyi tamamlayarak Ankara'ya aynı gün teslimat sağlamaktadır.",
        [("besiktas", ServisTipi.EvdenEve)]      = "Levent ve Etiler'deki modern rezidanslarda asansör koordinasyonu, Ortaköy'deki tarihi yapılarda ise kat kat taşıma ile kapsamlı ev nakliyesi gerçekleştirilmektedir.",
        [("besiktas", ServisTipi.Ofis)]          = "Levent ve Balmumcu'daki finans ve hukuk kuruluşlarının Ankara'ya ofis taşımalarında IT güvenliği, arşiv paketi ve gece çalışma seçeneği standart olarak sunulmaktadır.",
        [("besiktas", ServisTipi.Fuar)]          = "Beşiktaş'taki kurumsal firmaların Ankara CNR veya Tüyap fuar alanlarına taşınan stand ve ekipmanlar fuar tarihinden 2 gün önce teslim edilmektedir.",
        [("besiktas", ServisTipi.Kamyon)]        = "Etiler ve Levent'teki büyük dairelerden Ankara'ya 12–18 ton kamyon ile tek seferlik sigortalı büyük ev taşıması sabah erken yüklemeyle başlatılmaktadır.",
        [("besiktas", ServisTipi.Parsiyel)]      = "Beşiktaş'tan Ankara'ya az eşya veya kargo göndermek için parsiyel araç hizmeti ekonomik ve zamanında teslimat imkânı sunar.",
        [("besiktas", ServisTipi.Ambar)]         = "Beşiktaş'taki konutunu boşaltıp Ankara'ya taşınma tarihi netleşmemiş müşteriler eşyalarını güvenli depomuzda esnek süreyle saklayabilmektedir.",

        // ── BAKIRKÖY ──
        [("bakirkoy", ServisTipi.Kamyonet)]      = "Zuhuratbaba ve Cevizlik'in eski apartmanlarında 3,5 ton kamyonetimiz asansör yokluğunda merdiven taşımasıyla hizmet vermekte; Ataköy sitelerinde ise büyük araçlar sorunsuz çalışmaktadır.",
        [("bakirkoy", ServisTipi.Sehirlerarasi)] = "Bakırköy'den E-5 aksıyla Ankara güzergâhına çıkan araç, sabah yüklemesiyle aynı gün Ankara adresine teslimat sağlamaktadır.",
        [("bakirkoy", ServisTipi.EvdenEve)]      = "Ataköy ve Florya'daki büyük sitelerde asansör koordinasyonu ve söküm-montaj dahil kapsamlı ev taşıması yapılmaktadır.",
        [("bakirkoy", ServisTipi.Ofis)]          = "Bakırköy'deki plaza ve iş merkezlerinden Ankara'ya kurumsal ofis taşımalarında IT ekipmanı güvenli paketleme ve gece seçeneği sunulmaktadır.",
        [("bakirkoy", ServisTipi.Fuar)]          = "Bakırköy'deki işletmeler için Ankara fuar alanlarına stand ve ekipman taşımalarında zamanında teslim planlaması yapılmaktadır.",
        [("bakirkoy", ServisTipi.Kamyon)]        = "Ataköy sitelerindeki büyük 3+1 ve 4+1 dairelerden Ankara'ya 12 ton kamyon ile tek seferlik sigortalı büyük ev taşıması gerçekleştirilmektedir.",
        [("bakirkoy", ServisTipi.Parsiyel)]      = "Bakırköy'den Ankara'ya birkaç parça mobilya veya kargo için parsiyel araç hizmetimiz ekonomik ve zamanında teslimat sunar.",
        [("bakirkoy", ServisTipi.Ambar)]         = "Bakırköy'deki evi boşaltıp Ankara'ya taşınma tarihi netleşmemiş müşteriler için güvenli esnek süreli depolama hizmetimiz mevcuttur.",

        // ── BEYLİKDÜZÜ ──
        [("beylikduzu", ServisTipi.Kamyonet)]      = "Büyükşehir ve Adnan Kahveci mahallelerindeki geniş sitelerden yapılan taşımalarda 3,5 ton kamyonetimiz asansör koordinasyonuyla hızlı yükleme tamamlamaktadır.",
        [("beylikduzu", ServisTipi.Sehirlerarasi)] = "Beylikdüzü'nden Esenyurt aksıyla TEM'e bağlanan araç, sabah yüklemesiyle Ankara'ya aynı gün teslimat sağlamaktadır.",
        [("beylikduzu", ServisTipi.EvdenEve)]      = "Beylikdüzü'nün geniş bina girişli modern sitelerinde asansör koordinasyonu ve büyük mobilya söküm-montajı dahil kapsamlı ev taşıması yapılmaktadır.",
        [("beylikduzu", ServisTipi.Ofis)]          = "Beylikdüzü'ndeki AVM çevresi ve iş bölgelerindeki ofislerin Ankara'ya kurumsal taşımalarında IT paketleme ve hafta sonu seçeneği sunulmaktadır.",
        [("beylikduzu", ServisTipi.Fuar)]          = "Beylikdüzü'ndeki firmalar için Ankara fuar alanlarına taşınan stand ve promosyon materyalleri özel ambalajla fuar tarihinden önce teslim edilmektedir.",
        [("beylikduzu", ServisTipi.Kamyon)]        = "Beylikdüzü'nün büyük sitelerdeki 3+1 ve 4+1 dairelerinden Ankara'ya 12–18 ton kamyon ile tek seferlik büyük ev taşıması verimli biçimde yürütülmektedir.",
        [("beylikduzu", ServisTipi.Parsiyel)]      = "Beylikdüzü'nden Ankara'ya az eşya için parsiyel araç hizmetimiz belirli günlerde düzenli sefer yaparak ekonomik teslimat sunar.",
        [("beylikduzu", ServisTipi.Ambar)]         = "Beylikdüzü'ndeki evi boşaltıp Ankara'ya geçiş tarihi bekleniyor ise eşyalar güvenli depomuzda esnek süreyle muhafaza edilmektedir.",

        // ── ESENYURT ──
        [("esenyurt", ServisTipi.Kamyonet)]      = "Esenyurt'un yoğun konut bloklarında asansör koordinasyonuyla 3,5 ton kamyonetimiz hızlı yükleme tamamlamaktadır; TEM'e Avcılar aksından kısa sürede ulaşılmaktadır.",
        [("esenyurt", ServisTipi.Sehirlerarasi)] = "Esenyurt'tan TEM'e bağlanan araç sabah 07:00 öncesi yüklemeyle ilçe trafiğini atlatarak Ankara'ya aynı gün teslimatı tamamlamaktadır.",
        [("esenyurt", ServisTipi.EvdenEve)]      = "Talatpaşa ve Pınar mahallelerindeki konutlarda asansör koordinasyonu ve söküm-montaj dahil kapsamlı ev taşıması yapılmakta; büyük mobilyalar Ankara'da monte edilmektedir.",
        [("esenyurt", ServisTipi.Ofis)]          = "Esenyurt'taki ticari işletmelerin Ankara'ya kurumsal taşımalarında IT paketleme ve gece çalışma seçeneği sunulmaktadır.",
        [("esenyurt", ServisTipi.Fuar)]          = "Esenyurt'taki firmalar için Ankara fuar alanlarına taşınan stand ve ekipmanlar özel ambalajla fuar tarihinden önce teslim edilmektedir.",
        [("esenyurt", ServisTipi.Kamyon)]        = "Esenyurt'taki büyük 3+1 ve 4+1 dairelerden Ankara'ya 12–18 ton kamyon ile tek seferlik büyük ev taşıması verimli biçimde yürütülmektedir.",
        [("esenyurt", ServisTipi.Parsiyel)]      = "Esenyurt'tan Ankara'ya az eşya için parsiyel araç hizmetimiz belirli günlerde düzenli sefer yaparak ekonomik teslimat sunar.",
        [("esenyurt", ServisTipi.Ambar)]         = "Esenyurt'taki evi boşaltıp Ankara'ya geçiş tarihini bekleyen müşteriler için güvenli esnek süreli depolama hizmetimiz mevcuttur.",

        // ── BAŞAKŞEHİR ──
        [("basaksehir", ServisTipi.Kamyonet)]      = "Bahçeşehir ve Kayaşehir'deki planlı sitelerde 3,5 ton kamyonetimiz geniş bina girişleri ve asansörlü yapılar sayesinde hızlı yükleme tamamlamaktadır.",
        [("basaksehir", ServisTipi.Sehirlerarasi)] = "Başakşehir'in TEM'e doğrudan bağlantısı, şehirlerarası araçların İstanbul trafiğine girmeden Ankara yoluna çıkmasını ve teslimat süresini kısaltmaktadır.",
        [("basaksehir", ServisTipi.EvdenEve)]      = "Altınşehir ve Başakşehir Merkez'deki modern konutlarda asansör koordinasyonu ve büyük mobilya söküm-montajı dahil kapsamlı ev taşıması yapılmaktadır.",
        [("basaksehir", ServisTipi.Ofis)]          = "Başakşehir'deki teknoloji ve kurumsal firmaların Ankara'ya ofis taşımalarında IT ekipmanı güvenli paketleme ve kurumsal fatura standart olarak sunulmaktadır.",
        [("basaksehir", ServisTipi.Fuar)]          = "Başakşehir'deki firmalar için Ankara fuar alanlarına stand ve ekipman taşımalarında TEM'e yakın güzergâh avantajıyla zamanında teslimat sağlanmaktadır.",
        [("basaksehir", ServisTipi.Kamyon)]        = "Başakşehir'deki büyük sitelerin 3+1 ve 4+1 dairelerinden Ankara'ya 12–18 ton kamyon ile tek seferlik büyük ev taşıması TEM güzergâhını etkin kullanmaktadır.",
        [("basaksehir", ServisTipi.Parsiyel)]      = "Başakşehir'den Ankara'ya az eşya için parsiyel araç hizmetimiz ekonomik biçimde ve belirli günlerde düzenli sefer yaparak teslimat sunar.",
        [("basaksehir", ServisTipi.Ambar)]         = "Başakşehir'deki evi boşaltıp Ankara'daki yeni konuta geçiş tarihi netleşmemiş müşteriler için esnek süreli güvenli depolama mevcuttur.",

        // ── ARNAVUTKÖY ──
        [("arnavutkoy", ServisTipi.Kamyonet)]      = "Bolluca ve Haraçcı mahallelerindeki yeni konut sitelerinde 3,5 ton kamyonetimiz asansör koordinasyonuyla hızlı yükleme tamamlamaktadır.",
        [("arnavutkoy", ServisTipi.Sehirlerarasi)] = "Arnavutköy'den TEM'e çevreyolu üzerinden 15–20 dakikada ulaşan araç, sabah yüklemesiyle Ankara'ya aynı gün teslimat sağlamaktadır.",
        [("arnavutkoy", ServisTipi.EvdenEve)]      = "Arnavutköy Merkez ve Taşoluk'taki konutlarda asansör koordinasyonu ve söküm-montaj dahil kapsamlı ev taşıması yapılmaktadır.",
        [("arnavutkoy", ServisTipi.Ofis)]          = "Arnavutköy'deki işletmelerin Ankara'ya kurumsal ofis taşımalarında IT paketleme ve gece çalışma seçeneği sunulmaktadır.",
        [("arnavutkoy", ServisTipi.Fuar)]          = "Arnavutköy'deki firmalar için Ankara fuar alanlarına taşınan ekipman ve stand materyalleri özel ambalajla zamanında teslim edilmektedir.",
        [("arnavutkoy", ServisTipi.Kamyon)]        = "Arnavutköy'deki büyük konut sitelerinden Ankara'ya 12–18 ton kamyon ile tek seferlik büyük ev taşıması TEM'e yakın güzergâh avantajıyla yapılmaktadır.",
        [("arnavutkoy", ServisTipi.Parsiyel)]      = "Arnavutköy'den Ankara'ya birkaç parça mobilya veya kargo için parsiyel araç hizmetimiz ekonomik ve zamanında teslimat sunar.",
        [("arnavutkoy", ServisTipi.Ambar)]         = "Arnavutköy'deki evi boşaltıp Ankara'ya taşınma tarihini bekleyen müşteriler için güvenli esnek süreli depolama hizmetimiz mevcuttur.",

        // ── HADIMKÖY ──
        [("hadimkoy", ServisTipi.Kamyonet)]      = "Hadımköy Merkez mahallelerindeki konut bölgelerine 3,5 ton kamyonetimiz sorunsuz erişmekte; TEM girişine 5 dakikalık mesafe yükleme sonrası hızlı çıkışı sağlamaktadır.",
        [("hadimkoy", ServisTipi.Sehirlerarasi)] = "Hadımköy'ün TEM girişine olan 5 dakikalık mesafesi, şehirlerarası araçların İstanbul trafiğine hiç girmeden Ankara yoluna çıkmasını mümkün kılmaktadır.",
        [("hadimkoy", ServisTipi.EvdenEve)]      = "Hadımköy'deki konut ve site mahallelerinde kapıdan kapıya ev taşıması için asansör koordinasyonu ve söküm-montaj dahil hizmet verilmektedir.",
        [("hadimkoy", ServisTipi.Ofis)]          = "Hadımköy OSB'deki işletmelerin Ankara'ya kurumsal taşımalarında büyük araç altyapısına alışkın güzergâhtan yararlanılmakta; IT ve depo ekipmanı güvenle paketlenmektedir.",
        [("hadimkoy", ServisTipi.Fuar)]          = "Hadımköy'deki sanayi ve üretim firmalarının Ankara fuar alanlarına taşınan ürün ve ekipmanlar vibrasyon emici ambalajla korunmaktadır.",
        [("hadimkoy", ServisTipi.Kamyon)]        = "Hadımköy'deki sanayi tesisleri veya büyük konutlardan Ankara'ya TEM'e sıfır mesafedeki konumun avantajıyla 12–18 ton kamyon taşıması verimli yürütülmektedir.",
        [("hadimkoy", ServisTipi.Parsiyel)]      = "Hadımköy'den Ankara'ya kargo veya birkaç parça eşya göndermek için parsiyel araç hizmetimiz ekonomik çözüm sunar.",
        [("hadimkoy", ServisTipi.Ambar)]         = "Hadımköy'deki evi veya iş yerini boşaltıp Ankara'ya geçiş tarihini bekleyen müşteriler için esnek süreli güvenli depolama mevcuttur.",

        // ── İKİTELLİ ──
        [("ikitelli", ServisTipi.Kamyonet)]      = "Kazım Karabekir ve Ziya Gökalp mahallelerindeki konut bölgelerine 3,5 ton kamyonetimiz sorunsuz erişmekte; OSB girişindeki büyük araç deneyimi yükleme planlamasını kolaylaştırmaktadır.",
        [("ikitelli", ServisTipi.Sehirlerarasi)] = "İkitelli'den Başakşehir aksıyla TEM'e bağlanan araç, sabah yüklemesiyle Ankara'ya aynı gün teslimatı tamamlamaktadır.",
        [("ikitelli", ServisTipi.EvdenEve)]      = "İkitelli'deki konut mahallelerinde asansör koordinasyonu ve söküm-montaj dahil kapsamlı ev taşıması yapılmaktadır.",
        [("ikitelli", ServisTipi.Ofis)]          = "İkitelli OSB'deki firmaların Ankara'ya kurumsal taşımalarında IT ekipmanı ve depo malzemeleri güvenli paketleme ve etiketiyle nakliyesi yapılmaktadır.",
        [("ikitelli", ServisTipi.Fuar)]          = "İkitelli'deki sanayi firmalarının Ankara fuar alanlarına taşınan ürün ve stand materyalleri özel ambalajla zamanında teslim edilmektedir.",
        [("ikitelli", ServisTipi.Kamyon)]        = "İkitelli OSB çevresindeki sanayi işletmeleri veya büyük konutlardan Ankara'ya 12–18 ton kamyon ile tek seferlik taşıma büyük araç altyapısına alışkın güzergâhtan geçmektedir.",
        [("ikitelli", ServisTipi.Parsiyel)]      = "İkitelli'den Ankara'ya az eşya veya kargo göndermek için parsiyel araç hizmetimiz ekonomik ve zamanında teslimat sunar.",
        [("ikitelli", ServisTipi.Ambar)]         = "İkitelli'deki evi veya iş yerini boşaltıp Ankara'ya geçiş tarihi bekleniyor ise eşyalar güvenli depomuzda esnek süreyle muhafaza edilmektedir.",

        // ── AVCILAR ──
        [("avcilar", ServisTipi.Kamyonet)]      = "Cihangir ve Tahtakale'nin konut mahallelerinde 3,5 ton kamyonetimiz sorunsuz çalışır; Ambarlı sanayi bölgesine alışkın ekip hızlı yükleme planlaması yapmaktadır.",
        [("avcilar", ServisTipi.Sehirlerarasi)] = "Avcılar'dan E-5 ve TEM Küçükçekmece–Esenyurt aksından Ankara yoluna çıkan araç, sabah yüklemesiyle aynı gün teslimatı tamamlamaktadır.",
        [("avcilar", ServisTipi.EvdenEve)]      = "Üniversite ve Firuzköy mahallelerindeki konutlarda asansör koordinasyonu ve söküm-montaj dahil kapsamlı ev taşıması yapılmaktadır.",
        [("avcilar", ServisTipi.Ofis)]          = "Avcılar'daki işletmelerin Ankara'ya kurumsal ofis taşımalarında IT ekipmanı güvenli paketleme ve gece çalışma seçeneği sunulmaktadır.",
        [("avcilar", ServisTipi.Fuar)]          = "Avcılar'daki firmalar için Ankara fuar alanlarına stand ve ekipman taşımalarında zamanında teslim planlaması yapılmaktadır.",
        [("avcilar", ServisTipi.Kamyon)]        = "Avcılar'daki 3+1 ve büyük dairelerden Ankara'ya 12 ton kamyon ile tek seferlik büyük ev taşıması verimli yürütülmektedir.",
        [("avcilar", ServisTipi.Parsiyel)]      = "Avcılar'dan Ankara'ya öğrenci veya bekar taşımalarında parsiyel araç hizmetimiz ekonomik ve zamanında teslimat imkânı sunar.",
        [("avcilar", ServisTipi.Ambar)]         = "Avcılar'daki evi boşaltıp Ankara'ya taşınma tarihi netleşmemiş müşteriler için esnek süreli güvenli depolama hizmetimiz mevcuttur.",

        // ── BÜYÜKÇEKMECe ──
        [("buyukcekemece", ServisTipi.Kamyonet)]      = "Mimarsinan ve Kumburgaz'ın sahil sitelerindeki geniş yollarda 3,5 ton kamyonetimiz sorunsuz çalışmakta; sabah erken saatte yükleme başlatılmaktadır.",
        [("buyukcekemece", ServisTipi.Sehirlerarasi)] = "Büyükçekmece'den E-5 ve TEM'e Avcılar ya da Esenyurt aksından bağlanan araç, sabah yüklemesiyle Ankara'ya aynı gün teslimat sağlamaktadır.",
        [("buyukcekemece", ServisTipi.EvdenEve)]      = "Pınarca ve Güzelce'deki sitelerde asansör koordinasyonu ile kapsamlı ev taşıması yapılmakta; büyük mobilyalar Ankara'daki yeni adrese monte edilmektedir.",
        [("buyukcekemece", ServisTipi.Ofis)]          = "Büyükçekmece'deki işletmelerin Ankara'ya kurumsal taşımalarında IT paketleme ve gece çalışma seçeneği sunulmaktadır.",
        [("buyukcekemece", ServisTipi.Fuar)]          = "Büyükçekmece'deki firmalar için Ankara fuar taşımalarında stand ve ekipmanlar özel ambalajla zamanında teslim edilmektedir.",
        [("buyukcekemece", ServisTipi.Kamyon)]        = "Büyükçekmece'nin büyük sahil sitelerindeki 3+1 ve 4+1 konutlardan Ankara'ya 12 ton kamyon ile tek seferlik sigortalı taşıma yapılmaktadır.",
        [("buyukcekemece", ServisTipi.Parsiyel)]      = "Büyükçekmece'den Ankara'ya az eşya veya kargo göndermek için parsiyel araç hizmetimiz ekonomik ve zamanında teslimat sunar.",
        [("buyukcekemece", ServisTipi.Ambar)]         = "Büyükçekmece'deki evi boşaltıp Ankara'ya taşınma tarihi netleşmemiş müşteriler için güvenli esnek süreli depolama hizmetimiz mevcuttur.",

        // ── SİLİVRİ ──
        [("silivri", ServisTipi.Kamyonet)]      = "Selimpaşa ve Gümüşyaka'daki sitelerde 3,5 ton kamyonetimiz geniş yollarda sorunsuz çalışmakta; bağ bölgelerinde dar yollara uyum sağlamaktadır.",
        [("silivri", ServisTipi.Sehirlerarasi)] = "Silivri'den E-5 ve TEM'e Büyükçekmece güzergâhından bağlanan araç, sabah yüklemesiyle Ankara'ya aynı gün teslimat sağlamaktadır.",
        [("silivri", ServisTipi.EvdenEve)]      = "Silivri Merkez ve Ortaköy'deki konutlarda asansör koordinasyonu ve söküm-montaj dahil kapsamlı ev taşıması yapılmaktadır.",
        [("silivri", ServisTipi.Ofis)]          = "Silivri'deki ticari işletmelerin Ankara'ya taşımalarında IT paketleme ve kurumsal fatura ile profesyonel hizmet sunulmaktadır.",
        [("silivri", ServisTipi.Fuar)]          = "Silivri'deki firmalar için Ankara fuar taşımalarında uzun güzergâh nedeniyle kalkış sabah erken saatte planlanmaktadır.",
        [("silivri", ServisTipi.Kamyon)]        = "Silivri'deki büyük siteler veya bağ evlerindeki konutlardan Ankara'ya kamyon ile tek seferlik sigortalı taşıma yapılmaktadır.",
        [("silivri", ServisTipi.Parsiyel)]      = "Silivri'den Ankara'ya birkaç parça mobilya veya kargo için parsiyel araç hizmetimiz ekonomik çözüm sunar.",
        [("silivri", ServisTipi.Ambar)]         = "Silivri'deki evi veya yazlığını boşaltıp Ankara'ya geçiş tarihi bekleniyor ise eşyalar güvenli depomuzda esnek süreyle muhafaza edilmektedir.",

        // ── ÇATALCA ──
        [("catalca", ServisTipi.Kamyonet)]      = "Çatalca Merkez ve Kapaklı mahallelerine 3,5 ton kamyonetimiz sorunsuz erişmekte; köy bölgelerinde dar yollara uyum sağlayan araç boyutu tercih edilmektedir.",
        [("catalca", ServisTipi.Sehirlerarasi)] = "Çatalca'dan Silivri veya Büyükçekmece üzerinden E-5 ve TEM'e bağlanan araç, sabah yüklemesiyle Ankara'ya aynı gün teslimatı tamamlamaktadır.",
        [("catalca", ServisTipi.EvdenEve)]      = "Çatalca Merkez'deki konutlarda kapıdan kapıya ev taşıması için asansör koordinasyonu ve söküm-montaj dahil hizmet verilmektedir.",
        [("catalca", ServisTipi.Ofis)]          = "Çatalca'daki işletmelerin Ankara'ya taşımalarında IT paketleme ve kurumsal fatura ile profesyonel hizmet sunulmaktadır.",
        [("catalca", ServisTipi.Fuar)]          = "Çatalca'daki firmalar için Ankara fuar taşımalarında uzun güzergâh nedeniyle sabah erken kalkış planlanmakta; zamanında teslimat garanti edilmektedir.",
        [("catalca", ServisTipi.Kamyon)]        = "Çatalca'daki büyük konutlardan Ankara'ya kamyon ile tek seferlik sigortalı taşıma Silivri–TEM güzergâhından geçmektedir.",
        [("catalca", ServisTipi.Parsiyel)]      = "Çatalca'dan Ankara'ya birkaç parça eşya veya kargo göndermek için parsiyel araç hizmetimiz ekonomik çözüm sunar.",
        [("catalca", ServisTipi.Ambar)]         = "Çatalca'daki evi boşaltıp Ankara'ya taşınma tarihi netleşmemiş müşteriler için güvenli esnek süreli depolama hizmetimiz mevcuttur.",

        // ── KÜÇÜKÇEKMECe ──
        [("kucukcekemece", ServisTipi.Kamyonet)]      = "Atakent sitelerinde 3,5 ton kamyonetimiz geniş bina girişlerini etkin kullanmakta; Halkalı ve İnönü mahallelerindeki eski yapılarda dar yollara uyum sağlamaktadır.",
        [("kucukcekemece", ServisTipi.Sehirlerarasi)] = "Küçükçekmece'den E-5 aksıyla Ankara güzergâhına çıkan araç, sabah yüklemesiyle aynı gün teslimatı tamamlamaktadır.",
        [("kucukcekemece", ServisTipi.EvdenEve)]      = "Atakent ve Cennet mahallelerindeki sitelerde asansör koordinasyonu ve söküm-montaj dahil kapsamlı ev taşıması yapılmaktadır.",
        [("kucukcekemece", ServisTipi.Ofis)]          = "Küçükçekmece'deki ticari işletmelerin Ankara'ya kurumsal taşımalarında IT paketleme ve gece çalışma seçeneği sunulmaktadır.",
        [("kucukcekemece", ServisTipi.Fuar)]          = "Küçükçekmece'deki firmalar için Ankara fuar alanlarına taşınan stand ve ekipmanlar özel ambalajla zamanında teslim edilmektedir.",
        [("kucukcekemece", ServisTipi.Kamyon)]        = "Atakent'teki büyük sitelerin 3+1 ve 4+1 dairelerinden Ankara'ya 12 ton kamyon ile tek seferlik büyük ev taşıması yapılmaktadır.",
        [("kucukcekemece", ServisTipi.Parsiyel)]      = "Küçükçekmece'den Ankara'ya birkaç parça mobilya veya kargo için parsiyel araç hizmetimiz ekonomik ve zamanında teslimat sunar.",
        [("kucukcekemece", ServisTipi.Ambar)]         = "Küçükçekmece'deki evi boşaltıp Ankara'ya taşınma tarihi netleşmemiş müşteriler için esnek süreli güvenli depolama mevcuttur.",

        // ── GÜNGÖREN ──
        [("gungoren", ServisTipi.Kamyonet)]      = "Güngören'in dar iç sokaklarında 3,5 ton kamyonetimiz büyük araçların erişemediği adreslere ulaşmakta; Merter aksında ise kamyon erişimi sorunsuz sağlanmaktadır.",
        [("gungoren", ServisTipi.Sehirlerarasi)] = "Güngören'den Bakırköy aksıyla E-5 ve TEM'e bağlanan araç, sabah yüklemesiyle Ankara'ya aynı gün teslimatı tamamlamaktadır.",
        [("gungoren", ServisTipi.EvdenEve)]      = "Güngören Merkez ve Tozkoparan'daki konutlarda asansör koordinasyonu ve söküm-montaj dahil kapsamlı ev taşıması yapılmaktadır.",
        [("gungoren", ServisTipi.Ofis)]          = "Güngören'deki tekstil ve ticari işletmelerin Ankara'ya taşımalarında IT paketleme ve kurumsal fatura ile profesyonel hizmet sunulmaktadır.",
        [("gungoren", ServisTipi.Fuar)]          = "Güngören'deki firmalar için Ankara fuar taşımalarında stand ve ürün materyalleri özel ambalajla zamanında teslim edilmektedir.",
        [("gungoren", ServisTipi.Kamyon)]        = "Güngören'deki 3+1 ve büyük dairelerden Ankara'ya 12 ton kamyon ile tek seferlik büyük ev taşıması Bakırköy aksından verimli yürütülmektedir.",
        [("gungoren", ServisTipi.Parsiyel)]      = "Güngören'den Ankara'ya az eşya için parsiyel araç hizmetimiz ekonomik ve zamanında teslimat sunar.",
        [("gungoren", ServisTipi.Ambar)]         = "Güngören'deki evi boşaltıp Ankara'ya taşınma tarihi netleşmemiş müşteriler için güvenli esnek süreli depolama hizmetimiz mevcuttur.",

        // ── BAHÇELİEVLER ──
        [("bahcelievler", ServisTipi.Kamyonet)]      = "Kocasinan ve Şirinevler'in yüksek katlı yapılarında 3,5 ton kamyonetimiz asansör koordinasyonuyla hızlı yükleme tamamlamaktadır.",
        [("bahcelievler", ServisTipi.Sehirlerarasi)] = "Bahçelievler'den E-5 aksıyla Ankara güzergâhına çıkan araç, sabah yüklemesiyle aynı gün Ankara adresine teslimat sağlamaktadır.",
        [("bahcelievler", ServisTipi.EvdenEve)]      = "Zafer ve Cumhuriyet mahallelerindeki konutlarda asansör koordinasyonu ve söküm-montaj dahil kapsamlı ev taşıması yapılmakta; büyük mobilyalar Ankara'da monte edilmektedir.",
        [("bahcelievler", ServisTipi.Ofis)]          = "Bahçelievler'deki ticari işletmelerin Ankara'ya kurumsal taşımalarında IT paketleme ve gece çalışma seçeneği sunulmaktadır.",
        [("bahcelievler", ServisTipi.Fuar)]          = "Bahçelievler'deki firmalar için Ankara fuar alanlarına stand ve ekipman taşımalarında zamanında teslim planlaması yapılmaktadır.",
        [("bahcelievler", ServisTipi.Kamyon)]        = "Bahçelievler'deki büyük 3+1 ve 4+1 dairelerden Ankara'ya 12 ton kamyon ile tek seferlik büyük ev taşıması E-5 aksından verimli yürütülmektedir.",
        [("bahcelievler", ServisTipi.Parsiyel)]      = "Bahçelievler'den Ankara'ya birkaç parça mobilya veya kargo için parsiyel araç hizmetimiz ekonomik ve zamanında teslimat sunar.",
        [("bahcelievler", ServisTipi.Ambar)]         = "Bahçelievler'deki evi boşaltıp Ankara'ya taşınma tarihi netleşmemiş müşteriler için güvenli esnek süreli depolama hizmetimiz mevcuttur.",

        // ── BAĞCILAR ──
        [("bagcilar", ServisTipi.Kamyonet)]      = "Bağcılar Merkez ve Kirazlı'daki yüksek katlı yapılarda 3,5 ton kamyonetimiz asansör koordinasyonuyla hızlı yükleme tamamlamaktadır; TEM çıkışı Esenyurt aksından sağlanmaktadır.",
        [("bagcilar", ServisTipi.Sehirlerarasi)] = "Bağcılar'dan TEM'e Bağcılar çevreyolundan bağlanan araç, sabah 07:00 öncesi yüklemeyle Ankara'ya aynı gün teslimatı tamamlamaktadır.",
        [("bagcilar", ServisTipi.EvdenEve)]      = "Göztepe ve Mahmutbey mahallelerindeki konutlarda asansör koordinasyonu ve söküm-montaj dahil kapsamlı ev taşıması yapılmaktadır.",
        [("bagcilar", ServisTipi.Ofis)]          = "Bağcılar'daki ticari işletmelerin Ankara'ya kurumsal taşımalarında IT paketleme ve gece çalışma seçeneği sunulmaktadır.",
        [("bagcilar", ServisTipi.Fuar)]          = "Bağcılar'daki firmalar için Ankara fuar alanlarına taşınan stand ve ekipmanlar özel ambalajla zamanında teslim edilmektedir.",
        [("bagcilar", ServisTipi.Kamyon)]        = "Bağcılar'daki büyük 3+1 ve 4+1 dairelerden Ankara'ya 12–18 ton kamyon ile tek seferlik büyük ev taşıması verimli yürütülmektedir.",
        [("bagcilar", ServisTipi.Parsiyel)]      = "Bağcılar'dan Ankara'ya az eşya için parsiyel araç hizmetimiz belirli günlerde düzenli sefer yaparak ekonomik teslimat sunar.",
        [("bagcilar", ServisTipi.Ambar)]         = "Bağcılar'daki evi boşaltıp Ankara'ya geçiş tarihini bekleyen müşteriler için güvenli esnek süreli depolama hizmetimiz mevcuttur.",

        // ── ESENLER ──
        [("esenler", ServisTipi.Kamyonet)]      = "Esenler'in Büyük Otogar'a alışkın büyük araç trafiği ortamında 3,5 ton kamyonetimiz konut mahallelerine sorunsuz erişmektedir.",
        [("esenler", ServisTipi.Sehirlerarasi)] = "Esenler'den Bağcılar aksıyla TEM'e bağlanan araç, sabah yüklemesiyle Ankara'ya aynı gün teslimatı tamamlamaktadır.",
        [("esenler", ServisTipi.EvdenEve)]      = "Turgut Reis ve Nene Hatun mahallelerindeki konutlarda asansör koordinasyonu ve söküm-montaj dahil kapsamlı ev taşıması yapılmaktadır.",
        [("esenler", ServisTipi.Ofis)]          = "Esenler'deki ticari işletmelerin Ankara'ya kurumsal taşımalarında IT paketleme ve gece çalışma seçeneği sunulmaktadır.",
        [("esenler", ServisTipi.Fuar)]          = "Esenler'deki firmalar için Ankara fuar taşımalarında stand ve ekipmanlar özel ambalajla zamanında teslim edilmektedir.",
        [("esenler", ServisTipi.Kamyon)]        = "Esenler'deki büyük dairelerden Ankara'ya 12 ton kamyon ile tek seferlik büyük ev taşıması verimli yürütülmektedir.",
        [("esenler", ServisTipi.Parsiyel)]      = "Esenler'den Ankara'ya az eşya için parsiyel araç hizmetimiz ekonomik ve zamanında teslimat sunar.",
        [("esenler", ServisTipi.Ambar)]         = "Esenler'deki evi boşaltıp Ankara'ya taşınma tarihi netleşmemiş müşteriler için güvenli esnek süreli depolama hizmetimiz mevcuttur.",

        // ── BAYRAMPAŞA ──
        [("bayrampasa", ServisTipi.Kamyonet)]      = "Bayrampaşa Merkez ve Muratpaşa mahallelerinde 3,5 ton kamyonetimiz dar sokaklara uyum sağlamakta; geniş arterlere yakın adreslerde kamyon da sorunsuz çalışmaktadır.",
        [("bayrampasa", ServisTipi.Sehirlerarasi)] = "Bayrampaşa'dan E-5 veya Zeytinburnu aksıyla TEM'e bağlanan araç, sabah yüklemesiyle Ankara'ya aynı gün teslimatı tamamlamaktadır.",
        [("bayrampasa", ServisTipi.EvdenEve)]      = "Kocatepe ve İsmetpaşa mahallelerindeki yüksek katlı yapılarda asansör koordinasyonu ve söküm-montaj dahil kapsamlı ev taşıması yapılmaktadır.",
        [("bayrampasa", ServisTipi.Ofis)]          = "Bayrampaşa'daki ticari işletmelerin Ankara'ya kurumsal taşımalarında IT paketleme ve gece çalışma seçeneği sunulmaktadır.",
        [("bayrampasa", ServisTipi.Fuar)]          = "Bayrampaşa'daki firmalar için Ankara fuar alanlarına stand ve ekipman taşımalarında zamanında teslim planlaması yapılmaktadır.",
        [("bayrampasa", ServisTipi.Kamyon)]        = "Bayrampaşa'daki 3+1 ve büyük dairelerden Ankara'ya 12 ton kamyon ile tek seferlik büyük ev taşıması E-5 aksından verimli yürütülmektedir.",
        [("bayrampasa", ServisTipi.Parsiyel)]      = "Bayrampaşa'dan Ankara'ya birkaç parça mobilya veya kargo için parsiyel araç hizmetimiz ekonomik ve zamanında teslimat sunar.",
        [("bayrampasa", ServisTipi.Ambar)]         = "Bayrampaşa'daki evi boşaltıp Ankara'ya taşınma tarihi netleşmemiş müşteriler için güvenli esnek süreli depolama hizmetimiz mevcuttur.",

        // ── GAZİOSMANPAŞA ──
        [("gaziosmanpasa", ServisTipi.Kamyonet)]      = "Gaziosmanpaşa'nın yoğun sokak dokusunda 3,5 ton kamyonetimiz dar aralıklara kolaylıkla girmekte; Yenidoğan'daki dönüşüm yapılarında asansör koordinasyonu uygulanmaktadır.",
        [("gaziosmanpasa", ServisTipi.Sehirlerarasi)] = "Gaziosmanpaşa'dan Sultangazi veya Eyüpsultan aksından TEM'e bağlanan araç, sabah yüklemesiyle Ankara'ya aynı gün teslimatı tamamlamaktadır.",
        [("gaziosmanpasa", ServisTipi.EvdenEve)]      = "Barbaros ve Karadeniz mahallelerindeki konutlarda asansör koordinasyonu ve söküm-montaj dahil kapsamlı ev taşıması yapılmaktadır.",
        [("gaziosmanpasa", ServisTipi.Ofis)]          = "Gaziosmanpaşa'daki ticari işletmelerin Ankara'ya kurumsal taşımalarında IT paketleme ve gece çalışma seçeneği sunulmaktadır.",
        [("gaziosmanpasa", ServisTipi.Fuar)]          = "Gaziosmanpaşa'daki firmalar için Ankara fuar alanlarına taşınan stand ve ekipmanlar özel ambalajla zamanında teslim edilmektedir.",
        [("gaziosmanpasa", ServisTipi.Kamyon)]        = "Gaziosmanpaşa'daki 3+1 ve büyük dairelerden Ankara'ya 12 ton kamyon ile tek seferlik büyük ev taşıması verimli yürütülmektedir.",
        [("gaziosmanpasa", ServisTipi.Parsiyel)]      = "Gaziosmanpaşa'dan Ankara'ya az eşya için parsiyel araç hizmetimiz ekonomik ve zamanında teslimat sunar.",
        [("gaziosmanpasa", ServisTipi.Ambar)]         = "Gaziosmanpaşa'daki evi boşaltıp Ankara'ya taşınma tarihi netleşmemiş müşteriler için güvenli esnek süreli depolama hizmetimiz mevcuttur.",

        // ── SULTANGAZİ ──
        [("sultangazi", ServisTipi.Kamyonet)]      = "Cebeci ve Uğur Mumcu mahallelerindeki yeni konut sitelerinde 3,5 ton kamyonetimiz asansör koordinasyonuyla hızlı yükleme tamamlamaktadır.",
        [("sultangazi", ServisTipi.Sehirlerarasi)] = "Sultangazi'den Arnavutköy veya Eyüpsultan aksından TEM'e bağlanan araç, sabah yüklemesiyle Ankara'ya aynı gün teslimatı tamamlamaktadır.",
        [("sultangazi", ServisTipi.EvdenEve)]      = "Sultançiftliği ve Habibler mahallelerindeki konutlarda asansör koordinasyonu ve söküm-montaj dahil kapsamlı ev taşıması yapılmaktadır.",
        [("sultangazi", ServisTipi.Ofis)]          = "Sultangazi'deki işletmelerin Ankara'ya kurumsal taşımalarında IT paketleme ve gece çalışma seçeneği sunulmaktadır.",
        [("sultangazi", ServisTipi.Fuar)]          = "Sultangazi'deki firmalar için Ankara fuar alanlarına taşınan stand ve ekipmanlar özel ambalajla zamanında teslim edilmektedir.",
        [("sultangazi", ServisTipi.Kamyon)]        = "Sultangazi'deki büyük 3+1 ve 4+1 dairelerden Ankara'ya 12 ton kamyon ile tek seferlik büyük ev taşıması verimli yürütülmektedir.",
        [("sultangazi", ServisTipi.Parsiyel)]      = "Sultangazi'den Ankara'ya az eşya için parsiyel araç hizmetimiz belirli günlerde düzenli sefer yaparak ekonomik teslimat sunar.",
        [("sultangazi", ServisTipi.Ambar)]         = "Sultangazi'deki evi boşaltıp Ankara'ya taşınma tarihi netleşmemiş müşteriler için güvenli esnek süreli depolama hizmetimiz mevcuttur.",

        // ── KAĞITHANe ──
        [("kagithane", ServisTipi.Kamyonet)]      = "Çağlayan ve Gültepe'nin yenilenmiş konut bloklarında 3,5 ton kamyonetimiz asansör koordinasyonuyla hızlı yükleme tamamlamaktadır; Seyrantepe aksında büyük araçlar da sorunsuz çalışmaktadır.",
        [("kagithane", ServisTipi.Sehirlerarasi)] = "Kağıthane'den Maslak aksıyla TEM'e bağlanan araç, sabah yüklemesiyle Ankara'ya aynı gün teslimatı tamamlamaktadır.",
        [("kagithane", ServisTipi.EvdenEve)]      = "Hamidiye ve Ortabayır mahallelerindeki konutlarda asansör koordinasyonu ve söküm-montaj dahil kapsamlı ev taşıması yapılmaktadır.",
        [("kagithane", ServisTipi.Ofis)]          = "Kağıthane'deki ofis ve iş merkezlerinden Ankara'ya kurumsal taşımalarda IT ekipmanı güvenli paketleme ve gece çalışma seçeneği sunulmaktadır.",
        [("kagithane", ServisTipi.Fuar)]          = "Kağıthane'deki firmalar için Ankara fuar alanlarına taşınan stand ve ekipmanlar özel ambalajla zamanında teslim edilmektedir.",
        [("kagithane", ServisTipi.Kamyon)]        = "Kağıthane'deki 3+1 ve büyük dairelerden Ankara'ya 12 ton kamyon ile tek seferlik büyük ev taşıması Maslak–TEM güzergâhından verimli yürütülmektedir.",
        [("kagithane", ServisTipi.Parsiyel)]      = "Kağıthane'den Ankara'ya az eşya için parsiyel araç hizmetimiz ekonomik ve zamanında teslimat sunar.",
        [("kagithane", ServisTipi.Ambar)]         = "Kağıthane'deki evi boşaltıp Ankara'ya taşınma tarihi netleşmemiş müşteriler için güvenli esnek süreli depolama hizmetimiz mevcuttur.",

        // ── BEYOĞLU ──
        [("beyoglu", ServisTipi.Kamyonet)]      = "Taksim ve Cihangir'in eğimli dar sokaklarında 3,5 ton kamyonetimiz büyük araçların giremediği bölgelere ulaşmakta; gece yükleme saati trafik kısıtlamalarına göre planlanmaktadır.",
        [("beyoglu", ServisTipi.Sehirlerarasi)] = "Beyoğlu'ndan Maslak veya Şişli aksıyla TEM'e bağlanan araç, sabah erken yüklemeyle Ankara'ya aynı gün teslimatı tamamlamaktadır.",
        [("beyoglu", ServisTipi.EvdenEve)]      = "Galata ve Karaköy'deki tarihi yapılarda merdiven taşıması, Pera bölgesindeki modern konutlarda ise asansör koordinasyonuyla kapsamlı ev nakliyesi yapılmaktadır.",
        [("beyoglu", ServisTipi.Ofis)]          = "Beyoğlu'ndaki kreatif, medya ve teknoloji firmalarının Ankara'ya ofis taşımalarında IT ekipmanı ve arşiv için gece çalışma seçeneği standart olarak sunulmaktadır.",
        [("beyoglu", ServisTipi.Fuar)]          = "Beyoğlu'ndaki reklam ve etkinlik firmalarının Ankara fuar alanlarına taşınan stand ve ekipmanları özel ambalajla korunmakta; fuar öncesi teslim planlanmaktadır.",
        [("beyoglu", ServisTipi.Kamyon)]        = "Harbiye ve Nişantaşı aksındaki büyük dairelerden Ankara'ya 12 ton kamyon ile tek seferlik büyük ev taşıması sabah erken yüklemeyle başlatılmaktadır.",
        [("beyoglu", ServisTipi.Parsiyel)]      = "Beyoğlu'ndan Ankara'ya birkaç parça mobilya veya kargo için parsiyel araç hizmetimiz ekonomik ve zamanında teslimat sunar.",
        [("beyoglu", ServisTipi.Ambar)]         = "Beyoğlu'ndaki evi boşaltıp Ankara'ya taşınma tarihi netleşmemiş müşteriler eşyalarını güvenli depomuzda esnek süreyle saklayabilmektedir.",

        // ── FATİH ──
        [("fatih", ServisTipi.Kamyonet)]      = "Aksaray ve Samatya'nın tarihi sokaklarında 3,5 ton kamyonetimiz büyük araçların erişemediği bölgelere ulaşmakta; trafik kısıtlamaları gözetilerek yükleme saati planlanmaktadır.",
        [("fatih", ServisTipi.Sehirlerarasi)] = "Fatih'ten Zeytinburnu veya Bayrampaşa aksıyla TEM'e bağlanan araç, sabah trafik yoğunluğu öncesinde Ankara yoluna çıkmaktadır.",
        [("fatih", ServisTipi.EvdenEve)]      = "Kocamustafapaşa ve Balat'taki tarihi yapılarda merdiven taşıması, kentsel dönüşüm alanlarında ise asansör koordinasyonuyla kapsamlı ev taşıması yapılmaktadır.",
        [("fatih", ServisTipi.Ofis)]          = "Fatih'teki ticari ve küçük ölçekli ofislerin Ankara'ya taşımalarında IT paketleme ve kurumsal fatura ile profesyonel hizmet sunulmaktadır.",
        [("fatih", ServisTipi.Fuar)]          = "Fatih'teki firmalar için Ankara fuar taşımalarında trafik kısıtlamaları gözetilerek sabah erken kalkış planlanmakta; zamanında teslimat garanti edilmektedir.",
        [("fatih", ServisTipi.Kamyon)]        = "Fatih'teki büyük konutlarda kamyon erişimi uygun saatler ve cadde bazında değerlendirilerek, gerektiğinde kamyonet kombinasyonuyla organize edilmektedir.",
        [("fatih", ServisTipi.Parsiyel)]      = "Fatih'ten Ankara'ya birkaç parça eşya veya kargo için parsiyel araç hizmetimiz ekonomik ve zamanında teslimat sunar.",
        [("fatih", ServisTipi.Ambar)]         = "Fatih'teki evi boşaltıp Ankara'ya taşınma tarihi netleşmemiş müşteriler eşyalarını güvenli depomuzda esnek süreyle saklayabilmektedir.",

        // ── EYÜPSULTAN ──
        [("eyupsultan", ServisTipi.Kamyonet)]      = "Alibeyköy'ün yoğun konut mahallelerinde 3,5 ton kamyonetimiz dar sokaklara uyum sağlamakta; Göktürk'ün geniş villa bölgelerinde ise büyük araçlar da sorunsuz çalışmaktadır.",
        [("eyupsultan", ServisTipi.Sehirlerarasi)] = "Eyüpsultan'dan Arnavutköy aksıyla TEM'e bağlanan araç, sabah yüklemesiyle Ankara'ya aynı gün teslimatı tamamlamaktadır.",
        [("eyupsultan", ServisTipi.EvdenEve)]      = "Göktürk'teki villa konutlardan Ankara'ya değerli mobilya ve büyük ev eşyaları özel ambalajla korunarak kapsamlı ev taşıması yapılmaktadır.",
        [("eyupsultan", ServisTipi.Ofis)]          = "Eyüpsultan'daki işletmelerin Ankara'ya kurumsal taşımalarında IT paketleme ve gece çalışma seçeneği sunulmaktadır.",
        [("eyupsultan", ServisTipi.Fuar)]          = "Eyüpsultan'daki firmalar için Ankara fuar alanlarına taşınan stand ve ekipmanlar özel ambalajla zamanında teslim edilmektedir.",
        [("eyupsultan", ServisTipi.Kamyon)]        = "Göktürk ve Nişanca'daki büyük konutlardan Ankara'ya 12–18 ton kamyon ile tek seferlik sigortalı büyük ev taşıması yapılmaktadır.",
        [("eyupsultan", ServisTipi.Parsiyel)]      = "Eyüpsultan'dan Ankara'ya az eşya için parsiyel araç hizmetimiz ekonomik ve zamanında teslimat sunar.",
        [("eyupsultan", ServisTipi.Ambar)]         = "Eyüpsultan'daki evi boşaltıp Ankara'ya taşınma tarihi netleşmemiş müşteriler için güvenli esnek süreli depolama hizmetimiz mevcuttur.",

        // ── SARIYER ──
        [("sariyer", ServisTipi.Kamyonet)]      = "Yeniköy ve Tarabya'nın Boğaz kıyısındaki dar sokaklarında 3,5 ton kamyonetimiz büyük araçların erişemeyeceği yalı ve köşklere ulaşım sağlamaktadır.",
        [("sariyer", ServisTipi.Sehirlerarasi)] = "Sarıyer'den Maslak aksıyla TEM'e bağlanan araç, sabah erken yüklemeyle Boğaz trafiğini aşarak Ankara'ya aynı gün teslimatı tamamlamaktadır.",
        [("sariyer", ServisTipi.EvdenEve)]      = "İstinye ve Büyükdere'deki modern yapılarda asansör koordinasyonu, Yeniköy ve Tarabya'daki tarihi konutlarda ise kat kat taşıma ile kapsamlı ev nakliyesi gerçekleştirilmektedir.",
        [("sariyer", ServisTipi.Ofis)]          = "Sarıyer'deki iş yerleri ve Maslak aksındaki ofislerin Ankara'ya kurumsal taşımalarında IT ekipmanı güvenli paketleme ve gece seçeneği sunulmaktadır.",
        [("sariyer", ServisTipi.Fuar)]          = "Sarıyer'deki firmalar için Ankara fuar alanlarına taşınan stand ve ekipmanlar özel ambalajla fuar tarihinden önce teslim edilmektedir.",
        [("sariyer", ServisTipi.Kamyon)]        = "Zekeriyaköy ve İstinye'deki büyük konutlardan Ankara'ya değerli mobilya ve villa eşyaları 12–18 ton kamyon ile sigortalı taşınmaktadır.",
        [("sariyer", ServisTipi.Parsiyel)]      = "Sarıyer'den Ankara'ya birkaç parça eşya veya kargo için parsiyel araç hizmetimiz ekonomik çözüm sunar.",
        [("sariyer", ServisTipi.Ambar)]         = "Sarıyer'deki evi boşaltıp Ankara'ya taşınma tarihi netleşmemiş müşteriler eşyalarını güvenli depomuzda esnek süreyle saklayabilmektedir.",

        // ── ZEYTİNBURNU ──
        [("zeytinburnu", ServisTipi.Kamyonet)]      = "Merkezefendi ve Seyitnizam'daki konut bloklarında 3,5 ton kamyonetimiz asansör koordinasyonuyla hızlı yükleme tamamlamaktadır; Kazlıçeşme sanayi aksında büyük araçlar da sorunsuz çalışmaktadır.",
        [("zeytinburnu", ServisTipi.Sehirlerarasi)] = "Zeytinburnu'ndan E-5 aksıyla Ankara güzergâhına doğrudan çıkan araç, sabah yüklemesiyle aynı gün Ankara adresine teslimat sağlamaktadır.",
        [("zeytinburnu", ServisTipi.EvdenEve)]      = "Veliefendi ve Nuripaşa mahallelerindeki konutlarda asansör koordinasyonu ve söküm-montaj dahil kapsamlı ev taşıması yapılmaktadır.",
        [("zeytinburnu", ServisTipi.Ofis)]          = "Zeytinburnu'ndaki sanayi ve ticari ofislerin Ankara'ya kurumsal taşımalarında IT paketleme ve gece çalışma seçeneği sunulmaktadır.",
        [("zeytinburnu", ServisTipi.Fuar)]          = "Zeytinburnu'ndaki firmalar için Ankara fuar alanlarına taşınan stand ve ekipmanlar özel ambalajla zamanında teslim edilmektedir.",
        [("zeytinburnu", ServisTipi.Kamyon)]        = "Zeytinburnu'ndaki büyük konut ve sanayi işletmelerinden Ankara'ya 12 ton kamyon ile tek seferlik büyük taşıma E-5 aksından verimli yürütülmektedir.",
        [("zeytinburnu", ServisTipi.Parsiyel)]      = "Zeytinburnu'ndan Ankara'ya birkaç parça mobilya veya kargo için parsiyel araç hizmetimiz ekonomik ve zamanında teslimat sunar.",
        [("zeytinburnu", ServisTipi.Ambar)]         = "Zeytinburnu'ndaki evi boşaltıp Ankara'ya taşınma tarihi netleşmemiş müşteriler için güvenli esnek süreli depolama hizmetimiz mevcuttur.",
    };
}
