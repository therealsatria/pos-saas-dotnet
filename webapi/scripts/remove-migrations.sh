#!/bin/bash

# Navigasi ke direktori webapi
cd "$(dirname "$0")/.."

# Mengecek apakah EF Core tools sudah terinstall
if ! dotnet ef > /dev/null 2>&1; then
    echo "Error: Entity Framework Core tools tidak ditemukan."
    echo "Menginstall EF Core tools..."
    dotnet tool install --global dotnet-ef
fi

# Menampilkan daftar migrations sebelum penghapusan
echo "Daftar migrations saat ini:"
dotnet ef migrations list

echo "Menghapus migration terakhir..."
dotnet ef migrations remove

# Mengecek status
if [ $? -eq 0 ]; then
    echo "✅ Migration terakhir berhasil dihapus."
else
    echo "❌ Gagal menghapus migration."
    exit 1
fi

# Menampilkan daftar migrations setelah penghapusan
echo "Daftar migrations setelah penghapusan:"
dotnet ef migrations list 