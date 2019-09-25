using System;

public class FizzBuzzFilter
{
    public static int[] fizzBuzzFunc(int[] t_array)
    {
        for (int i = 0; i < t_array.Length; i++)
        {
            if (t_array[i] % 3 == 0 && t_array[i] % 5 == 0)
            {
                t_array[i] = 0;
            }
            else if (t_array[i] % 3 == 0)
            {
                t_array[i] = 3;
            }
            else if (t_array[i] % 5 == 0)
            {
                t_array[i] = 5;
            }
        }

        return t_array;
    }
}
