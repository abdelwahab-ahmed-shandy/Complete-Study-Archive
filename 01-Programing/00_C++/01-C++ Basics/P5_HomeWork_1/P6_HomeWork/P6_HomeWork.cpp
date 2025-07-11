#include <iostream> 
using namespace std;
int main()
{
	//HomeWork_1
	//Variables
	string YourName;
	string YourCity;
	string YourCountry;
	int YourAge = 0;
	float YourMonthlySalary = 0;
	float YourYearlySalary = YourMonthlySalary * 12;
	char YourGender;
	bool AreYouMarried;

	//Input in program 
	cout << "What is your name?" << endl ;
	cin  >> YourName;
	cout << "When is your birthday?" << endl;
	cin >> YourAge;
	cout << "what is your city?" << endl;
	cin >> YourCity ;
	cout << "what is your country?" << endl;
	cin >> YourCountry;
	cout <<"How much is your monthly salary?" << endl;
	cin >> YourMonthlySalary;
	cout << "Are you a man or a woman? Also enter ( M or W)" << endl;
	cin >> YourGender;
	cout << "Are you married؟ (true Or false)" << endl;
	cin >> AreYouMarried;

	////OutPut In Program
	cout << "------------------------------------------------ \n";
	cout << "Name : "<< YourName << endl;
	cout << "Age : " << YourAge <<" Years." << endl;
	cout << "City : " << YourCity << endl;
	cout << "Country : " << YourCountry << endl;
	cout << "Monthly Salary : " << YourMonthlySalary << endl;
	cout << "Yearly Salary : " << YourYearlySalary << endl;
	cout << "Gender : " << YourGender << endl;
	cout << "Married : " << AreYouMarried << endl;
	cout << "------------------------------------------------\n";
	////-----------------------------------------------------------------------------------------------
	HomeWork_2
	variables
	int Num1, Num2, Num3;
	//Input Program
	cout << "Enter Number1 :" << endl;
	cin >> Num1;
	cout << "Enter Number2 :" << endl;
	cin >> Num2;
	cout << "Enter Number3 :" << endl;
	cin >> Num3;
	//Output program
	cout << "------------------------------------------------\n";
	cout << Num1 << "+" << endl;
	cout << Num2 << "+" << endl;
	cout << Num3 << endl<<endl; 
	cout << "-------------------------------\n" << endl; 
	cout << "Total = " << Num1 + Num2 +Num3 << endl;
	////-----------------------------------------------------------------------------------------------
	//HomeWork3
	// VAR 
	short int Age = 0;
	short int AfterYears = 0; 

	//Input
	cout <<"When is your birthday?" << endl;
	cin >> Age ;
	
	cout << "How many after years" << endl; 
	cin >> AfterYears;
	//Output 
	cout << "After "<< AfterYears << " years you will be "<< Age + AfterYears << " years old" << endl; 

}
