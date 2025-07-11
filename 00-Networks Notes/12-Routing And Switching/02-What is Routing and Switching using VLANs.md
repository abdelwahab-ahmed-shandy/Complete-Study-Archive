# 🧠 What is Routing and Switching using VLANs? 

📘 The story and the basic idea:

## Imagine a large company with employees from different departments:
👩‍💼 Human Resources (HR) | 🧑‍💻 Finance | 👨‍🔧 Information Technology (IT)
They're all working on a single network, but the manager wants the data to remain isolated, while at the same time allowing them to communicate when needed.

## This is where the role of:

| Item | Function |
| -------------------------------- | --------------------------------------------- |
| **Switching** | Connects devices within the same network using MAC addresses |
| **VLANs** | Divides devices into logical networks within the same switch to isolate sections |
| **Routing (Inter-VLAN Routing)** | Allows devices in different VLANs to communicate when needed |


## First: Switching & VLANs – The Foundation

### 🔌 What is a switch?

- A Layer 2 device operating at the Data Link level.
- It recognizes the MAC address of each device.
- It sends data only to the intended device (not to all devices).

### 🧱 What are VLANs?

- VLAN = Virtual Local Area Network
- A logical partition within a switch isolates devices, even if they are physically connected to the same device.
- Each VLAN is considered a separate network, with its own broadcast domain.

### 🎯 Benefits:

✅ Increased security (isolation).
✅ Reduced broadcasting (broadcasting).
✅ Easier management and maintenance.
✅ Flexible expansion without physical change.

### 🧪 Practical example: Building VLANs inside a switch

👩‍💻 Scenario:

| Section | VLAN ID | Devices |
| ------- | ------- | ------------- |
| HR | 10 | PC1 on Fa0/1 |
| Finance | 20 | PC2 on Fa0/2 |
| IT | 30 | PC3 on Fa0/3 |


### ⚙️ Steps to configure a VLAN on a Switch 

```
Switch > enable

Switch# configure terminal

! Create VLANs

Switch(config)#vlan 10

Switch(config-vlan)#name HR

Switch(config)#vlan 20

Switch(config-vlan)# name Finance

Switch(config)# vlan 30

Switch(config-vlan)# name IT
```

### 🖥️ Setting Access Ports:

```
! PC1 → VLAN 10 :

Switch(config)# interface fa0/1

Switch(config-if)# switchport mode access

Switch(config-if)# switchport access vlan 10

! PC2 → VLAN 20 :

Switch(config)# interface fa0/2

Switch(config-if)# switchport mode access

Switch(config-if)# switchport access vlan 20

```

### 🔄 Connecting a Trunk Port:

```
Switch(config)# interface fa0/24

Switch(config-if)# switchport mode trunk

Switch(config-if)# switchport trunk native vlan 99
```

```
Create a Native VLAN (optional) :

Switch(config)# vlan 99

Switch(config-vlan)# name Native
```

### 🔍 Check settings:

```
Switch# show vlan brief ! Displays VLANs and ports

Switch# show interfaces trunk ! Displays Trunk ports
```

---

---

---

#🔁 Inter-VLAN Routing - Routing Between VLANs

## ❓ Why do we need routing?
Each VLAN is considered an independent network, so we need a router or Layer 3 switch to allow them to communicate.

## 🛣️ Available methods:

### 1️⃣ Router-on-a-Stick:
- We use a regular router.
- One port is divided into sub-interfaces for each VLAN.

```
Router > enable

Router# configure terminal

! Subinterface for VLAN 10

Router(config)# interface g0/0.10

Router(config-subif)#encapsulation dot1Q 10

Router(config-subif)# ip address 192.168.10.1 255.255.255.0

! Subinterface for VLAN 20

Router(config)# interface g0/0.20

Router(config-subif)# encapsulation dot1Q 20

Router(config-subif)# ip address 192.168.20.1 255.255.255.0
```

### 2️⃣ Using a Multilayer Switch (Layer 3):

- The switch itself supports routing.
- We enable IP Routing and use SVIs (Switched Virtual Interfaces).

```
Switch(config)# ip routing

Switch(config)# interface vlan 10

Switch(config-if)# ip address 192.168.10.1 255.255.255.0

Switch(config-if)# no shutdown

Switch(config)# interface vlan 20

Switch(config-if)# ip address 192.168.20.1 255.255.255.0

Switch(config-if)# no shutdown

```

### 💡 Concept Summary:

| Concept | Function |
| ----- | ------------------------------------------- |
| **Switching** | Connecting devices within a LAN using MACs |
| **VLAN** | Logical partitioning to isolate partitions within the same switch |
| **Access Port** | A port for a single device, associated with a single VLAN |
| **Trunk Port** | Transports more than one VLAN between switches |
| **Router-on-a-Stick** | Routing between VLANs using subinterfaces |
| **Multilayer Switch** | The switch itself performs the routing between VLANs |
| **Native VLAN** | A VLAN transmitted without a tag in the trunk |

---

### **By : Abdelwahab SHandy**