string thisIsCamelCase;
string firstName;
/*Console.WriteLine(firstName); = ERROR NOT ASSIGNED */
firstName = "Bob";
Console.WriteLine(firstName);

firstName = "Bob";
Console.WriteLine(firstName);
firstName = "Liem";
Console.WriteLine(firstName);
firstName = "Isabella";
Console.WriteLine(firstName);
firstName = "Yasmin";
Console.WriteLine(firstName);


// implicitly typed local variable
var message = "Hello";
Console.WriteLine(message);
/*
 * 
 message = 2; ERROR Cannot implicitly convert type 'decimal' to 'string'
 var message; ERROR Implicitly-typed variables must be initialized
 */