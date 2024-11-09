# Composite

> **Composite** is a structural design pattern that lets you compose objects into tree structures and then work with these structures as if they were individual objects.

<p align="center">
  <img width="640" src="https://refactoring.guru/images/patterns/content/composite/composite.png" />
</p>

## Structure

<p align="center">
  <img width="360" src="https://refactoring.guru/images/patterns/diagrams/composite/structure-en.png" />
</p>

## Applicability

- Use the Composite pattern when you have to implement a tree-like object structure.
- Use the pattern when you want the client code to treat both simple and complex elements uniformly.

## Pros and Cons
- You can work with complex tree structures more conveniently: use polymorphism and recursion to your advantage.
- *Open/Closed Principle*. You can introduce new element types into the app without breaking the existing code, which now works with the object tree.
<br/><br/>  
- It might be difficult to provide a common interface for classes whose functionality differs too much. In certain scenarios, you’d need to overgeneralize the component interface, making it harder to comprehend.