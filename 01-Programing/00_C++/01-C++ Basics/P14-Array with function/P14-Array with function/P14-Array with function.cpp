#include <iostream>
using namespace std;

void ReadArrayData(int x[3])
{
	cout << "Enter Number 1 :";
	cin >> x[0];
	cout << "Enter Number 2 :";
	cin >> x[1];
	cout << "Enter Number 3 :";
	cin >> x[2];
}

void PrintArrayData(int x[3])
{
	cout << "Number 1 is : " << x[0] << endl;
	cout << "Number 2 is : " << x[1] << endl;
	cout << "Number 3 is : " << x[2] << endl;

}

int main()
{
	int x[3];
	ReadArrayData(x);
	PrintArrayData(x); 
}