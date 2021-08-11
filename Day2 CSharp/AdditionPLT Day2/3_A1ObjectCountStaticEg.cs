using System;
public class ObjectCount
{
    public static int count;

    public ObjectCount()
    {
        count++;
    }
    public int display()
    {
        return count;
    }

}
class Static
{
    public static int Main(string[] args)
    {
        ObjectCount obj1 = new ObjectCount();
	  ObjectCount obj2 = new ObjectCount();
	  ObjectCount obj3 = new ObjectCount();
       
	  Console.WriteLine("Number of objects created are {0}", obj3.display());
	  
        Console.ReadLine();
        return 0;
    }
}
