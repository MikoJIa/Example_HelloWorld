int[] array = { 12, 23, 34, 45, 66, 34, 67, 78, 89 };
int n = array.Length;
int find = 34;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;

}
