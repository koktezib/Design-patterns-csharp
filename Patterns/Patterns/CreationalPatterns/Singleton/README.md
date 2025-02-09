# Singleton Pattern

The **Singleton** pattern is a creational design pattern that ensures a class has only one instance and provides a global access point to that instance.

## Why Use Singleton?

The **Singleton** pattern is useful when:
- There should be only one instance of a class controlling access to shared resources (e.g., logging, configuration, thread pool, database connections).
- A centralized global instance is required throughout the application.

## Implementation

Typically, Singleton is implemented by:
1. **Making the constructor private** to prevent direct instantiation.
2. **Providing a static method** to retrieve the single instance.
3. **Using lazy initialization** or a static instance.

