



























string pangram = "The quick brown fox jumps over the lazy dog";

// Step 1
string[] message = pangram.Split(' ');

//Step 2
string[] newMessage = new string[message.Length];

// Step 3
for (int i = 0; i < message.Length; i++)
{
    char[] letters = message[i].ToCharArray();
    Array.Reverse(letters);
    newMessage[i] = new string(letters);
}

//Step 4
string result = String.Join(" ", newMessage);
Console.WriteLine(result);






/*

string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);

//string result = new string(valueArray);
string result = String.Join(",", valueArray);

Console.WriteLine(result);

//split is designed for string valueables.
string[] items = result.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}

*/