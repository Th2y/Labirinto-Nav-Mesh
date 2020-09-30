using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public Rigidbody controle;
    public float velocidade = 2f;
    bool estaAndandoDireita;
    bool andar = false;
    
    void Update()
    {
        if (!andar)
        {
            Invoke("Esperar", 5f);
            andar = true;
        }
    }

    void Esperar()
    {
        if (estaAndandoDireita)
        {
            AndarDireita();
        }
        else
        {
            AndarEsquerda();
        }
        andar = false;
    }

    void AndarDireita()
    {
        transform.position = new Vector3(-27, transform.position.y, transform.position.z);
        estaAndandoDireita = false;
    }

    void AndarEsquerda()
    {
        transform.position = new Vector3(-17, transform.position.y, transform.position.z);
        estaAndandoDireita = true;
    }
}
