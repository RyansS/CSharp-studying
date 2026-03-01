List<int> numbers = new List<int> {1, 3, 4, 1, 7 ,6 ,7 ,8, 4, 3};

// LINQ Query Syntax

var FilterNumbersQ = from num in numbers //
where num == 7 || num < 8
select num;

foreach (var shownumbs in FilterNumbersQ)
{
    Console.WriteLine(shownumbs);
}

// LINQ Method Syntax

var FilterNumbersM = numbers.Where(num => num > 6 || num < 4).Distinct(); // Can use two or more methods in a single line


