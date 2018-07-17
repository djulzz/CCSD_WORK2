
#include <cstdio>
#include <cstring>
#include <string>
#include <iostream>

int main( int argc, char* argv[] )
{
	std::string ar_names[] = {"Saul Goodman", "Walter white", "Jessie Pinkman"};
	double ar_hourly_rate[] = {10.5, 11.5, 12.5 };
	double ar_hours_worked[] = {2.5, 4.4, 5.3 };
	double ar_tax_percentage[] = {25.3, 30.5, 54.4 };
	for( int i = 0; i < 3; i++ ) {
		double v = ar_hourly_rate[ i ] * ar_hours_worked[ i ] * ( 1.0 - ar_tax_percentage[ i ] / 100.0 );
		std::cout << ar_names[ i ] << " - net paycheck = " << v << " $" << std::endl;
	}
	return 0;
}