# Real-time Chat System

A showcase project demonstrating real-time communication capabilities using ASP.NET Core and SignalR. This project highlights my skills in building modern, real-time web applications.

## Project Overview

This is a real-time chat system backend that enables:
- Instant messaging between users
- Group chat functionality
- Real-time message delivery using SignalR
- Cross-Origin Resource Sharing (CORS) support for frontend integration

## Technical Details

Built with:
- ASP.NET Core 9.0
- SignalR for real-time communication
- ConcurrentDictionary for thread-safe user connection management
- OpenAPI/Swagger for API documentation

## Key Features

- **Real-time Chat**: Uses SignalR Hub for instant message delivery
- **Group Chat Support**: Users can join specific chat rooms
- **Connection Management**: Thread-safe user connection tracking
- **CORS Configuration**: Ready for integration with React frontend
- **API Documentation**: Swagger UI available in development mode

## Architecture Highlights

- **Clean Architecture**: Separation of concerns with distinct folders for Models, Hubs, and Services
- **Thread Safety**: Uses ConcurrentDictionary for managing user connections
- **Scalable Design**: Built with group chat support and room management
- **Frontend Integration Ready**: CORS configured for React client at http://localhost:5173