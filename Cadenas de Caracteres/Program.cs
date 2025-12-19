
string str = "The brown fox jumps over the lazy dog.";
// convert the message into a char array
char[] charMenssage = str.ToCharArray();
//reverse the chars
Array.Reverse(charMenssage);
int x = 0;
// count the o's
foreach (char i in charMenssage)
{
    if (i == 'o')
    {
        x++;
    }
}
//convert it back to a string
string new_message = new string(charMenssage);
//print in out
Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");
