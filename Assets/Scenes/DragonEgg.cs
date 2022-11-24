using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonEgg : MonoBehaviour
{
    //создаем переменную, по которой будем смотреть на упавшие слишком низко яйца
    public static float bottomY = -30f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    //метод срабатывает при столкновении объекта с тригером
    private void OnTriggerEnter(Collider other)
    {
        // GetComponent позволяет получить компонент с текущего объекта
        ParticleSystem ps = GetComponent<ParticleSystem>();
        var em = ps.emission;
        em.enabled = true;
        Renderer rend;
        rend = GetComponent<Renderer>();
        rend.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < bottomY)
        {
            Destroy(gameObject);
        }
    }
}
