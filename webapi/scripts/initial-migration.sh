#!/bin/bash

# Navigasi ke direktori webapi
cd "$(dirname "$0")/.."

# Mengecek apakah EF Core tools sudah terinstall
if ! dotnet ef > /dev/null 2>&1; then
    echo "Error: Entity Framework Core tools tidak ditemukan."
    echo "Menginstall EF Core tools..."
    dotnet tool install --global dotnet-ef
fi

# Membuat migration awal
echo "Membuat migration awal 'InitialCreate'..."
dotnet ef migrations add InitialCreate --output-dir Infrastructures/Data/Migrations

# Mengecek status
if [ $? -eq 0 ]; then
    echo "✅ Migration awal berhasil dibuat."
else
    echo "❌ Gagal membuat migration awal."
    exit 1
fi

# Mengaplikasikan migration ke database
echo "Mengaplikasikan migration ke database..."
dotnet ef database update

# Mengecek status
if [ $? -eq 0 ]; then
    echo "✅ Database berhasil diinisialisasi."
else
    echo "❌ Gagal menginisialisasi database."
    exit 1
fi

echo "Inisialisasi database selesai." 