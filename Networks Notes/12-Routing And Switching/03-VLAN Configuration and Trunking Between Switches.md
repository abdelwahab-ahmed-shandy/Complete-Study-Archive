# 🧪 🔧 Lab Title:

## VLAN Configuration and Trunking Between Switches :

### 🧱 Lab components:

| Device | Number | Usage |
| -------- | ----- | -------------------------- |
| PCs | 4 | Devices per section |
| Switches | 2 | VLAN distribution and trunking |
| Cables | Sufficient | Straight for each PC and switches |

## 🖥️Laptop details:

🖧 Topology:

```
[ PC1 - HR ]         [ PC2 - Finance ]
      |                    |
   Fa0/1                Fa0/2
      \                  /
       \                /
        [ Switch 1 ]==================[ Switch 2 ]
             |                             |
         Fa0/24 (Trunk)              Fa0/24 (Trunk)
             |                             |
       [ PC3 - HR ]                 [ PC4 - Finance ]
         Fa0/3                          Fa0/4

```

## 🎯 Required implementation on the laptop:

- Create VLANs (e.g., VLAN 10 - HR, VLAN 20 - Finance)
- Assign each access port to a department.
- Assign a trunk port between switches.
- Test connectivity between devices in the same VLAN.
- Ensure that devices in different VLANs do not communicate with each other (unless a router is present).

## ⚙️ Detailed setup steps:

### 🔵 On Switch 1:

```
enable
configure terminal

! Create VLANs
vlan 10
name HR
exit
vlan 20
nameFinance
exit

! Assign ports
interface fastEthernet 0/1
switchport mode access
switchport access vlan 10
exit

interface fastEthernet 0/2
switchport mode access
switchport access vlan 20
exit

! Trunk port setup
interface fastEthernet 0/24
switchport mode trunk
exit
```

### 🔵 On Switch 2:

```
enable
configure terminal

The same VLANs must be present here as well
vlan 10
name HR
exit
vlan 20
name Finance
exit

Assign ports
interface fastEthernet 0/3
switchport mode access
switchport access vlan 10
exit

interface fastEthernet 0/4
switchport mode access
switchport access vlan 20
exit

Trunk port setup
interface fastEthernet 0/24
switchport mode trunk
exit
```

## 🖥️ PCs Settings:

| PC  | IP Address   | Subnet Mask   | VLAN |
| --- | ------------ | ------------- | ---- |
| PC1 | 192.168.10.1 | 255.255.255.0 | 10   |
| PC2 | 192.168.20.1 | 255.255.255.0 | 20   |
| PC3 | 192.168.10.2 | 255.255.255.0 | 10   |
| PC4 | 192.168.20.2 | 255.255.255.0 | 20   |


### ✅ Required Test:

✅ PC1 ↔ PC3 → Ping is working (same VLAN)
✅ PC2 ↔ PC4 → Ping is working (same VLAN)


❌ PC1 ↔ PC2 → Ping is not working (different VLAN, no router)

---

### **By : Abdelwahab SHandy**