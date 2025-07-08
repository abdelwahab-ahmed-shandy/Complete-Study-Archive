# 🏢 Integrated Lab: Switching + Routing + Telnet/SSH

## ✅ 1. Lab Objective:

* Create a real-world enterprise network to apply the following concepts:
* Set up VLANs and connect devices
* Inter-VLAN Routing using a Layer 3 Switch
* Static Routing + RIP Dynamic Routing
* Network Management using Telnet and SSH
* Test connectivity and interaction between all devices

## 🧱 2. Topology (Chart)

```
[AdminPC]────(SSH/Telnet)────[SW1]────[TRUNK]────[SW2]
                                │
                        ┌────── MLS ──────┐
                        │                │
                    [Router1]         [Router2]
                      (Static)           (RIP)
```

## 📦 3. Required equipment:

| Device | Number | Usage |
| ----------------- | ----- | ------ |
| PC | 6 | 2 devices per section |
| Layer 2 Switch | 2 | SW1 and SW2 |
| Multilayer Switch | 1 | Inter-VLAN Routing |
| Routers | 2 | R1 (Static), R2 (RIP) |
| Server | 1 | For SSH/Telnet Testing |
| Admin PC | 1 | Remote Login to Switch |


## 🧩 4. Network Partitioning :

| Partition | VLAN | Network | Devices |
| ---------- | ---- | ------------------ | -------- |
| HR | 10 | 192.168.10.0/24 | PC1, PC2 |
| Finance | 20 | 192.168.20.0/24 | PC3, PC4 |
| IT | 30 | 192.168.30.0/24 | PC5, PC6 |
| Management | 99 | 192.168.99.0/24 | AdminPC |

## 🛠️ 5. Configuration Details

### 🟩 5.1: Setting up VLANs on SW1 and SW2

```
Switch> enable
Switch# configure terminal

vlan 10
name HR
vlan 20
name Finance
vlan 30
name IT
vlan 99
name Management
```

### 🟦 5.2: Assigning ports to VLANs (Access Ports)

```
interface fa0/1
switchport mode access
switchport access vlan 10

interface fa0/2
switchport mode access
switchport access vlan 20

interface fa0/3
switchport mode access
switchport access vlan 30

interface fa0/5
switchport mode access
switchport access vlan 99
```

### 🔁 5.3: Setting up a Trunk Port between SW1 and SW2

```
interface fa0/24
switchport mode trunk
switchport trunk native vlan 99
```

### 🏗️ 6. Configure MLS for Inter-VLAN Routing

```
Switch> enable
Switch# configure terminal
ip routing

interface vlan 10
ip address 192.168.10.1 255.255.255.0
no shutdown

interface vlan 20
ip address 192.168.20.1 255.255.255.0
no shutdown

interface vlan 30
ip address 192.168.30.1 255.255.255.0
no shutdown

interface vlan 99
ip address 192.168.99.1 255.255.255.0
no shutdown
```

### 🟥 7. Static Routing on Router1

```
interface g0/0
ip address 10.0.0.2 255.255.255.0
no shutdown

ip route 0.0.0.0 0.0.0.0 10.0.0.1
```

### 🟧 8. RIP Configuration on Router2

```
interface g0/0
ip address 10.0.1.2 255.255.255.0
no shutdown

router rip
version 2
no auto-summary
network 10.0.1.0
network 192.168.40.0
```

### 🟨 9. Set up SSH and Telnet on SW1

```
enable
configure terminal
hostname SW1
ip domain-name mynetwork.local
username admin privilege 15 secret cisco123
crypto key generate rsa
1024
ip ssh version 2

line vty 0 4
login local
transport input ssh telnet
exec-timeout 5 0
password telnetpass
exit
write memory
```

### 🧪 10. Tests

| Test | Required |
| -------- | -------- |
| Ping between PC1 and PC2 | Should succeed |
| Ping from PC1 to PC3 | Inter-VLAN working |
| Ping from PC5 to the RIP network | RIP enabled |
| SSH from AdminPC to SW1 | via the command `ssh -l admin 192.168.99.1` |


### 🔍 11. Useful commands to follow

show vlan brief
show interfaces trunk
show ip interface brief
show ip route


---

### **By : Abdelwahab SHandy**