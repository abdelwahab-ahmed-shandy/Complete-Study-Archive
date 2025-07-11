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

void ReadManyPersonal(int &ManyPersonal)
{
	cout << "***************************************\n";
	cout << "                  INPUT                \n";
	cout << "***************************************\n";
	cout << "How Many Enter the Personal Info : ";
	cin >> ManyPersonal;
}

void ReadInfoPersonal(strPersonalInfo Persnal[100] , int ManyPersonal)
{
	for (int i = 0 ; i <= ManyPersonal -1 ; i++)
	{
		cout << "============================================\n";
		cout << "Enter Personal Info Number " << i + 1 << endl;
		cout << "Enter Your First Name : "  ;
		cin >> Persnal[i].FirstName;

		cout << "Enter Your Last Name : ";
		cin >> Persnal[i].LastName;

		cout << "Enter Your Phone : ";
		cin >> Persnal[i].Phone;

		cout << "Enter Your Age : ";
		cin >> Persnal[i].Age;
		cout << "============================================\n\n";
	}
}

void PrintInfoPersonal(strPersonalInfo Personal[100], int ManyPersonal)
{
	cout << "***************************************\n";
	cout << "                 OUTPUT                \n";
	cout << "***************************************\n";

	for (int i = 0; i <= ManyPersonal - 1 ; i++)
	{
		cout << "Personal " << i + 1 << " Info : " << endl;
		cout << "============================================\n";
		cout << "First Name : " << Personal[i].FirstName << endl;
		cout << "Last Name : " << Personal[i].LastName << endl;
		cout << "Age : " << Personal[i].Age << endl;
		cout << "Phone : " << Personal[i].Phone << endl;
		cout << "============================================\n";
	}
}

int main()
{
	int MantPersonal;
	strPersonalInfo Personal[100];
	ReadManyPersonal(MantPersonal);
	ReadInfoPersonal(Personal, MantPersonal);
	PrintInfoPersonal(Personal, MantPersonal);
}