//the enums of colors : 
//#include <iostream>
//using namespace std;
//enum enScreenColor {Red=1, Blue = 2,Green=3, yellow =4};
//
//int main()
//{
//	cout << "====================================\n";
//	cout << "Chosse in Number of Color : " << endl;
//	cout << "Red (1)" << endl;
//	cout << "Blue (2)" << endl;
//	cout << "Green (3)" << endl;
//	cout << "Yellow (4)" << endl;
//	cout << "====================================\n";
//
//	int ChosseColor;
//	cout << "Enter The Number : ";
//	cin >> ChosseColor;
//
//	enScreenColor Color;
//	Color = (enScreenColor) ChosseColor;
//
//	if ( ChosseColor == enScreenColor::Red )
//	{
//		system("color 4F");
//	}
//	else if (ChosseColor == enScreenColor::Blue)
//	{
//		system("color 1F");
//	}
//	else if (ChosseColor == enScreenColor::Green)
//	{
//		system("color 2F");
//	}
//	else if (ChosseColor == enScreenColor::yellow)
//	{
//		system("color 6F");
//	}
//	else
//	{
//		system("color 9F");
//	}
//}

// The Enums of Countrys :
#include <iostream>
using namespace std;

enum enChosseCountry { Egypt = 1, Jordan = 2, Tunisa = 3, Algeria = 4, Oman = 5, Iraq = 6 };

int main()
{
	cout << "=================================================\n";
	cout << "Egypt (1)" << endl;
	cout << "Jordan (2)" << endl;
	cout << "Tunisa (3)" << endl;
	cout << "Algeria (4)" << endl;
	cout << "Oman (5)" << endl;
	cout << "Iraq (6)" << endl;
	cout << "enter the Number of Country : ";

	int NumCounry;
	cin >> NumCounry;
	cout << "=================================================\n";

	enChosseCountry Country;
	Country = (enChosseCountry) NumCounry;

	if (NumCounry == enChosseCountry::Egypt)
	{
		cout << "The Counry is Egypt" << endl;
	}
	else if (NumCounry == enChosseCountry::Tunisa)
	{
		cout << "The Counry is Tunisa" << endl;
	}
	else if (NumCounry == enChosseCountry::Jordan)
	{
		cout << "The Counry is Jordan" << endl;
	}
	else if (NumCounry == enChosseCountry::Algeria)
	{
		cout << "The Counry is Algeria" << endl;
	}
	else if (NumCounry == enChosseCountry::Oman)
	{
		cout << "The Counry is Oman" << endl;
	}
	else if (NumCounry == enChosseCountry::Iraq)
	{
		cout << "The Counry is Iraq" << endl;
	}
	else 
	{
		cout << "Error You can enter Again .";
	}
}