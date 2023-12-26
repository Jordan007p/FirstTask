using FirstTask;

JLinkedList<String> testlist = new JLinkedList<String>();

// This is a series of tests for the new JLinkedList class
testlist.AddFirst("Marco");
testlist.AddFirst("Alice");
testlist.AddFirst("Bob");
testlist.AddFirst("Charlie");
testlist.AddFirst("Diana");
testlist.AddFirst("Edward");
testlist.AddFirst("Fiona");
testlist.AddFirst("George");
testlist.AddFirst("Hannah");
testlist.AddFirst("Ian");
testlist.AddFirst("Julia");

Console.WriteLine(testlist.ToString());

testlist.Remove("Marco");
Console.WriteLine(testlist.ToString());

testlist.AddLast("Shrek");
Console.WriteLine(testlist.ToString());

testlist.AddAfter("Fiona", "Donkey");
Console.WriteLine(testlist.ToString());

Console.WriteLine("Number of elements is "+testlist.Count());

testlist.Clear();
Console.WriteLine(testlist.ToString());