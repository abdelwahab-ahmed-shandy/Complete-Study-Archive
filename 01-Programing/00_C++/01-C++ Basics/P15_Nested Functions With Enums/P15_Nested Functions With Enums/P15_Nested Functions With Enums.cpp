//The week Day :
//#include <iostream>
//using namespace std;
//
//enum enWeekDays { Sunday = 1, Monday = 2, Tuesday = 3, Wednesday = 4, Thursday = 5, Friday = 6, Saturday = 7 };
//
//void ShowMenueWeekDay()
//{
//    cout << "****************************" << endl;
//    cout << "          Week Days         " << endl;
//    cout << "****************************" << endl;
//    cout << "1 : Sunday " << endl;
//    cout << "2 : Monday " << endl;
//    cout << "3 : Tuesday " << endl;
//    cout << "4 : Wednesday " << endl;
//    cout << "5 : Thursday " << endl;
//    cout << "6 : Friday " << endl;
//    cout << "7 : Saturday " << endl;
//    cout << "****************************" << endl;
//    cout << "Please Enter The Number Of Day ?" << endl;
//}
//
//enWeekDays ReadWeekDay()
//{
//    int wd;
//    cin >> wd;
//    return (enWeekDays)wd;
//}
//
//string GetWeekDayName(enWeekDays WeekDay)
//{
//    switch (WeekDay)
//    {
//    case enWeekDays::Sunday:
//        return "Sunday";
//    case enWeekDays::Monday:
//        return "Monday";
//    case enWeekDays::Tuesday:
//        return "Tuesday";
//    case enWeekDays::Wednesday:
//        return "Wednesday";
//    case enWeekDays::Thursday:
//        return "Thursday";
//    case enWeekDays::Friday:
//        return "Friday";
//    case enWeekDays::Saturday:
//        return "Saturday";
//    default:
//        return "Not Found";
//    }
//}
//
//int main()
//{
//    ShowMenueWeekDay();
//    cout << "Today is a : " << GetWeekDayName(ReadWeekDay()) << endl;
//    return 0;
//}
//===================================================================================