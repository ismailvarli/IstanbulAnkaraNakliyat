using IstanbulAnkaraNakliyat.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace IstanbulAnkaraNakliyat.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment _env;

        public HomeController(ILogger<HomeController> logger, IWebHostEnvironment env)
        {
            _logger = logger;
            _env    = env;
        }

        public IActionResult Index()
        {
            ViewData["Title"]       = "İstanbul Ankara Nakliyat | Güvenli Ev & Ofis Taşıma";
            ViewData["Description"] = "İstanbul Ankara arası profesyonel nakliyat hizmeti. Ev taşıma, ofis taşıma ve parça eşya taşımacılığında sigortalı, güvenli hizmet. Hemen teklif alın: 0532 543 68 37";
            ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/";
            ViewData["Schema"]      = """
                <script type="application/ld+json">
                {
                    "@context": "https://schema.org",
                    "@type": "MovingCompany",
                    "@id": "https://www.istanbulankaranakliyat.tr/#business",
                    "name": "İstanbul Ankara Nakliyat",
                    "url": "https://www.istanbulankaranakliyat.tr",
                    "telephone": "+905325436837",
                    "email": "istanbulankaranakliyat.tr@gmail.com",
                    "priceRange": "₺₺",
                    "areaServed": [
                        { "@type": "City", "name": "İstanbul" },
                        { "@type": "City", "name": "Ankara" }
                    ],
                    "hasOfferCatalog": {
                        "@type": "OfferCatalog",
                        "name": "Nakliyat Hizmetleri",
                        "itemListElement": [
                            { "@type": "Offer", "itemOffered": { "@type": "Service", "name": "Evden Eve Nakliyat" } },
                            { "@type": "Offer", "itemOffered": { "@type": "Service", "name": "Ofis Taşıma" } },
                            { "@type": "Offer", "itemOffered": { "@type": "Service", "name": "Parça Eşya Taşıma" } }
                        ]
                    }
                }
                </script>
                """;
            var reviewPath = Path.Combine(_env.ContentRootPath, "App_Data", "reviews.json");
            ViewBag.UserReviews = ReviewController.Load(reviewPath).Take(6).ToList();

            return View();
        }

        [HttpGet("/hakkimizda")]
        public IActionResult Hakkimizda()
        {
            ViewData["Title"]       = "Hakkımızda | İstanbul Ankara Nakliyat";
            ViewData["Description"] = "İstanbul Ankara Nakliyat olarak 10 yılı aşkın tecrübemizle güvenilir, sigortalı ve profesyonel nakliyat hizmeti sunuyoruz. Ekibimizi ve değerlerimizi tanıyın.";
            ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/hakkimizda";
            return View();
        }

        [HttpGet("/hizmetler")]
        public IActionResult Hizmetler()
        {
            ViewData["Title"]       = "Hizmetlerimiz | İstanbul Ankara Nakliyat";
            ViewData["Description"] = "İstanbul Ankara arası evden eve nakliyat, ofis taşıma, parça eşya taşıma, eşya depolama ve profesyonel ambalaj hizmetleri. Sigortalı, güvenli taşımacılık.";
            ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/hizmetler";
            return View();
        }

        [HttpGet("/galeri")]
        public IActionResult Galeri()
        {
            ViewData["Title"]       = "Taşıma Galerisi | İstanbul Ankara Nakliyat";
            ViewData["Description"] = "İstanbul Ankara nakliyat süreçlerimizden fotoğraflar. Profesyonel ev taşıma, ofis taşıma ve ambalaj hizmetlerimizi görsellerle inceleyin.";
            ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/galeri";

            var galeriPath = Path.Combine(_env.WebRootPath, "img", "galeri");
            var altTexts = new[]
            {
                "İstanbul Ankara ev taşıma hizmeti",
                "Profesyonel eşya ambalajlama",
                "Nakliyat aracına yükleme",
                "Mobilya koruma ve paketleme",
                "Sigortalı nakliyat ekibi",
                "Ofis taşıma İstanbul Ankara",
                "Parça eşya taşıma hizmeti",
                "Ev eşyası güvenli taşıma",
                "Kırılgan eşya özel ambalaj",
                "İstanbul Ankara nakliyat aracı",
                "Kapıdan kapıya taşımacılık",
                "Profesyonel nakliyat ekibi çalışırken"
            };

            var items = new List<string[]>();
            if (Directory.Exists(galeriPath))
            {
                var exts = new HashSet<string>(StringComparer.OrdinalIgnoreCase) { ".jpg", ".jpeg", ".png", ".webp" };
                var files = Directory.GetFiles(galeriPath)
                    .Where(f => exts.Contains(Path.GetExtension(f)))
                    .OrderBy(Path.GetFileName)
                    .ToList();

                for (int i = 0; i < files.Count; i++)
                    items.Add(new[] { $"/img/galeri/{Path.GetFileName(files[i])}", altTexts[i % altTexts.Length] });
            }

            ViewBag.GalleryItems = items;
            return View();
        }

        [HttpGet("/iletisim")]
        public IActionResult Iletisim()
        {
            ViewData["Title"]       = "İletişim | İstanbul Ankara Nakliyat — 0532 543 68 37";
            ViewData["Description"] = "İstanbul Ankara Nakliyat ile iletişime geçin. 0532 543 68 37 numaralı hattımızı arayın veya WhatsApp ile yazın. Ücretsiz keşif ve teklif için 7/24 hizmetinizdeyiz.";
            ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/iletisim";
            return View();
        }

        [HttpGet("/gizlilik-politikasi")]
        public IActionResult GizlilikPolitikasi()
        {
            ViewData["Title"]       = "Gizlilik Politikası | İstanbul Ankara Nakliyat";
            ViewData["Description"] = "İstanbul Ankara Nakliyat gizlilik politikası. Kişisel verilerinizin nasıl toplandığı, kullanıldığı ve korunduğuna dair bilgi edinin.";
            ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/gizlilik-politikasi";
            ViewData["Noindex"]     = true;
            return View();
        }

        [HttpGet("/kullanim-kosullari")]
        public IActionResult KullanimKosullari()
        {
            ViewData["Title"]       = "Kullanım Koşulları | İstanbul Ankara Nakliyat";
            ViewData["Description"] = "İstanbul Ankara Nakliyat web sitesi kullanım koşulları ve hizmet şartları.";
            ViewData["Canonical"]   = "https://www.istanbulankaranakliyat.tr/kullanim-kosullari";
            ViewData["Noindex"]     = true;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
