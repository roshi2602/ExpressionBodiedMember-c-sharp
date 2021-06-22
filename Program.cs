using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//it gives implementation of memeber in readable format
//syntax-    member => expression; 
//list of members are- methods, properties, constructor, destructor, getter,setter,indexers


namespace ExpressionBodiedMember
{
    //------------------------------------------------------------------
    //constructor
    //. Expression or right side followed with '=>' must be valid and should be one statement
    //A constructor does not have any return type and it is private by default.

    class EbmConstructor
    {
        //2 parameters
        public int x = 100;
        public int y = 200;

        //constructor implemented using ExpressionBodiedMember
        public EbmConstructor() => x = x + y;
        //now goto main method
    }
    //--------------------------------------------------------

    //Destructor
    class EbmDestructor
    {
        public int x = 100;
        public int y = 200;

        //create constructor implemented using ExpressionBodiedMember
        public EbmDestructor() => x = x + y;
     
        //destructor implemented using ExpressionBodiedMember
        ~EbmDestructor() => Console.WriteLine("this is destructor");
        //now goto main method
    }
    //--------------------------------------------------------
    //property get accessor
    //get keyword is used
    //Expression or right side followed with => must be a valid single statement and must return a value of data type d

    class Get
    {
        public int x = 100;
        public int y = 200;
        private string z;
        //property
        public string Name
        {
            //get implemented by ExpressionBodiedMember
            get => z;
        }
    }
    //---------------------------------------------------------------
    //property set accessor

    //Expression or right side followed with => must be valid single statement and must assign a value back to the variable of datatype

    class Set
    {
        public int x = 100;
        public int y = 200;
        private string z;
        //property
      public string Name
        {
            //get implemented by ExpressionBodiedMember
            get => z;
            //set implemented by ExpressionBodiedMember
            set =>z= value;
        }
    }
    //---------------------------------------------------------------
    //ExpressionBodied methods
    //An expression-bodied method consists of a single expression that returns a value 
    class Method1
    {
        public int x = 100;
        public int y = 200;

        //method
        public void Demo1() => Console.WriteLine("hello");

        //method that will call another method
        public void Demo2() => Demo1();

        //method having 2 parameters
        public int Demo3(int p, int q) => p + q;

        //now goto main method
    }
    //---------------------------------------------------------------
    //indexers ExpressionBodied

    public class Indexers
    {
        public string[] z = { "cricket", "basketball", "baseball", "volleyball" };


        //Both the indexer’s get and set accessors are implemented as expression body definitions.
        public string this[int i]
        {
            get => z[i];
            set => z[i]=value;
        }

    }
    
   

    //---------------------------------------------------------------
    class Program
    {
        static void Main()
        {
            //----------------------------------
            EbmConstructor ee = new EbmConstructor();
            Console.ReadLine();

            //----------------------------------
            EbmDestructor ed = new EbmDestructor();
            Console.ReadLine();

            //----------------------------------
            Get gg = new Get();
            Console.ReadLine();

            //---------------------------------
            Set ss = new Set();
            Console.ReadLine();


            //---------------------------------
            Method1 mm = new Method1();
            mm.Demo1();
            mm.Demo2();
            mm.Demo3(10, 20);
            Console.ReadLine();
            //---------------------------------
            Indexers ii = new Indexers();
            Console.WriteLine(ii[0]);
            Console.WriteLine(ii[2]);
            Console.ReadLine();

            //---------------------------------
         
        }

    }



}

