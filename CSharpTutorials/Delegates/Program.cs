using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    class Program
    {
        //Delegate declaration 
        internal delegate void Display(string param);
        static void Main(string[] args)
        {
            #region Simple Delegate example
            Program p = new Program();

            //Creating new instance of Delegate and 
            //providing method name which needs to be executed when called back
            Display disp = new Display(p.DisplayToConcole);

            //Callback happens at this point
            disp("Hello World");
            #endregion

            #region Delegate chaining using Combine/Remove methods of delegate
            Display d1 = new Display(p.DisplayToConcole);
            Display d2 = new Display(p.SayHelloToUser);
            
            //Chained d1 and d2, so when callback happens both methods DisplayToConsole() and 
            //SayHelloToUser() will be called sequentially
            Display dChain = null;
            dChain = (Display)Delegate.Combine(dChain, d1);
            dChain = (Display)Delegate.Combine(dChain, d2);
            dChain("David");

            //Removed one delegate from the chain
            dChain = (Display)Delegate.Remove(dChain, d2);
            dChain("Rock");
            #endregion

            #region Delegate chaining using +=/-= operator
            Display d3 = new Display(p.DisplayToConcole);
            Display d4 = new Display(p.SayHelloToUser);

            Display operatorChain = null;

            operatorChain += d3;
            operatorChain += d4;
            operatorChain("DavidOperator");

            operatorChain -= d4;
            operatorChain("RockOperator");
            #endregion

            #region Delegate using lambda expression

            Display dLamb = new Display(obj => {
                Console.WriteLine(obj);
            });
            dLamb("Lambda delegate");

            #endregion

            Console.Read();
        }    
        
        private void DisplayToConcole(string parameter)
        {
            Console.WriteLine(parameter);
        }

        private void SayHelloToUser(string username)
        {
            Console.WriteLine("Hello " + username);
        }
    }
}
