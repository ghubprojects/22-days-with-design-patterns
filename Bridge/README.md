# Bridge

> **Bridge** is a structural design pattern that lets you split a large class or a set of closely related classes into two separate hierarchies—abstraction and implementation—which can be developed independently of each other.

<p align="center">
  <img width="640" src="https://refactoring.guru/images/patterns/content/bridge/bridge.png" />
</p>

## Structure

<p align="center">
  <img width="560" src="https://refactoring.guru/images/patterns/diagrams/bridge/structure-en.png" />
</p>

## Applicability

- Use the Bridge pattern when you want to divide and organize a monolithic class that has several variants of some functionality (for example, if the class can work with various database servers).
- Use the pattern when you need to extend a class in several orthogonal (independent) dimensions.
- Use the pattern when you need to extend a class in several orthogonal (independent) dimensions.

## Pros and Cons
- You can create platform-independent classes and apps.
- The client code works with high-level abstractions. It isn’t exposed to the platform details.
- *Open/Closed Principle*. You can introduce new abstractions and implementations independently from each other.
- *Single Responsibility Principle*. You can focus on high-level logic in the abstraction and on platform details in the implementation.
<br/><br/>  
- You might make the code more complicated by applying the pattern to a highly cohesive class.