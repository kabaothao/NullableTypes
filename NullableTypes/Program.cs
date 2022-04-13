// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace NullableTypes // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime? date = null;
            DateTime date2 = date ?? DateTime.Today;

            DateTime date3 = (date != null) ? date.GetValueOrDefault() : DateTime.Today;


            Console.WriteLine(date2);



            //DateTime? date = new DateTime(2014, 1, 1);
            //DateTime date2 = date.GetValueOrDefault();
            //Console.WriteLine(date2);

            //DateTime? date3 = date2;

            //Console.WriteLine(date3.GetValueOrDefault());





            //DateTime? date = null;

            //Console.WriteLine("GetValueOrDefault " + date.HasValue);
            //Console.WriteLine("HasValue: " + date.Value);
            //Console.WriteLine("Value: " + date.Value);


        }
    }
}


/*
 

What is Nullable Types?

Cannot be null
bool hasAccess = true; // or false



 
 What are they and why do we need them?

In C#, as you probably know, a value type cannot have null. So if you define a bool,

it can have either a true or a false. But there are situations that you would also like to cater for null values.

For example, if you're working with a database and you have a table called Customers which has a column called Birthdate.

Birthdate can be nullable because not everyone wants to put in their birthdate.

In that case, if you want to map that table to a C# class, that's one of the cases where you use a nullable type.

Null Coalescing Operator




 
 */