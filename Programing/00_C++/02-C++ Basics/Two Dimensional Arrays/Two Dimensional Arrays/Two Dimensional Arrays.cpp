//#include <iostream>
//using namespace std;
//int main()
//{
//	//int x[Rows][Cols];
//	int x[3][4] ={
//					{1,2,3,4},
//					{5,6,7,8},
//					{9,10,11,12}
//				};
//	for (int i = 0; i < 3; i++) 
//	{
//		for (int j = 0; j < 4; j++)
//		{
//			cout << x[i][j] << " ";
//		}
//		cout << endl;
//	}
//	return 0;
//}


#include <iostream>
#include <iomanip> 
using namespace std;
int main()
{
	//int x[Rows][Cols];
	int x[10][10] = {
					{1,2,3,4,5,6,7,8,9,10},
					{1,2,3,4,5,6,7,8,9,10},
					{1,2,3,4,5,6,7,8,9,10},
					{1,2,3,4,5,6,7,8,9,10},
					{1,2,3,4,5,6,7,8,9,10},
					{1,2,3,4,5,6,7,8,9,10},
					{1,2,3,4,5,6,7,8,9,10},
					{1,2,3,4,5,6,7,8,9,10},
					{1,2,3,4,5,6,7,8,9,10},
					{1,2,3,4,5,6,7,8,9,10}
	};
	for (int i = 1; i <= 10; i++)
	{
		for (int j = 1; j <= 10; j++)
		{
			int result = i * j;
			printf("%d ", result);
			//cout << setw(4) << result;
			//printf("%0*d ",2, result);
		}
		cout << endl;
	}
	return 0;
}