#include <iostream>
using namespace std;

int main()
{
	for (int i = 1; i <= 12; i++)
	{
		cout << "i = " << i << endl;
		
		for (int J=1 ; J<= 12 ;J ++)
		{
			cout << i << " * " << J << " = " << i * J << endl;
		}

		cout << "====================================\n";
	}
}