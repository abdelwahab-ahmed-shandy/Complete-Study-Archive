# 📘 Chapter 2: Managing Files from the Command Line

---

## 📂 Absolute and Relative Paths

```bash
cd                  # Move to the current user's home directory
cd /root/Videos     # Move to an absolute path
cd Videos           # Move to a relative path
pwd                 # Display the current path
cd /root/Documents  # Move to another absolute path
cd ~abeer           # Move to the home directory of user 'abeer'
cd -                # Go back to the previous directory
cd ..               # Move up one level
cd ../..            # Move up two levels
```

---

## 📄 Viewing Files

```bash
ls          # List directory contents
ls -l ~     # Long format listing
ls -a       # Show all files (including hidden)
ls -la      # Long + all
ls -lh      # Long listing with human-readable sizes
ls -R       # Recursive listing of directories
ls -t       # Sort by modification time
ls -r       # Reverse order
dir         # Another command similar to ls
dir --color # Color output
```

---

## 📁 Creating Files

```bash
touch file1 FILE1               # Create files (case-sensitive)
touch /root/Documents/file      # Create a file at a specific path
ls -R                           # View contents recursively
```

---

## 🗂️ Creating Folders

```bash
mkdir dir1 dir2 dir3         # Create multiple folders
mkdir -p dir4/dir5           # Create nested folders
mkdir 'A S'                  # Folder with space in name
mkdir "A S"                  # Alternative way
mkdir A\ S                  # Escape space with backslash
```

---

## 📄 Copying Files and Folders

```bash
cp file1 file2                               # Copy file1 to file2
cp file1 /root/Documents/                    # Copy file1 to a directory
cp file1 file2 file3 /root/Documents/        # Copy multiple files to a directory
cp -r /etc/ dir1                             # Copy a folder recursively
cp -r /etc/* dir1                            # Copy only contents of a folder
cp ~/file1 .                                 # Copy from home to current directory
```

---

## 🔀 Moving / Renaming

```bash
mv file1 new_file1                           # Rename file1 to new_file1
mv file1 file2 file3 /root/Documents/        # Move multiple files
mv dir1 dir2 dir3 dir4                       # Move multiple folders
```

---

## 🗑️ Deleting Files and Folders

```bash
rm file1                  # Delete a file
rm -f file1 file2         # Force delete files
rm -d dir1                # Delete empty folder
rmdir dir1                # Also deletes empty folder
rm -rf dir1               # Delete a non-empty folder recursively
```

---

## ✨ Globbing

```bash
touch alfa bravo charlie delta echo able baker cast dog easy

ls a*       # Starts with 'a'
ls *a       # Ends with 'a'
rm -f a*    # Delete files starting with 'a'
ls *a*      # Contains 'a'
ls [!a]*    # Does NOT start with 'a'
ls [ac]*    # Starts with 'a' or 'c'
ls ????     # Four-letter names
ls ?????    # Five-letter names

# Advanced examples:
touch file1 file2 file3 file4 file11 file12 file111 filea fileb fileab fa fab fabc

ls f?           # 2-letter names starting with 'f'
ls f??          # 3-letter names starting with 'f'
ls file[a-c]    # filea, fileb, or filec
ls file[^a-c]   # Any file except a-c after 'file'
echo ~abeer     # Show home path for user 'abeer'
```

---

## 📦 Variables

```bash
x=5
echo x              # Prints: x
echo $x             # Prints: 5

echo "Today is $(date)"              # Embed command output
echo "Sum of 1 plus 2 is $[1+2]"     # Arithmetic using $[]
echo "Sum of 1 plus 2 is $((1+2))"   # Arithmetic using $(())
```

---

### ✍️ Author: Abdelwahab Shandy
