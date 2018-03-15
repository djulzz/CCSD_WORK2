// How to declare a variable
var myAge = 36

// print the age, blending it with the message
print( "Today, temperature is \(myAge)" )

// create constant, set it to 1976
let yearFounded = 1976

// print( "Apple Inc. was founded in \(yearFounded)")
let celsius:Double = 10.678
print( "Today, temperature is \(celsius)")

// create a variable of a specific type
var Decision:Bool = true
var AgeOld:Int = 50
var AgeYoung:Int = 20

// String Concatenation
var s1:String = "Julien"
var s2:String = "Esposito"
var s3:String = s1 + " " + s2
print( s3 )

// defining without affection allows assining values later on
let Celsius:Float 
let Fahrenheit:Float = 50
Celsius = (Fahrenheit-32)/1.8
print( "The temperature in celsius is \(Celsius)")

// On Boolean variable
var decision:Bool = true
var ageOld:Int = 50
var ageYoung:Int = 20
// comapring two values
decision = ( ageYoung > ageOld )
print( "The value of decision is \(decision)")

// creating uninitialized variable, and if

var a:Double?
if( a == nil )
{
	print( "a has not been initialized")
}

// Intro to if else statements
var temperature:Double = 75
var isRainy:Bool = false;
if( (temperature >= 70) && (!isRainy) )
{
		print( "It's NOT rainy")
		print( "temperature is enjoyable")
}
else
{
	print( "One of the 2 conditions is missing - Today sucks");
}


// First Version of for loops
// using variables for start and stopping point

var start = 1
var stop = 10
for i in start..<stop {
	print( "Displaying i = \(i)" )
}

// or
for i in 1...10
{
	print( "Displaying i = \(i)")
}


// for loop used to print every even number
// within the range [0 10]
for i in stride(from: 0, to: 10, by: 2) {
    print("Current Even Number \(i)" )
}

// function
func greet(person: String) -> String {
    let greeting = "Hello, " + person + "!"
    return greeting
}