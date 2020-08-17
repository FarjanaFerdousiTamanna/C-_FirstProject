using System;

namespace FirstProject
{
    
    class Program
    {
        static void Main(string[] args)
        {
            /*  variable can be set by using var,
             But good practice is setting the variable name by the datatype
             ones the datatype is set, it does not need to mention again
             we can find different methods by going "view- object browser"
             like the ToUpper is a method
             maintaining the lowercase uppercase in variable name is called "Camel case"
             
             */
            var name = "tamanna";
            string newname = "Rakib";
            newname = newname.ToUpper();
            Console.WriteLine(name);
            Console.WriteLine(newname);
        }
    }
    
}
