// Break 
#include <iostream>
using namespace std;

int main()
{
	int Arry[10] = { 10,20,30,40,50,60,70,80,90,100 };
	int SearchNumber;

	cout << "Enter the number of search : ";
	cin >> SearchNumber;

	for (int i = 0; i <= 10; i++)
	{
		
		cout << "We are at iteraton " << i + 1 << endl;

		if (SearchNumber == Arry[i])
		{
			cout << "Found The Number of search " << SearchNumber<<" Position is "<< i +1 << endl;
			break;
		}
	}


}