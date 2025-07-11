#include <iostream>
using namespace std;
int main()
{
	//Data type 
	int myNumber = 52; //Integer (Whole number without decimals)
	float myFloatNumber = 3.14; //Floating point number (with decimals)
	double myDoublNumber = 21.5656; // Larg Floating point number 
	char myLetter = 'A'; //Character note char use '' only .
	string myText = "Abdelwahab"; //String (text)
	bool myBoolean = false; //Boolean (true or false) (0 or 1) ( 0 = false , 1 = true)

	//Ex:
	cout << myNumber << endl;
	cout << myFloatNumber << endl;
	cout << myDoublNumber << endl;
	cout << myLetter << endl;
	cout << myText << endl;
	cout << myBoolean << endl;

	int MyAge = 22;	
	MyAge = MyAge + 22;
	cout << "I am " << MyAge << endl; //output is a 22 and 44 

	//Declare Many Variables
	int x = 10;
	int y = 20;
	int sum = x + y;
	cout << endl << sum;

	int a = 5, b = 10, plus = a + b;
	cout << endl << plus;

	int c = 10, v = 20, m = 30;
	cout <<endl << c + v + m << endl;

	char char1 = 'A', char2 = 'B', char3 = 'C';
	cout << char1 << char2 << char3 << " Reversed is " << char3 << char2 << char1 << endl;

	//Constants 

	const float PI = 3.14;
	
	const int MinutesPerHour = 60;
	cout << MinutesPerHour << endl ;

	 
}