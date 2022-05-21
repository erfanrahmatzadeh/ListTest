using System.Linq;

List<int> first = new List<int>() { 1, 2, 3, 4, 5 };
List<int> second = new List<int>() { 6, 7, 8, 9 };

List<int> result = first.Join(second);
Console.WriteLine(String.Join(",", result));



/// <summary>
/// Merges the specified collections so that the n-th element of the second list should appear after the n-th element of the first collection. 
/// Example : first : 1,3,5 second : 2,4,6 -> result : 1,2,3,4,5,6
/// </summary>
//public IEnumerable<int> Merge(IEnumerable<int> first, IEnumerable<int> second)
//{
//    throw new NotImplementedException();
//}