# 🎓 Student Management System API

A RESTful **ASP.NET Core Web API** for managing student records. This project demonstrates a clean layered architecture using **Repository Pattern**, **Service Layer**, **Entity Framework Core**, **JWT Authentication**, **Serilog Logging**, and **Global Exception Handling**.

---

## 📌 Features

- ✅ Student CRUD Operations
- ✅ SQL Server Database Integration
- ✅ Entity Framework Core (Code First)
- ✅ Repository Pattern
- ✅ Service Layer
- ✅ DTO (Data Transfer Objects)
- ✅ Dependency Injection
- ✅ JWT Authentication
- ✅ Authorization using `[Authorize]`
- ✅ Global Exception Handling Middleware
- ✅ Serilog Request Logging
- ✅ Swagger API Documentation

---

## 🛠️ Tech Stack

- ASP.NET Core Web API (.NET 10)
- C#
- SQL Server
- Entity Framework Core
- Swagger / OpenAPI
- JWT Authentication
- Serilog
- Visual Studio 2026
- Git & GitHub

---

## 📂 Project Structure

```
StudentManagementSystem
│
├── Controllers
│   ├── AuthController.cs
│   └── StudentController.cs
│
├── Data
│   └── ApplicationDbContext.cs
│
├── DTOs
│   ├── LoginRequestDto.cs
│   ├── LoginResponseDto.cs
│   ├── StudentCreateDto.cs
│   ├── StudentReadDto.cs
│   └── StudentUpdateDto.cs
│
├── Interfaces
│   ├── IStudentRepository.cs
│   └── IStudentService.cs
│
├── Middleware
│   └── GlobalExceptionMiddleware.cs
│
├── Models
│   └── Student.cs
│
├── Repository
│   └── StudentRepository.cs
│
├── Services
│   ├── JwtService.cs
│   └── StudentService.cs
│
├── Migrations
│
├── Program.cs
├── appsettings.json
└── README.md
```

---

# 🚀 Getting Started

## Prerequisites

Before running the project, install:

- Visual Studio 2026
- .NET 10 SDK
- SQL Server
- SQL Server Management Studio (SSMS)

---

## Clone the Repository

```bash
git clone https://github.com/komalpathare8755/Student-Management-System.git
```

Navigate to the project folder:

```bash
cd StudentManagementSystem
```

---

## Configure Database

Update the connection string in **appsettings.json**

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=StudentDB;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

---

## Apply Migrations

Open **Package Manager Console**

```powershell
Update-Database
```

---

## Run the Application

Press

```
F5
```

or

```
Ctrl + F5
```

Swagger will open automatically.

---

# 📖 API Documentation

Swagger URL

```
https://localhost:7170/swagger
```

---

# 🔐 Authentication

## Login

### Endpoint

```
POST /api/Auth/login
```

### Request

```json
{
  "username": "admin",
  "password": "admin123"
}
```

### Response

```json
{
  "token": "YOUR_JWT_TOKEN"
}
```

Use the generated JWT token in the Authorization header when accessing protected endpoints.

Example:

```
Authorization: Bearer YOUR_TOKEN
```

---

# 📚 Student APIs

| Method | Endpoint | Description |
|---------|----------|-------------|
| GET | `/api/Student` | Get all students |
| GET | `/api/Student/{id}` | Get student by ID |
| POST | `/api/Student` | Create student |
| PUT | `/api/Student/{id}` | Update student |
| DELETE | `/api/Student/{id}` | Delete student |

> **Note:** All Student APIs require JWT Authentication.

---

# 🏗️ Architecture

The project follows a layered architecture:

```
Client
   │
Controllers
   │
Service Layer
   │
Repository Layer
   │
Entity Framework Core
   │
SQL Server
```

---

# 🔄 Project Workflow

1. Client sends a request.
2. Controller receives the request.
3. Service Layer validates business logic.
4. Repository Layer interacts with the database.
5. Entity Framework Core executes SQL queries.
6. Response is returned to the client.

---

# 🔑 JWT Authentication Flow

1. User logs in using `/api/Auth/login`.
2. API validates the credentials.
3. JWT token is generated.
4. Client stores the token.
5. Token is sent with every protected request.
6. `[Authorize]` validates the token before allowing access.

---

# 📝 Logging

The project uses **Serilog** for request logging.

Example log:

```
HTTP GET /api/Student responded 200 in 40 ms
```

---

# ⚠️ Global Exception Handling

Unhandled exceptions are captured using custom middleware and returned as a structured JSON response.

Example:

```json
{
  "success": false,
  "message": "An unexpected error occurred.",
  "error": "Exception Message"
}
```

---

# 📦 Packages Used

- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Tools
- Microsoft.AspNetCore.Authentication.JwtBearer
- Swashbuckle.AspNetCore
- Serilog.AspNetCore
- Serilog.Sinks.Console

---

# 🚀 Future Enhancements

- User Registration
- Database-based Authentication
- Password Hashing
- Role-Based Authorization
- Refresh Tokens
- Unit Testing
- Docker Support
- Azure Deployment
- Pagination & Filtering

---

# 👨‍💻 Author

**Komal Pathare**

- Bachelor of Engineering (Computer Engineering)
- PG-DAC, CDAC IET Pune

**GitHub**

https://github.com/komalpathare8755

---

# 📄 License

This project is created for learning and portfolio purposes.
