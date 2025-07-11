#include <iostream>
using namespace std;

struct strInfo 
{
	string FirstName;
	string LastName;
	string Phone;
	int Age;
};
void ReadInfo(strInfo &Info) 
{
	cout << "Enter Your First Name : ";
	cin >> Info.FirstName;

	cout << "Enter Your Last Name : ";
	cin >> Info.LastName;

	cout << "Enter Your Age : ";
	cin >> Info.Age;

	cout << "Enter Your Phone : ";
	cin >> Info.Phone;
}
void PrintInfo(strInfo Info)
{
	cout << "*********************************\n";
	cout << "First Name : " << Info.FirstName << endl;
	cout << "Last Name : " << Info.LastName << endl;
	cout << "Phone : " << Info.Phone << endl;
	cout << "Age : " << Info.Age << endl;
	cout << "*********************************\n";
}

void ReadPersonal(strInfo Personal[2])
{
	ReadInfo(Personal[0]);
	ReadInfo(Personal[1]);
}
void PrintPersonal(strInfo Personal[2])
{
	PrintInfo(Personal[0]);
	PrintInfo(Personal[1]);
}

int main()
{
	strInfo Peronals[2];
	ReadPersonal(Peronals);
	PrintPersonal(Peronals);
}