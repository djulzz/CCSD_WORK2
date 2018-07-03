#include <cstdio>
#include <string>
#include <iostream>

using namespace std;

int main()
{
	system( "cls");
	double hourlyWage = 0;
	double percentage = 0;
	double hoursWorked = 0;

	// start printing
	// to terminal                                 // go to next
												   // line
	cout << "Please enter your hourly rate"        << endl;
	cin >> hourlyWage;
	cout << "How much percentage is Uncle Sam taking from you?" << endl;
	cin >> percentage; // cin is used to store user input
	cout << "Please enter hours worked for current week" << endl;
	cin >> hoursWorked;

	double grossPay = hoursWorked * hourlyWage;
	double netPay = grossPay * ( 1 - percentage / 100 );
	cout << "Your gross pay is " << grossPay << " dollars. And your net income is " << netPay << " dollars" << endl;

	return 0;
}