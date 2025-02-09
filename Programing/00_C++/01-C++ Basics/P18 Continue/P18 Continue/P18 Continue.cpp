#include <iostream> 
using namespace std;

int main()
{
	int Number = 0;
	int Sum = 0;
	for (int i = 0; i <= 4; i++)
	{
		cout << "Enter Number : ";
		cin >> Number;

		if (Number >50)
		{
			cout << "Need Number As3ar in 50 " << endl;
			continue;
		}
		Sum = Sum + Number;
	}
	cout << "The Sum Numbers is : " << Sum << endl;
}