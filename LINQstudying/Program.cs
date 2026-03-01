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

// 2. Query creation using method syntax

        // Filtering with Where()
        // Find numbers greater than 10
        var greaterThanTen = numbers.Where(num => num > 10);

        // Filtering and Ordering with Where() and OrderBy()
        // Find even numbers and order them in ascending order
        var evenNumbersOrdered = numbers.Where(num => num % 2 == 0)
                                        .OrderBy(num => num);

        // Projection with Select()
        // Square each number
        var squaredNumbers = numbers.Select(num => num * num);
        
        // Aggregation with Count()
        // Count numbers greater than 15
        var count = numbers.Count(num => num > 15);
        
        // First or default element
        // Get the first number greater than 20, or a default value if none is found
        var firstNumber = numbers.FirstOrDefault(num => num > 20);

        // 3. Query execution (e.g., in a foreach loop or using conversion operators like ToList())
        Console.WriteLine("Numbers greater than 10:");
        foreach (var num in greaterThanTen)
        {
            Console.Write(num + " ");
        }
        // Output: 15 20 25 30 
        
        Console.WriteLine($"\n\nNumber of elements greater than 15: {count}");
        // Output: Number of elements greater than 15: 3