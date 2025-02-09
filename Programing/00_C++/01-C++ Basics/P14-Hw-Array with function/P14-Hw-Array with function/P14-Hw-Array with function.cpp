#include <iostream>
using namespace std;

void ReadGreda(float Greda[3]) 
{
	cout << "Enter Number 1 : ";
	cin >> Greda[0];

	cout << "Enter Number 2 : ";
	cin >> Greda[1];

	cout << "Enter Number 3 : ";
	cin >> Greda[2];
}
float AvaregeCalcGreda(float Greda[3])
{ 
	return (Greda[0] + Greda[1] + Greda[2]) / 3;
}

int main()
{
	float Greda[3];
	ReadGreda(Greda);
	cout << "Avarage of Greda : " << AvaregeCalcGreda(Greda) << endl;
}


