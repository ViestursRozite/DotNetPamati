// See https://aka.ms/new-console-template for more information

void MyFunctionName(string myVariableName)
{
    Console.WriteLine("Hello, World!");
}


try
{
    string result = "";
    MyFunctionName("");
    result = Console.ReadLine();

    if (result.Equals("Hello, World!"))
    {
        Console.WriteLine("1.Uzd. DONE");
    }
    else
    {
        Console.WriteLine("1.uzd. FAIL");
    }
}
catch (Exception e)
{
    Console.WriteLine(e);
	
}