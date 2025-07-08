# 🔁 Routing and Switching – The Comprehensive Concept :

Imagine managing a massive city that represents the network, with streets (cables), 
intersections (switches), and highways connecting cities (routers).
This is where the data journey into and out of the networks begins.

##  First: Switching - Switching within the same network (LAN)

### ✅ The basic idea:
A switch is a smart device used in local area networks (LANs). 
It connects devices within the same network and relies on the MAC address to determine the correct path for the data.

### 🧠 How does it work?
When device A sends data to device B, the switch checks B's MAC address and sends the data directly to it,
without sending it to all devices, increasing efficiency and reducing congestion.


### 💻 Basic components and concepts in Switching:

| Item | Explanation |
| ------ | ------ |
| **MAC Address Table** | A table that maintains the MAC addresses of each device connected to any port. |
| **Port Modes** | **Access**: For a port connected to a single device. <br> **Trunk**: Used to transfer data across multiple VLANs between switches. |
| **VLAN (Virtual LAN)** | Dividing the network into independent logical sections to isolate devices even though they are connected to the same switch. This is useful for security and reducing network transmission volume. |


### ⚙️ Basic commands to configure the Switch :

```
Switch> enable 				# Enter Advanced Mode

Switch# configure terminal 		# Enable Configuration Mode

Switch(config)# hostname SW1 		# Name the Switch

SW1(config)# vlan 10 			# Create VLAN

SW1(config-vlan)# name Marketing 	# Name the VLAN

SW1(config)# interface fastEthernet 0/1 # Select a Port

SW1(config-if)# switchport mode access 	# Access Mode

SW1(config-if)# switchport access vlan 10 # Bind the Port to the VLAN

SW1# write memory # Save the Settings

```

---

---

## Second: Routing - routing between different networks (WAN / LAN to LAN)

### ✅ The basic idea:
A router is the device responsible for connecting different networks together and determining the best route for data to take to reach its destination, like a road map.

### 🧠 How does it work?
If you want to send a message from one city to another (for example, from Cairo to Alexandria), you don't send it to your neighbor, but rather to the post office (router), which chooses the fastest route to deliver it.


### 📘 Key concepts in routing:

| Item | Explanation |
| ------------------- | ----- | |
| **IP Addressing** | Every network must have a unique IP address. |
| **Routing Table** | A table containing information about different networks and the best routes to reach them. |
| **Static Routing** | Manually specifying the route, suitable for small and simple networks. |
| **Dynamic Routing** | Network information is automatically exchanged between routers using protocols such as: <br> - **RIP** (Simple Hop-in Protocol) <br> - **OSPF** (Static-independent) <br> - **EIGRP** (Cisco proprietary, fast, and enhanced by advanced metrics). |


### ⚙️ Basic commands to configure the router :

```
Router> enable 			# Enter enable mode

Router# configure terminal 	# Enable configuration mode

Router(config)# hostname R1 	# Router name

R1(config)# interface g0/0 	# Select port

R1(config-if)# ip address 192.168.1.1 255.255.255.0 # Specify IP

R1(config-if)# no shutdown 	# Enable port

R1(config)# ip route 192.168.2.0 255.255.255.0 10.0.0.2 # Static Route

R1# show ip route 		# Display the routing table
```

---

### 📚 A quick comparison between Switching and Routing:

| Property | Switching | Routing |
| ---------------- | ----------------- | --------------- |
| Domain | Within the network (LAN) | Between different networks (WAN/LAN) |
| Base | MAC address | IP address |
| Device used | Switch | Router |
| Performance | Faster in switching | Relatively slower due to route calculations |
| Isolation and security | Uses VLAN | Uses subnetting and ACLs |


### 🧠 Why do we need both?
Switching helps build an organized and fast internal network.

Routing connects this network to the outside world or to other networks.
