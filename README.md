# Scriblio-BlogApp-.NET-MVC

Welcome to **Scriblio**, a modern web app designed for creating and managing blogs. Whether you're an aspiring writer, an established author, or just someone looking to share ideas, Scriblio offers a platform to create, edit, and manage blog posts with ease.

This repository contains the full codebase for Scriblio, built with **ASP.NET Core**, **Bootstrap**, and **C#**.

## Features

* **Create and Edit Blog Posts**: Users can easily create and manage their blog posts.
* **Authentication**: Secure login and registration system using ASP.NET Core Identity.
* **Responsive UI**: Built with **Bootstrap**, the application is fully responsive, ensuring a seamless experience across all devices.
* **User Profiles**: Authenticated users can manage their profiles and log out.
* **External Authentication**: Users can log in using external services (like Google, Facebook) if configured.

## Technologies Used

* **ASP.NET Core 6.0** (or your current version)
* **Bootstrap 5**: For responsive and modern UI components
* **ASP.NET Identity**: User authentication and authorization
* **Entity Framework Core**: For data access and management
* **SQL Server** (or other database management system as configured)
* **CSS**: For additional custom styling
* **HTML5**: For markup

## Getting Started

### Prerequisites

To run the project locally, you will need:

* [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet)
* [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (or any other database management system, make sure to update the connection strings in `appsettings.json`)

### Clone the Repository

```bash
(https://github.com/bilalmalikkk/Scriblio-BlogApp-.NET-MVC.git)
```

### Setup the Project

1. Open the solution in **Visual Studio** or your preferred **C# editor**.
2. Build the solution.

### Configure the Database

1. Update your connection string in `appsettings.json` if you're not using SQL Server.
2. Run the following command in the **Package Manager Console** or use **dotnet CLI** to apply the database migrations:

   ```bash
   dotnet ef database update
   ```

### Running the Application

1. After building the solution, run the application using the following command:

   ```bash
   dotnet run
   ```

2. Open your browser and navigate to `http://localhost:5000` to see the app in action.

## Contributing

We welcome contributions! Here's how you can help:

1. **Fork** the repository
2. Create a new **branch** (`git checkout -b feature-xyz`)
3. Make your changes and **commit** them
4. **Push** your changes (`git push origin feature-xyz`)
5. **Create a pull request**

Please make sure to follow the coding conventions and ensure your code is properly tested.

## Acknowledgements

* **Bootstrap** for making the UI development faster and responsive.
* **ASP.NET Core** for the powerful web framework.
* **Entity Framework Core** for seamless data handling.

