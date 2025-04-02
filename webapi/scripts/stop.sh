#!/bin/bash

# Navigate to docker-compose directory
cd "$(dirname "$0")/.."

# Stop and remove containers
docker-compose down

# Cleanup unused volumes (optional)
echo "Membersihkan volume yang tidak digunakan..."
docker volume prune -f

echo "Docker containers dihentikan."
