#include <iostream>
using namespace std;

int main()
{
	int x ;

	cout << "Enter Number : ";
	cin >> x;
	if (x > 20)
	{
		cout << "yes , x is grater than 20" << endl;
	}
	else
	{
		cout << "No , x is less than 20 " << endl;

	}
	cout << "The code after if body always executed" << endl;

}