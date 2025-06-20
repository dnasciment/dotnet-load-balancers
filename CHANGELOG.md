# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),  
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

---

## [0.3.0] - 2025-06-18

### Added

- `RandomBalancer`:
  - Random load balancing algorithm
  - Console demo with 20 requests and final distribution stats
  - Unit tests verifying correct distribution and randomness over time

## [0.2.0] - 2025-06-18

### Added

- `IpHashBalancer`:
  - IP-based load balancing using SHA-256 hashing
  - Console demo with simulated client IPs
  - Final output includes per-server request distribution and IP-to-server mapping
  - Unit tests for hash consistency and distribution

---

## [0.1.0] - 2025-06-18

### Added

- Initial repository structure
- `RoundRobinBalancer`:
  - Round Robin load balancing algorithm
  - Console demo with request simulation
  - Unit test for sequential distribution
- `LeastConnectionsBalancer`:
  - Least Connections algorithm with simulated parallel connections
  - Server connection tracking (active + total)
  - Console demo with live load balancing and random disconnection
  - Final per-server statistics output
  - Unit test for selecting the server with least connections
