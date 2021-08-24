using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Indexers are smart array
//Similar to properties,indexers implement set and get methods
//reduce complexity of programs



class myIndexer
{
    public string[] name = new string[5];
    public string[] city = new string[5];
    public string this[int index] //Indexer
    {
        get
        {
            return name[index];
        }
        set
        {
            name[index] = value;
        }
    }
}

class MyMain
{
    public static void Main()
    {
        myIndexer ind = new myIndexer();


        ind[0] = "Kavin";
        ind[1] = "Kanav";
        ind[2] = "Sumedha";
        ind[3] = "Saadhana";
        ind[4] = "Joshitha";

        ind.city[0] = "Delhi";
        ind.city[1] = "Calcutta";
        ind.city[2] = "Mumbai";

        Console.WriteLine("{0},{1},{2},{3},{4}",
          ind[0], ind[1], ind[2], ind[3], ind[4]);       //calls the getter method
        Console.ReadKey();
    }
}

