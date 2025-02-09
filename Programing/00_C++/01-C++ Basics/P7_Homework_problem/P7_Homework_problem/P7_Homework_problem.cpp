#include <iostream>
using namespace std;
int main()
{
	////Problem_7 Half Number (Done)
	//int Num;
	//cout << "Enter Your Number" << endl;
	//cin >> Num;
	//cout << "Half of the " << Num << " is " << Num / 2 << endl;
	////--------------------------------------------------------------------
	//Problem_9 Sum of 3 Numbers (Done)
	/*int Num1, Num2, Num3;
	cout << "Enter Number 1 : " << endl;
	cin >> Num1;
	cout << "Enter Number 2 : " << endl;
	cin >> Num2;
	cout << "Enter Number 3 : " << endl;
	cin >> Num3;
	cout << "The Sum = "<<Num1 + Num2 + Num3 <<endl;*/
	////--------------------------------------------------------------------
	//Problem_10 Average of 3 Marks (Done)
	/*float Mark1, Mark2, Mark3;
	cout << "Enter your Mark 1 : " << endl;
	cin >> Mark1;
	cout << "Enter your Mark 2 : " << endl;
	cin >> Mark2;
	cout << "Enter your Mark 3 : " << endl;
	cin >> Mark3;
	float Avg = (Mark1 + Mark2 + Mark3) / 3;
	cout << "The Average of entered marks = "<< Avg << endl;*/
	////--------------------------------------------------------------------
	//Problem_14 Swap Numbers(Done)
	//int Num1, Num2, temp;
	//// Request the user to enter the two numbers
	//cout << "Enter Number 1 : ";
	//cin >> Num1;
	//cout << "Enter Number 2 : ";
	//cin >> Num2;
	////Print numbers before switching
	//cout << "-----------------------------";
	//cout << "Print numbers before switching" << endl;
	//cout << "Number 1 is :" << Num1 << endl;
	//cout << "Number 2 is :" << Num2 << endl;
	//cout << "-----------------------------";
	//// Print numbers after switching
	//temp = Num1;
	//Num1 = Num2;
	//Num2 = temp;
	//cout << "Print numbers after switching" << endl;
	//cout << "Number 1 is :" << Num1 << endl;
	//cout << "Number 2 is :" << Num2 << endl;
	//cout << "-----------------------------";
	////--------------------------------------------------------------------
	//Problem_15 Rectangle Area (Done)
	/*float A, B;
	cout << "Enter Length of rectangle :" ;
	cin >> A;
	cout << "Enter Width of rectangle :";
	cin >> B;
	float ​​RectangleArea = A * B;
	cout << "-------------------------\n";
	cout << "Area of rectangle : "<< ​​RectangleArea << endl;*/
	////--------------------------------------------------------------------
	//Problem_17 Triangle Area (Done)
	/*float Base, Height;
	cout << "Enter your Base of triangle : ";
	cin >> Base;
	cout << "Enter your Height of ​​triangle : ";
	cin >> Height;
	float AreaOfTriangle = (0.5 * Base) * Height;
	cout << "------------------------------\n";
	cout <<"The Area Of Triangle : " << AreaOfTriangle << endl;*/
	////--------------------------------------------------------------------
	//Problem_19 Circle Area Through Diameter (Done)
	/*float Diamerter;
	cout << "Enter your Diameter length : " << endl;
	cin >> Diamerter;
	const float PI = 3.14159;
	float CircleArea =( PI * Diamerter * Diamerter )/4 ;
	cout << "-----------------------------------\n";
	cout << "The Area of ​​the circle : "<< CircleArea << endl;*/
	////--------------------------------------------------------------------
	//Problem_20 Circle Area inscribed in a square (Done)
	/*float lengthSquare;
	cout << "Enter your square length : ";
	cin >> lengthSquare;
	const float PI = 3.14159;
	float CircleArea = (PI * lengthSquare * lengthSquare) / 4;
	cout << "-----------------------------------\n";
	cout << "The Area of the circle : " << CircleArea << endl;*/
	////--------------------------------------------------------------------
	//Problem_21 Circle Area Along the circumference (Done)
	/*float circumference;
	cout << "Enter the circumference : ";
	cin >> circumference;
	const float PI = 3.14159;
	cout << "-----------------------------\n";
	cout << "The Circle Area : " << (circumference * circumference)/(4 * PI) <<endl; */
	////--------------------------------------------------------------------
	//Problem_22 Circle Area Inscibed in an Isosceles Triangle (Done)
	/*float Length, Base;
	const float PI = 3.14159;
	cout << "Enter a Length :";
	cin >> Length;
	cout << "Enter a Base :";
	cin >> Base;
	cout << "-------------------------------\n";
	cout << "The Circle Area : " << (PI * Base * Base / 4) * (2 *Length - Base ) / (2 * Length + Base)<< endl; */
	//-------------------------------------------------------------------------------------------------------
	//Problem_31 Power of 2,3,4 (Done)
	//float Number;
	//cout << "Enter a Number : ";
	//cin >> Number;
	//cout << "--------------------\n";
	//cout << "The Number ^ 2 : " << Number * 3 << endl; 
	//cout << "The Number ^ 3 : " << Number * 9 << endl;
	//cout << "The Number ^ 4 : " << Number * 27 << endl;
	//---------------------------------------------------------------------------------------------------
	////Problem_35 piggy Bank Calculater (Done)
	//const int Penny = 1;
	//const int Nickel = 5;
	//const int Dime = 10;
	//const int Quarter = 25;
	//const int Dollar = 100;

	//float ManyPenny;
	//float ManyNickel;
	//float ManyDime;
	//float ManyQuarter;
	//float ManyDollar;

	//cout << "How many Penny : ";
	//cin >> ManyPenny;
	//cout << "How many Nickel : ";
	//cin >> ManyNickel;
	//cout << "How many Dime : ";
	//cin >> ManyDime;
	//cout << "How many Quarter : ";
	//cin >> ManyQuarter;
	//cout << "How many Dollar : ";
	//cin >> ManyDollar;

	//cout << "_____________________________________\n";
	//float TotalPenny = ManyPenny * Penny + ManyNickel * Nickel + ManyDime * Dime + ManyQuarter * Quarter + ManyDollar * Dollar;
	//cout << "The Total Pennies : "<< TotalPenny << endl;
	//
	//float TotalDollar = TotalPenny / 100;
	//cout << "The Total Dollars : "<< TotalDollar << endl;
	//----------------------------------------------------------------------------------------------------------------------------
	//Problem_39 Pay Remainder ? (Done)
	/*float TotalBill, moneypaid;

	cout << "How much is the total bill?" << endl;
	cin >> TotalBill;
	cout << "How much did you pay in cash?" << endl;
	cin >> moneypaid;

	float Paidback = TotalBill - moneypaid;
	cout << "----------------------------------------\n";
	cout << "The Paid Back = " << Paidback << endl;*/
	//----------------------------------------------------------------------------------------------------------------------------
	//Problem_40 Service fee and sales tax (Done)
	/*const float services = 1.1;
	const float SalesTax = 1.16;
	float BillValue;

	cout << "How much is the bill? " << endl;
	cin >> BillValue;

	float TotalBill = services * BillValue;
	cout << "The service fee : "<< TotalBill << endl;
	cout << "The sales tax : " << TotalBill * SalesTax << endl;

	TotalBill = TotalBill * SalesTax;
	cout << "The Total Bill : " << TotalBill << endl;*/
	//----------------------------------------------------------------------------------------------------------------------------
	//Problem_42 Task Duration In Seconds  (Done)
	// to seconds >>>>
	/*float days = 24 * 60 * 60 ;
	float hours = 60 * 60;
	float minutes = 60;
	float seconds = 1;

	float Manydays;
	float Manyhours;
	float Manyminutes;
	float Manyseconds;

	cout << "How Many The Days ?" << endl;
	cin >> Manydays;
	cout << "How Many The hours ?" << endl;
	cin >> Manyhours;
	cout << "How Many The minutes ?" << endl;
	cin >> Manyminutes;
	cout << "How Many The seconds ?" << endl;
	cin >> Manyseconds;

	float TotalSeconds = (Manydays * days) + (Manyhours * hours) + (Manyminutes * minutes) + (Manyseconds * seconds);
	cout <<"_________________________________________\n";
	cout << "Total Time with Seconds : " << TotalSeconds << endl;*/
	//---------------------------------------------------------------------------------------------------------
	//Problem_43 Seconds to Days Hours Minutes Secounds  (Done)
	//int Totalseconds;
	//cout << "How Many The Total Seconds ?" << endl;
	//cin >> Totalseconds;

	//int daysToSec = 24 * 60 * 60;
	//int hoursToSec = 60 * 60;
	//int minutesToSec = 60;

	//int TotalOfDay = floor(Totalseconds / daysToSec);
	//int remanider = Totalseconds % daysToSec;
	//int TotalOfHours = floor(remanider / hoursToSec);
	//remanider = remanider % hoursToSec;
	//int TotalOfMinutes = floor(remanider / minutesToSec);
	//remanider = remanider % minutesToSec;
	//int TotalOfSec = remanider;

	//cout << TotalOfDay << " : " << TotalOfHours << " : " << TotalOfMinutes << " : " << TotalOfSec;
	//---------------------------------------------------------------------------------------------------------
	//Problem_47 Loan Installment Months (Done)
	//float LoanAmount, MonthlyPayment;
	//
	//cout << "Enter the Loan Amount : ";
	//cin >> LoanAmount;
	//cout << "Enter the Monthly Payment : ";
	//cin >> MonthlyPayment;

	//cout << "---------------------------------\n";
	//cout << "You Need a " << LoanAmount / MonthlyPayment << " Months" << endl;
	//---------------------------------------------------------------------------------------------------------
	//Problem_47 Monthly Loan Installment (Done)
	float LoanAmount, ManyMonthly;

	cout << "Enter the Loan Amount : ";
	cin >> LoanAmount;
	cout << "Enter the Many Monthly : ";
	cin >> ManyMonthly;

	cout << "---------------------------------\n";
	cout << "can you Payment in one month " << LoanAmount / ManyMonthly << " Money" << endl;
}
