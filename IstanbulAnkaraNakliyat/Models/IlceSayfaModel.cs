namespace IstanbulAnkaraNakliyat.Models;

public enum NakliyatYon { IstanbulToAnkara, AnkaraToIstanbul }

public class IlceSayfaModel
{
    public required string DisplayName { get; init; }
    public required string Slug         { get; init; }
    public required string Ozellik      { get; init; }   // Kısa ilçe tanımı
    public required string[] Mahalleler { get; init; }
    public required NakliyatYon Yon     { get; init; }
    public required (string Name, string Slug)[] YakinIlceler { get; init; }

    // ── Hesaplanan özellikler ────────────────────────────────
    public string KalkisIl       => Yon == NakliyatYon.IstanbulToAnkara ? "İstanbul" : "Ankara";
    public string VarisIl        => Yon == NakliyatYon.IstanbulToAnkara ? "Ankara"   : "İstanbul";
    public string YonSuffix      => Yon == NakliyatYon.IstanbulToAnkara ? "ankara-nakliyat" : "istanbul-nakliyat";
    public string H1             => $"{DisplayName} {VarisIl} Nakliyat";
    public string SeoTitle       => $"{DisplayName} {VarisIl} Nakliyat | Profesyonel Ev Taşıma Hizmeti";
    public string SeoDescription =>
        $"{KalkisIl} {DisplayName} ilçesinden {VarisIl}'ya güvenli nakliyat hizmeti. " +
        $"{string.Join(", ", Mahalleler[..Math.Min(3, Mahalleler.Length)])} ve tüm mahallelerden " +
        $"kapıdan kapıya taşıma. Sigortalı araç, profesyonel ekip. " +
        $"Ücretsiz teklif: 0532 543 68 37";
    public string PageUrl        =>
        $"https://www.istanbulankaranakliyat.tr/{Slug}-{YonSuffix}";
    public string MahallelerJoined => string.Join(", ", Mahalleler);
}
