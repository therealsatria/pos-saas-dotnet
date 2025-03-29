#!/bin/bash

# Stop and remove containers
docker-compose -f ../docker/docker-compose.yml down -v

# Cleanup unused volumes
docker volume prune -f
