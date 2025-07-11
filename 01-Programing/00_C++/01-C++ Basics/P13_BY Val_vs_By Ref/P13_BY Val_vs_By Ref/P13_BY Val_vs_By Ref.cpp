//#include <iostream>
//
//using namespace std;
//
////void MyFunction(int Num1 )
////{
////	Num1 = 7000;
////	
////	cout << "Number inside function become = " << Num1 << endl;
////}
//
//int main()
//{
//	int Num1 = 1000;
//
//	//MyFunction(Num1); 
//
//	//cout << "Number After calling the function became = " << Num1 << endl;
//
//	cout << Num1 << endl; // BY Value
//	cout << &Num1 << endl; //BY Reference
//}
//===========================================================================================
// problem swap is Done 
#include <iostream>

using namespace std;

void MYSwap( int &A , int &B  )
{
	int temp;
	temp = A;
	A = B;
	B = temp;
	cout << " the B TO A : " << A << " TO " << B << endl;
}

int main()
{
	int A, B;

	cout << "Enter the A : ";
	cin >> A;
	cout << "Enter the B : ";
	cin >> B;
	
	cout << " the A TO B : " << A << " TO " << B << endl;

	MYSwap(A, B);
}