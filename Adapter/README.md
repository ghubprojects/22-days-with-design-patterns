﻿# Adapter

> **Adapter** is a structural design pattern that allows objects with incompatible interfaces to collaborate.

<p align="center">
  <img width="640" src="https://refactoring.guru/images/patterns/content/adapter/adapter-en.png" />
</p>

## Structure

<p align="center">
  <img width="580" src="https://refactoring.guru/images/patterns/diagrams/adapter/structure-object-adapter.png" />
</p>

## Applicability

- Use the Adapter class when you want to use some existing class, but its interface isn’t compatible with the rest of your code.
- Use the pattern when you want to reuse several existing subclasses that lack some common functionality that can’t be added to the superclass.

## Pros and Cons
- *Single Responsibility Principle*. You can separate the interface or data conversion code from the primary business logic of the program.
- *Open/Closed Principle*. You can introduce new types of adapters into the program without breaking the existing client code, as long as they work with the adapters through the client interface.
<br/><br/>  
- The overall complexity of the code increases because you need to introduce a set of new interfaces and classes. Sometimes it’s simpler just to change the service class so that it matches the rest of your code.