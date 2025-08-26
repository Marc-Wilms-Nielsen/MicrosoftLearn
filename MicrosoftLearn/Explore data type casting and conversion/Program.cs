

//you can convert int to a string but not the string to int. You can only convert to 
//values that can hold the other. like int to decimal, but not decimal to
//int without cuttin the decimals.
/*
int first = 2;
string second = "4";
string result = first + second;
Console.WriteLine(result);

int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}");
*/





//Convert a string to an int using the Parse() helper method
//Most of the numeric data types have a Parse() method, 
//which converts a string into the given data type.

string first = "5";
string second = "7";
int sum = int.Parse(first) + int.Parse(second);
Console.WriteLine(sum);




//Convert a string to a int using the Convert class

string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result);


//Use ToString() to convert a number to a string
int first = 5;
int second = 7;
string message = first.ToString() + second.ToString();
Console.WriteLine(message);

//Convert a string to an int using the Parse() helper method
string first = "5";
string second = "7";
int sum = int.Parse(first) + int.Parse(second);
Console.WriteLine(sum);


//Compare casting and converting a decimal into an int

int value = (int)1.5m; // casting truncates
Console.WriteLine(value);

int value2 = Convert.ToInt32(1.5m); // converting rounds up (properly rounded)
Console.WriteLine(value2);