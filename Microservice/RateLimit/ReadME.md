## Rate Limit Microservice Design Pattern
Rate limiting is a crucial design pattern in microservices to prevent abuse, ensure fair resource allocation, 
and protect services from being overwhelmed. It controls the number of requests 
a client (user, service, or API consumer) can make within a given time window.

## Why Use Rate Limiting in Microservices?
### Prevent Abuse & DDoS Attacks – Stops malicious users from flooding services.
### Fair Usage – Ensures all consumers get a fair share of resources.
### Optimize Performance – Prevents API overuse from degrading system performance.
### Cost Control – Helps in controlling API usage in paid-tier services.


## Implementation
Architecture
### Client Request → Sent to Rate Limit Service.
### Rate Limit Check → Using Redis as distributed cache with docker container support.
### Forward Allowed Requests → Passed to actual microservice.
### Reject Requests → Blocked with 429 Too Many Requests.
### RateLimitTests -> Two test cases with ok below limit and after limit. The cache store for 1 minute can be increased

## Command for Redis setup in docker container
### pull the image : docker pull redis
### run the coniatner with Persistent Data Storage :  docker run --name rate-limit-redis-cache -d -p 6379:6379 -v redis_data:/data redis