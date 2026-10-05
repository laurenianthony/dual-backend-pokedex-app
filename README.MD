# Dual-Backend Pokédex
======================

A full-stack Pokédex application with one frontend that can switch between two REST API backends:

- ASP.NET Core (C#) — Port 5000
- Spring Boot (Java) — Port 8080

## Project Structure

FINAL ASPNET/
└── pokedex aspnet/       # ASP.NET Core backend

FINAL OOP/
└── FINAL POKEDEX/        # Spring Boot backend

pokedex-frontend.html     # Frontend

## Requirements

- .NET 8 SDK
- JDK 17+
- Maven
- Modern web browser

## Run the Project

### 1. ASP.NET Core

    cd "FINAL ASPNET/pokedex aspnet"
    dotnet run

Runs on:

    http://localhost:5000

### 2. Spring Boot

    cd "FINAL OOP/FINAL POKEDEX"
    mvn spring-boot:run

Runs on:

    http://localhost:8080

### 3. Frontend

Open:

    pokedex-frontend.html

Or use VS Code Live Server.

## Backend Switcher

Use the frontend buttons to switch between:

- ASP.NET → http://localhost:5000
- Spring → http://localhost:8080

Both backends must be running to switch between them.

## Tech Stack

- HTML5
- CSS3
- JavaScript
- C# / ASP.NET Core
- Java / Spring Boot
- REST API
- JSON

## Project Goal

Demonstrate how one frontend can work with two different backend technologies using REST APIs and JSON.
