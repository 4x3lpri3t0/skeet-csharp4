using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MasteringCSharp_CovarianceAndContravariance
{
    class Fruit { }
    class Banana : Fruit { }
    class Apple : Fruit { }

    class Program
    {
        interface IFoo<in T> //in: passing an argument into
        { 
            //T GiveMeAnInstanceOfT(); //ERROR, but would work with interface IFoo<out T>
            void takeAnInstanceOfT(T instance);
        }

        static void Main(string[] args)
        {
            ////List<Fruit> fruitBowl = new List<Banana>(); // ERROR
            //List<Banana> bunchOfBananas = new List<Banana>();
            //List<Fruit> fruitBowl = bunchOfBananas;
            //fruitBowl.Add(new Apple());

            //Banana banana = bunchOfBananas[0]; // can explode if [0] is an APPLE

            //List<Banana> bunchOfBananas = new List<Banana>();
            //IEnumerable<Fruit> fruitBowl = bunchOfBananas; //IEnumerable is a sequence (something you can iterate). Inmutable type.

            //COVARIANCE: Values come OUT of an interface.
            //CONTRAVARIACNE: Values come IN to an interface.

            IFoo<Fruit> fruit = null;
            IFoo<Apple> apple = fruit;
        }
    }
}
