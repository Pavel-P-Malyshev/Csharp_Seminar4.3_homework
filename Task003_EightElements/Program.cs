/*

Задача 3: Напишите программу, которая задаёт массив из 8 элементов, выводит их на экран. И ищет второй максимум (элемент меньше максимального, но больше всех остальных)

1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33], 19
*/



//ввод набора чисел с консоли строкой
int[] ParseArray(string message)
{
Console.WriteLine(message);
string[] nums = Console.ReadLine().Split(new char[] { ',' });
int[] intArray = new int[nums.Length];
for (int i = 0; i < nums.Length; i++)
{
    intArray[i] = int.Parse(nums[i]);
}
 return intArray;

}

//распечатка массива
void PrintArray (int[] col)
{

    int count=col.Length;
    int position=0;
    while(position<count) 
    {
        if(position==count-1) {Console.Write($"{col[position]}]");}
        else {Console.Write($"{col[position]}, ");}
        position++;
    }
}

//поиск второго максимального элемента
int Find2ndMax(int[] array)
{
    int max=0;
    int max_index=0;
    int second_max=0;

    for (int i=0; i<array.Length;i++)
    {
        if(array[i]>max)
        {
            max=array[i];
            max_index=i;
        }
    }

    for (int i=0; i<array.Length;i++)
    {
        if((i!=max_index)&&(array[i]>second_max))
        {
            second_max=array[i];
            
        }
    }

     return second_max;


}




int[] input=ParseArray("Введите через запятую 8 элементов массива и нажмите Enter");
Console.Write($"Ваш массив: [");
PrintArray(input);
Console.WriteLine($", второй максимальный элемент массива={Find2ndMax(input)}");



