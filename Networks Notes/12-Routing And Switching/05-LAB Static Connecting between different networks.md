# LAB Connecting Between Different Networks

| Device | Details |
| ---------- | ----------------------------------- |
| 🧭 Router1 | Connected to the 192.168.1.0/24 network |
| 🧭 Router2 | Connected to the 192.168.2.0/24 network and Router1 |
| 🧭 Router3 | Connected to the 192.168.3.0/24 network and Router2 |
| 🖥️ PC1 | Connected to Router1 (network 192.168.1.0) |
| 🖥️ PC2 | Connected to Router3 (network 192.168.3.0) |

## 📦 الاتصالات (Connections):

```
[PC1]──(192.168.1.10)──[Router1]──(10.0.0.1)────
                                                 │
                                              (10.0.0.2)
                                          [Router2]──(10.0.1.1)──[Router3]──(192.168.3.1)──[PC2]
                                                           
                                       Router2 also has 192.168.2.1

```

## 🟨 Distribution of titles:

| Device or Interface | IP Address | Notes |
| ----------------- | ------------ | ------ |
| PC1 | 192.168.1.10 | Gateway = 192.168.1.1 |
| Router1 G0/0 | 192.168.1.1 | |
| Router1 G0/1 | 10.0.0.1 | ↔ Router2 |
| Router2 G0/0 | 10.0.0.2 | ↔ Router1 |
| Router2 G0/1 | 10.0.1.1 | ↔ Router3 |
| Router2 G0/2 | 192.168.2.1 | Additional Internal Network |
| Router3 G0/0 | 10.0.1.2 | ↔ Router2 |
| Router3 G0/1 | 192.168.3.1 | |
| PC2 | 192.168.3.10 | Gateway = 192.168.3.1 |


## 🛠️ Configuration (Static Routing on Router1 and Router3):

### 🔸 Router1:

```
interface g0/0

ip address 192.168.1.1 255.255.255.0

no shutdown

interface g0/1

ip address 10.0.0.1 255.255.255.0

no shutdown

ip route 192.168.2.0 255.255.255.0 10.0.0.2

ip route 192.168.3.0 255.255.255.0 10.0.0.2

```

### 🔸 Router3:

```
interface g0/0
ip address 10.0.1.2 255.255.255.0

no shutdown

interface g0/1

ip address 192.168.3.1 255.255.255.0

no shutdown

ip route 192.168.1.0 255.255.255.0 10.0.1.1

ip route 192.168.2.0 255.255.255.0 10.0.1.1

```

### 🟦 RIP Configuration (Router2 only):

```
router rip

version 2

no auto-summary

network 10.0.0.0

network 10.0.1.0

network 192.168.2.0
```

### ✅ Testing steps:

- Ping from PC1 to PC2
- Ping from Router1 to 192.168.2.1 (Router2)

- Use the command:

```
show ip route
```

On each router to see the routing table.

---

### **By : Abdelwahab SHandy**