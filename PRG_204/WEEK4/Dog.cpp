#include <cstdio>
#include <cstring>
#include <iostream>
#include <string>

using namespace std;

////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////
class  Dog
{
	std::string name; // text
	std::string breed; // text

	int 		age;
	static const double license_fee;

	// INITIALIZING AN OBJECT OF A CLASS USING PROPER PARAMETERS MEANS WE ARE CALLING
	// THE "CONSTRUCTOR" OF THAT SAME CLASS
	public:
	Dog( string given_name, std::string given_breed, int given_age )
	{
		name = given_name;
		breed = given_breed;
		age = given_age;
	}

	public:
	void Debug()
	{
		std::cout << "age = " << age << std::endl;
		std::cout << "breed = " << breed << std::endl;
		std::cout << "name = " << name << std::endl;
	}

};


const double Dog::license_fee = 12.25;

////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////
int main()
{
	Dog d1( std::string( "Pluto"), std::string( "labrador" ), 4 );
	d1.Debug();
	return 0;
}
