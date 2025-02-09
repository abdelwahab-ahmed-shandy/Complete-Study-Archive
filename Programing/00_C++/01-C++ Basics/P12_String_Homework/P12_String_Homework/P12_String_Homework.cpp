#include <iostream>
#include <string>
using namespace std;
int main()
{
	string FullName;
	cout << "Enter String 1 ?" << endl;
	getline(cin, FullName);
	//cout << "The Full Name : " << FullName << endl;

	string str2, str3;
	cout << "Please Enter String 2 : " << endl;
	cin >> str2;
	cout << "Please Enter String 3 : " << endl;
	cin >> str3;

	cout << "*************************************************\n";

	cout << "The Length of String1 is " << FullName.length() << endl;

	cout << "Charactars at 0,2,4,7 are : " << FullName[0] << FullName[2] << FullName[4] << FullName[7] << endl;

	cout << "Cancatenating String2 and String3 = " << str2 + str3 << endl;

	cout << str2 << " * " << str3 << " = " << stoi(str2) * stoi(str3);

};