#!/bin/bash

# Navigasi ke direktori webapi
cd "$(dirname "$0")/.."

# Mengecek apakah EF Core tools sudah terinstall
if ! dotnet ef > /dev/null 2>&1; then
    echo "Error: Entity Framework Core tools tidak ditemukan."
    echo "Menginstall EF Core tools..."
    dotnet tool install --global dotnet-ef
fi

echo "Mengaplikasikan migrations ke database..."

# Menerapkan semua migrations yang belum diaplikasikan
dotnet ef database update

# Mengecek status
if [ $? -eq 0 ]; then
    echo "✅ Database berhasil diupdate."
else
    echo "❌ Gagal mengupdate database."
    exit 1
fi

# Menampilkan status migrations
echo "Status migrations saat ini:"
dotnet ef migrations list 