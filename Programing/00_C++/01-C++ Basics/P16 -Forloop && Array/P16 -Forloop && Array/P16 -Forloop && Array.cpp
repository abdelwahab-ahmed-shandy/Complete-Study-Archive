#include <iostream> 
#include <string>
#include <cmath>
using namespace std;

void ReadArrayData(int Arry[100], int &Length)
{
	cout << "How Many Numbers do you want to enter ? 1 to 100 ? " << endl;
	cin >> Length;
	
	for (int i = 0; i <= Length - 1 ; i++)
	{
		cout << "Enter Number " << i + 1 << " : " << endl;
		cin >> Arry[i];
	}
	cout << "=================================\n";
}

void PrintArrayData(int Arr[100], int Length)
{
	for (int i = 0; i <= Length -1 ; i++)
	{
		cout << "Number (" << i + 1 << ") : " << Arr[i] << endl;
	}
	cout << "=================================\n";
}

int CalculatDataSum(int Arry[100] , int Length)
{
	int Sum = 0;
	for (int i = 0 ; i <= Length - 1 ; i++ )
	{
		Sum = Sum + Arry[i];
	}
	return Sum;
}

float CalculatDataAverage(int Arry[100], int Length)
{
	return (float)CalculatDataSum(Arry, Length) / Length;
}

int main()
{
	int Arry1[100], Length = 0;
	ReadArrayData(Arry1, Length);
	PrintArrayData(Arry1, Length);
	cout << "The Calcuate Sum : " << CalculatDataSum(Arry1, Length) << endl;
	cout << "The Calcuate Average : " << CalculatDataAverage(Arry1, Length) << endl;
	cout << "******************************************************************************\n";
}