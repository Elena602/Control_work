// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
string[] countries = new string[7] {"Russia", "Japan", "Portugal", "USA", "Italy", "Armenia", "GB"};
string[] array1 = new string[countries.Length];
void SecondArray(string[] countries, string[] array1)
{
    int count = 0;
    for (int i = 0; i < countries.Length; i++)
    {
    if(countries[i].Length <= 3)
        {
        array1[count] = countries[i];
        count++;
        }
    }
}