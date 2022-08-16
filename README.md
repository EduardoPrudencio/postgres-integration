# postgres-integration

Esse projeto tem como objetivo registrar um exemplo de criação de api que integre com Postgres.
Para isso criamos nosso banco de dados com Docker

...
docker run -d \
	--name estudo-postgres \
      -e POSTGRES_USER=postgress_user \
	-e POSTGRES_PASSWORD=  \
	-e PGDATA=/var/lib/postgresql/data/pgdata \
	-p 5432:5432 \
	postgres
	
Para usarmos o Entity Framework inserimos os pacotes Microsoft.EntityFrameworkCore, Microsoft.EntityFrameworkCore.Tools e Npgsql.EntityFrameworkCore.PostgresSQL.

