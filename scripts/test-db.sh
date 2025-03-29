#!/bin/bash

# Test database connectivity
echo "Testing PostgreSQL connection from app container..."
docker exec pos-saas-app-1 dotnet ef database update --dry-run

echo "Testing PostgreSQL with pg_isready..."
docker exec pos-saas-postgres-1 pg_isready -U postgres -d pos_saas

echo "Checking migrations status..."
docker exec pos-saas-app-1 dotnet ef migrations list
