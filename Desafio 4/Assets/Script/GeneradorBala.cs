using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorBala : MonoBehaviour
{
    public GameObject Bullet;
    public float StartDelayBullet = 2f;
    public float TimeRepeatBullet = 1f;
    void Start()
    {
        InvokeRepeating("Disparo", StartDelayBullet, TimeRepeatBullet);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Disparo()
    {
        Instantiate(Bullet, transform);
    }
}
