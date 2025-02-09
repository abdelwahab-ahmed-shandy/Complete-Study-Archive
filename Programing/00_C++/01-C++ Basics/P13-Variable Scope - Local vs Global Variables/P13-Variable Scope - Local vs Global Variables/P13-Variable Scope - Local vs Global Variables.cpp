#include <iostream>

using namespace std;

//The Global Variables (Global )
int X = 100;

void MyFunction()
{
	//The Local Values in (Function)
	int X = 200;
	cout << "The Value of X inside function is : " << X << endl;
}

int main()
{
	//The Local Values in (int main)
	int X = 300;
	cout << "The local value of X inside main is : " << X << endl;

	MyFunction();

	cout << "The Global Value of X : " << ::X *4 << endl;
}