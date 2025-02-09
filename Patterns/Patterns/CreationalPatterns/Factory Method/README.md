# Factory Method Pattern

The **Factory Method** pattern is a creational design pattern that provides an interface for creating objects but allows subclasses to alter the type of objects that will be created.

## Why Use Factory Method?

The **Factory Method** pattern is useful when:
- A class needs to delegate the instantiation of objects to its subclasses.
- Object creation needs to be decoupled from its implementation.
- A system should be open for extension but closed for modification (Open-Closed Principle).

## Directory Structure

The project is organized in the following way to reflect the core elements of the **Factory Method** pattern:

- **AbstractProduct/** – Contains the abstract class or interface defining the structure of the product.
- **ConcreteProducts/** – Implements the abstract product, providing specific versions of the product.
- **Creator/** – Defines the abstract method for creating products.
- **ConcreteCreators/** – Implements the **Creator** and defines the factory method to create specific products.

This structure improves maintainability and flexibility by keeping object creation logic separate from business logic.
