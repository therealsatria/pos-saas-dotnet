#!/bin/bash

# Build and start containers
docker-compose -f ../docker/docker-compose.yml up -d --build

# Wait for PostgreSQL
echo "Waiting for PostgreSQL to become ready..."
while ! docker exec pos-saas-postgres-1 pg_isready -U postgres; do
  sleep 2
done

# Run migrations
docker exec pos-saas-app-1 dotnet ef database update
