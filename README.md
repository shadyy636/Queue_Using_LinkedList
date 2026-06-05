# 🍔 Restaurant Order Ticket Processor (Linked List Queue Showcase)

A robust and efficient implementation of a custom **Queue** data structure built from scratch in **C#** using dynamic node allocation. To demonstrate the practical utilization of data structures, this project models a real-world **Restaurant Kitchen Order Pipeline**, illustrating standard FIFO (First-In, First-Out) operations, pointer management, and fluid memory scalability.

---

## 🚀 Key Features & Architectural Highlights

This repository implements dynamic pointer tracking designed to process sequential data flows smoothly:

* **Efficient Ticket Logging (`PlaceOrder`):** Achieves optimized $O(1)$ performance by maintaining a strict reference pointer to the `rear` node, appending incoming food orders to the tail of the kitchen queue with no traversal delay.
* **First-In First-Served Processing (`PrepareNextOrder`):** Processes and evicts the oldest pending ticket from the `front` boundary with a deterministic $O(1)$ execution path, keeping data flow continuous and organized.
* **Non-Mutating Kitchen Inspection (`PeekNextOrder`):** Safely previews the next order waiting for the chef without mutating the pipeline or causing tracking misalignment.
* **Array-Free Linear Scaling:** Bypasses memory reallocation or fragmentation limitations found in array-based queues, scaling dynamically based on active order volumes.

---

## 🛠️ Data Structure Blueprint & Mechanics

### FIFO Order Mechanics & Memory Layout
* **Dynamic Ticket Node:** Each order element encapsulates a descriptive tracking string payload (`orderDetails`) bound dynamically to a sequential forward address pointer (`next`).
* **Zero Boundary Overhead:** Offers native protection against memory overflow exceptions, making the system adaptive to sudden increases in request volumes.

---

## 💻 Tech Stack & Environment
* **Language:** C# (.NET)
* **Data Structure:** Queue (Linked List Based)
* **IDE:** Microsoft Visual Studio

---

## ⚙️ How to Run & Explore

1. **Clone the Project Pipeline:**
   ```bash
   git clone [https://github.com/shadyy636/RestaurantQueue_LinkedList.git](https://github.com/shadyy636/RestaurantQueue_LinkedList.git)
