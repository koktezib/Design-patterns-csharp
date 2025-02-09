# Abstract Factory Pattern

The **Abstract Factory** pattern is a creational design pattern that provides an interface for creating families of related or dependent objects without specifying their concrete classes.

## Why Use Abstract Factory?

The **Abstract Factory** pattern is useful when:
- A system needs to be independent of how its objects are created.
- Objects need to be created as part of a family with consistent dependencies.
- Code should be open for extension but closed for modification (following the Open-Closed Principle).

## Directory Structure

The project follows this structure to represent the core elements of the **Abstract Factory** pattern:

- **AbstractFactory/** – Contains the abstract class or interface defining the contract for creating families of related products.
- **AbstractProducts/** – Includes interfaces or abstract classes for the product families.
- **ConcreteFactory/** – Implements the **AbstractFactory**, defining the creation logic for specific product families.
- **ConcreteProducts/** – Contains concrete implementations of products that belong to a specific product family.

This organization ensures a clear separation of concerns and promotes scalability when introducing new product families.
