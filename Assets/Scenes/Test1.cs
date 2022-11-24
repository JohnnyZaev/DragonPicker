using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour
{
    // Пользователь в инспекторе получает целое число. Необходимо вывести в консоль цифры этого числа начиная с конца
    public int number;

    // Start is called before the first frame update
    // for (<действия перед циклом>; <условие цикла>; <действие после итерации>)
    void Start()
    {
	    int sum = 0;
	    for (int i = 1; i <= number; i++)
		    sum += i;
	    Debug.Log(sum);
    }
}
