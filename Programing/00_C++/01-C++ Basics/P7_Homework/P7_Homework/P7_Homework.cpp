#include <iostream>
using namespace std;
int main()
{
	//VAR
	float A, B;
	//INPUT
	cout << "Please enter the first Number A ?" << endl;
	cin >> A;
	cout << "Please enter the second Number B ?" << endl;
	cin >> B;
	//OUTPUT
	cout << A << " + " << B << " = " << A + B << endl;
	cout << A << " - " << B << " = " << A - B << endl;
	cout << A << " * " << B << " = " << A * B << endl;
	cout << A << " / " << B << " = " << A / B << endl;
	// The Big Error 
	//cout << A << " % " << B << " = " << A % B << endl;

	/*To use MOD the numbers must be integers,
	so the mode must be changed to int instead of float,
	so that the operation is completed without affecting the rest.*/
	//After searching I found the following:

	int _A = static_cast <int>(A) ;
	int _B = static_cast <int>(B);

	cout << _A << " % " << _B << " = " << _A % _B << endl;

}