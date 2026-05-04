namespace IstanbulAnkaraNakliyat.Models;

public enum ServisTipi
{
    Kamyonet,
    Sehirlerarasi,
    EvdenEve,
    Ofis,
    Fuar,
    Kamyon,
    Parsiyel,
    Ambar
}

public class IstanbulIlceServisModel
{
    public required string IlceAdi      { get; init; }
    public required string IlceSlug     { get; init; }
    public required string IlceOzellik  { get; init; }
    public required string[] Mahalleler { get; init; }
    public required (string Name, string Slug)[] YakinIlceler { get; init; }
    public required ServisTipi Servis   { get; init; }

    public string ServisAdi => Servis switch
    {
        ServisTipi.Kamyonet    => "Kamyonet Nakliyat",
        ServisTipi.Sehirlerarasi => "Şehirlerarası Nakliyat",
        ServisTipi.EvdenEve    => "Evden Eve Nakliyat",
        ServisTipi.Ofis        => "Ofis Nakliyat",
        ServisTipi.Fuar        => "Fuar Nakliyat",
        ServisTipi.Kamyon      => "Kamyon Nakliyat",
        ServisTipi.Parsiyel    => "Parsiyel Nakliyat",
        ServisTipi.Ambar       => "Ambar Nakliyat",
        _                      => "Nakliyat"
    };

    public string ServisSlug => Servis switch
    {
        ServisTipi.Kamyonet    => "kamyonet",
        ServisTipi.Sehirlerarasi => "sehirlerarasi",
        ServisTipi.EvdenEve    => "evden-eve",
        ServisTipi.Ofis        => "ofis",
        ServisTipi.Fuar        => "fuar",
        ServisTipi.Kamyon      => "kamyon",
        ServisTipi.Parsiyel    => "parsiyel",
        ServisTipi.Ambar       => "ambar",
        _                      => "nakliyat"
    };

    public string ServisAciklama => Servis switch
    {
        ServisTipi.Kamyonet => "1+1 daire, stüdyo ve öğrenci eşyası için ekonomik kamyonet taşıma",
        ServisTipi.Sehirlerarasi => "C Tipi Yetki Belgeli, 450 km sigortalı şehirlerarası taşıma",
        ServisTipi.EvdenEve => "Ambalaj, söküm, montaj dahil kapıdan kapıya ev taşıma",
        ServisTipi.Ofis => "IT ekipmanı, sunucu, arşiv ve kasa dahil kurumsal ofis taşıma",
        ServisTipi.Fuar => "Stand, display ve sergi malzemesi için fuar öncesi zamanında taşıma",
        ServisTipi.Kamyon => "2+1, 3+1 ve büyük daireler için tam araçlı kamyon taşıma",
        ServisTipi.Parsiyel => "Az eşya için paylaşımlı araç ile ekonomik parça taşıma",
        ServisTipi.Ambar => "Güvenli depolama ve esnek tarihli şehirlerarası taşıma kombine hizmeti",
        _ => "Profesyonel nakliyat hizmeti"
    };

    public string FiyatBaslangic => Servis switch
    {
        ServisTipi.Kamyonet => "4.500 ₺",
        ServisTipi.Sehirlerarasi => "8.000 ₺",
        ServisTipi.EvdenEve => "8.000 ₺",
        ServisTipi.Ofis => "Keşif Sonrası",
        ServisTipi.Fuar => "3.500 ₺",
        ServisTipi.Kamyon => "10.000 ₺",
        ServisTipi.Parsiyel => "1.200 ₺",
        ServisTipi.Ambar => "1.500 ₺",
        _ => "Keşif Sonrası"
    };

    public string PageUrl =>
        $"https://www.istanbulankaranakliyat.tr/{IlceSlug}-ankara-{ServisSlug}-nakliyat";

    public string SeoTitle =>
        $"{IlceAdi} Ankara {ServisAdi} | {IlceOzellik.Split(',')[0].Trim()} 2026";

    public string SeoDescription => Servis switch
    {
        ServisTipi.Kamyonet =>
            $"{IlceAdi}'den Ankara'ya kamyonet nakliyat. 1+1 daire ve öğrenci eşyası için ekonomik, hızlı taşıma. {Mahalleler[0]}, {Mahalleler[1]} ve tüm {IlceAdi} mahallelerinden. 0532 543 68 37",
        ServisTipi.Sehirlerarasi =>
            $"{IlceAdi}'den Ankara'ya şehirlerarası nakliyat. C Tipi Yetki Belgeli, sigortalı 450 km taşıma. {string.Join(", ", Mahalleler.Take(3))} mahallelerinden profesyonel nakliyat. 0532 543 68 37",
        ServisTipi.EvdenEve =>
            $"{IlceAdi}'den Ankara'ya evden eve nakliyat. Ambalaj, söküm, montaj dahil kapıdan kapıya taşıma. {Mahalleler[0]} ve tüm {IlceAdi} mahallelerinden sigortalı. 0532 543 68 37",
        ServisTipi.Ofis =>
            $"{IlceAdi}'den Ankara'ya ofis nakliyat. IT ekipmanı, sunucu ve arşiv dahil kurumsal taşıma. Gece ve hafta sonu seçeneği. {IlceAdi} ilçesinden: 0532 543 68 37",
        ServisTipi.Fuar =>
            $"{IlceAdi}'den Ankara'ya fuar nakliyat. Stand, display ve sergi malzemeleri sigortalı ve zamanında teslim. {IlceAdi} ilçesinden fuar taşımacılığı: 0532 543 68 37",
        ServisTipi.Kamyon =>
            $"{IlceAdi}'den Ankara'ya kamyon nakliyat. 2+1, 3+1 büyük ev taşıma için tam araç. {Mahalleler[0]} ve {IlceAdi} tüm mahallelerinden sigortalı: 0532 543 68 37",
        ServisTipi.Parsiyel =>
            $"{IlceAdi}'den Ankara'ya parsiyel nakliyat. Az eşya için paylaşımlı araç seçeneği. Tek koliden mobilyaya ekonomik taşıma. {IlceAdi} ilçesinden: 0532 543 68 37",
        ServisTipi.Ambar =>
            $"{IlceAdi}'den Ankara'ya ambar nakliyat. Güvenli depolama ve esnek tarihli taşıma kombine hizmeti. {IlceAdi} ilçesinden: 0532 543 68 37",
        _ =>
            $"{IlceAdi}'den Ankara'ya profesyonel nakliyat. Sigortalı, kapıdan kapıya taşıma. 0532 543 68 37"
    };

    public string H1 => $"{IlceAdi} Ankara {ServisAdi}";
    public string MahallelerJoined => string.Join(", ", Mahalleler);

    public string IlceDetay   => IstanbulIlceDetaylar.GetIlceDetay(IlceSlug);
    public string ServisDetay => IstanbulIlceDetaylar.GetServisDetay(IlceSlug, Servis);
}
