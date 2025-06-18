# dotnet-load-balancers

This repository contains educational, production-grade implementations of common load balancing algorithms in C#, using .NET 8.

Each algorithm is implemented in its own self-contained project, including:

- Core logic
- Console demo
- Unit tests

✅ **Perfect for learning, experimenting, or using as a base for production systems.**

---

## 📦 Implemented Algorithms

| Algorithm         | Description                                           | Project Folder              |
| ----------------- | ----------------------------------------------------- | --------------------------- |
| Round Robin       | Distributes requests in a fixed circular sequence     | `RoundRobinBalancer/`       |
| Least Connections | Chooses the server with the fewest active connections | `LeastConnectionsBalancer/` |

More algorithms coming soon:

- [ ] IP Hash
- [ ] Random
- [ ] Least Response Time
- [ ] Weighted Round Robin

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
