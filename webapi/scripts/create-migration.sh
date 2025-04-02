#!/bin/bash

# Memastikan parameter nama migration diberikan
if [ -z "$1" ]; then
    echo "Error: Nama migration harus disediakan."
    echo "Penggunaan: ./create-migration.sh NamaMigration"
    exit 1
fi

# Navigasi ke direktori webapi
cd "$(dirname "$0")/.."

# Mengecek apakah EF Core tools sudah terinstall
if ! dotnet ef > /dev/null 2>&1; then
    echo "Error: Entity Framework Core tools tidak ditemukan."
    echo "Menginstall EF Core tools..."
    dotnet tool install --global dotnet-ef
fi

# Membuat migration baru
echo "Membuat migration '$1'..."
dotnet ef migrations add $1 --output-dir Infrastructures/Data/Migrations

# Mengecek status
if [ $? -eq 0 ]; then
    echo "✅ Migration '$1' berhasil dibuat."
else
    echo "❌ Gagal membuat migration."
    exit 1
fi 