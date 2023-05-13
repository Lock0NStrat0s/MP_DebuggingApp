using MP_Debugging;

try
{
    double i = Methods.W(0);
    Console.WriteLine(i);
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("Something went wrong.");
}

