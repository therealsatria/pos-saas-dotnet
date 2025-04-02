#!/bin/bash

# Navigasi ke direktori webapi
cd "$(dirname "$0")/.."

# Mengecek apakah EF Core tools sudah terinstall
if ! dotnet ef > /dev/null 2>&1; then
    echo "Error: Entity Framework Core tools tidak ditemukan."
    echo "Menginstall EF Core tools..."
    dotnet tool install --global dotnet-ef
fi

# Konfirmasi penghapusan database
echo "⚠️ PERINGATAN: Semua data dalam database akan dihapus. ⚠️"
read -p "Apakah Anda yakin ingin menghapus database? (y/n): " -n 1 -r
echo

if [[ ! $REPLY =~ ^[Yy]$ ]]; then
    echo "Penghapusan database dibatalkan."
    exit 0
fi

echo "Menghapus database..."
dotnet ef database drop --force

# Mengecek status
if [ $? -eq 0 ]; then
    echo "✅ Database berhasil dihapus."
else
    echo "❌ Gagal menghapus database."
    exit 1
fi

echo "Database telah dihapus." 