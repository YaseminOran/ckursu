using System;

namespace GenericsIntro
{
    class MainClass
    {
        public static void Main(string[] args)
        {


            MyList<string>names = new MyList<string>();
            names.Add("yasemin");
            Console.WriteLine(names.Length);

            names.Add("tayfun");
            Console.WriteLine(names.Length);
        }
    }
}
