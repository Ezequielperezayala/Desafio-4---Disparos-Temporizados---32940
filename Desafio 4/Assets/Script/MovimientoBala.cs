using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoBala : MonoBehaviour
{
    public Vector3 Direccion;
    public float Speed = 0f;
    public int Damage = 0;
    

    void Start()
    {
        Invoke("DestroyBullet", 2f);
        
    }

    
    void Update()
    {
        Movimiento();
        ScaleBullet();
    }

    void Movimiento ()
    {
        transform.position += Direccion * Speed * Time.deltaTime;
    }

    void DestroyBullet()
    {
        Destroy(gameObject);
    }

    void ScaleBullet()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            transform.localScale = transform.localScale * 2;
        }
    }
}
