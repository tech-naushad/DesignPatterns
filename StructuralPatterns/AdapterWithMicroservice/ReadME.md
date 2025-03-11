## What is the Decorator Pattern?
The Decorator Pattern is a structural design pattern used to extend the functionality of objects dynamically
without modifying their code. It is widely used in scenarios where you want to add responsibilities 
to individual objects rather than entire classes.

## Real-Life Example: multiple middlewares for Microservices
let’s consider a situation where you need to integrate multiple middlewares into a microservices architecture 
that involve different external services (e.g., authentication, logging, rate limiting, etc.), 
and some of these services have different interfaces. The Adapter pattern can help you adapt the different services 
to a consistent interface, ensuring smooth integration in the middleware pipeline.


## Benefits of Using Adapter Pattern in this scenerio
Decoupling: Each middleware is encapsulated in its adapter, keeping its implementation separate from the core application logic. This makes it easier to update or change middleware without affecting other parts of the system.

Uniform Interface: The adapter pattern allows different middlewares to be unified under a common IUnifiedMiddleware interface, making it easier to integrate third-party services or legacy middlewares.

Scalability: New middlewares can be added without having to refactor the existing ones. As new services (e.g., security, monitoring) are introduced, you can simply create new adapters.

Maintainability: The system is easier to maintain because each middleware is isolated in its class, and its interaction with the rest of the pipeline is mediated by the adapter. This improves testability and debugging.

Flexibility: This architecture provides flexibility in adding more complex logic or changing existing middleware logic without causing disruptions.