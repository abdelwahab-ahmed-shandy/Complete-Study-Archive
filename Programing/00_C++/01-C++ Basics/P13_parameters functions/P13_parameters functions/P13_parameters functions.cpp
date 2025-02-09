#include <iostream>
using namespace std;

int MySunFunction(int N1 , int N2)
{
	return N1 + N2;
}

int main()
{
	int Num1, Num2;
	cout << "Enter Number 1 : " ;
	cin >> Num1;
	cout << "Enter Number 2 : " ;
	cin >> Num2;
	cout << "The Result : " << MySunFunction(Num1, Num2) << endl;
}