// Variables
using System.Linq;
using System.Linq.Expressions;

int a = 5;
string s = "KEK";
// array
string[] sarr = { "one", "two", "three" };
sarr = sarr.Append("KEKE").ToArray(); // need explicit cast from IEnumerable to array
// arrays are not automatically printed with Console.WriteLine(), need explicit conversion from array to string
string array_string = string.Join(", ", sarr); 
Console.WriteLine(a + ", " + s + ", " + "[{0}]", array_string);
Console.WriteLine("Thing object: {0}", new Thing(105, "y", 4.8).ToString());

// looping
ushort[] shorts = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
// standard C-style for loop
Console.WriteLine("C-style for loop");
for (ushort i = 0; i < shorts.Length; i++) {
    Console.Write(shorts[i]);
    if (i != shorts.Length - 1) Console.Write(", ");
}
Console.WriteLine();
// foreach
Console.WriteLine("foreach operator");
foreach (var elem in shorts) { 
    Console.Write(elem.ToString() + " ");
}
// while
Console.WriteLine("\nA while loop");
ushort i2 = 0;
while (i2 < shorts.Length) {
    Console.Write(shorts[i2].ToString() + " ");
    i2++;
}
Console.WriteLine();
// .ForEach()
Console.WriteLine(".ForEach() extension method");
Array.ForEach(shorts, elem => Console.Write("{0} ", elem)); Console.WriteLine();

// List
Console.WriteLine("Create list of ints as range and join into string:");
var lints = Enumerable.Range(1, 10).ToList();
Console.WriteLine("[{0}]", string.Join(", ", lints));
Console.WriteLine("Sum of lints: [{0}]", lints.Sum());
// map function in C# is done via LINQ's .Select() method
Console.WriteLine("Map increment of each element by one: [{0}]", string.Join(", ", lints.Select(elem => elem + 1)));
Console.WriteLine("Filter only even numbers: [{0}]", string.Join(", ", lints.Where(elem => elem % 2 == 0)));


class Thing {
    public int X { get; set; }
    protected string Y { get; set; }
    private double Z { get; set; }
    // cool syntax for initializing 3 properties in a single constructor line
    public Thing(int newx, string newy, double newz) => (X, Y, Z) = (newx, newy, newz);
    // note the new() syntax
    public override string ToString() => new($"{{ {X}, {Y}, {Z} }}"); // oneliner method syntax, =>
}