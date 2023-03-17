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
    Console.Write("The sum of the original numbers is: {0}" ,sum);
}
