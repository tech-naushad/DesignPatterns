## What is the Decorator Pattern?
The Decorator Pattern is a structural design pattern used to extend the functionality of objects dynamically
without modifying their code. It is widely used in scenarios where you want to add responsibilities 
to individual objects rather than entire classes.

## Real-Life Example: Coffee Shop
Consider a coffee shop where a customer can order a simple coffee, but they can also add extra ingredients like milk, 
sugar, or caramel. Instead of modifying the Coffee class every time a new add-on is introduced, 
we use the Decorator Pattern.


## Benefits of Using Adapter Pattern
✅ Flexible and Scalable: Easily add new decorators without modifying existing code.
✅ Open/Closed Principle: Allows extension of functionality without modifying existing classes.
✅ Composition Over Inheritance: Avoids class explosion that would occur if we used subclassing for every coffee variation.

This pattern is widely used in logging, data stream processing, UI components, and middleware pipelines in C# applications.