using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    int number = 0;
    // Операторы присваивания
    // Start is called before the first frame update
    void Start()
    {
        // += -> прибавить значение в нашу переменную
        // -= - вычесть значение из нашей переменной
        // *= - умножить нашу переменную на
        // /= - поделить нашу переменную на
        // %= - взять значение по модулю из нашей переменной
        // выводит сообщение в консоль
        //Debug.Log(number);
        // number = number + 1;
        // инкремент постфиксный
        //Debug.Log(number++);
        // инкремент префиксный
        // Debug.Log(++number);
        // декремент постфиксный
        // number = number - 1;
        //Debug.Log(number--);
        // декремент префиксный
        // Debug.Log(--number);
        int i = 0;
        while (i < 10)
        {
            Debug.Log("Привет, мир!");
            i++;
        }
    }

}
