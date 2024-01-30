
1. **for loop**:
```csharp
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Value of i: " + i);
}
```

2. **while loop**:
```csharp
int j = 0;
while (j < 5)
{
    Console.WriteLine("Value of j: " + j);
    j++;
}
```

3. **do-while loop**:
```csharp
int k = 0;
do
{
    Console.WriteLine("Value of k: " + k);
    k++;
} while (k < 5);
```

4. **foreach loop** (used with collections like arrays or lists):
```csharp
int[] numbers = { 1, 2, 3, 4, 5 };
foreach (int num in numbers)
{
    Console.WriteLine("Number: " + num);
}
```

Each of these loops serves a different purpose and can be used depending on the specific requirements of your code.
