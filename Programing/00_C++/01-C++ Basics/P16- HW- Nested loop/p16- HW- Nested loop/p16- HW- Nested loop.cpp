// HW 1: 
//#include <iostream>
//using namespace std;
//int main()
//{
//	for (char i = 65; i <= 90; i++)
//	{
//		cout << "letter : "<<  i << endl;
//		for (char j = 65 ; j <= 90 ; j++)
//		{
//			cout << i << j << endl;
//		}
//		cout << "--------------\n";
//	} 
//}
//================================================================
//Hw 2 

//#include <iostream> 
//using namespace std;
//int main() 
//{
//	for (int i = 10; i >= 1; i--)
//	{
//		for (int j = 1; j <= i; j++)
//		{
//			cout << "*";
//		}
//		cout << "\n";
//	}
//}

//================================================================
//Hw 3

//#include <iostream>
//using namespace std;
//
//int main()
//{
//    for (int i = 10; i >= 1; i--)
//    {
//        for (int j = 1; j <= i; j++)
//        {
//            cout << j<<" ";
//        }
//        cout << endl;
//    }
//
//    return 0;
//}

//================================================================
//#include <iostream> 
//using namespace std;
//
//int main()
//{
//	for (int i = 1; i <= 10; i++)
//	{
//		for (int j = 1; j <= i; j++)
//		{
//			cout << j << " ";
//		}
//		cout << "\n";
//	}
//}
//================================================================
#include <iostream>
using namespace std;
int main()
{
	for (int i = 1; i <= 10; i++)
	{
		for (int j = i ;j <= 10 ; j++)
		{
			cout << j << " ";
		}
		cout << endl;
	}

}