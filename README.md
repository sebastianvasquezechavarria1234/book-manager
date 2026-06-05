# 📚 Book Manager System (ExamenMVC)

![.NET](https://img.shields.io/badge/.NET_8.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![ASP.NET Core MVC](https://img.shields.io/badge/ASP.NET_MVC-005697?style=for-the-badge&logo=dot-net&logoColor=white)
![Entity Framework Core](https://img.shields.io/badge/EF_Core-33A06F?style=for-the-badge)
![SQL Server](https://img.shields.io/badge/SQL_Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white)

📖 **Book Manager** is a robust web application built with **ASP.NET Core MVC** and **Entity Framework Core**. It is designed to manage a library or bookstore ecosystem, providing full CRUD (Create, Read, Update, Delete) operations for managing books, authors, categories, publishers, and users.

This project was developed as a technical evaluation/exam (`ExamenMVC`) to demonstrate proficiency in modern web development using C# and the .NET ecosystem.

---

## ✨ Features

The application provides a complete interface to manage the following core entities:

*   **📚 Books (Libros):** Maintain the catalog of available books.
*   **✍️ Authors (Autores):** Keep track of the writers behind the books.
*   **🔖 Categories (Categorías):** Organize books by their respective genres.
*   **🏢 Publishers (Editoriales):** Manage publishing companies.
*   **👥 Users (Usuarios):** Manage the users of the system.
*   **🐾 Animals (Animales):** Additional entity managed within the database.

Each module includes a user-friendly web interface with seamless operations to **Create**, **View Details**, **Update**, and **Delete** records.

## 🛠️ Technology Stack

*   **Backend:** C#, .NET 8.0, ASP.NET Core MVC
*   **ORM:** Entity Framework Core 9.0 (`Microsoft.EntityFrameworkCore.SqlServer`)
*   **Database:** Microsoft SQL Server
*   **Frontend:** Razor Views `.cshtml` (HTML, CSS)
*   **Architecture:** MVC (Model-View-Controller)

## 🗄️ Database Setup

The project uses Entity Framework Core to connect to a SQL Server database. To run the application, make sure you configure your connection strings properly:

1. Open `book-manager/appsettings.json`.
2. Update the `conexion` and `conexionCrud` connection strings with your local SQL Server instance credentials.
3. Run the Entity Framework Core migrations or ensure the database schema is created.

## 🚀 How to Run the Project

1. Clone this repository.
2. Open the solution file `book-manager.sln` in **Visual Studio** or **JetBrains Rider**.
3. Restore NuGet packages.
4. Set the `book-manager` project as the startup project.
5. Press `F5` or click **Run** to build and start the application in your default browser.

Alternatively, you can run it via the .NET CLI:
```bash
cd book-manager
dotnet restore
dotnet build
dotnet run
```

