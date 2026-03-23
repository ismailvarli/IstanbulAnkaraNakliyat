/* İstanbul Ankara Nakliyat — site.js (vanilla JS, no jQuery) */

(function () {
    'use strict';

    /* ── Mobil Menü ──────────────────────────────────────────── */
    var toggle = document.getElementById('navToggle');
    var menu   = document.getElementById('mobileMenu');

    if (toggle && menu) {
        toggle.addEventListener('click', function () {
            var isOpen = menu.classList.toggle('open');
            toggle.classList.toggle('open', isOpen);
            toggle.setAttribute('aria-expanded', isOpen ? 'true' : 'false');
            menu.setAttribute('aria-hidden',      isOpen ? 'false' : 'true');
        });

        // Menü linkine tıklanınca kapat
        menu.querySelectorAll('a').forEach(function (link) {
            link.addEventListener('click', function () {
                menu.classList.remove('open');
                toggle.classList.remove('open');
                toggle.setAttribute('aria-expanded', 'false');
                menu.setAttribute('aria-hidden', 'true');
            });
        });

        // Dışına tıklanınca kapat
        document.addEventListener('click', function (e) {
            if (!menu.contains(e.target) && !toggle.contains(e.target)) {
                menu.classList.remove('open');
                toggle.classList.remove('open');
                toggle.setAttribute('aria-expanded', 'false');
                menu.setAttribute('aria-hidden', 'true');
            }
        });
    }

    /* ── Desktop Dropdown (hover + 250ms gecikme) ────────────── */
    document.querySelectorAll('.nav-dropdown').forEach(function (item) {
        var timer;
        var ddToggle = item.querySelector('.nav-dropdown-toggle');

        function openDropdown() {
            clearTimeout(timer);
            item.classList.add('open');
            ddToggle.setAttribute('aria-expanded', 'true');
        }

        function closeDropdown() {
            timer = setTimeout(function () {
                item.classList.remove('open');
                ddToggle.setAttribute('aria-expanded', 'false');
            }, 250);
        }

        item.addEventListener('mouseenter', openDropdown);
        item.addEventListener('mouseleave', closeDropdown);

        // Dropdown menü üzerindeyken timer'ı iptal et
        var ddMenu = item.querySelector('.dropdown-menu');
        if (ddMenu) {
            ddMenu.addEventListener('mouseenter', function () { clearTimeout(timer); });
            ddMenu.addEventListener('mouseleave', closeDropdown);
        }
    });

    /* ── Mobil Dropdown ──────────────────────────────────────── */
    document.querySelectorAll('.mobile-dropdown-toggle').forEach(function (btn) {
        btn.addEventListener('click', function () {
            var item = btn.closest('.mobile-dropdown');
            var isOpen = item.classList.toggle('open');
            btn.setAttribute('aria-expanded', isOpen ? 'true' : 'false');
        });
    });

    /* ── FAQ Accordion ───────────────────────────────────────── */
    document.querySelectorAll('.faq-question').forEach(function (btn) {
        btn.addEventListener('click', function () {
            var item = btn.closest('.faq-item');
            var isOpen = item.classList.contains('open');
            // Diğerlerini kapat (isteğe bağlı)
            document.querySelectorAll('.faq-item.open').forEach(function (o) {
                if (o !== item) o.classList.remove('open');
            });
            item.classList.toggle('open', !isOpen);
        });
    });

    /* ── Yıldız Puanlama ─────────────────────────────────────── */
    var starPicker = document.getElementById('starPicker');
    var puanInput  = document.getElementById('puanInput');

    if (starPicker && puanInput) {
        var starBtns = starPicker.querySelectorAll('.star-btn');
        var current  = 5;

        function lightStars(val) {
            starBtns.forEach(function (btn) {
                btn.classList.toggle('lit', parseInt(btn.dataset.val) <= val);
            });
        }

        lightStars(current);

        starBtns.forEach(function (btn) {
            btn.addEventListener('mouseenter', function () { lightStars(parseInt(btn.dataset.val)); });
            btn.addEventListener('mouseleave', function () { lightStars(current); });
            btn.addEventListener('click', function () {
                current = parseInt(btn.dataset.val);
                puanInput.value = current;
                lightStars(current);
            });
        });
    }

    /* ── Aktif nav linki ─────────────────────────────────────── */
    var currentPath = window.location.pathname.replace(/\/$/, '') || '/';
    document.querySelectorAll('.nav-links a').forEach(function (a) {
        var href = a.getAttribute('href').replace(/\/$/, '') || '/';
        if (href === currentPath) {
            a.classList.add('active');
            a.setAttribute('aria-current', 'page');
        }
    });

})();
