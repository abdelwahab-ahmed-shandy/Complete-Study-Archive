//problem 33
//#include <iostream>
//using namespace std;
//
//int main()
//{
//	float Grade;
//	cout << "Enter Your Grade : ";
//	cin >> Grade;
//
//	if (Grade <= 100 && Grade >=90)
//	{
//		cout << "The Grade is 'A' " << endl;
//	}
//	else if (Grade <= 89 && Grade >= 80)
//	{
//		cout << "The Grade is 'B' " << endl;
//	}
//	else if (Grade <= 79 && Grade >= 70)
//	{
//		cout << "The Grade is 'C' " << endl;
//	}
//	else if (Grade <= 69 && Grade >= 60)
//	{
//		cout << "The Grade is 'D' " << endl;
//	}
//	else if (Grade <= 59 && Grade >= 50)
//	{
//		cout << "The Grade is 'B' " << endl;
//	}
//	else
//	{
//		cout << "The Grade is 'F' " << endl;
//	}
//}
//==============================================================================
//Problem 34
//#include <iostream>
//using namespace std;
//
//int main()
//{
//	float TotalSalse;
//	cout << "Enter Your Total Salse : ";
//	cin >> TotalSalse;
//
//	if (TotalSalse >= 10000000)
//	{
//		cout << "The Percentage 1% is : " << (TotalSalse) * (0.01) << endl;
//	}
//	else if (TotalSalse <= 1000000 && TotalSalse >= 500000)
//	{
//		cout << "The Percentage 2% is : " << (TotalSalse) * (0.02) << endl;
//	}
//	else if (TotalSalse <= 500000 && TotalSalse >= 100000)
//	{
//		cout << "The Percentage 3% is : " << (TotalSalse) * (0.03) << endl;
//	}
//	else if (TotalSalse <= 100000 && TotalSalse >= 50000)
//	{
//		cout << "The Percentage 5% is : " << (TotalSalse) * (0.05) << endl;
//	}
//	else
//	{
//		cout << "The Not Percentage is : " << (TotalSalse) << endl;
//	}
//}
//==============================================================================
//Problem 36
//#include <iostream> 
//using namespace std;
//
//int main()
//{
//	string Operation;
//	int Num1, Num2;
//	cout << "Enter Number 1 : ";
//	cin >> Num1;
//
//	cout << "Enter Operation ( + , - , * , / ) : ";
//	cin >> Operation;
//
//	cout << "Enter Number 2 : ";
//	cin >> Num2;
//
//	if (Operation == "+" )
//	{
//		cout << "The "<< Num1 <<" + " <<Num2 <<" = " << Num1 + Num2 << endl;
//	}
//	else if (Operation == "-")
//	{
//		cout << "The " << Num1 << " - " << Num2 << " = " << Num1 - Num2 << endl;
//	}
//	else if (Operation == "*")
//	{
//		cout << "The " << Num1 << " * " << Num2 << " = " << Num1 * Num2 << endl;
//	}
//	else if (Operation == "/")
//	{
//		cout << "The " << Num1 << " / " << Num2 << " = " << Num1 / Num2 << endl;
//	}
//	else
//	{
//		cout << "Error Can You try Again ." << endl;
//	}
//}
//==============================================================================
//Problem 44
//#include <iostream>
//using namespace std;
//
//int main()
//{
//	int WINOfDay ;
//
//	cout << "Enter To Day Number : ";
//	cin >> WINOfDay;
//
//	if ( WINOfDay == 1)
//	{
//		cout << "It's a Sunday " << endl;
//	}
//	else if (WINOfDay == 2)
//	{
//		cout << "It's a Monday " << endl;
//	}
//	else if (WINOfDay == 3)
//	{
//		cout << "It's a Tuesday " << endl;
//	}
//	else if (WINOfDay == 4)
//	{
//		cout << "It's a Wednesday " << endl;
//	}
//	else if (WINOfDay == 5)
//	{
//		cout << "It's a Thursday " << endl;
//	}
//	else if (WINOfDay == 6)
//	{
//		cout << "It's a Friday " << endl;
//	}
//	else if (WINOfDay == 7)
//	{
//		cout << "It's a Saturday " << endl;
//	}
//	else
//	{
//		cout << "Error you can enter days Number in 1 to 7 only" << endl;
//	}
//}
//==============================================================================
//Problem 44
#include <iostream>
using namespace std;

int main()
{
	int MonthNumber;
	cout << "Enter The Month Number : ";
	cin >> MonthNumber;

	if ( MonthNumber == 1 )
	{
		cout << "The Month is a January " << endl;
	}
	else if (MonthNumber == 2)
	{
		cout << "The Month is a February " << endl;
	}
	else if (MonthNumber == 3)
	{
		cout << "The Month is a March " << endl;
	}
	else if (MonthNumber == 4)
	{
		cout << "The Month is a April " << endl;
	}
	else if (MonthNumber == 5)
	{
		cout << "The Month is a May " << endl;
	}
	else if (MonthNumber == 6)
	{
		cout << "The Month is a June " << endl;
	}
	else if (MonthNumber == 7)
	{
		cout << "The Month is a July " << endl;
	}
	else if (MonthNumber == 8)
	{
		cout << "The Month is a August " << endl;
	}
	else if (MonthNumber == 9)
	{
		cout << "The Month is a September " << endl;
	}
	else if (MonthNumber == 10)
	{
		cout << "The Month is a October " << endl;
	}
	else if (MonthNumber == 11)
	{
		cout << "The Month is a November " << endl;
	}
	else if (MonthNumber == 12)
	{
		cout << "The Month is a December " << endl;
	}
	else
	{
		cout << "The Month Number is Error , You Can add a new number . " << endl;

	}
}