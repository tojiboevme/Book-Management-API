# Book Management API

## Overview
This project is a **RESTful API** developed using **ASP.NET Core Web API** for managing books. It supports basic CRUD operations and additional features such as tracking book views, calculating popularity scores, and managing book details securely.

## Objective
The main objective of this API is to allow users to:
- Add, update, delete, and retrieve book information.
- Track book views and popularity scores dynamically.
- Secure endpoints using JWT-based authentication (optional feature).

## Technologies Used
- **Programming Language:** C#
- **Framework:** .NET 8 or .NET 9
- **Database:** SQL Server (with Entity Framework Core or Dapper) or MongoDB (using MongoDB C# Driver)
- **Architecture:** 3-layered architecture (Models, Data Access, API Layer)

## Features
### CRUD Operations
- **Add**: Add new books (single or bulk).
- **Update**: Update book details.
- **Delete**: Soft delete books (single or bulk).
- **Retrieve**:
  - Get a list of books with pagination (most popular to least popular).
  - Get detailed information for a specific book.

### Validation Rules
- Prevent adding books with duplicate names.
- Implement necessary validations to ensure data integrity.

### Additional Functionalities
- **Book Views Tracking**: Tracks how many times each book is accessed.
- **Popularity Score Calculation** (Optional):
  - Formula: `BookViews * 0.5 + YearsSincePublished * 2`
- **Age of the Book**: Tracks how long since the book was published.

### Security (Optional)
- JWT-based authentication to secure API endpoints and restrict access to authorized users only.

## Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/book-management-api.git
   ```
2. Navigate to the project directory:
   ```bash
   cd book-management-api
   ```
3. Install dependencies:
   ```bash
   dotnet restore
   ```
4. Update the `appsettings.json` with your database connection string.
5. Run the API:
   ```bash
   dotnet run
   ```

## API Documentation
This project uses **Swagger** for API documentation. After running the project, navigate to:
```
http://localhost:5000/swagger
```
