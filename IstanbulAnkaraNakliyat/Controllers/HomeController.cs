using IstanbulAnkaraNakliyat.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
