# 🔐 The difference between Telnet and SSH 

## 📌 General Concept:
Both Telnet and SSH are used for remote access to network devices (such as routers and switches),
but they differ significantly in security and data transfer methods.

| Features | 🟡 Telnet | 🟢 SSH |
| ----------------- | ----------------------------------- | ------------------------------------- |
| Encryption | ❌ None - Data sent as plain text | ✅ Encrypted using strong encryption protocols |
| Security | Low - Vulnerable to spying or theft | High - Secure against eavesdropping and tampering attacks |
| Usage | For testing or in isolated networks | In real, secure environments |
| Protocol | TCP Port 23 | TCP Port 22 |
| Authentication Type | Simple - Using only a password | Multiple - Password + encryption keys |
| Supporting Tools | Regular Command Prompt | Tools like PuTTY / OpenSSH / SecureCRT |


## 🛠️ Steps to Set Up Telnet and SSH :

### ✅ Basic Steps (Common for Telnet and SSH):

- Naming the Device (Router or Switch)
- Specifying a Domain Name – Required for SSH
- Creating a User with a Password and Privileges
- Enable VTY Login
- Selecting Login Method: Local
- Setting a Password (Required for Telnet only)
- Enable SSH and Generating Encryption Keys

## ⚙️ Full configuration (Telnet + SSH):

```
Switch> enable
Switch# configure terminal

! ✅ Change the device name:
Switch(config)# hostname SW1

! ✅ Specify the domain name:
SW1(config)# ip domain-name mynetwork.local

! ✅ Create a user with privileges and a password:
SW1(config)# username admin privilege 15 secret MySecurePass

! ✅ Generate encryption keys for SSH:
SW1(config)# crypto key generate rsa
! When asked: How many bits? Choose at least 1024:
How many bits in the modulus [512]: 1024

! ✅ Enable SSH version 2:
SW1(config)# ip ssh version 2

! ✅ Log in on VTY lines (remote control port):
SW1(config)# line vty 0 4

! ✅ Specify the login method (local):
SW1(config-line)# login local

! ✅ Allow access using Telnet and SSH:
SW1(config-line)# transport input ssh telnet

! ⏲️ (Optional) Set idle session timeout:
SW1(config-line)# exec-timeout 5 0

! 🔑 (Optional for Telnet only) Direct password:
SW1(config-line)# password telnetpass

! 🚪 Exit setup:
SW1(config-line)# exit

! 💾 Save settings:
SW1# write memory
```

### 🧪 Test connection after setup (from PC on Packet Tracer):

Telnet:

```
telnet 192.168.X.X
```

SSH:

```
ssh -l admin 192.168.X.X
```

### 💡 Important Notes:
Make sure that the sending device (PC) and the receiving device (Switch/Router) are on the same network or that there is routing between them.

In Packet Tracer:

- Use Command Prompt from within the PC (from the Desktop menu).
- Make sure Terminal is enabled.

| Status | Recommendation |
| -------------------------------- | ------------------------------ |
| Production environment (corporate, sensitive network) | Use SSH only |
| Test or training environment | You can use Telnet |
| You want a secure login | Use SSH with a private key |
| When using ACLs | Access can be restricted to SSH only |