
#include <cstdio>
#include <cstring>
#include <string>
#include <iostream>

int main(int argc, char* argv[])
{
	std::string names1 = "Saul Goodman";
	std::string names2 = "Walter white";
	std::string names3 = "Jessie Pinkman";

	double hourly_rate1 = 10.5;
	double hourly_rate2 = 11.5;
	double hourly_rate3 = 12.5;

	double hours_worked1 = 2.5;
	double hours_worked2 = 4.4;
	double hours_worked3 = 5.3;

	double tax_percentage1 = 25.3;
	double tax_percentage2 = 30.5;
	double tax_percentage3 = 54.4;

	double v1 = hourly_rate1 * hours_worked1 * (1.0 - tax_percentage1 / 100.0);
	double v2 = hourly_rate2 * hours_worked2 * (1.0 - tax_percentage2 / 100.0);
	double v3 = hourly_rate3 * hours_worked3 * (1.0 - tax_percentage3 / 100.0);

	std::cout << names1 << " - net paycheck = " << v1 << " $" << std::endl;
	std::cout << names2 << " - net paycheck = " << v2 << " $" << std::endl;
	std::cout << names3 << " - net paycheck = " << v3 << " $" << std::endl;
	return 0;
}
