using System;

namespace Indexers
{

    class ProgramIndexers
    {
        static void Main(string[] args)
        {
            // A way to access elements in a class that represent a list of values

            // similar to the below
            // var array = new int[5];
            // array[0] = 1;

            // var list = new List<int>();
            // list[0] = 2;

            // Can use indexers to access

            // public class HttpCookie
            // {
            //     public stirng this[string key]
            //     {
            //         get {...}
            //         set {...}
            //     }
            // }

            var cookie = new HttpCookie();
            cookie["name"] = "Mosh";
            System.Console.WriteLine(cookie["name"]);

        }
    }
}
