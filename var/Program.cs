using System;
using System.Collections.Generic;

//ref link:https://www.youtube.com/watch?v=1THfVo6FRcY&list=PL259BC2977085CF37&index=3
//var - advantages is for efficiency, and for anonymous types
//var - can be use in scope of function, property,
//var - compiler requires the expression("new Cow()") after the "=" in "var cow2 = new Cow();"

class Cow 
{
    //var UdderCapacity {  get; set; } // error var uses -- compiler cant process complicated long variable(UdderCapacity)
    public int MooCount { get; set; } 
}

class MainClass
{
    static void Main()
    {
        //Cow cow = new Cow();
        ////List<Cow> cows = new List<Cow>();
        //var cows = new List<Cow>(); // for efficiency("lazy")
        //var cow2 = new Cow();   // simple expression //looks like javascript, dynamic languages

        double dub = 5.3;
        var cow2 = dub * 2; // compiler can process complicated expression after the "="
        var value = 5;  // simple var example "not recommended"
    }
}