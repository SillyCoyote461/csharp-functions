//Console input
Console.Write("How many numbers do you want to elaborate? ");
int n = Convert.ToInt32(Console.ReadLine());


//variable array
int[] arrayNum = new int[n];
for (int i = 0; i < arrayNum.Length; i++)
{
    Console.Write("Digit a number ");
    arrayNum[i] = Convert.ToInt32(Console.ReadLine());

}

//functions call
printArray(arrayNum);
rootArray(arrayNum);
sumArray(arrayNum);


comparator(arrayNum, arrayNum.Length -2, arrayNum[^1]);


//functions
    //print array function
void printArray(int[] array)
{
    Console.WriteLine(arrayToString(array));
}

string arrayToString(int[] array)
{
    var result = "[";

    for (int i = 0; i < array.Length; i++)
    {
        result += array[i].ToString();

        if (i < array.Length - 1)
        {
            result += ", ";
        }
    }

    result += "]";

    return result;
}

    //root functions
void rootArray(int[] array)
{
    int[] rootedArray = new int[array.Length];
    array.CopyTo(rootedArray, 0);
    for (int i = 0; i < rootedArray.Length; i++) rootedArray[i] = rootNum(rootedArray[i]);
    printArray(rootedArray);
    sumArray(rootedArray);
    printArray(array);

}
int rootNum(int num)
{
    return num *= num;
}

    //sum function
void sumArray(int[] array)
{
    int sum = 0;
    foreach (var item in array)
    {
        sum += item;
    }
    Console.WriteLine("The sum of the array's numbers is: {0}" ,sum);
}

    //find smaller
int comparator(int[] array ,int index, int placeholder)
{
    if(placeholder > array[index])placeholder = array[index];
    index -= 1;
    if(index < 0)
    {
        Console.WriteLine($"Numero minimo é: {placeholder}");
        return placeholder;
    }
    else
    {
        return comparator(array, index, placeholder);
    }
}