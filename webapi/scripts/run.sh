#!/bin/bash

# Navigate to docker-compose directory
cd "$(dirname "$0")/.."

# Build and start containers
docker-compose up -d

# Wait for PostgreSQL
echo "Menunggu PostgreSQL siap..."
while ! docker exec pos_saas_db pg_isready -U postgres -d pos_saas; do
  sleep 2
done

echo "PostgreSQL siap digunakan."

