#include <iostream>
#include <cmath>
#include <string>
using namespace std;

struct strPersonalInfo
{
	string FirstName;
	string LastName;
	string Phone;
	int Age;
};
void ReadInfo(strPersonalInfo &Info )
{
	cout << "Enter your First Name ?" << endl;
	cin >> Info.FirstName;
	cout << "Enter your Last Name ?" << endl;
	cin >> Info.LastName;
	cout << "Enter your Phone ?" << endl;
	cin >> Info.Phone;
	cout << "Enter your Age ?" << endl;
	cin >> Info.Age;
}
void PrintInfo(strPersonalInfo Info)
{
	cout << "*************************************************\n";
	cout << "The First Name : " << Info.FirstName << endl;
	cout << "The Last Name : " << Info.LastName << endl;
	cout << "The Phone : " << Info.Phone << endl;
	cout << "The Age : " << Info.Age << endl;
	cout << "*************************************************\n";
}

int main()
{
	strPersonalInfo person1, person2;
	//person1
	ReadInfo(person1);
	PrintInfo(person1);
	//person2
	ReadInfo(person2);
	PrintInfo(person2);

}