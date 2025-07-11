#include <iostream>
#include <string>
#include <cmath>
using namespace std;

struct strPersonInfo
{
	string FullName;
	int Age;
	string City;
	string Country;
	float MonthlySalary;
	char Gendar;
	bool Married;
};
void ReadPersonInfo(strPersonInfo &perInfo)
{
	cout << "What is Your FullName ?" << endl;
	getline(cin, perInfo.FullName);
	cout << "What is Your Age ?" << endl;
	cin >> perInfo.Age;
	cout << "What is Your City ?" << endl;
	cin >> perInfo.City;
	cout << "What is Your Country ?" << endl;
	cin >> perInfo.Country;
	cout << "What is Your Monthly Salary ?" << endl;
	cin >> perInfo.MonthlySalary;
	cout << "What is Your Gender (M or W) ?" << endl;
	cin >> perInfo.Gendar;
	cout << "What is Your Married (true or false) ?" << endl;
	cin >> perInfo.Married;
}
void PrintPersonInfo(strPersonInfo perInfo)
{
	cout << "***************************************\n";
	cout << "Name : " << perInfo.FullName << endl;
	cout << "Age : " << perInfo.Age << endl;
	cout << "City : " << perInfo.City << endl;
	cout << "Country : " << perInfo.Country << endl;
	cout << "Monthly Salary : " << perInfo.MonthlySalary << endl;
	cout << "Yearly Salary : " << perInfo.MonthlySalary * 12 << endl;
	cout << "Gender : " << perInfo.Gendar << endl;
	cout << "Married : " << perInfo.Married << endl;
	cout << "***************************************\n";
}


int main()
{
	strPersonInfo person1;
	ReadPersonInfo(person1);
	PrintPersonInfo(person1);
}