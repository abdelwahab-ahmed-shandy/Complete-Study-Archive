#include <iostream>
#include <string>
using namespace std;

int main()
{
	//Conversion from double to int
	int Num1;
	double Num2 = 18.99;

	Num1 = Num2; //Inmlecit Conversion from double to int 

	Num1 = (int) Num2; //Explicit Conversion

	Num1 = int(Num2); //Explicit Conversion

	//cout << Num2 << endl;
//=========================================================================================
	//Conversion from String to int,float,double
	string str = "123.456";

	//conversion string to int 
	int Num_int = stoi(str);

	//Conversion string to float 
	float Num_float = stof(str);

	//Conversion string to double
	double Num_double = stod(str);

	//cout << Num_double << endl;
//====================================================================================
	//Converion Numbers(any num ) To String
	int Number1 = 12345;
	float Number2 = 9876.5432;

	string st1 = to_string(Number1);
	string st2 = to_string(Number2);

	cout << st1 << endl;
	cout << st2 << endl;

}
