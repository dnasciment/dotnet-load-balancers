# dotnet-load-balancers

This repository contains educational, production-grade implementations of common load balancing algorithms in C#, using .NET 8.

Each algorithm is implemented in its own self-contained project, including:

- Core logic
- Console demo
- Unit tests

✅ **Perfect for learning, experimenting, or using as a base for production systems.**

---

## 📦 Implemented Algorithms

| Algorithm             | Description                                                                 | Project Folder              |
| --------------------- | --------------------------------------------------------------------------- | --------------------------- |
| **Round Robin**       | Distributes incoming requests evenly in a circular sequence across servers. | `RoundRobinBalancer/`       |
| **Least Connections** | Sends each new request to the server with the fewest active connections.    | `LeastConnectionsBalancer/` |
| **IP Hash**           | Maps each client IP to a specific server using a consistent hash function.  | `IpHashBalancer/`           |

---

## 🧪 Upcoming Algorithms

| Algorithm                | Description                                                              |
| ------------------------ | ------------------------------------------------------------------------ |
| **Random**               | Selects a server randomly for each incoming request.                     |
| **Least Response Time**  | Chooses the server with the lowest average response time.                |
| **Weighted Round Robin** | Like Round Robin, but servers with higher weights receive more requests. |

---

## 🚀 How to Run

Each project is a self-contained .NET 8 console application.

Example (Round Robin):

```bash
cd RoundRobinBalancer
dotnet run

cd LeastConnectionsBalancer
dotnet run
```

## 🧪 How to Test

Each project includes unit tests using xUnit.

Example:

```bash
dotnet test RoundRobinBalancer
dotnet test LeastConnectionsBalancer
```
