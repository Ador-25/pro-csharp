string firstName = "Bob";
string greetings = "Hello";

string message = $"{greetings} {firstName}!";

Console.WriteLine(message);


// avoid intermediate variables
int version = 11;
string updateText = "Update to Windows";
Console.WriteLine($"{updateText} {version}!");


string projectName = "First-Project";
string output = $@"C:\Output\{projectName}\Data";
Console.WriteLine(output);


projectName = "ACME";

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

Console.WriteLine("View English Output:\n\t" + $@"c:\Exercise\{projectName}\data.txt");
Console.WriteLine(russianMessage);


Console.WriteLine(projectName+@"\");
