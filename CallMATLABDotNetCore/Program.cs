using System;

namespace CallMATLABDotNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the MATLAB instance 
            MLApp.MLApp matlab = new MLApp.MLApp();

            // Change to the directory where the function is located 
            matlab.Execute(@"cd G:\MatlabProject\FunctionCallFromDotNet");

            // Define the output 
            object result = null;

            // Call the MATLAB function myfunc
            matlab.Feval("cubicpoly", 1, out result, 2, 3, 1);

            // Display result 
            object[] res = result as object[];

            Console.WriteLine(res[0]);
            //Console.WriteLine(res[1]);
            // Get user input to terminate program
            Console.ReadLine();
        }
    }
}
