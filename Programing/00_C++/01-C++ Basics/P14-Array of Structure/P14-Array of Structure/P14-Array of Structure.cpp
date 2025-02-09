#include <iostream>
using namespace std;

struct strInfo 
{
	string FirestName;
	string LastName;
	int Age;
	string Phone;
};

int main()
{
	strInfo Person[2];

	Person[0].FirestName = "Abdelwahab";
	Person[0].LastName = "Shandy";
	Person[0].Age = 22;
	Person[0].Phone = "01017417103";

	cout << Person[0].FirestName;


}