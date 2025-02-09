#include <iostream>
#include <string>
#include <cmath>
using namespace std;
int main()
{
	//float Num1, Num2, Num3;
	//float A[3] = { Num1, Num2, Num3};

	// Array 
	float Grades[3];

	cout << "Enter Graodel 1 : ";
	cin >> Grades[0];
	cout << "Enter Graodel 2 : ";
	cin >> Grades[1];
	cout << "Enter Graodel 3 : ";
	cin >> Grades[2];
	cout << "*****************************\n";
	float Avg = (Grades[0] + Grades[1] + Grades[2]) / 3;
	cout << "The Average of Graodes is " << Avg << endl;
	//=======================================================================================
}

