/* Написать программу, которая из имеющегося массива строк, 
формирует массив из строк, длина которых меньше или равна 3 символам.
*/

/* Используем static, так как этот метод будет принадлежать не каждому объекту класса, 
а всем им вместе, чтобы работать над двумя массивами одновременно
*/
static string[] sortStrings(string[] array)  
{                                                 
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    { 
        if (array[i].Length <= 3)  
        { 
            count++;   
        }
    }
    string[] newArray = new string[count];  
    int j = 0; 
    for (int i = 0; i < array.Length; i++) 
    {  
        if (array[i].Length <= 3)  
        {                            
            newArray[j] = array[i];     
            j++;                                      
        }    
    }
    return newArray;
}

void printArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
        {
          Console.Write(array[i]);
          //нужно, чтобы вывести массив красивее с запятыми и окончанием массива
          if (i < array.Length - 1)
            {
                Console.Write(", ");
            }
        }
    Console.WriteLine(" ]");
}

Console.WriteLine("Введите символы или слова через пробел: ");
// Чтобы преобразовать строки в массив нужно было добавить Split,так как он разбивает строки на подстроки
string[] array = Console.ReadLine().Split();
Console.WriteLine();
printArray(array);
// Чтобы был пробел между старым и новым массивом
Console.WriteLine();
string[] newArray = sortStrings(array);
printArray(newArray);
