////problem 26
//#include <iostream> 
//using namespace std;
//
//void ShowEnterNumber()
//{
//	cout << "You can add the Number , And I can Print in 1 to Number ." << endl;
//	cout << "What is Number in Loop : ";
//}
//void ReadNumPrint(int &EnterNum)
//{
//	cin >> EnterNum;
//
//	 for (int i = 1; i <= EnterNum; i++)
//	{
//		cout << i << endl;
//	}
//}
//
//
//int main()
//{
//
//	ShowEnterNumber();
//	
//	int EnterNum;
//
//	ReadNumPrint(EnterNum);
//
//}
//=======================================================================
// problem27
//#include <iostream> 
//using namespace std;
//void ShowMenue()
//{
//	cout << "You can add the Number , And I can Print in Number to 1 ." << endl;
//	cout << "What is Number in Loop : ";
//}
//
//void ReadNumPrint(int &Num)
//{
//	cin >> Num;
//	for (int i = Num ; i >= 1; i--)
//	{
//		cout << i << endl;
//	}
//}
//
//int main()
//{
//	int NumEnter;
//
//	ShowMenue();
//
//	ReadNumPrint(NumEnter);
//}
//=====================================================================
////problem 28
//#include <iostream>
//using namespace std;
//
//void Showscreen()
//{
//	cout << "Sum odd numbers from 1 to Number ?" << endl;
//	cout << " Enter The Number : ";
//}
//
//void ReadNumber(int &Num)
//{
//	cin >> Num;
//	int sum = 0;
//	for (int i = 1; i <= Num; i = i + 2)
//	{
//		cout << i << endl;
//	}
//}
//
//int SumOddNum(int Num)
//{
//	int sum = 0;  
//	for (int i = 1; i <= Num; i += 2)
//	{
//		sum += i;  
//	}
//	return sum;
//}
//
//int main()
//{
//	Showscreen();
//	int Number;
//	ReadNumber(Number);
//	cout << "*****************" << endl;
//	cout << SumOddNum(Number) ;
//}
//=====================================================================
//problem 29
//#include <iostream>
//using namespace std;
//
//void Showscreen()
//{
//	cout << "Sum Even numbers from 1 to Number ?" << endl;
//	cout << "Enter The Number : ";
//}
//
//void ReadNumber(int & Num)
//{
//	cin >> Num;
//	for (int i = 0; i <= Num; i = i + 2)
//	{
//		cout << i << endl;
//	}
//}
//
//int SumOddNum(int Num)
//{
//	int sum = 0;
//	for (int i = 0; i <= Num; i += 2)
//	{
//		sum += i;
//	}
//	return sum;
//}
//
//int main()
//{
//	Showscreen();
//	int Number;
//	ReadNumber(Number);
//	cout << "*****************" << endl;
//	cout << SumOddNum(Number);
//}
//===================================================================
//problem 30
//#include <iostream>
//using namespace std;
//
//void ShowScreen()
//{
//	cout << "Calculate Factorial of Number ?" << endl;
//	cout << "Enter the Number : ";
//}
//
//void ReadNumber(int &ReadNumber)
//{
//	cin >> ReadNumber;
//
//	for (int i = ReadNumber ; i >= 1; i--)
//	{
//		cout << i << endl;
//		cout << " *" << endl;
//	}
//}
//
//int FactoralOfNum(int Num)
//{
//	int Sum = 1;
//	for (int i = Num; i >= 1; i--)
//	{
//		Sum = Sum * i;
//	}
//	return Sum;
//}
//
//int main()
//{
//	ShowScreen();
//	int ReadNum;
//	ReadNumber(ReadNum);
//	cout << "===================\n";
//	cout << FactoralOfNum(ReadNum) << endl;
//}
//===================================================================
//problem 32
//#include <iostream>
//using namespace std;
//
//int main()
//{
//	int Num, M ;
//	
//	cout << "Enter the Number :";
//	cin >> Num;
//
//	cout << "Enter the M :";
//	cin >> M;
//
//	int P = 1;
//
//	for (int i = 1 ; i <= M; i++ )
//	{
//		P = P * Num;
//	}
//
//	cout << "===================\n";
//	cout << P;
//
//}
//================================================================================

