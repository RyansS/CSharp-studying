
using ConnectingDatabase.Database;



try
{
    using var connection = new Connection().openConnection();
    connection.Open();
    Console.WriteLine(connection.State);
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

return;