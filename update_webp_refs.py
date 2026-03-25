import os
import re
import glob

views_dir = r"C:\Users\Melih\source\repos\IstanbulAnkaraNakliyat\IstanbulAnkaraNakliyat\Views"
webp_dir = r"C:\Users\Melih\source\repos\IstanbulAnkaraNakliyat\IstanbulAnkaraNakliyat\wwwroot\img\galeri"

# Get all webp files that exist
webp_files = set(os.path.splitext(os.path.basename(f))[0] for f in glob.glob(os.path.join(webp_dir, "*.webp")))

updated_files = 0
for cshtml in glob.glob(os.path.join(views_dir, "**", "*.cshtml"), recursive=True):
    with open(cshtml, 'r', encoding='utf-8') as f:
        content = f.read()

    # Replace galeri img references
    new_content = re.sub(r'(img/galeri/galeri\d+)\.jpeg', r'\1.webp', content)
    new_content = re.sub(r'(img/galeri/galeri\d+)\.jpg', r'\1.webp', new_content)

    # Replace blog img references
    new_content = re.sub(r'(img/blog/[^"\']+)\.jpg', r'\1.webp', new_content)
    new_content = re.sub(r'(img/blog/[^"\']+)\.jpeg', r'\1.webp', new_content)

    if new_content != content:
        with open(cshtml, 'w', encoding='utf-8') as f:
            f.write(new_content)
        updated_files += 1
        print(f"Updated: {cshtml}")

print(f"Done. Updated {updated_files} .cshtml files.")
