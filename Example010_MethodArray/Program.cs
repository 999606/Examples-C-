int[] array = { 81 , 72 , 63 , 4 , 54 , 36 , 27 , 81 };

int n = array.Length;
int find = 81;

int index = 0;

while (index < n )
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //index = index +1;
    index++;
}