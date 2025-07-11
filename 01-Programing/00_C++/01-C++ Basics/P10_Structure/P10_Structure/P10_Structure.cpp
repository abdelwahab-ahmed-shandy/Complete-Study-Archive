#include <iostream> 
using namespace std;

struct Address
{
	string Street;
	int houseNumber;
};
struct carOwner
{
	string FullName;
	string Phone;
	Address caraddress;
};

struct Car
{
	string Brand;
	string Mondel;
	int Year;
	carOwner Owner;
};



int main ()
{
	Car car1;
	car1.Owner.FullName = "Abdelwahab Shandy";
	car1.Owner.Phone = "01017417103";
	car1.Brand = "BMW";
	car1.Mondel = "X5";
	car1.Year = 2000;
	car1.Owner.caraddress.Street = "11 st saad ";
	car1.Owner.caraddress.houseNumber = 4;

	cout << car1.Owner.FullName <<endl  << car1.Owner.Phone << endl << car1.Brand << endl << car1.Mondel << endl << car1.Year << endl << car1.Owner.caraddress.Street << endl << car1.Owner.caraddress.houseNumber << endl;
}