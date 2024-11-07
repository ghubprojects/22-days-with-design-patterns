# Abstract Factory

> **Abstract Factory** is a creational design pattern that lets you produce families of related objects without specifying their concrete classes.

<p align="center">
  <img width="640" src="https://refactoring.guru/images/patterns/content/abstract-factory/abstract-factory-en.png" />
</p>

## Structure

<p align="center">
  <img width="720" src="https://refactoring.guru/images/patterns/diagrams/abstract-factory/structure.png" />
</p>

## Applicability

- Use the Abstract Factory when your code needs to work with various families of related products, but you don’t want it to depend on the concrete classes of those products—they might be unknown beforehand or you simply want to allow for future extensibility.
- Consider implementing the Abstract Factory when you have a class with a set of Factory Methods that blur its primary responsibility.

## Pros and Cons
- You can be sure that the products you’re getting from a factory are compatible with each other.
- You avoid tight coupling between concrete products and client code.
- *Single Responsibility Principle*. You can extract the product creation code into one place, making the code easier to support.
- *Open/Closed Principle*. You can introduce new variants of products without breaking existing client code.
<br/><br/>  
- The code may become more complicated than it should be, since a lot of new interfaces and classes are introduced along with the pattern.