# EventEase-Blazor-App

EventEase is a Blazor-based web application for managing and browsing events.  
This project was developed using Microsoft Copilot to assist with code generation, debugging, and optimization.

## Features

- Event listing with reusable EventCard component
- Navigation between event details and registration pages
- Registration form with validation (name, email)
- User session tracking
- Attendance tracking per event
- Performance optimization using virtualization

## Technologies

- Blazor (ASP.NET Core)
- C#
- Microsoft Copilot

## Copilot Usage Summary

### Activity 1 – Generation
Copilot was used to:
- Generate the EventCard component
- Suggest Razor syntax and data binding
- Assist with routing setup

### Activity 2 – Debugging & Optimization
Copilot helped:
- Identify null binding issues and add validation
- Fix routing errors and implement fallback pages
- Improve performance using Virtualize and @key

### Activity 3 – Advanced Features
Copilot assisted in:
- Creating a validated registration form using EditForm
- Implementing session state using services
- Building an attendance tracking system
- Applying best practices for clean code and structure

## How to Run

1. Open the solution in Visual Studio
2. Build and run the project
3. Navigate to `/events`
