#include <iostream>
using namespace std;

enum MyGender {Male, Female };
enum MyType { Single, Maried};
enum Myfovcolor {Red,Blue,Green,yellow};
struct MySalary
{
	int Monthly;
};
struct infoPerson
{	
	string FullName;
	int id;
	int Age;
	string City;
	string Contry;
	MySalary mysalary;
};

int main()
{
	infoPerson ID_1;
	cout << "Enter your Name : ";
	cin >> ID_1.FullName;
	cout << "Enter your Age : ";
	cin >> ID_1.Age;
	cout << "Enter your Id : ";
	cin >> ID_1.id;
	cout << "Enter your City : ";
	cin >> ID_1.City;
	cout << "Enter your Contry : ";
	cin >> ID_1.Contry;
	cout << "Enter your Monthly Salary : ";
	cin >> ID_1.mysalary.Monthly;
	
	cout << "************************************************\n";
	cout << "Name : " << ID_1.FullName << endl;
	cout << "Age : " << ID_1.Age << endl;
	cout << "ID : " << ID_1.id << endl;
	cout << "City : " << ID_1.City << endl;
	cout << "Country : " << ID_1.Contry << endl;
	cout << "Monthly Salary : " << ID_1.mysalary.Monthly << endl;
	cout << "Yearly Salary : " << ID_1.mysalary.Monthly * 12 << endl;
	cout << "Gender : " << MyGender::Male << endl;
	cout << "Married : " << MyType::Single << endl;
	cout << "************************************************\n";
}
