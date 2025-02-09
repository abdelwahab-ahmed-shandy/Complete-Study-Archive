#include <iostream>
using namespace std;

void MyFunction()
{
	cout << "This is my first function , it got executed :-)" << endl;
}

void MyCardInfo()
{
	cout << endl << "**************************************\n";
	cout << "Name : Abdelwahab Shandy " << endl; 
	cout << "City : Cairo " << endl;
	cout << "Country : Egypt" << endl; 
	cout << "**************************************\n";
}

void MyPrintStars()
{
	cout << endl <<"****************" << endl; 
	cout << "****************" << endl;
	cout << "****************" << endl;
	cout << "****************" << endl;
}

void IloveProgramming()
{
	cout << endl << "I Love Programming !" << endl;
	cout << "I Promise to be the best developer ever !" << endl;
	cout << "I Know it will take some time to proctice , but I will achieve my goal." << endl;
	cout << "Best Regards ," << endl;
	cout << "Abdelwahab Shamdy ." << endl;
}
void H()
{
	cout << endl;
	cout << "*      *" << endl;
	cout << "*      *" << endl;
	cout << "*      *" << endl;
	cout << "*      *" << endl;
	cout << "********" << endl;
	cout << "*      *" << endl;
	cout << "*      *" << endl;
	cout << "*      *" << endl;
	cout << "*      *" << endl;
}
void MySumProcedures()
{
	int Num1, Num2, Result;
	cout << "Please Enter Number1 ?" << endl;
	cin >> Num1;
	cout << "Please Enter Number2 ?" << endl;
	cin >> Num2;
	cout << "*******************************\n";
	Result = Num1 + Num2;
	cout << Result << endl;
}
float MySumFunction()
{
	float Num1 , Num2 ;
	cout << "Please Enter Number1 ?" << endl;
	cin >> Num1;
	cout << "Please Enter Number2 ?" << endl;
	cin >> Num2;
	cout << "*******************************\n";
	return Num1 + Num2;
}

int main()
{
	//MyFunction();
	//MyCardInfo();
	//MyPrintStars();
	//IloveProgramming();
	//H();
	//MySumProcedures();
	cout <<MySumFunction()<<endl ;
};