
#include <cstdio>
#include <string>
#include <iostream>

#include <cmath> // <--------------- THIS IS NEW!!
#include <stdlib.h>     /* srand, rand */
#include <time.h>       /* time */

using namespace std;

int main()
{
	for( int i = 0; i < 10; i = i + 2 ) {
		cout << "THe current value is " << i << endl;
	}
	return 0;
}