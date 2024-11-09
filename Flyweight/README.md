﻿# Flyweight

> **Flyweight** is a structural design pattern that lets you fit more objects into the available amount of RAM by sharing common parts of state between multiple objects instead of keeping all of the data in each object.

<p align="center">
  <img width="640" src="https://refactoring.guru/images/patterns/content/flyweight/flyweight.png" />
</p>

## Structure

<p align="center">
  <img width="648" src="https://refactoring.guru/images/patterns/diagrams/flyweight/structure.png" />
</p>

## Applicability

- Use the Flyweight pattern only when your program must support a huge number of objects which barely fit into available RAM.

## Pros and Cons
- You can save lots of RAM, assuming your program has tons of similar objects.
<br/><br/>  
- You might be trading RAM over CPU cycles when some of the context data needs to be recalculated each time somebody calls a flyweight method.
- The code becomes much more complicated. New team members will always be wondering why the state of an entity was separated in such a way.