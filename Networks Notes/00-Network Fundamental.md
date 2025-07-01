# Computer NetworksFundamentals :

### References :
Books : 
	- Cisco Student Guide ICND1
	- CompTIA Network N10-006 Cert Guide
	- Data and Computer Communications - William Stallings 8th Edition
	- TCP/IP Protocol Suite -   Behrouz A. Forouzan 4th Edition
	- Understanding IPv6 –    Joseph Davies 2nd Edition

---

Objective : 

- Introduction to Computer Networks 
- OSI Model
- TCP/IP Model
- Ethernet Protocol
- Network Devices
- Network media
- Introduction to Wireless Networks 
- Security Fundamentals

---

## What is the Computer Network ?

- Computer Network : 
a collection of computers, and other devices, or peripherals connected together through connecting media to perform certain task such asshare resources

## Benefits of Computer Networks :

- Resources Sharing 
	. File Sharing 
	. Devices Sharing 
	. Software Sharing with multi-user licenses.
	. Voice and Video calls 

- Shared Internet Access 

## Basic Network Terminologies :

- NIC (Network Interface Card): The hardware that plugs into the motherboard and directly access the network

- Mac address: Physical Address, Unique address over the world burned on the  NIC card

- IP address :Logical Address, identify each device on an IP network layer

- Protocols : Communication rules that all entity must agree on

## Basic Network Terminologies :

- Hub : Allow different nodes to communicate with each other at the same network(Slow the network)

- Switch : Allow different nodes to communicate with each other at the same network and time without slowing each other


- Router : Allow different networks to communicate with each other 

---

# How to apply networks ?? 

### Networks Classifications :

- According to Covered Area
	How large is the network?

- According to network topology
	How the computer are connected?

- According to network model
	What type of model?

According to Covered Area ( PAN – MAN - WAN - INTERNET )


## According to Covered Area :

- Personal Area Networks (PAN)
	- A computer network for interconnecting devices centered on an individual person's workspace.
	- A PAN provides data transmission among devices such as computers, smartphones, tablets and personal digital assistants

- Local Area Networks (LAN) :

	- a group of computers connected in small geographical area
	- a limited area such as a residence, school, laboratory, university campus or office building
	- Allow users to share files and services
	- High speed of communications
	- Under your administrative Control

- Metropolitan Area Networks (MAN) : 

	- A MAN connects an area larger than a LAN but smaller than a WAN
	- such as a city.
	- dedicated or high-performance hardware 

- Wide Area Networks (WAN) :

	- A WAN is a group of computers connected in Large geographical area such as country 
	- A WAN often connects two LANs (WAN Link)
	- Very low Speed
	- Under your ISP Administrative control

- Internet (WWW) :
	- The internet is defined as a global mesh of interconnected networks
	- the most used service on the Internet is the World Wide Web 
	- No one actually owns the Internet
	- Many Orgs, ISPs, Companies, Govs own pieces of Internet Infrastructure.
		. ISOC: Internet Society
		. IETF: Internet Engineering Task Forum 
		. ICANN: Internet Corporation for Assigned Names and Numbers 

---

# Network Topology :

### According to Network Topology ( Bus – Star - Ring - Mesh- Hybrid )

- Topology 
	- refers to the shape of a network, or the network's layout.

	- Two types of Network topologies:

	- The physical topology: physical way ( how computers connected to each other physically :_wired or wireless)

	- The logical topology: the way the he message are sent. ( how to send message from device to other)

	- The choice of topology is dependent upon :
		. Type and number of equipment being used
		. Cost 

	- Each topology has its own advantages and disadvantages.

---

## Bus Topology :
- All devices are connected to a central cable, called the bus or backbone
- Both ends of the network must be terminated with a terminator. 
- A barrel connector can be used to extend the network. 

### Frame Transmission - Bus LAN :

- The backbone functions as a shared communication medium 
- Device wanting to communicate with another device on the network sends a message onto the backbone
- The message is heard by all stations, but only the intended recipient actually accepts and processes the message. 
- Terminator absorbs frames at end of medium

### Bus Advantages and Disadvantages :

- Advantages :
	. Simple, easy to use and construct
	. Requires least amount of cable (less expensive)
	. Reliable
- Disadvantages :
	. A faulty cable take the entire LAN down 
	. Difficult to troubleshoot
	. No security
	. Slow during peak traffic period

---

## Star Topology : 

- All the devices are connected to a centralized unit such as a Hub or Switch. 

- Nodes communicate across the network by passing data through the central device. 


### Star Topology types : 

- Hubbed Star ( Broadcasted Star Topology)
	. Central node can broadcast (Hub)
		- Physical star, logically bus
		- Only one station can transmit at a time

- Switched Star 
	. Central node can act as frame switch 
		- Retransmits only to destination

---

## Ring Topology :

- A cable connects one node to another to form a ring (shape of a closed loop)
- each device is connected directly to two other devices, one on either side of it. 

- All messages travel through a ring in the same direction 
- token is used to transmit data and pass over each station

### Frame Transmission - Ring LAN :

- Data transmitted in frames (token)
	. Circulate past all stations
	. Destination recognizes address and copies frame
	. Data is passed one way from device to device. 
	. Frame circulates back to source where it is removed
	. Medium access control determines when station can insert frame

### Ring Advantages and Disadvantages :

- Advantages:
	. Fair (Equal access for all users)
	. Perform well under heavy traffic
- Disadvantages
	. Network expansion or reconfiguration will affect the network operation
	. If one node fails, the entire network fails
	. Difficult to troubleshoot
	. very bad if we have about 60 pc, Slow Network

---

## Mesh Topology : 

- Each device/PC is connected to every other device/PC in the network by its own cable 
- Amount of cables needed can be calculated by: 
	CN = (D * (D-1)) / 2 (where CN is Cables Needed, and D is the amount of devices on the network) 
- Mesh Types
 	. Full Mesh
 	. Partial Mesh

### Mesh Advantages and Disadvantages :

- Advantages:
	. Mesh topology boasts the highest fault tolerance of all of the network topologies
	. Redundancy exist
	. Secure
- Disadvantages
	. Because each connection needs its own cable a Mesh topology can get very expensive

--- 

## Hybrid Topology :

- Hybrid means that there is more than one topology exist
- Combine bus ,star and ring topologies
- Allow network expansion 
- Flexible

### Hybrid Advantages and Disadvantages : 

- Advantages:
	. Network expansion is simple
- Disadvantages
	. If hub fails connections between failed hub and other hubs will fail

---

# According to Network Model :

- Peer to Peer Networks
- Client/Server Networks


### Peer-to-Peer Networks: 

- No dedicated resources to present specific service
- Easy to work with 
- All nodes are the same (equal to use the resources )
	. Example : Windows Workgroup

### Client/Server Networks :

- Some nodes (SERVER) are dedicated to present services to other nodes (CLIENTS)
- Server is more powerful

Examples: 
	. Mail Server
	. Web Server
	. File Server 
	. Print Server

- Computers providing the service are called Servers
- Computers that request and use the service are called Client computers. 
- Number of servers is very small compared with the number of clients

### Peer to peer vs client/server model :

---

# Building the network :

## What do you need to build your network? 

### Basic Network Elements :

- Hardware
	- Computers / Peripherals
	- NICs
	- Connecting Media
	- Networking Device(s)
		. Routers
		. Switches
		. Hubs 
- Software
	-Protocols
		. Communication rules that all entity must agree on

### Basic Network Elements ( Hardware / Software ) 

- Hardware :
	- Devices used to communicate with one another
		. Computers – Printers –Phone – Routers - Switches
- Medium how the devices are connected together
		. Wired  -Wireless –Satellites
- Software :

- Messages Information that travels over the medium
	. Mails-WhatsApp….etc
- Protocols Governs how messages flow across network
	. http –https-ftp-rdp

---

# Basic Network Elements (Software)

What is Protocols ?

- Communication rules that all entity must agree on it 
- Method to connect internetworking elements

Why we need Protocols ?

- To communicate efficiently
- Control the messages and the messages quantity in the network

--- 

# Open Systems Interconnection Reference Model OSI RM

OSI Reference Model

- OSI: Open Systems Interconnect
- OSI/RM was defined by ISO in 1983
	. International Organization for Standardization 

- OSI Three practical functions
	. Give developers universal concepts so they can develop protocols
	. Explain the framework used to connect heterogeneous systems (Client/server can communicate even if they have different OS)
	. Describes the process of packet creation

- The OSI reference model breaks this approach into layers.

### Benefits of using a layered model :

- It divides the network communication process into Layers, so easier to troubleshooting.
- It allows multiple-vendor development through standardization of network components.
- It allows various types of network hardware and software to communicate.
- Changes in one layer do not affect other layers because of layer separation 
- Layers interact with each other.

## Why a Layered Network Model?

- Reduces complexity
- Standardizes interfaces
- Facilitates modular engineering
- Simplifies teaching and learning


## الطبقات السبع لنموذج OSI:

| رقم | الطبقة            | الوظيفة الأساسية                                           |
|----|-------------------|----------------------------------------------------------|
| 7  | **Application**    | تفاعل المستخدم مع التطبيق (مثل HTTP, FTP, SMTP).          |
| 6  | **Presentation**   | تحويل البيانات (تشفير، ضغط، تحويل الصيغ).                  |
| 5  | **Session**        | إدارة الجلسات (بدء، إنهاء، التحكم بالجلسات بين الأنظمة).     |
| 4  | **Transport**      | النقل الموثوق للبيانات (مثل TCP/UDP).                     |
| 3  | **Network**        | التوجيه وتحديد العناوين (IP Addressing, Routing).          |
| 2  | **Data Link**      | التحكم في الوصول إلى الوسيط وإطار البيانات (MAC, Ethernet). |
| 1  | **Physical**       | نقل الإشارات الفعلية عبر الوسيط (كابلات، موجات، ألياف ضوئية). |


--- 

# The Seven Layers Functions (Cont.) 

## Application Layer :
	- Interface to end users
	- File transfer
	- Network management
	- Email 
	- Many other services

- Protocols :
	. HTTP (Hyper Text Transfer Protocol)
	. FTP (File transfer Protocol)
	. SMTP (Simple Mail transfer Protocol)
	. POP3 (Post office transfers Protocol)
	. Telnet/SSH (secure Shell)
	. RTP (Real-time Protocol)


## Presentation Layer :
- Finding common presentation between source and Destination
- Provide transformation of data to support standardized application interface
- Coding or Translation of data (ex: EBCDIC to ASCII)

## Session Layer :

- Establishes, manages and terminates sessions (connections) between cooperating applications
- Synchronization (add checkpoints into a stream of data) 
- Controls the sessions between the local and remote applications


## Transport Layer :
- Organize data into Segments
- Provide reliable transport between end systems (source and destination hosts)
- End-to-end error recovery
- End-to-end flow control


## Network Layer :
- Organize data into datagram (packets)
- It is responsible for the Internet Protocol Addressing (IP) (Addressing)
- It know the best path for the destination (Routing)
- End-to-end Addressing 


## Data link Layer :
- Reliable data transfer across a physical link (Error Control)
- Organize the data into Frames, to be put on the physical medium
- Check the Frame For errors
- Hop to hop addressing


## Physical Layer :
- Transmission of unstructured bit stream over the physical link
- Deals with the mechanical and electrical specifications of the interface and transmission media (cables and connectors)
- Representation of bits

===========================================

Sender => Data Encapsulation

Receiver <= Data De-Encapsulation


	    Sender 				  Receiver 
|----|--------------------|		|----|--------------------|
| 7  | **Application**    |		| 7  | **Application**    |  
| 6  | **Presentation**   |		| 6  | **Presentation**   | 
| 5  | **Session**        |		| 5  | **Session**        | 
| 4  | **Transport**      |---Segments--| 4  | **Transport**      |
| 3  | **Network**        |---Packets---| 3  | **Network**        | 
| 2  | **Data Link**      |----Frames---| 2  | **Data Link**      | 
| 1  | **Physical**       |		| 1  | **Physical**       |
	    |					     |
	    |--------------------Bits------------------|


---

---

### By Abdelwahab Shandy 