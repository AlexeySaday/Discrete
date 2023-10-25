using Prims;

var edges = new List<Edge>
{
    new(new[] { 'A', 'B' }, 3),
    new(new[] { 'A', 'F' }, 2),
    new(new[] { 'F', 'G' }, 3),
    new(new[] { 'B', 'G' }, 6),
    new(new[] { 'B', 'C' }, 3),
    new(new[] { 'G', 'C' }, 1),
    new(new[] { 'G', 'E' }, 3),
    new(new[] { 'F', 'E' }, 4), 
    new(new[] { 'C', 'E' }, 2),
    new(new[] { 'C', 'D' }, 3),
    new(new[] { 'E', 'D' }, 5),
};
var prime = new Prime(edges);
Console.WriteLine("Result:" + prime.Calc());
