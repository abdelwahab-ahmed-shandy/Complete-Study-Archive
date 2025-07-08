# 🧭 Routing – Routing in Networks 

### 📘 Basic Idea:

- Routing is the process of moving data from one network to another via routers, using IP addresses.
- Each router knows the networks directly connected to it.
- It needs to learn or know the routes to networks not directly connected to it.

### 🛠️ The difference between a Switch and a Router in terms of setup:

| Property | Switch | Router |
| -------------- | ------------------- | ------------------------------ |
| Layer | Layer 2 (Data Link) | Layer 3 (Network) |
| Interface | Enabled by default | **Shutdown** by default |
| Routing Method | None | Depends on **IP Routing** |

### 📍 To check the status of interfaces:

```
show ip interface brief
```

### 📍 To view the routing table:

```
show ip route
```

---

# 🟩 Static Routing – Manual Routing

✅ Concept:

- Static Routing means you manually tell the router how to access a network it isn't connected to.
- It's used when there are few networks, or the network is static.

✅ When do we use it?

- A simple network.
- No frequent changes.
- We want complete control.

### ⚙️ Static Route setup steps:

- 1️⃣ Activate the router interface and specify the IP address:

```
Router(config)# interface g0/0

Router(config-if)# ip address 192.168.1.1 255.255.255.0

Router(config-if)# no shutdown
```

- 2️⃣ Add Static Route:

```
Using the next hop address

Router(config)# ip route 192.168.2.0 255.255.255.0 10.0.0.2

Or using the interface name

Router(config)# ip route 192.168.2.0 255.255.255.0 g0/1
```

---

# 🟦 Dynamic Routing

### ✅ The idea:
Instead of manually adding networks, routers exchange network information automatically.

### ✅ Dynamic protocols:

| Type | Protocols |
| ------------ | ------------------------------------------- |
| **Interior** | Within the same system (AS) such as: RIP, OSPF, EIGRP |
| **Exterior** | Between different systems (AS) such as: BGP |

### 📘 Default Route

- Used when you want the router to send any data to an unknown network to a specific destination (such as the internet).
- It is commonly used in home networks.

```
Router(config)# ip route 0.0.0.0 0.0.0.0 10.0.0.2
```

### 📌 Important concepts in guidance:

| The term		      | Meaning|
| --------------------------- | ------------------------------------------------------ |
| **Metric** | Measures the quality of the path (number of hops, speed, delay...) |
| **Administrative Distance** | How reliable is the protocol (the lower the number, the higher the priority) |


| Protocol | AD (Default) |
| ---------- | --------------- |
| Connected | 0 |
| Static | 1 |
| RIP | 120 |
| OSPF | 110 |
| EIGRP | 90 |

---

# 🔁 RIP – Routing Information Protocol 

## ✅ RIP Concept:

- Each router shares its connected networks with the rest of the routers.
- The exchange occurs every 30 seconds.
- The maximum hop count is 15; anything more is invalid.

### ❌ Problem: Loop & Network Poisoning
If a network goes down and the tables aren't updated, an incorrect replication of the network's propagation can occur, causing a loop.


## 🔄 RIP supports Load Balancing :

- which means it can distribute the load across more than one equal path.


### 🔍 RIP Versions:

| Version | Feature |
| --------- | ---------------------------------------------------------- |
| **RIPv1** | Classful (does not support subnetting), uses broadcast |
| **RIPv2** | Classless (supports subnetting), uses multicast `224.0.0.9` |

### ⚙️ Setting up RIP on the router:

```
Router(config)# router rip

Router(config-router)# version 2

Router(config-router)# no auto-summary

Router(config-router)# network 192.168.1.0

Router(config-router)# network 10.0.0.0
```

## 📌 Note:

- The network command is used to tell RIP which networks are actually connected to the router.
- no auto-summary disables auto-summary (allows subnetting).

### 🧠 Quick comparison summary:

| Type | Static Routing | Dynamic Routing |
| --------- | ------------------ | ------------ |
| Setup | Manual | Automatic |
| Scalability | Difficult | Easy and suitable for large networks |
| Performance | Very fast | A little slower depending on the protocol |
| Updates | Must be manually adjusted | Automatically communicates between devices |
| Security | More secure | Relatively less secure, depending on the setup |

