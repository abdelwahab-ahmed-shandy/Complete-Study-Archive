#include <iostream>
using namespace std;

int main()
{
	int Number = 0;

	// Using Ternary Operator

	(Number >= 0) ? cout << "Positive" : cout << "Negative";

	cout << endl;

	// using Nested Ternary Operator

	(Number == 0) ? cout << "Zero" : (Number > 0) ? cout << "Positive" : cout << "Negative";

	cout << endl;

	// OR

	(Number == 0) ? cout << "Zero" : ((Number > 0) ? cout << "Positive" : cout << "Negative");

}

