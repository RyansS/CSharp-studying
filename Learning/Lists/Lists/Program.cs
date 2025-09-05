internal class Program
{
    private static void Main(string[] args)
    {

        List<string> songs = new List<string>();

        songs.Add("Phonk"); //adds a new item to the list

        songs.Add("Rock");

        songs.Remove("Rock"); //remove a item from the list

        songs.Insert(1, "Pop"); // insert a item in a selected position of the list

        songs.Add("Phonk");

        songs.LastIndexOf("Phonk"); // searches for the last position of the given item

        Console.WriteLine(songs.Contains("Rock")); // its gonna return true or false if it contains the solicited item 
        //needs a writeline to show the answer

        Console.WriteLine(songs.IndexOf("Phonk")); //show the position of the written item

        songs.Sort(); // show our list in alphabetical order

        songs.Reverse(); //show our list in reverse order

        songs.Clear(); // clear our list

        Console.WriteLine(songs.Count); // indicate the number of items in the list

        string[] songsdiff = songs.ToArray(); // converts the list to a normal array

        foreach (string playl in songs)
        {
            Console.WriteLine(playl);
        }


        Console.ReadKey();
    }
}