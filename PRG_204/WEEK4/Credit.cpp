#include <cstdio>
#include <cstring>
#include <iostream>

////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////
void customerCreditLimit( double credit_requested = 0.0 )
{
	if( credit_requested <= 500 ) {
		std::cout << "you did not ask for a specific ";
		std::cout << " credit value - we are granting you 500 dollars.";
		return;

	} else if( credit_requested > 500 ) {
		std::cout << "you were just granted " << credit_requested << " USD";
	}
}

////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////
int main()
{
	std::cout << "How much you want?" << std::endl;
	customerCreditLimit();
	customerCreditLimit(700);
	return 0;
}