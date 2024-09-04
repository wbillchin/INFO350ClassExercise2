/*
 * INFO 350 - Spring 2024
 * 
 * Class Exercise 2
 * 
 */

/* Note how this is a comment - that does not affect the code at all.
   Everything between the forward slash - asterisk and then the
   asterisk - slash is ignored by the compiler when generating code
 */

/*
 * Some people like to format their comments this way.
 * 
 * Comments are important documentation in code to allow humans
 * to understand the code and you are expected to put reasonable
 * comments in the code you submit
 */

// This is also a comment - the double forward slashes indicate that
// the rest of the line is a comment

// Includes go here to bring in symbols that the code below would reference
using System;

// We will eventually discuss the set up here, but for now, pay attention
// to the code within the Main function below
namespace MyApp
{
    internal class Program
    {
        // this is the Main function - every program has an entry point, usually
        // called main. It is the start point where the operating system
        // hands off control to the application to start running
        static void Main(string[] args)
        {
            /*
             * We will go over the meaning of the various parts of the function
             * declaration above, but just note for now the curly brace above
             * and the curly brace that ends this main function below.
             * 
             * These matching curly braces { and } define a block
             */

            // some languages only support declaring variable at the top of a 
            // block. C# is not one of those

            /* 
             * Declare variables to store data.
             * 
             * The syntax is <datatype> <variablename> <optional = initial value>
             * 
             * Built-in data types in C#:
             * https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types
             *
             * We will initially deal with just 3 types, for formal definitions,
             * see the language specifications link above
             *
             * bool - single binary digit - on/off, 0/1, true/false
             * int - scalar values, no decimals
             * double - floating point number in 8 bytes with mantissa, exponent
             */

            //Console.WriteLine("The total is " + total); // note what happens if you
                                                          // uncomment this

            int firstValue;   // declare an integer scalar variable named firstValue
                              // note the value is currently undefined
                              // program will set aside the storage for this variable
                              // and we call this a local variable, defined
                              // for the scope of this block

            // declare an integer scalar variable named secondValue
            // and set the initial value to 35
            int secondValue = 35; 

            // declare an integer scalar variable named total
            // value is not defined yet
            int total;

            //Console.WriteLine("The total is " + total); // note what happens if you
                                                          // uncomment this

            // variable value assignment
            // the item to the left of the equals sign "=" is called a lvalue
            // and the item to the right is called an rvalue

            // assign the number 10 to firstValue
            firstValue = 10;

            // assign the number 25 to secondValue
            secondValue = 25;

            // assign the value of the expression given in the rvalue
            // to total

            // note that the rvalue expression here has an operator that
            // performs math
            total = firstValue % secondValue;

            // try out +, -, *, /, %

            // full set of operators
            // https://learn.microsoft.com/en-us/cpp/c-language/c-operators?view=msvc-170

            // operator precedence
            // https://learn.microsoft.com/en-us/cpp/c-language/precedence-and-order-of-evaluation?view=msvc-170

            // And write it out to console like this:
            Console.WriteLine("The total is " + total);

        }
    }
}