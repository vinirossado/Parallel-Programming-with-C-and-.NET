// See https://aka.ms/new-console-template for more information

//There are a lot mix . ? and - because all 3 threads are executing at the same time 
static void Write(char c)
{
    var i = 1000;
    while (i-- > 0)
    {
        Console.Write(c);
    }
}


Task.Factory.StartNew(() => Write('.'));

var t = new Task(() => Write('?'));
t.Start();

Write('-');
Console.WriteLine("Main program done!");
Console.ReadKey();