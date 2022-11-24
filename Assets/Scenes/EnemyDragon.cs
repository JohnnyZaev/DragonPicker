using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDragon : MonoBehaviour
{
    //ссылка на яйцо. Сохранять яйцо, которое мы сделали на прошлом уроке
    public GameObject dragonEggPrefab;
    // Указать скорость для полета дракона
    public float speed = 4f;
    // время между скидыванием яиц
    public float timeBetweenEggDrops = 2f;
    // Дистанция для полета дракона влево и вправо
    public float leftRightDistance = 13f;
    // шанс смены направления
    public float chanceDirections = 0.001f;
    // количество яиц выпускаемых за раз
    public int eggCount = 3;
    public int storeEggCount = 10;

    public float chanceToSpawnEgg = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        if (storeEggCount <= 0)
            eggCount = 1;
        Invoke("DropEgg", 2f);
    }

    void DropEgg()
    {
        //Тема урока - оператор цикла do-while и операторы break и continue
        // насколько ниже должно быть яйцо от позиции дракона
        int i = 0;
        Vector3 myVector = new Vector3(0.5f, 5f, 0f);
        //do
        //{
        //    GameObject egg = Instantiate<GameObject>(dragonEggPrefab);
        //    // сразу же после создания мы меняем его позицию на позицию самого дракона с небольшими изменениями
        //    egg.transform.position = transform.position + myVector;
        //    i++;
        //} while (i < eggCount);

        // Яйцо вызываем (создаем)

        while (i < eggCount)
        {
            i++;
            if (Random.value > chanceToSpawnEgg)
            {
                continue;
            }
            GameObject egg = Instantiate<GameObject>(dragonEggPrefab);
            // сразу же после создания мы меняем его позицию на позицию самого дракона с небольшими изменениями
            egg.transform.position = transform.position + myVector;
        }
        Invoke("DropEgg", timeBetweenEggDrops);
        // Цикл While
        /*
         *       bool
        while (<условие>)
        {
            <тело цикла>
        }
        */
    }

    // Update вызывается раз в кадр
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;
        if (pos.x < -leftRightDistance)
        {
            speed *= -1;
        }
        else if (pos.x > leftRightDistance)
        {
            speed *= -1;
        }
    }

    // Вызывается фиксированное кол-во раз в секунду
    private void FixedUpdate()
    {
        if (Random.value < chanceDirections)
        {
            speed *= -1;
        }
    }
}
