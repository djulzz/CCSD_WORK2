
#include <cstdio>
#include <string>
#include <iostream>
#include <string.h>

using namespace std;

int main()
{
	char string[ 1024 ];
	FILE* file = fopen( "payroll.txt", "r" );
	while( !feof( file ) ) {
		fgets( string, 1024, file );
		int length = strlen( string );
		if( length >= 10 )
		{
			char name[ 100 ];
			char hr[ 100 ];
			char nh[ 100 ];
			sscanf( string, "%s\t%s\t%s\r\n", name, hr, nh );
			int hr_as_number;
			int nh_as_number;
			hr_as_number = atoi( hr );
			nh_as_number = atoi( nh );
			double gross_paycheck = hr_as_number * nh_as_number;
			printf( "name = %s - Gross Paycheck = %f\r\n", name, gross_paycheck );
		}
	}
	return 0;
}
