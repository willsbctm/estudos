# System Design

## Índice
1. [Scale from Zero to Millions of Users](#scale-from-zero-to-millions-of-users)
    1. [Single Server Setup](#single-server-setup)


## Scale from Zero to Millions of Users

### Single Server Setup

```mermaid
---
title: Single Server Setup
---
graph TD
    dns((DNS))
    subgraph user
        web
        mobile
    end
    subgraph server
        webserver
    end
    user -- mysite.com --> dns
    dns -- IP address --> user
    user -- mysite.com --> server
    user -- api.mysite.com --> server
```

Add database
```mermaid
---
title: Database
---
graph TD
    dns((DNS))
    subgraph user
        web
        mobile
    end
    subgraph databasearea [Database]
        database
    end
    subgraph server
        webserver
    end
    user -- mysite.com --> dns
    dns -- IP address --> user
    user -- mysite.com --> server
    user -- api.mysite.com --> server
    server -- read/write/update --> databasearea
    databasearea -- return data --> server
```

#### Banco SQL x NoSQL

#### CAP
- Consistência:
    Todos os clientes veem os mesmos dados ao mesmo tempo. Indenpdendente do nó.
- Disponibilidade:
    Toda solicitação terá uma resposta mesmo que um ou mais nós estejam desativados
- Particionamento:
    Deve continuar a funcionar mesmo ocorra ou mais falhas de comunicação entre os nós do sistema

<!--

<script src="https://cdn.jsdelivr.net/npm/mermaid@10.8.0/dist/mermaid.min.js"></script>

 -->