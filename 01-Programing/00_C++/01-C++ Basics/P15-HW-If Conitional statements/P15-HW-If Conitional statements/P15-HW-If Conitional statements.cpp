// Problem 4 
//#include <iostream>
//using namespace std;
//
//int main()
//{
//	int Age;
//	bool DriverLicence;
//
//	cout << "Enter your Age : ";
//	cin >> Age;
//
//	cout << "Are you have Driver Licence (True = 1 or False = 0) : ";
//	cin >> DriverLicence;
//
//	if (Age >= 21 && DriverLicence == true)
//	{
//		cout << "Hired" << endl;
//	}
//	else
//	{
//		cout << "Rejected" << endl;
//	}
//	cout << "Good Luck '))" << endl;
//}
//================================================================================
// Problem 8 
//#include <iostream>
//using namespace std;
//
//int main()
//{
//	float Mark;
//	cout << "enter your mark : ";
//	cin >> Mark;
//	if (Mark >= 50)
//	{
//		cout << "Your Pass ." << endl;
//	}
//	else
//	{
//		cout << "Your Fail ." << endl;
//	}
//	cout << "You Can Enter Again ') ";
//}
//================================================================================
// Problem 11 
//#include <iostream>
//using namespace std;
//
//int main()
//{
//	float Mark1, Mark2, Mark3 ,Avarage;
//
//	cout << "Enter Mark 1 : ";
//	cin >> Mark1;
//
//	cout << "Enter Mark 2 : ";
//	cin >> Mark2;
//
//	cout << "Enter Mark 3 : ";
//	cin >> Mark3;
//
//	Avarage = (Mark1 + Mark2 + Mark3) / 3;
//
//	if (Avarage >= 50)
//	{
//		cout << "Pass" << endl;
//	}
//	else
//	{
//		cout << "Fail" << endl;
//	}
//	cout << "You can enter Number Again ') " << endl;
//}
//================================================================================
// Problem 24
//#include <iostream>
//using namespace std;
//int main() 
//{
//	int Age;
//
//	cout << "Enter your Age : ";
//	cin >> Age;
//
//	if (Age >=18 && Age <=45)
//	{
//		cout << "Your Valid Age ') " << endl;
//	}
//	else
//	{
//		cout << "Your INValid Age ') " << endl;
//	}
//	cout << "You can Try Again '))" << endl;
//}
//================================================================================
// Problem 49
#include <iostream> 
using namespace std;

int main()
{
	int PinCode;
	cout << "Enter The Pin Code : ";
	cin >> PinCode;

	if (PinCode == 1234)
	{
		cout << "The Balance is 7500$ " << endl;
	}
	else
	{
		cout << "The Pin Code Is Wrong , You can Enter Again " << endl;
	}
	cout << "welcome to ATM ') ";
}