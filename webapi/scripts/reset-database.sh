#!/bin/bash

# Navigasi ke direktori webapi
cd "$(dirname "$0")/.."

# Mengecek apakah EF Core tools sudah terinstall
if ! dotnet ef > /dev/null 2>&1; then
    echo "Error: Entity Framework Core tools tidak ditemukan."
    echo "Menginstall EF Core tools..."
    dotnet tool install --global dotnet-ef
fi

# Konfirmasi reset database
echo "⚠️ PERINGATAN: Database akan dihapus dan dibuat ulang. Semua data akan hilang. ⚠️"
read -p "Apakah Anda yakin ingin mereset database? (y/n): " -n 1 -r
echo

if [[ ! $REPLY =~ ^[Yy]$ ]]; then
    echo "Reset database dibatalkan."
    exit 0
fi

# Menghapus database
echo "Menghapus database..."
dotnet ef database drop --force

# Mengecek status
if [ $? -eq 0 ]; then
    echo "✅ Database berhasil dihapus."
else
    echo "❌ Gagal menghapus database."
    exit 1
fi

# Mengaplikasikan migrations untuk membuat database baru
echo "Membuat database baru dan mengaplikasikan migrations..."
dotnet ef database update

# Mengecek status
if [ $? -eq 0 ]; then
    echo "✅ Database berhasil dibuat ulang."
else
    echo "❌ Gagal membuat ulang database."
    exit 1
fi

echo "Reset database selesai." 