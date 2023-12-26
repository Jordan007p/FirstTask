
# FirstTask

## Summary
`JLinkedList<T>` is a custom implementation of a singly linked list in C#. It provides basic functionality such as adding, removing, finding, and clearing nodes, as well as checking the list's emptiness and counting its elements. Simply put, it is a basic and efficient way of implementing a Linked List from scratch.
## How to Use

### Initialization
To create a new instance of `JLinkedList`, declare it with the desired data type:
```csharp
JLinkedList<string> myList = new JLinkedList<string>();
```

### Adding Elements
Add elements using `AddFirst`, `AddLast`, or `AddAfter` methods:

- `AddFirst(T data)` adds an element at the beginning of the list.
  ```csharp
  myList.AddFirst("Hello");
  ```
- `AddLast(T data)` adds an element at the end of the list.
  ```csharp
  myList.AddLast("World");
  ```
- `AddAfter(T key, T data)` adds an element after a specified element.
  ```csharp
  myList.AddAfter("Hello", "There");
  ```

### Removing Elements
Remove an element using the `Remove` method:
```csharp
myList.Remove("Hello");
```

### Finding Elements
Find an element with the `Find` method, which returns the node containing the data:
```csharp
Node<string> node = myList.Find("World");
```

### Checking for Emptiness
Check if the list is empty:
```csharp
bool isEmpty = myList.IsEmpty();
```

### Counting Elements
Get the number of elements in the list:
```csharp
int count = myList.Count();
```

### Clearing the List
Remove all elements from the list:
```csharp
myList.Clear();
```

### Printing the List
Get a string representation of the list:
```csharp
string listAsString = myList.ToString();
Console.WriteLine(listAsString);
```

## Node Class
The `JLinkedList` uses an inner `Node<T>` class to hold the data and the reference to the next node.

## Limitations
- Does not support indexing.
- Singly linked list, so traversal is only forward.

## Conclusion
`JLinkedList<T>` is a versatile implementation of a linked list in C#, useful for understanding data structures and for scenarios where a custom implementation is more beneficial than the built-in `LinkedList<T>` in .NET.



