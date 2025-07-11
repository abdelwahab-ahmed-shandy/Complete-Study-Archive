#include <iostream> 
using namespace std;
enum Color {Red, Green, Yellow, Blue };
enum Direction {North, South, East, West};
enum Week {Sat , Sun, Mon, Tue, Wed, Thu, Fri};
enum Gender {Male , Female};
enum Status {Single, Married};

int main()
{
	Color MyColor;
	Direction MyDirection;
	Week Today;
	Gender MyGender;
	Status Mystatus;

	MyColor = Color::Blue;
	MyDirection = Direction::North;
	Today = Week::Fri;
	MyGender = Gender::Male;
	Mystatus = Status::Single;


	cout << MyColor << "  " << MyDirection << "  " << Today << "  " << MyGender << "  " << Mystatus;

}
