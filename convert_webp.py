import os
import glob
from PIL import Image

galeri_dir = r"C:\Users\Melih\source\repos\IstanbulAnkaraNakliyat\IstanbulAnkaraNakliyat\wwwroot\img\galeri"

# Convert all .jpeg files to .webp
jpegs = glob.glob(os.path.join(galeri_dir, "*.jpeg")) + glob.glob(os.path.join(galeri_dir, "*.jpg"))
converted = 0
for jpeg_path in jpegs:
    webp_path = os.path.splitext(jpeg_path)[0] + ".webp"
    if not os.path.exists(webp_path):
        with Image.open(jpeg_path) as img:
            img.save(webp_path, "WEBP", quality=82, method=6)
        converted += 1
        print(f"Converted: {os.path.basename(jpeg_path)} -> {os.path.basename(webp_path)}")
    else:
        print(f"Already exists: {os.path.basename(webp_path)}")

print(f"Done. Converted {converted} files.")

# Also convert blog image
blog_dir = r"C:\Users\Melih\source\repos\IstanbulAnkaraNakliyat\IstanbulAnkaraNakliyat\wwwroot\img\blog"
for jpeg_path in glob.glob(os.path.join(blog_dir, "*.jpg")) + glob.glob(os.path.join(blog_dir, "*.jpeg")):
    webp_path = os.path.splitext(jpeg_path)[0] + ".webp"
    if not os.path.exists(webp_path):
        with Image.open(jpeg_path) as img:
            img.save(webp_path, "WEBP", quality=82, method=6)
        print(f"Converted blog: {os.path.basename(jpeg_path)} -> {os.path.basename(webp_path)}")
    else:
        print(f"Blog already exists: {os.path.basename(webp_path)}")
