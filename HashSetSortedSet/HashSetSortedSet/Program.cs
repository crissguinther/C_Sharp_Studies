using Course.Entities;

namespace Course
{
    class Course
    {
        public static void Main(string[] args)
        {
            //HashSet<string> set = new HashSet<string>();

            //set.Add("TV");
            //set.Add("Notebook");
            //set.Add("Tablet");

            //Console.WriteLine(set.Contains("Notebook"));

            //foreach(string str in set)
            //{
            //    Console.WriteLine(str);
            //}

            SortedSet<int> a = new SortedSet<int> { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int> { 5, 6, 7, 8, 9, 10 };

            // Union
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b); // Join two collections

            // intersetion
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b); // Get the values that are present on both collections

            // difference
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b); // Get the values that are not present on another collection

            PrintCollection(e);


            // Comparison
            HashSet<Product> prods = new HashSet<Product>();
            prods.Add(new Product("TV", 1200.0));
            prods.Add(new Product("Notebook", 2400.0));

            HashSet<Point> points = new HashSet<Point>();
            points.Add(new Point(3, 4));
            points.Add(new Point(5, 10));

            Product prod = new Product("Notebook", 2400.0);
            Console.WriteLine(prods.Contains(prod));

            Point p = new Point(5, 10);
            Console.WriteLine(points.Contains(p));
        }

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach(T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}