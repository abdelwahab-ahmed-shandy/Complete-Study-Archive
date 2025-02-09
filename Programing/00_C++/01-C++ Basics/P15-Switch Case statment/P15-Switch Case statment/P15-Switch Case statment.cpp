//#include <iostream>
//using namespace std;
//
//int main()
//{
//	int day = 8;
//
//	switch (day)
//	{
//	case 1 :
//		cout << "Sunday";
//		break;
//	case 2:
//		cout << "Monday";
//		break;
//	case 3:
//		cout << "Tusday";
//		break;
//	case 4:
//		cout << "Wensday";
//		break;
//	case 5:
//		cout << "Thruday";
//		break;
//	case 6:
//		cout << "Friday";
//		break;
//	case 7:
//		cout << "Satarday";
//		break;
//	default:
//		cout << "That Not Found";
//		break;
//	}
//}
//=================================================================================
//#include <iostream>
//using namespace std;
//
//enum enColorsScreen {Red = 1 ,Blue =2 , Green = 3 , Yellow =4};
//
//int main()
//{
//	cout << "***************************************\n";
//	cout << "Chosse the color on screen : \n";
//	cout << "(1) Red" << endl; 
//	cout << "(2) Blue" << endl;
//	cout << "(3) Green" << endl;
//	cout << "(4) Yellow" << endl;
//	cout << "***************************************\n";
//	cout << "Chosse Number : ";
//
//	int NumChosse;
//
//	cin >> NumChosse;
//
//	enColorsScreen Color;
//	Color = (enColorsScreen)NumChosse;
//
//	switch (NumChosse)
//	{
//
//	case enColorsScreen::Red:
//		system("color 4F");
//		break;
//	
//	case enColorsScreen::Blue:
//		system("color 1F");
//			break;
//
//	case enColorsScreen::Green:
//		system("color 2F");
//		break;
//
//	case enColorsScreen::Yellow:
//		system("color 6F");
//		break;
//	
//	default:
//		cout << "Not Found ') ";
//	}
//
//}
//=====================================================================================
//problem 36 this Big Error 

//#include <iostream>
//using namespace std;
//
//int main()
//{
//	int Num1, Num2;
//	int Operation;
//
//	cout << "Enter Number 1 : "<<endl; 
//	cin >> Num1;
//
//	cout << "Enter Operation ( + - * / ) : ";
//	cin >> Operation;
//
//	cout << "Enter Number 2 : " ;
//	cin >> Num2;
//
//	switch (Operation)
//	{
//	case + :
//		cout << "The Number1 + Number2 = " << Num1 + Num2 << endl;
//		break;
//	case - :
//		cout << "The Number1 - Number2 = " << Num1 - Num2 << endl;
//		break;
//
//	case * :
//		cout << "The Number1 * Number2 = " << Num1 * Num2 << endl;
//		break;
//	case / :
//		cout << "The Number1 / Number2 = " << Num1 / Num2 << endl;
//		break;
//	default:
//		cout << "Not Found";
//		break;
//	}
//
//}
//================================================================
//problem 44
//#include <iostream>
//using namespace std;
//
//enum enDays {Sunday = 1, Monday=2,Tuesday=3,Wednesday=4,Thursday=5,Friday=6,Saturday=7};
//
//int main()
//{
//	cout << "Enter Number of Day : ";
//	
//	int NumDay;
//	cin >> NumDay;
//
//	enDays Day;
//	Day = (enDays) NumDay;
//
//	switch (NumDay)
//	{
//	case enDays::Sunday :
//		cout << "The Day is Sunday. ";
//			break;
//	case enDays::Monday :
//		cout << "The Day is Monday. ";
//		break;
//	case enDays::Tuesday:
//		cout << "The Day is Tuesday. ";
//		break;	
//	case enDays::Wednesday:
//			cout << "The Day is Wednesday. ";
//			break;
//	case enDays::Thursday :
//		cout << "The Day is Thursday. ";
//		break;
//	case enDays::Friday:
//		cout << "The Day is Friday. ";
//		break;
//	case enDays::Saturday:
//		cout << "The Day is Saturday. ";
//		break;
//
//	default:
//		cout << "Not Found , You Can Enter Day Again ') ";
//		break;
//	}
//}
//=====================================================================
#include <iostream>
using namespace std;

enum enMonths {Jan=1 , Feb=2, Mar=3, Apr=4, May=5, Jun=6, Jul=7, Aug=8, Sep=9, Oct=10, Nov=11, Dec=12};

int main()
{
	int Month;
	cout << "Enter the Number Of Month : ";
	cin >> Month;

	enMonths ChosseMonth;
	ChosseMonth = (enMonths)Month;

	switch (Month)
	{
	case enMonths::Jan :
		cout << "This is a January";
			break;
	case enMonths::Feb:
		cout << "This is a February";
		break;
	case enMonths::Mar:
		cout << "This is a March";
		break;
	case enMonths::Apr:
		cout << "This is a April";
		break;
	case enMonths::May:
		cout << "This is a May";
		break;
	case enMonths::Jun:
		cout << "This is a June";
		break;
	case enMonths::Jul:
		cout << "This is a July";
		break;
	case enMonths::Aug:
		cout << "This is a August";
		break;
	case enMonths::Sep:
		cout << "This is a September";
		break;
	case enMonths::Oct:
		cout << "This is a October";
		break;
	case enMonths::Nov:
		cout << "This is a November";
		break;
	case enMonths::Dec:
		cout << "This is a December";
		break;
	default:
		cout << "Not Found , You Can Enter Month Again ') ";
		break;
	}
}

