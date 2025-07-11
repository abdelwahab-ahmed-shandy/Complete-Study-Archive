#include <iostream>
using namespace std;
int main()
{
	//int A = 10, B = 20;

	//A++; // same as A = A + 1
	//B--; // same as B = B - 1

	//cout << "A = " << A << endl;
	//cout << "B = " << B << endl;
	//---------------------------------------------
	//Prefix VS Postfix
	// 
	//++X       X++
	//int X = 10;
	//int Y = X++; 
	//// Y will take the old value of A, then X will increase by 1

	//cout << "Y = "<< Y << endl;
	//cout << "X = " << X << endl;

	//int M = 20;
	//int N = ++M;

	////N will increase by 1 , then M will take the new value 
	//cout << "N = " << N << endl;
	//cout << "M = " << M << endl;
	//---------------------------------------------
	//Assignment Operators....
	//int A = 10, B = 20;

	//A += B; //A = A + B
	//cout << "A = " << A << endl;

	//A -= B; //A = A - B
	//cout << "A = " << A << endl;

	//A *= B; //A = A * B
	//cout << "A = " << A << endl;

	//A /= B; //A = A / B
	//cout << "A = " << A << endl;

	//A %= B; //A = A % B
	//cout << "A = " << A << endl;
	//-----------------------------------------------------
	// Relational Operators 
	//int A = 20, B = 20;

	//// 0 == False , 1 == True
	//cout << (A == B) << endl;
	//cout << (A != B) << endl;
	//cout << (A >  B) << endl;
	//cout << (A <  B) << endl;
	//cout << (A >= B) << endl;
	//cout << (A <= B) << endl;
	//==================================================================
	//The HomeWork
	//int A, B;
	//cout << "Please Enter The First Number A ?\n";
	//cin >> A;
	//cout << "Please Enter The First Number B ?\n";
	//cin >> B; 

	////operation in task 
	//cout << A << " =  " << B << " is " << (A == B)<<endl; 
	//cout << A << " != " << B << " is " << (A != B) << endl;
	//cout << A << " >  " << B << " is " << (A > B) << endl;
	//cout << A << " <  " << B << " is " << (A < B) << endl;
	//cout << A << " >= " << B << " is " << (A >= B) << endl;
	//cout << A << " <= " << B << " is " << (A <= B) << endl;
	//==================================================================
	// Logical Operator 	
	// 1 (True) , 0(False)
	//bool A = 1, B = 0;

	//cout << (A && B) << endl;
	//cout << (A || B) << endl;
	//cout << !A << endl;
	//cout << !B << endl;
	//cout << !(A && B) << endl;
	//cout << !(A || B) << endl;
	//------------------------------------------------------------------------
	//HomeWork
	// true==1 , false==0

	cout << (5 > 6 && 7 == 7) || (1 || 0); //output = 0
	cout << !(5 > 6 && 7 == 7) || (1 || 1); //output = 1
	cout << !(5 > 6 && 7 == 7) || !(1 || 0); //output = 1
	cout << !(5 > 6 && 7 == 7) && !(1 || 0); //output = 1
	cout << ((5>6 && 7<=8) || (8>1 && 4<=3)) && !0; //output = 0
	cout << ((5 > 6 && !(7 <= 8)) && (8 > 1 || 4 <= 3)) || !0; //output = 0

}