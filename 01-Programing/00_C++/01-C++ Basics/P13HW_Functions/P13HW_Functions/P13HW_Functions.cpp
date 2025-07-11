//problem N_1 and 2_Functions
//#include <iostream>
//
//using namespace std;
//
//string MyNameFunction(string FName,string LName )
//{
//	return FName + " " + LName;
//}
//
//int main()
//{
//	string FirestName, LastName;
//	cout << "Enter Your Firest Name : ";
//	cin >> FirestName;
//	cout << "Enter Your Last Name : ";
//	cin >> LastName;
//	cout <<"The Full Name is : " << MyNameFunction(FirestName, LastName) << endl;
//}
//====================================================================

//problem N_14_Procedures
#include <iostream> 

using namespace std;

void MySwapFunction(int N1 ,int N2 )
{
	cout << "The Swap numbers N2 to N1 : " << N2 << " " << N1 << endl;
}

int main()
{
	float N1, N2;
	cout << "enter Num 1 : ";
	cin >> N1;
	cout << "enter Num 2 : ";
	cin >> N2;
	cout << "the not swap Numbers N1 to N2 :"<< N1 <<" "<< N2 << endl;
	MySwapFunction(N1, N2);
}
//============================================================================
//Problem 15_Function 
//#include <iostream>
//
//using namespace std;
//float MYAreaOfRectangle(float A ,float B)
//{
//	return A * B;
//}
//
//int main()
//{
//	float A, B;
//	cout << "Enter the A : ";
//	cin >> A;
//	cout << "Enter the B : ";
//	cin >> B;
//	cout << "*****************************\n";
//	cout << "The Area of Rectangle : " << MYAreaOfRectangle(A, B) << endl;
//}
//============================================================================
//Problem 16_Function 
//#include <iostream>
//
//using namespace std;
//
//float AreaRectangle(float a , float d )
//{
//	return (a)*sqrt(pow(d, 2) - pow(a, 2));
//}
//
//int main()
//{
//	float A, D;
//	cout << "Enter the A : ";
//	cin >> A;
//	cout << "Enter the D : ";
//	cin >> D;
//	cout << "Area Rectangle : " << AreaRectangle(A, D) << endl; 
//}
//===========================================================================
//Problem 19_Function 
//#include <iostream>
//using namespace std;
//
//float CircleArea(float D)
//{
//	float PI = 3.14;
//	return PI * pow(D, 2) / 4;
//}
//
//int main()
//{
//	float d;
//	cout << "Enter The D : ";
//	cin >> d;
//	cout << "The Circle Area is : " << CircleArea(d) << endl;
//}
//===========================================================================
//Problem 20_Function
//#include <iostream>
//using namespace std;
//
//float CircleArea(float A)
//{
//	float PI = 3.14;
//	return PI * pow(A, 2) / 4;
//}
//
//int main()
//{
//	float a;
//	cout << "Enter the A : ";
//	cin >> a;
//	cout << " The Circle Area : " << CircleArea(a) << endl;
//}
//===========================================================================
//Problem 21_Function
//#include <iostream> 
//
//using namespace std;
//
//float CircleArea(float L)
//{
//	float pi = 3.14;
//	return pow(L,2) / (pi*4) ;
//}
//
//int main()
//{
//	float l;
//	cout << "Enter the L : ";
//	cin >> l;
//	cout << "The Circle Area : " << CircleArea(l) << endl;
//}
//===========================================================================
//Problem 22_Function
//#include <iostream>
//using namespace std;
//
//float CircleArea(float a, float b)
//{
//	float Pi = 3.14;
//	return (Pi) * (pow(b,2)/4) * ((2 * a -b ) / (2 * a + b) )  ;
//}
//
//int main()
//{
//	float A, B;
//	cout << "Enter the A : ";
//	cin >> A;
//	cout << "Enter the B : ";
//	cin >> B;
//	cout << "The Circle Area is a : " << CircleArea(A, B) << endl;
//}
//===========================================================================
//Problem 23_Function
//#include <iostream>
//using namespace std;
//
//float CircleArea(float a , float b , float c)
//{
//	float Pi = 3.14;
//	float P = a * b * c / 2;
//	return (Pi) * ((a * b * c) / (4 * sqrt(P * (P - a) * (P - b) * (P - c))));
//}
//
//int main()
//{
//	float A, B, C;
//	cout << "enter a :";
//	cin >> A;
//	cout << "enter b : ";
//	cin >> B;
//	cout << "enter c : ";
//	cin >> C;
//	cout << " the circle area : " << CircleArea(A, B, C) << endl;
//
//}
//===========================================================================
//Problem 31_Function
//#include <iostream>
//using namespace std;
//
//float Power_1(float Number ,float Power)
//{
//	return pow(Number, Power);
//}
//float Power_2(float Number, float Power)
//{
//	return pow(Number, Power);
//}
//float Power_3(float Number, float Power)
//{
//	return pow(Number, Power);
//}
//
//int main()
//{
//	float Num;
//	float Pow1, Pow2, Pow3;
//	cout << "Enter the Number : ";
//	cin >> Num;
//	cout << "Enter Number of Power_1 : ";
//	cin >> Pow1;
//	cout << "Enter Number of Power_2:  ";
//	cin >> Pow2;
//	cout << "Enter Number of Power_3 : ";
//	cin >> Pow3;
//	cout << "==================================" << endl;
//	
//	cout << "The " << Num << " ^ " << Pow1 << " is a : " << Power_1(Num, Pow1) << endl;
//
//	cout << "The " << Num << " ^ " << Pow2 << " is a : " << Power_1(Num, Pow2) << endl;
//
//	cout << "The " << Num << " ^ " << Pow3 << " is a : " << Power_1(Num, Pow3) << endl;
//}
//===========================================================================================

