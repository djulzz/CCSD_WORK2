
#include <cstdio>
#include <string>
#include <iostream>

#include <cmath> // <--------------- THIS IS NEW!!
#include <stdlib.h>     /* srand, rand */
#include <time.h>       /* time */

using namespace std;

int main()
{
	srand (time(NULL));
	int random = rand() % 10;

	cout << "Enter your guess between (0 - 9)";
	int guess = 0;
	cin >> guess;
	int diff = abs( guess - random );
	cout << "the random number was = " << random << endl;
	cout << "your guess was = " << guess << endl;
	cout << "You are " << diff << " steps away from the ramdom number" << endl;
	if( guess == random )  {
		cout << "PERFECT MATCH!" << endl;
	} else if( diff <= 2 ) {
		cout << "Close, but not quite" << endl;
	} else {
		cout << "you are " << diff << " steps away from the random number" << endl;
	}
	return 0;
}
