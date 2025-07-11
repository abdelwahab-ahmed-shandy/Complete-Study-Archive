#include <iostream>
using namespace std;

struct MyAddress
{
	string street;
	int NumHouse;
	int NumApartment;
};

struct MySalary
{
	int Monthly;
};
struct ContactUs
{
	int Phone;
	string Email;
	string Linkedin;
	string Medium;
	string Github;
};
struct personalInfo
{
	string FullName;
	int Age;
	int Id;
	char Gender;
	bool Married;
	string City;
	string Country;
	ContactUs MyContactUs;
	MySalary mySalary;
	MyAddress myAddress;
};


int main()
{
	personalInfo person_1;

	cout << "Enter Your Full Name : ";
	cin >> person_1.FullName;
	
	cout << "Enter Your Age : ";
	cin >> person_1.Age;
	
	cout << "Enter Your Id Number : ";
	cin >> person_1.Id;
	
	cout << "Enter Your City : ";
	cin >> person_1.City;
	
	cout << "Enter Your Country : ";
	cin >> person_1.Country;
	
	cout << "Enter Your Street : ";
	cin >> person_1.myAddress.street;
	
	cout << "Enter Your House Number : ";
	cin >> person_1.myAddress.NumHouse;

	cout << "Enter Your Apartment Number : ";
	cin >> person_1.myAddress.NumApartment;
	
	cout << "Enter Your Gender (M OR W) : ";
	cin >> person_1.Gender;

	cout << "Enter Your Married (true OR false) : ";
	cin >> person_1.Married;
	
	cout << "Enter Your Phone Number : ";
	cin >> person_1.MyContactUs.Phone;
	
	cout << "Enter Your Email : ";
	cin >> person_1.MyContactUs.Email;
	
	cout << "Enter Your Linkedin : ";
	cin >> person_1.MyContactUs.Linkedin;
	
	cout << "Enter Your GitHub : ";
	cin >> person_1.MyContactUs.Github;
	
	cout << "Enter Your Medium : ";
	cin >> person_1.MyContactUs.Medium;
	
	cout << "Enter Your Monthly Salary : ";
	cin >> person_1.mySalary.Monthly;
	
	cout << "\n***************************************************************\n";
	cout << "Name : " << person_1.FullName << endl; 
	cout << "Age : " << person_1.Age << endl;
	cout << "City : " << person_1.City << endl;
	cout << "Country : " << person_1.Country << endl;
	cout << "Montly Salary : " << person_1.mySalary.Monthly << endl;
	person_1.mySalary.Monthly = person_1.mySalary.Monthly * 12; 
	cout << "Yearly Salary : " << person_1.mySalary.Monthly << endl;
	cout << "Gender : " << person_1.Gender << endl;
	cout << "Married : " << person_1.Married << endl;
	cout << "Street Address : " << person_1.myAddress.street << endl;
	cout << "House Number : " << person_1.myAddress.NumHouse << endl;
	cout << "Apartment Number : " << person_1.myAddress.NumApartment << endl;
	cout << "Phone : " << person_1.MyContactUs.Phone << endl;
	cout << "Email : " << person_1.MyContactUs.Email << endl;
	cout << "Github : " << person_1.MyContactUs.Github << endl;
	cout << "Linkedin : " << person_1.MyContactUs.Linkedin << endl;
	cout << "Medium : " << person_1.MyContactUs.Medium << endl;
	cout << "***************************************************************\n";
}
/****************************************************************
Name : Abdelwahab_Shandy
Age : 22
City : cairo
Country : egypt
Montly Salary : 5000
Yearly Salary : 60000
Gender : M
Married : 0
Street Address : 11St_Saad_AinShams
House Number : 1
Apartment Number : 2
Phone : 1017#####3
Email : abdelwahabshandy@gmail.com
Github : https://github.com/Abdelwahab90
Linkedin : https://www.linkedin.com/in/abdelwahab-shandy/
Medium : https://medium.com/@abdelwahabshandy
****************************************************************/

