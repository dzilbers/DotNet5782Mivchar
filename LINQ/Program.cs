using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace LINQ
{
    struct MyStruct
    {
        int boo;
        public int Boo
        {
            get
            {
                Console.WriteLine("Getter: " + boo);
                return boo;
            }
            set => boo = value;
        }
        public MyStruct(int value) => boo = value;
        public override string ToString() => "Boo: " + boo;
    }
    class Program
    {
        static List<MyStruct?> list = new() { new(1), new(2), new(3), new(4) };
        static void Main(string[] args)
        {
            // ================== basic LINQ and deferred execution ==================
            //IEnumerable<MyStruct?> coll = list;

            //Console.WriteLine("Start");
            //Console.ReadKey();
            //var obj1 = list.Find(o => o?.Boo > 0); // List<> and IEnumerable<> functions
            //Console.WriteLine("List tracked");
            //Console.ReadKey();
            //var obj2 = coll.FirstOrDefault(o => o?.Boo == 2);  // IEnumerable<> functions
            //Console.WriteLine("Collection tracked");
            //Console.ReadKey();

            //var result = //coll.Where(item => item?.Boo % 2 == 0).Select(item => "Boo" + item?.Boo);
            //    from item in coll
            //    where item?.Boo % 2 == 0
            //    select "Boo" + item?.Boo;

            //Console.WriteLine("Result Assigned");
            //Console.ReadKey();
            //foreach (var item in result)
            //{
            //    Console.WriteLine("foreach " + item);
            //    Console.ReadKey();
            //}
            //Console.WriteLine("Another foreach");
            //Console.ReadKey();
            //foreach (var item in result)
            //{
            //    Console.WriteLine("foreach " + item);
            //    Console.ReadKey();
            //}

            //Console.WriteLine(result.FirstOrDefault());

            //Console.WriteLine("ToList");
            //Console.ReadKey();
            //var lResult = result.ToList();
            //Console.WriteLine("continue");
            //Console.ReadKey();
            //Console.WriteLine($@"
            //Count: {lResult.Count}
            //0: {lResult[0]}
            //");
            //Console.WriteLine("Finish");
            //Console.ReadKey();

            // ================== grouping ====================
            List<string> names = new()
            {
                "Zvi",
                "Lia",
                "Reuven",
                "Eliahu z\"l",
                "Sarit",
                "David", // Dani's kids
                "Avraham",
                "Mira",
                "Moshe", // Dani's nephews
                "Shim'on",
                "Levy",
                "Yehuda",
                "Issachar",
                "Zvulun",
                "Dan", // Yaakov kids
                "Naftali",
                "Gad",
                "Asher",
                "Dina",
                "Yossef",
                "Byniamin" // More Yaakov kids
            };

            //var temp = from name in names
            //           group name.Substring(1) by name[0];
            //var dict = from grp in temp
            //           orderby grp.Key
            //           select grp;
            // ******* can be concatenated into a single LINQ request by "into" syntax
            var dict = from name in names
                       group name.Substring(1) by name[0]
                       into grp // here it is
                       orderby grp.Count() // grp.Key
                       select grp;


            foreach (var item in dict)
            {
                var key = item.Key;
                Console.WriteLine(key + ":");
                Console.ReadKey();
                int count = 0;
                foreach (var elem in item)
                    Console.WriteLine("  " + ++count + ". " + key + elem);
                Console.ReadKey();
            }

            foreach (var item in from name in names
                                 group name.Substring(1) by name[0]
                                 into grp
                                 orderby grp.Key
                                 select grp) ;

            Console.WriteLine(dict.Average(grp => grp.Count()));

            var result3 = names.GroupBy(name => name[0], name => name.Substring(1))
                               .OrderBy(grp => grp.Key);
        }

        static IEnumerable<IGrouping<char, string>> foo(IEnumerable<string> coll)
            => from name in coll
               group name.Substring(1) by name[0]
               into grp
               orderby grp.Key
               select grp;
    }
}
