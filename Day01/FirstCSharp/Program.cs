// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World From C# .NET");

// Data Types In C#

/* In  JavaScript
    String
    Number 
    Boolean
    Array
    Object
*/
/* In  Python
    String
    int
    float 
    Boolean
    tuple
    List
    Dictionary
*/

/* In  C#
    Numbers : 
        int : 
            short (0,128) 2 bytes
            long 8 bytes
        float
        double
        decimal
    Text : 
        char
        string
*/

// ! Numbers

int age = 28;
Int32 ageShort = 32;
Int64 ageLong = 45;

// Console.WriteLine(age);s

float rate = 1.25f;
double grade = 8.755;
//! Strings

// char :  primitive type single character single quotes ' '
// string :  complex type array of characters double quotes " "
char tag = 'A';
char tagTwo = 'B';

//! Boolean
bool hasCovid = true;
bool isFunny = false;

// ! Bytes
byte bOne = 0;
byte maxByte = 255;

// Complex Data Types

string FirstName =  "Alex";
// System.Console.WriteLine($"First Name is {FirstName} and he is {age} years old.");

// ! Arrays
// List with fixed Type and Length

int[] numbers  = new int[5];
numbers[0] = 1 ;
numbers[1] = 2 ;
numbers[2] = 3 ;
numbers[3] = 4 ;
numbers[4] = 5 ;

int[] grades = new int[5] {1,2,3,4,5};
// System.Console.WriteLine(numbers);


// ! List 

List<string> NamesList = new List<string>() {"John", "Alex", "Sarah"};
// System.Console.WriteLine(NamesList.Count());
// NamesList.Add("Alice");
// System.Console.WriteLine(NamesList.Count());
// NamesList.Remove("Alex");
// System.Console.WriteLine(NamesList.Count());
// System.Console.WriteLine(NamesList.Contains("John"));
// System.Console.WriteLine(NamesList.IndexOf("John"));


// ! Dictionary

Dictionary<int, string> FirstDict = new Dictionary<int, string>() {
    {1, "John"}, {2, "Max"}
};


// ! ENUM 

UserRoles userRole = UserRoles.User;
// System.Console.WriteLine($"User Role is {userRole}");

// ! Conditionals 

// if(userRole == UserRoles.Admin) 
// {
//     System.Console.WriteLine("You are an Admin you have all the access.");
// }
// else if(userRole == UserRoles.Customer) 
// {
//     System.Console.WriteLine("You are a Customer you can purchase items .");
// }
// else
// {
//     System.Console.WriteLine("You are a simple User you can see only Home Page.");
// }

// if(age > 18) 
// {
//     System.Console.WriteLine("You can Vote");
// } 
// if(age <= 60) {
//     System.Console.WriteLine("You are too young to retire.");
// }
// if(!hasCovid)
// {
//     System.Console.WriteLine("Go to the Doctor");
// }
//!  Loops

// for(int i = 0; i<NamesList.Count(); i++)
// {
//     System.Console.WriteLine($"User name is {NamesList[i]} ---- Index  = {i}");

// }
// for (int i = 0; i<grades.Length; i++){
//     System.Console.WriteLine(value: $"Grade For Loop : {grades[i]}");
// }
// foreach (string name in NamesList)
// {
//     System.Console.WriteLine($"ForEach User : {name}");
// }

// foreach(int i in grades) {
//     System.Console.WriteLine(value: $"Grade : {i}");
// }

// ! Functions 
/*
def say_hi():
    print("Hi")

const sayHi = () => console.log("Hi")
*/

static void SayHi(){
    System.Console.WriteLine("Hi");
}
static int AddTwoNumbers(int a, int b)
{
    int sum =  a + b;
    return sum;
}
// SayHi();
// System.Console.WriteLine(AddTwoNumbers(10,23));

static string SayHello(string name) 
{
    return $"Hello {name}, Happy to have you here.";
}

static List<int> FirstFiveMultiples(int number)
{
    List<int> result = new();
    for(int i=1 ; i<=5; i++){
        result.Add(i * number);
    }
    return result;
}

static void PrintResult(List<int> inputList){
    foreach(int i in inputList){
        System.Console.WriteLine($"Number is {i}");
    }
}
List<int> multiples  = FirstFiveMultiples(5);
PrintResult(multiples);
// System.Console.WriteLine(SayHello(FirstName));


// ! Casting  =  convert a variable from a type to another type

// string strAge = "22"; //64 -> 16
// int intAge = strAge;

// Implicit Casting 
int IntValue = 22;
double DoubleValue = IntValue;
byte ByteValue = 255;
int IntFromByte = ByteValue;
// Explicit Casting
int intValue = 300;
double DoubleFromInt = (int)intValue;
string stringFromInt = intValue.ToString();

// bytes 0-255
//Safe Casting
int radomValue  = 300;
if(0<=radomValue && radomValue<255){
    byte byteResult = (byte)radomValue;
} else{
    byte byteResult = 125;
}

public enum UserRoles 
{
    Admin = 1,
    User = 2,
    Customer = 3
}
 