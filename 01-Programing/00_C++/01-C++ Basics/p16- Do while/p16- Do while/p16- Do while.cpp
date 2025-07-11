// While Loop 
//#include <iostream>
//using namespace std;
//
//void ReadReange(int From, int To)
//{
//	int Number;
//	cout << "Please enter a number between " << From << " And " << To << endl;
//	cin >> Number;
//
//	while (Number < From || Number > To)
//	{
//		cout << "Wrong Number , Please enter a number between " << From << " And " << To << endl;
//		cin >> Number;
//	}
//
//}
//
//int main()
//{
//	ReadReange(20, 25);
//	cout << "Done ";
//}

//===================================================================
#include <iostream>
using namespace std;

void ReadRande(int From, int To)
{
	int Number;
	do
	{
		cout << "Please enter a number between " << From << " And " << To << endl;
		cin >> Number;
	} while (Number <From || Number > To ) ;

}

int main() 
{
	ReadRande(22, 45);
	cout << "Yes , This is Good " << endl;
}