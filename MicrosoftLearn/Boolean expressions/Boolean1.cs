



// are the value equal to eachother true/false.
Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string myValue = "a";
Console.WriteLine(myValue == "a");




// trim string value input to get higher match percentage.
string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());





// if the values are equal return a false. opposit of ==. 
Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

string myValue1= "a";

Console.WriteLine(myValue1 != "a");

int a = 7;
int b = 6;
Console.WriteLine(a != b); // output: True
string s1 = "Hello";
string s2 = "Hello";
Console.WriteLine(s1 != s2); // output: False






// Boolean comparision.
Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1);




// determine whether or not a larger string contains a specific word or phrase that's significant to your application.
//Some data types have methods that perform helpful utility tasks. The String data type has many of these. 
//Several return a Boolean value including Contains(), StartsWith(), and EndsWith(). 
//You can learn more about them in the Microsoft Learn module "Manipulate alphanumeric data using String class methods in C#". 

string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));

















