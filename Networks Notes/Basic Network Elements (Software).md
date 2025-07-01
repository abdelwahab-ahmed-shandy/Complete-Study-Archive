# Basic Network Elements (Software)

## TCP/IP Protocol Suite

### TCP/IP :

- Transmission Control Protocol/Internet Protocol.
- TCP/IP is open standard protocol
- Not tied to one vendor
- TCP/IP is the internet protocol
- Now internet use TCP/IP v4
- Next version TCP/IP v6
- It is the default protocol for all modern operating systems
	. Microsoft Operating Systems
	. UNIX Operating Systems
	. LINUX Operating Systems

### TCP/IP Advantages and Disadvantages :

- Advantages
	. Standard
	. Direct access to the Internet
	. Routable 
	. Cross Platform
- Disadvantages
	. Difficulty of setup
	. Slower than other protocols like IPX/SPX & NetBEUI

### Major Networking Protocols :

- TCP/IP _ free / standard
- IPX/SPX _ by Novel/ not free/not standard
- NetBEUI – not routable 
- Apple Talk
- Data Link Control (DLC)

## TCP/IP VS. OSI Model
 
- Defines four layers
- Uses different names for Layers 1 through 3
- Combines Layers 5 through 7 into single application layer


		TCP/IP Stack			      OSI Reference Model
	   |----|--------------------|		   |----|--------------------|
Applica <--| 7  | **Application**    |		   | 7  | **Application**    |    
   tion <--| 6  | **Presentation**   |<----------->| 6  | **Presentation**   | 
        <--| 5  | **Session**        |		   | 5  | **Session**        | 
	   | 4  | **Transport**      |<----------->| 4  | **Transport**      |
	   | 3  | **Network**        |<----------->| 3  | **Network**        | 
Network <--| 2  | **Data Link**      |<----------->| 2  | **Data Link**      | 
Access  <--| 1  | **Physical**       |		   | 1  | **Physical**       |
		        |				       |
		        |------------------Bits----------------|


## TCP/IP Protocol Architecture :


### Network Access Layer :

-Physical Layer
	. Transmission medium
	. Signal rate 
- Datalink Layer
	. Logical interface between end system and network
	. Hop to Hop addressing
	. Error detection Mechanism

---

### Physical (Mac) Addresses :

- Physical Address burned on the card
- Unique address over the world 
- called Mac address.
- 48-bit (6-byte) written as 12 hexadecimal digits; every byte (2 hexadecimal digits) is separated by a colon   :
- Physical addresses can be either
	. unicast 
	. multicast 
	. broadcast 

---

## Basic Network Elements (Software)- LAB 

### Physical Addresses : 

- To check your physical address: 
	. Ipconfig /all 
	. GetMac

Example Physical Address
07:01:02:01:2C:4B

### Internet Layer (IP Layer) :

- Network layer protocol
- Packet in the IP layer is called Datagram
- Datagram consist of TWO parts
	. Header
	. Data
- Routing of data
- Logical addressing IPV4 , IPV6

---

## Internet Protocol (IP V4) : 

- Uniquely identify each device on an IP network layer. 
- Some times we called it the logical address
- Every host (computer, networking device, peripheral) must have a unique address at the same network 
- The IP address 32 bit divided into 4 octets each octet 8 bit 


### IP Address Format: Dotted Decimal Notation

1 octet = 8 bit  each represents from 0 to 255 separated with dots

The address space of IPv4 is 232 or 4,294,967,296

### IP Address Ranges


### IP Address Classes: The First Octet

### Public IP Addresses (Real IP)

### Private IP Addresses (Local IP)

Nat is used to Translate the private IP address to public IP addresses.



