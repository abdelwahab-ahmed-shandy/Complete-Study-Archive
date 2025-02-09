#include <iostream>
using namespace std;
int main()
{
	//Output 1 Home work 
	//MyVariables
	string Fasla = "**************************************\n";
	string MyName = "Abdelwahab Shandy";
	int MyAge = 22;
	string MyCity = "Cairo";
	string MyCountry = "Egypt";
	float MyMonthlySalary = 5000;
	float MyYearlySalary = MyMonthlySalary * 12;
	char MyGender = 'M';
	bool isMarrid = true;
	//Output
	cout << Fasla;
	cout << "Name:" << MyName << "." << endl;
	cout << "Age:" << MyAge << "." << endl;
	cout << "City:" << MyCity << "." << endl;
	cout << "Country:" << MyCountry << "." << endl;
	cout << "Monthly Salary:" << MyMonthlySalary << endl;
	cout << "Yearly Salary:" << MyYearlySalary << endl;
	cout << "Gender:" << MyGender << endl;
	cout << "Married:" << isMarrid << endl;
	cout << Fasla << endl;
	
	//Output 2 Home work 
	string Space = "--------------------------------------------\n\n";
	int a = 20, b = 30, c = 10;
	int Total = a + b + c;
	cout << a << "+" << endl << b << "+" << endl << c << endl << endl << Space << "Total = " << Total;

	//Output 3 Home work 
	int After_5_years = MyAge + 5;
	cout <<endl << "After 5 years will be " <<After_5_years << " years old" << endl;

	return 0;

}