
#include <cstdio>
#include <string>
#include <iostream>

using namespace std;

int main()
{
	double HoursRequired = 0;
	const double dollarsPerDay = 200;
	const double partialDay = 40;

	cout << "How many hours?" << endl;
	cin >> HoursRequired;


	int NumberOfFullDays = HoursRequired / 8; // 26.5

	cout << "number of full days worked = " << NumberOfFullDays << endl;

	int numberOfHours = HoursRequired - ( NumberOfFullDays * 8 );
	cout << "number of hours remaining = " << numberOfHours << endl;

	double Earnings4FullDays = NumberOfFullDays * dollarsPerDay;
	double EarningPartial = numberOfHours * partialDay;

	cout << "Earning Full = " << Earnings4FullDays << endl;
	cout << "Earning Partial = " << EarningPartial << endl;
	cout << "Total cost = " << Earnings4FullDays + EarningPartial << endl;
	return 0;
}
