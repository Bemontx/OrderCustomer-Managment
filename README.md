# Customer & Order Management System

Sistema de gestión de clientes y pedidos desarrollado bajo los principios de **Clean Architecture**, priorizando el desacoplamiento, la escalabilidad y la facilidad de mantenimiento.

---

## 🏗️ Estructura de la Solución

El proyecto está organizado en 4 capas principales, siguiendo las reglas de dependencia de la Arquitectura Limpia:

### 1. Domain (Núcleo de Negocio)
Es la capa más interna y contiene la lógica empresarial pura. No tiene dependencias externas.
* **Entities:** Definición de los modelos de negocio `Customer` y `Order`.
* **Enums:** Constantes y enumeradores utilizados en las reglas de negocio.

### 2. Application (Casos de Uso)
Define los contratos y la lógica de negocio mediante el patrón **CQRS** (Command Query Responsibility Segregation).
* **Common/Interfaces:** Abstracciones base (ej. `IOrderInterface`, `ICustomerInterface`).
* **Models:** Organizados por entidad, cada uno con la siguiente estructura:
    * **DTOs:** Objetos de transferencia de datos.
    * **Commands:** Operaciones de escritura (Create, Update, Delete).
    * **Queries:** Operaciones de lectura (GetById, GetAll).
    * **Handlers:** Lógica que procesa tanto los Commands como las Queries.

### 3. Infrastructure (Servicios Externos)
Implementa las interfaces definidas en las capas superiores y gestiona el acceso a datos.
* **Persistence:** Configuración del `DbContext` y migraciones.
* **Repository:** Implementación concreta de los repositorios `IOrderRepository` e `ICustomerRepository`.
* **Dependency Injection:** * `InjectionDependency`: Registro de servicios generales.
    * `InfrastructureServiceRegistration`: Configuración de servicios específicos de infraestructura.

### 4. API (Presentación)
Punto de entrada del sistema.
* **Controllers:** Controladores RESTful para exponer las funcionalidades de `Customer` y `Order`.

---

## 📂 Visualización de Carpetas

```text
src/
├── 01. Domain/
│   ├── Entities/
│   │   ├── Customer.cs
│   │   └── Order.cs
│   └── Enums/
├── 02. Application/
│   ├── Common/
│   │   └── Interfaces/
│   └── Models/
│       ├── Customer/
│       │   ├── Commands/
│       │   ├── DTOs/
│       │   ├── Handlers/
│       │   └── Queries/
│       └── Order/
│           ├── Commands/
│           ├── DTOs/
│           ├── Handlers/
│           └── Queries/
├── 03. Infrastructure/
│   ├── DependencyInjection/
│   │   ├── InjectionDependency.cs
│   │   └── InfrastructureServiceRegistration.cs
│   ├── Persistence/
│   │   └── ApplicationDbContext.cs
│   └── Repository/
└── 04. Api/
    └── Controllers/