

#include <iostream>
using namespace std;
void PrintNumbersFromNtoM(int N, int M)
{
	if (N <= M)
	{
		cout << N << endl;
		PrintNumbersFromNtoM(N + 1, M);
	}
}

void PrintNumbersFromMtoN(int M, int N)
{
	if (M >= N)
	{
		cout << M << endl;
		PrintNumbersFromMtoN(M - 1 , N);
	}
}


int MyPower(int Base, int Power)
{
	if (Power == 0)
		return 1;
	else
	{
		return (Base * MyPower(Base, Power - 1));
	}
}

int main() {
	//PrintNumbersFromNtoM(1, 10);

	//PrintNumbersFromMtoN(10, 1);
	cout << MyPower(2, 4);
	
	return 0;
}
