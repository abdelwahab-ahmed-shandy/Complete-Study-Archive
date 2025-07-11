#include <iostream>
#include <string>
using namespace std;

int main()
{
	string myString = "abcDefghlmnoprstuvwfregerxyz";
	cout <<"the length of the string : "<<myString.length() << endl;

	cout << myString[3] << endl; //Out the D

	string S1 = "10", S2 = "30";

	string S3 = S1 + S2;
	cout << S3 << endl;//Out 1030
	cout << stoi(S1) + stoi(S2) << endl; // Out 40

	string S4 = "ABCD";
	//cout << stoi(S4);  // the big error can you see that 

	//==========================================================================
	// Read String with space
	string FullName;

	cout << "Enter the Full Name : ";
	
	//cin >> FullName;
	//cout << FullName; // input (abdlewahab shandy) output (abdelwahab) only 
	
	// You Can Add Space >>
	getline(cin, FullName);

	cout << FullName<<endl; 

}