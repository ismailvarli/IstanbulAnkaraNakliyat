namespace IstanbulAnkaraNakliyat.Models;

public class Teklif
{
    public string Ad          { get; set; } = "";
    public string Telefon     { get; set; } = "";
    public string Yon         { get; set; } = ""; // "istanbul-ankara" | "ankara-istanbul"
    public string DaireTipi   { get; set; } = ""; // "1+1" | "2+1" | "3+1" | "4+1" | "ofis" | "parca"
    public string Tarih       { get; set; } = "";
    public string Not         { get; set; } = "";
    public string Gonderim    { get; set; } = ""; // timestamp
}
