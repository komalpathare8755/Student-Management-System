# Student Management System API

A RESTful ASP.NET Core Web API for managing student records using SQL Server and Entity Framework Core. The application follows a clean layered architecture with Repository and Service patterns.

---

## Features

- Create a Student
- Get All Students
- Get Student by ID
- Update Student
- Delete Student
- SQL Server Integration
- Entity Framework Core
- Swagger API Documentation
- Repository Pattern
- Service Layer
- DTO Pattern
- Dependency Injection

---

## Technologies Used

- ASP.NET Core Web API
- C#
- .NET 10
- Entity Framework Core
- SQL Server
- SQL Server Management Studio (SSMS)
- Swagger / OpenAPI
- Visual Studio 2026

---

## Project Structure

```
StudentManagementSystem
│
├── Controllers
├── Models
├── DTOs
├── Data
├── Interfaces
├── Repository
├── Services
├── Middleware
├── Helpers
├── Program.cs
├── appsettings.json
└── README.md
```

---

## Prerequisites

Before running the project, install:

- Visual Studio 2026
- SQL Server
- SQL Server Management Studio (SSMS)
- .NET SDK

---

## Database Setup

### 1. Clone the repository

```bash
git clone https://github.com/YOUR_USERNAME/StudentManagementSystem.git
```

### 2. Open the project in Visual Studio

Open the solution (.sln) file.

### 3. Update Connection String

Open:

```
appsettings.json
```

Modify:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost\\MSSQLSERVER01;Database=StudentDB;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

Replace the server name if your SQL Server instance is different.

### 4. Apply Database Migration

Open Package Manager Console and run:

```powershell
Update-Database
```

This will create the StudentDB database and Students table.

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

The API will start and Swagger will open automatically.

---

## Swagger URL

```
https://localhost:7170/swagger
```

(The port may differ on your machine.)

---

## API Endpoints

| Method | Endpoint | Description |
|---------|----------|-------------|
| GET | /api/Student | Get all students |
| GET | /api/Student/{id} | Get student by ID |
| POST | /api/Student | Create a student |
| PUT | /api/Student/{id} | Update student |
| DELETE | /api/Student/{id} | Delete student |

---

## Sample Request

### Create Student

POST

```
/api/Student
```

Request Body

```json
{
  "name": "Komal",
  "email": "komal@gmail.com",
  "age": 24,
  "course": "Computer Engineering"
}
```

Response

```json
{
  "id": 1,
  "name": "Komal",
  "email": "komal@gmail.com",
  "age": 24,
  "course": "Computer Engineering"
}
```

---

## Architecture

```
Controller
      ↓
Service
      ↓
Repository
      ↓
Entity Framework Core
      ↓
SQL Server
```

---

## Author

**Komal Pathare**

Bachelor of Engineering (Computer Engineering)

PG-DAC, CDAC IET Pune

GitHub: https://github.com/YOUR_USERNAME
