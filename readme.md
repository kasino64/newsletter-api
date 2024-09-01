# Newsletter API

This project is a basic API built with **.NET Core**, **SQL Server**, and **Docker**. It handles newsletter subscriptions, allowing you to save, list, and remove email subscriptions.

## Project Overview

The Newsletter API is designed to showcase proficiency in:

- **.NET Core Development**: Utilizing .NET Core for building scalable and efficient APIs.
- **Entity Framework Core**: Implementing data persistence and management using SQL Server.
- **Dockerization**: Containerizing the application for consistent development, testing, and deployment environments.
- **RESTful API Design**: Adhering to REST principles to ensure the API is easy to use, scalable, and maintainable.
- **Swagger Integration**: Providing an interactive interface for exploring and testing API endpoints.

## Getting Started

### Prerequisites

Ensure you have the following installed:

- [Docker](https://www.docker.com/get-started)
- [Docker Compose](https://docs.docker.com/compose/install/)

### Running the Application

To build and run the Docker containers, navigate to the project directory and execute the following command:

```bash
docker-compose up --build
```

### Accessing the API
Once the containers are running, you can access the API's Swagger UI at:

```bash
http://localhost:5038/swagger/index.html
```

The Swagger UI provides a user-friendly interface to explore the API endpoints, view documentation, and execute test requests.