

//count up
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}


//countdown
for (int i = 10; i >= 0; i--)
{
    Console.WriteLine(i);
}


//add 3 at a time
for (int i = 0; i < 10; i += 3)
{
    Console.WriteLine(i);
}


//stop at certain value
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 7) break;
}



//printing multiple values
//First off, notice that we have instantiated a string array named names that contains four names.
//Next, notice that we are using the Array.Length property to get the number of elements in the array, 
//and that we are using this value to initialize our iterator variable (int i = names.Length - 1). 
//We subtract 1 from the value because the index number for array elements is zero-based 
//(the index numbers of the four elements are 0-3).
//Finally, notice we have chosen iterate through the array backwards--something that we are unable to do with the foreach statement. 
//We use the value of the iteration variable inside the code block to specify the index number of the array elements (names[i]).

string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}
