#include <iostream>
#include <string>
using namespace std;

int main()
{
	//HomeWork1-convertion string to double,float,int.
	string st1 = "43.22";

	// string to int
	int st1_int = stoi(st1);
	cout <<"Convert String To Int : " << st1_int << endl;

	// string to float
	float st1_float = stof(st1);
	cout << "Convert String To Float : " << st1_float << endl;

	//string to double
	double st1_double = stod(st1);
	cout << "Convert String To Double : " << st1_double << endl;
	cout << "=========================\n";
	//==========================================================================
	//Integer,Double and Float To String 
	int N1 = 20;
	double N2 = 33.5;
	float N3 = 55.23;

	string str_int, str_dou, str_flo;

	str_int = to_string(N1);
	str_dou = to_string(N2);
	str_flo = to_string(N3);
	
	cout << "Integer to String : " << str_int << endl;
	cout << "Double to String : " << str_dou << endl;
	cout << "Float to String : " << str_flo << endl;

	int N3_int = N3; // implecit
	//int N3_int = (int)N3; //explicit
	//int N3_int = int(N3); //explicit
	cout << "Float N3 to integer : " << N3_int << endl; 
}