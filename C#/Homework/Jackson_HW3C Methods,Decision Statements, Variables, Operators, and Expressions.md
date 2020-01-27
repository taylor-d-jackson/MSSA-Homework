# Methods and Scope

1. Can you declare a method inside another method?
		-yes
2.  Where can optional parameters be placed in a method signature?
		-Optional parameters can be placed in the parentheses within the argument list when you build a method statement. They must be the last parameter listed as well as the last statement within the method.
3. How can you pass parameters to a method out of order?
		-Yes, you can pass parameters out of order by using named and optional arguments.

# Decision Statements

4. If you want to combine two boolean statements with the && operator, would it make more sense to put the more computationally expensive statement on the left or right? Defend your answer.
		-You would put the more computationally expensive statement on the right of the && operator as it is evaluated second. You'd want the least computationally impactful statement to run first in order to have your program be more efficient. If it doesn't need to waste resources by caluculating a resource intensive statement and can rather evaluate something very quickly instead than it makes more sense to evaluate the statement that evaluates quickly first.

## Critique the following code:
5. 

    void M(bool t)
    {
        if (t == true)
        {
            doStuff();
        }
    }

		-First of all the code is vague. There are no comments for the code to tell us what is happening.
		-The method and variables are also vague and poorly defined. Your methods and variables should be named in a way that they provide some kind of clue as to their function.
	

# Apply

## Welcome to C#

6.  In the namespace MSSA.CS.Welcome, define a Main method which prints your name and "Welcome to C#!" to the command line.
```
	
	namespace: MSSA.CS.Welcome
	{	
		class: Program
		{
	
			public static void Main(string[] args)
			{
			Console.Writeline("Taylor, Welcome to C#!"
			}
		}	
	}
```	
## Variables, Operators, and Expressions

7. Given string input = "17", write code that:
	- Converts input to an integer and stores it in a variable named count
	- Increments count using the pre-increment operator
	- Prints count to the console using the string interpolation syntax
	```
	static void Main(string[] args)
        {
            string input = "17";
            var count = Int32.Parse($"{input}");
            ++count;
            Console.WriteLine($"{count}");
        }