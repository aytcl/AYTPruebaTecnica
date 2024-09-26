# Prueba de conocimientos técnicos

## Requisitos de Software

- IDE con soporte para Dotnet y CSharp
- Dotnet 8

## Contexto

La API está construida en CSharp (ultima versión estable), Dotnet 8 y su estructura está diseñada utilizando el enfoque de MinimalApi, entendiendo que ese tipo de estructura puede ser un poco desconocido se ha separado los endpoint en clases independientes lo que en MVC se podría conocer como "Controlador".

Esta prueba solo se evaluarán sus conocimientos técnicos en el desarrollo y en el entendimiento de conceptos, no es necesario conocimientos en MinimalApi para conseguir los objetivos de las tareas.

La aplicación es una API que retorna Smartphones con ciertas características de cada no, se ha utilizado una API pública para obtener la información.

Ejemplo:

```json
[
  {
    "id": 1,
    "name": "Google Pixel 6 Pro",
    "data": {
      "color": "Cloudy White",
      "capacity": "128 GB"
    }
  },
  {
    "id": 2,
    "name": "Apple iPhone 12 Mini, 256GB, Blue"
  },
  {
    "id": 3,
    "name": "Apple iPhone 12 Pro Max",
    "data": {
      "color": "Cloudy White"
    }
  },
  {
    "id": 4,
    "name": "Apple iPhone 11, 64GB",
    "data": {
      "color": "Purple",
      "price": 389.99
    }
  }
]
```

## Estructura

Como se ha mencionado anteriormente, la estructura sigue el concepto de MinimalApi, la solución tiene el siguiente esquema:

```text
- AYTPruebaTecnica
-- src
--- Api
---- Endpoints
---- Entities
---- Interfaces
---- Services
---- appsettings.json
---- Program.cs
```

_Endpoints_: Contiene los endpoint a consultar ("Controlador").
_Interfaces_: Interfaces utilizadas en los servicios (se deben inyectar como dependencia)
_Services_: Servicios con clases de implementación de las interfaces
_Entities_: Entidades para el mapeo de información de la API pública

## Tareas a realizar

- Compile la aplicación y resuelva si no lo hace
- Tarea 2
- Tarea 3
