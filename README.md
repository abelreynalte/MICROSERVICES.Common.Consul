# MICROSERVICES.Common.Consul
Extensión para consul - registro y descubrimiento  
Versión: .NET Standard 2.0  

# appsettings.json
```
"consul": {  
    "enabled": true,  
    "url": "http://localhost:8500",  
    "service": "customer-service",  
    "address": "localhost",  
    "port": "5000",  
    "pingEnabled": true,  
    "pingEndpoint": "ping",  
    "pingInterval": 5,  
    "removeAfterInterval": 10,  
    "requestRetries": 3  
  }
```
