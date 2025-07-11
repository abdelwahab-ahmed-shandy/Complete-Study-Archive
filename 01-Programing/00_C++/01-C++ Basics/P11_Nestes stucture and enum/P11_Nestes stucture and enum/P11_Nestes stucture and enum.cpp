#include <iostream>
using namespace std;

enum enColor { Red, Green, Yellow, Blue };
enum enGendor { Male, Female };
enum enMaritalStatus { Single, Married };


struct stAddress
{
	string streetName;
	string BuildingNO;
	string POBox;
	string ZipCode;
};
struct stContactInfo
{
	string Phone;
	string Email;
	
	stAddress Address;
};

struct stPerson 
{
	string FirstName;
	string LastName;
	
	stContactInfo ContactInfo;

	enColor FavoureteColor;
	enGendor Gender;
	enMaritalStatus MaritalStatus;
};

int main () 
{
	stPerson Person1;

	Person1.FirstName = "Abdelwahab";
	Person1.LastName = "Shandy";

	Person1.ContactInfo.Email = "abdelwahabshandy@gmail.com";
	Person1.ContactInfo.Phone = "01017417103";
	Person1.ContactInfo.Address.streetName = "11 ST saad Ahmed Matar";
	Person1.ContactInfo.Address.BuildingNO = "11";
	Person1.ContactInfo.Address.POBox = "6878";
	Person1.ContactInfo.Address.ZipCode = "202125";

	Person1.Gender = enGendor::Male;
	Person1.FavoureteColor = enColor::Blue;
	Person1.MaritalStatus = enMaritalStatus::Single;

	cout << Person1.ContactInfo.Address.streetName << endl;

	return 0;
}






