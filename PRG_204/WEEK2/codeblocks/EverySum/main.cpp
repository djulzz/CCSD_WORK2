
#include <cstdio>
#include <string>
#include <iostream>

int main( int arc, char* argv[] )
{
    // start = 102
    // stop  = 200

    int sum = 0;

    int start = atoi( argv[ 1 ] );
    int stop = atoi( argv[ 2 ] );
    for( int i = start; i <= stop; i++ ) {
    	sum = sum + i;
    }
    std::cout << "The sum of all number between " << start << 
    " and " << stop << " is = " << sum << "." << std::endl;
    return 0;
}
