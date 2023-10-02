// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Data Type in C#e
// Primitives 

/*
In JavaScript
    string
    boolean
    number
    arrays
    objects
*/
/*
In Python
    string
    int
    float
    boolean
    tuple
    list
    dictionary 

*/
/* In C#
*/
// type name = value ;
//! Numbers
int age = 36 ;
float rate = 1.32f;
double grade = 3.35;
Console.WriteLine(age);
Console.WriteLine(rate);
Console.WriteLine(grade);
//! Char vs String 
char tag = 'A';

System.Console.WriteLine($"My Programing level is {tag}.");


//! Boolean
bool isValid = true;
bool hasCovid = false;


//! Bytes
byte cOne = 0;
byte cTow = 255;

// Complex Types 


//! String
string FirstName = "Jhon";
Console.WriteLine($"My First Name is {FirstName} I am {age} years old .");


//! Arrays
/*
List with fixed Type and length
*/
int[] numbers = new int[5];
numbers [0] = 1;
numbers [1] = 2;
numbers [2] = 3;
numbers [3] = 4;
numbers [4] = 5;
Console.WriteLine(numbers);
//OR
int[] numbers = new int[5] {1,2,3,4,5};
Console.WriteLine(numbers);
Console.WriteLine(numbers.Length);


//! Lists
List<int> gradeList = new List<int>();
gradeList.Add(22);
gradeList.Add(2);

List<string> NameList = new List<string>() {"James", "Alice", "Jhon", "Sarah"};
Console.WriteLine($"Length of the list : {NameList.Count()}");

NameList.Add("Max");
Console.WriteLine($"Length of the list after adding Max : {NameList.Count()}");

NameList.Remove("Jhon");
Console.WriteLine($"Length of the list after deleting Jhon : {NameList.Count()}");

Console.WriteLine(NameList.IndexOf("Alice"));
Console.WriteLine(NameList.Contains("Jhon"));


//! Dictionary
Dictionary<int, string> MyDict = new Dictionary<int, string>(){
    {1, "Jhon"}, {2,"James"}
}


System.Console.WriteLine(OrderStatus.Canceled);
//! Enums
public enum OrderStatus 
{
    Pending = 1,
    Canceled = 0,
    Delivered = 2
}

System.Console.WriteLine();