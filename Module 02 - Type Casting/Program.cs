static void Print(string str) => Console.WriteLine(str);

//compiler does it for you
//implicit casting

int num = 2345;
long longNum = num;
Print(num + " " + longNum);

// explicit casting
double doubleNum = 323.32;
int castedNum = (int)doubleNum;


// Advance 
string data = "124234324";
int result = 0;
if (int.TryParse(data, out result)) // pass by reference 
    Print(result+"\t passed");
else 
    Print(result + "\t failed");


// implicit casting 
string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");
Console.WriteLine(firstName + " sold " + widgetsSold +7+ " widgets.");
Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");



string a = "asdasfr";
int b = 3;
a = a + b;
Console.WriteLine(a);