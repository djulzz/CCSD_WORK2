
#include <cstdio>
#include <string>
#include <iostream>

using namespace std;

int main()
{
	// scanning numbers between 0 and 1000
	for( int i = 0; i < 10001; i++ )
	{
		int current_number = i;
		//cout << "Testing #" << i << std::endl;
		int sum = 0;
		for( int j = 1; j < current_number; j++ )
		{
			if( (current_number % j) == 0 )
			{
				//cout << j << " divides " << current_number << endl;
				sum = sum + j;
			}
		}

		if( sum == current_number )
		{
			std::cout << sum << " is a perfect number" << std::endl;
		}
	}
	return 0;
}
