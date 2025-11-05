# Rotas da API do ReFeitep

***Observação importante:***

Todas as rotas com o caractere 📱 devem usar o Header `X-Device-Token: <token_dispositivo>`, com o token do dispositivo autenticado.

Todas as rotas com o caractere 🔒 devem usar o Header `Authorization: Bearer <seu_token_jwt_aqui>`, com o token do usuário autenticado.

Todas as rotas

## Dispositivo

Rota responsável pela autenticação dos dispositivos Android.

|Verbo|Rota|Descrição|
|---|---|---|
|`POST`|`/disp`|Login do dispositivo|
|`POST`|`/disp/` 📱|Logout do dispositivo|

### DTO

***Requisição***
```json
{
    "deviceinfo": "string"
}
```

***Reposta:***
```json
{
    "token": "string"
}
```

## Auth

Rota responsável pela autenticação dos usuários do app.

|Verbo|Rota|Descrição|
|---|---|---|
|`POST`|`/auth`|Login do usuário|
|`DELETE`|🔒`/auth/logout`|Logout do dispositivo|

### DTO

***Requisição:***
```json
{
    "usuario": "string",
    "senha": "string"
}
```

***Reposta:***
```json
{
    "token": "string"
}
```

## Clientes

|Verbo|Rota|Descrição|
|---|---|---|
|`GET`|🔒`/clientes`|Retorna todos os clientes|
|`GET`|🔒`/clientes/{id}` |Retorna um único cliente com base no {id}|
|`POST`|🔒`/clientes` |Inclui um novo cliente|
|`PUT`|🔒`/clientes/{id}`|Substitui as informações do cliente com base no {id}|
|`DELETE`|🔒`/clientes/{id}`|Exclui um cliente com base no {id}|

### DTO

```json
{
    "id": "number",
    "usuario": {
        "id": "number",
        "nome": "string",
        "email": "string",
        "senha": "string"
    },
    "cpf": "string",
    "ra": "string",
    "usuarioid": "number"
}
```

## Produtos

|Verbo|Rota|Descrição|
|---|---|---|
|`GET`|🔒`/produtos`|Retorna todos os produtos|
|`GET`|🔒`/produtos/{id}`|Retorna um único produto com base no {id}|
|`POST`|🔒`/produtos`|Inclui um novo produto|
|`PUT`|🔒`/produtos/{id}`|Substitui as informações do produto com base no {id}|
|`DELETE`|🔒`/produtos/{id}`|Exclui um produto com base no {id}|

### DTO

```json
{
    "id": "number",
    "usuario": {
        "id": "number",
        "nome": "string",
        "email": "string",
        "senha": "string"
    },
    "cpf": "string",
    "ra": "string",
    "usuarioid": "number"
}
```

## Pedidos

|Verbo|Rota|Descrição|
|---|---|---|
|`GET`|📱`/pedidos`|Retorna todos os pedidos|
|`GET`|📱`/pedidos/{id}`|Retorna um único pedido com base no {id}|
|`GET`|📱`/pedidos/disp`|Retorna todos os pedidos de um dispositivo|
|`GET`|🔒`/pedidos/cliente`|Retorna todos os pedidos de um cliente|
|`POST`|📱`/pedidos`|Inclui um novo pedido|
|`PUT`|📱`/pedidos/{id}`|Substitui as informações do pedido com base no {id}|
|`DELETE`|📱`/pedidos/{id}`|Exclui um pedido com base no {id}|


### DTO

```json
{
    "id": "number",
    "status": "number (1=Aberto, 2=Preparando, 3=Concluido, 4=Cancelado)",
    "clienteid": "number",
    "dispositivoid": "number",
    "data": "DateTime",
    "total": "number",
    "Cliente": {
    "id": "number",
        "usuario": {
            "id": "number",
            "nome": "string",
            "email": "string"
        },
        "cpf": "string",
        "ra": "string",
        "usuarioid": "number"
    },
    "Dispositivo": {
        "Id": "string",
        "Token": "token"
    }
}
```
