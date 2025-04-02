#!/bin/bash

# Navigate to docker-compose directory
cd "$(dirname "$0")/.."

# Test database connectivity
echo "Menguji koneksi ke PostgreSQL..."
if docker exec pos_saas_db pg_isready -U postgres -d pos_saas; then
  echo "✅ Koneksi ke PostgreSQL berhasil."
else
  echo "❌ Koneksi ke PostgreSQL gagal."
  exit 1
fi

# Test database tables (optional)
echo "Mengecek daftar tabel di database..."
docker exec pos_saas_db psql -U postgres -d pos_saas -c "\dt"

echo "Pengujian selesai."
