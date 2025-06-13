#include <iostream>
#include <cstdio>
#include <iomanip>
using namespace std;

int main() 
{
	//Integer Format (printf)
	int Page = 1, TotalPages = 10;
	// print string and int variable
	printf("The page number = %d \n", Page);
	printf("You are in Page %d of %d \n", Page, TotalPages);
	
	//Width specification
	printf("The page number = %0*d \n", 2, Page);
	printf("The page number = %0*d \n", 3, Page);
	printf("The page number = %0*d \n", 4, Page);
	printf("The page number = %0*d \n", 5, Page);
	
	int Number1 = 20, Number2 = 30;
	printf("The Result of %d + %d = %d \n", Number1, Number2,Number1 + Number2);
	

	//Float Format (printf)
	float PI = 3.14159265;
	
	//Precision specification
	printf("Precision specification of %.*f\n", 1, PI);
	printf("Precision specification of %.*f\n", 2, PI);
	printf("Precision specification of %.*f\n", 3, PI);
	printf("Precision specification of %.*f\n", 4, PI);

	float x = 7.0, y = 9.0;
	printf("\nThe float division is : %.3f / %.3f = %.3f \n\n", x, y, x / y);
	
	//Double Format (printf)
	double d = 12.45;
	printf("The double value is : %.3f \n", d);
	printf("The double value is : %.4f \n", d);

	//String and Char Format (printf)
	char Name[] = "Mohammed Abu-Hadhoud";
	char SchoolName[] = "Programming Advices";
	
	// print string and String
	printf("Dear %s, How are you?\n\n", Name);
	printf("Welcome to %s School!\n\n", SchoolName);
	
	char c = 'S';
	printf("Setting the width of c :%*c \n", 1, c);
	printf("Setting the width of c :%*c \n", 2, c);
	printf("Setting the width of c :%*c \n", 3, c);
	printf("Setting the width of c :%*c \n", 4, c);
	printf("Setting the width of c :%*c \n", 5, c);
	//=================================================================

	//Setw Manipulator

	
		cout << "---------|--------------------------------|---------| " << endl;
		cout << " Code    |			   Name		           |     Mark| " << endl;
		cout << "---------|--------------------------------|---------| " << endl;
		
		cout << setw(9) << "C101" << "|" << setw(32) << "introduction to Programming 1" << " | " << setw(9) << "95" << " | " << endl;
		cout << setw(9) << "C102" << "|" << setw(32) << "ComputerHardware" << " | " << setw(9) << "88" << " | " << endl;
		cout << setw(9) << "C1035243" << "|" << setw(32) << "Network" << "|" << setw(9) << "75" << "|" << endl;
		cout << "---------|--------------------------------|---------| " << endl;


	return 0;
}