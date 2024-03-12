# BackendReto2
dotnet ef database update  -p ./Data/TeatroBack.Data.csproj -s ./API/TeatroBack.API.csproj
dotnet tool install --global dotnet-ef --version 7.*
Comentar docker de la api, y levantar solo el contenedor de la base de datos


añadir al docker compose al final 
api:
    #container_name: apiContainer
    #image: apidb-dockerdemo:1.2
    ports:
      - 8001:80
    networks:
      - backend
    build:
      context: .
      dockerfile: API/Dockerfile
    depends_on:
      - db