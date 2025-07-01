# 🖧 Basic Network Elements (Software)

## TCP/IP Protocol Suite

## ✅ Table of Contents

* TCP/IP Protocol Suite (Expanded)
* Major Protocols in Networking (Detailed)
* OSI vs TCP/IP (Clarified)
* Data Encapsulation (In-depth)
* MAC & IP Addressing (Explained)
* IPv4 Addressing (Deeper Look)
* IP Classes (Analyzed)
* Private vs Public IP (Clarified)
* DHCP & APIPA (Expanded)
* Reserved IPs (Functions)
* NAT (Network Address Translation)
* ARP (Address Resolution Protocol)
* IPv6 Overview (Explained)
* Internet of Things (IoT)
* TCP vs UDP (Comparison)
* Port Numbers & Sockets (Explained)
* Useful Commands (with Examples)
* ✅ Final Notes

---

## TCP/IP Protocol Suite (Expanded)

TCP/IP is a protocol suite originally developed by the U.S. Department of Defense.

* It is the official standard of the internet.
* Supports communication between different OSs.
* Includes many protocols beyond TCP and IP:

  * HTTP / HTTPS
  * DNS
  * FTP / SFTP
  * SMTP / POP3 / IMAP
  * SSH / Telnet

### Difference between TCP/IP v4 and v6:

* **v4** uses 32-bit addressing (limited → IPv4 exhaustion)
* **v6** uses 128-bit addressing

  * Better support for QoS and security
  * IPSec is built-in

---

## Major Protocols in Networking (Detailed)

| Protocol  | Vendor    | Routable  | Notes                             |
| --------- | --------- | --------- | --------------------------------- |
| TCP/IP    | Open Std  | ✅ Yes     | Core protocol of the internet     |
| IPX/SPX   | Novell    | ✅ Yes     | Previously used in Novell NetWare |
| NetBEUI   | Microsoft | ❌ No      | LAN only, non-routable, very fast |
| AppleTalk | Apple     | ✅ Yes     | Deprecated since macOS X          |
| DLC       | IBM       | ❌ Partial | For old mainframe infrastructure  |

---

## OSI vs TCP/IP (Clarified)

* **OSI Model**: 7-layer theoretical framework
* **TCP/IP Model**: Practical 4-layer model

| OSI Layer        | Description                   | TCP/IP Equivalent |
| ---------------- | ----------------------------- | ----------------- |
| Application (7)  | Applications like browsers    | Application       |
| Presentation (6) | Data format, encryption       | Application       |
| Session (5)      | Session control               | Application       |
| Transport (4)    | Reliable delivery (TCP/UDP)   | Transport         |
| Network (3)      | Routing, IP addressing        | Internet          |
| Data Link (2)    | MAC-level communication       | Network Access    |
| Physical (1)     | Electrical/Physical signaling | Network Access    |

---

## Data Encapsulation (In-depth)

Each layer adds its own header (control info):

```
[Application Data]
   ↓
[+ Transport Header: TCP/UDP]
   ↓
[+ Network Header: IP]
   ↓
[+ Data Link Header: MAC (Ethernet)]
   ↓
[Physical Transmission: 1s & 0s via cable/wireless]
```

---

## MAC & IP Addressing (Explained)

### MAC (Media Access Control):

* Hardcoded on NIC (Network Interface Card)
* Identifies device uniquely on LAN
* Cannot be changed easily

### IP Address:

* Logical address (static/dynamic)
* Used for routing between networks
* Can be changed

---

## IPv4 Addressing (Deeper Look)

* IPv4 = 2³² ≈ 4.29 billion addresses
* Each **octet** = 8 bits → value range 0–255
* Example: `192.168.1.10`

  * Binary: `11000000.10101000.00000001.00001010`

---

## IP Classes (Analyzed)

| Class | Starting Bits | Host Bits | Max Hosts    | Notes                   |
| ----- | ------------- | --------- | ------------ | ----------------------- |
| A     | 0             | 24        | \~16 million | For large networks      |
| B     | 10            | 16        | \~65,000     | Medium-sized networks   |
| C     | 110           | 8         | 254          | Small networks          |
| D     | 1110          | N/A       | Multicast    | Not for host assignment |
| E     | 1111          | N/A       | Experimental | Reserved for research   |

---

## Private vs Public IP (Clarified)

* **Private IPs:**

  * Not directly reachable over internet
  * Used in homes/offices
  * Require NAT to access the internet

* **Public IPs:**

  * Assigned by ISPs
  * Must be globally unique

---

## DHCP & APIPA (Expanded)

### DHCP – Dynamic Host Configuration Protocol:

* Automatically assigns:

  * IP address
  * Subnet mask
  * Default gateway
  * DNS server
* Process (DORA):

  * Discover → Offer → Request → Acknowledge

### APIPA – Automatic Private IP Addressing:

* Used when DHCP is unreachable
* Address range: 169.254.0.1 – 169.254.255.254

---

## Reserved IPs (Functions)

| Usage Type      | Example       | Function                       |
| --------------- | ------------- | ------------------------------ |
| Network ID      | 192.168.1.0   | Identifies the network         |
| Broadcast       | 192.168.1.255 | Send to all devices on subnet  |
| Loopback        | 127.0.0.1     | Test local machine (localhost) |
| Default Gateway | 192.168.1.1   | Router for internet access     |

---

## NAT – Network Address Translation (Detailed)

* Translates between private and public IPs

### Types:

* **Static NAT:** One-to-one mapping
* **Dynamic NAT:** Pool of public IPs
* **PAT:** Port-based translation (many-to-one), most common

---

## ARP – Address Resolution Protocol

* Maps IP address to MAC address on LAN
* Types:

  * ARP Request
  * ARP Reply

**Command:** `arp -a` (view ARP cache)

---

## IPv6 Overview (Explained)

* 128-bit addresses: 2¹²⁸ ≈ 3.4 × 10³⁸ addresses
* Example:

  * Full: `2001:0db8:0000:0000:0000:8a2e:0370:7334`
  * Compressed: `2001:db8::8a2e:370:7334`

### Features:

* No need for NAT
* Built-in IPSec
* Auto-addressing (Stateless)

---

## Internet of Things (IoT)

* Connects everyday devices to the internet

### Requirements:

* Sensors
* Lightweight protocols (e.g., MQTT)
* IPv6 to support many devices

### Risks:

* Security vulnerabilities
* Weak embedded OSs

---

## TCP vs UDP (Comparison)

| Feature     | TCP                             | UDP                    |
| ----------- | ------------------------------- | ---------------------- |
| Connection  | Connection-oriented (handshake) | Connectionless         |
| Reliability | Reliable, guaranteed delivery   | No delivery guarantees |
| Order       | Maintains data order            | No ordering            |
| Use Cases   | Web, Email, FTP, SSH            | Live video, VoIP, DNS  |

---

## Port Numbers & Sockets (Explained)

### Well-known Ports:

* HTTP: 80
* HTTPS: 443
* FTP: 21
* SSH: 22
* SMTP: 25

### Socket:

* Combination of IP + Port
* Example: `192.168.1.5:80` → HTTP request to a device

---

## Useful Commands (with Examples)

| Command              | Function                          | Example Output          |
| -------------------- | --------------------------------- | ----------------------- |
| `ipconfig /all`      | View full network details         | IP, DNS, Gateway        |
| `getmac`             | Display MAC address               | Physical Address        |
| `ping 8.8.8.8`       | Test external connection (Google) | Ping reply              |
| `netstat -an`        | Show all active connections       | TCP/UDP ports           |
| `tracert google.com` | Trace route to server             | Shows intermediate hops |

---

---

*By: Abdelwahab Shandy*
