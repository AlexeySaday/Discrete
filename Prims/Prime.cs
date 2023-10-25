namespace Prims;

public class Prime
{
     private readonly List<Edge> _edges;
     private readonly List<char> _usedSymbols = new();
     private int _sum;

     public Prime(List<Edge> edges)
     {
          _edges = edges;
          if (_edges.Count < 2)
          {
               throw new ArgumentException(nameof(_edges));
          }
     }

     public int Calc()
     {
          var symbols = new HashSet<char>();
          foreach (var edge in _edges)
          {
               symbols.Add(edge.Symbols[0]);
               symbols.Add(edge.Symbols[1]);
          }

          var findingEdge = _edges.MinBy(x => x.Value)!;
          
          _usedSymbols.Add(findingEdge.Symbols[0]);
          _usedSymbols.Add(findingEdge.Symbols[1]);
          
          _sum += findingEdge.Value;
          _edges.Remove(findingEdge);
          
          while (_usedSymbols.Count != symbols.Count)
          {
               var possibleMinEdges = new List<Edge>();
               for (int i = 0; i < _usedSymbols.Count; i++)
               {  
                    var minEdge = _edges.Where(x => x.Symbols.Contains(_usedSymbols[i])).MinBy(x => x.Value);
                    if (minEdge != null)
                    {
                         possibleMinEdges.Add(minEdge);
                    }
               }
 
               var smallestEdge = possibleMinEdges.MinBy(x => x.Value)!;
               var newSymbol = smallestEdge.Symbols.First(x => !_usedSymbols.Contains(x));
                
               _usedSymbols.Add(newSymbol);
               _sum += smallestEdge.Value; 
               _edges.RemoveAll(x => (_usedSymbols.Contains(x.Symbols[0]) && newSymbol == x.Symbols[1])
                                     || (_usedSymbols.Contains(x.Symbols[1]) && newSymbol == x.Symbols[0]));
          }

          return _sum;
     } 
}

public record Edge(char[] Symbols, int Value);

