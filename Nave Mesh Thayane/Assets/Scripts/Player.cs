using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody controle;
    public float velocidade = 8f;
    bool tempoRolando = true;
    float tempoGasto = 0f;
    public static float tempoAtual;

    private void Start()
    {
        //PlayerPrefs.DeleteAll();
        if (!PlayerPrefs.HasKey("MenorTempo"))
            PlayerPrefs.SetFloat("MenorTempo", 10000);
    }

    void Update()
    {
        if (tempoRolando)
        {
            tempoGasto += Time.deltaTime;
            tempoAtual = tempoGasto;
        }

        Vector3 Posicao = new Vector3(Input.GetAxisRaw("Horizontal") * Time.deltaTime, 0, Input.GetAxisRaw("Vertical") * Time.deltaTime);

        controle.velocity = Posicao * velocidade;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Item"))
        {
            tempoRolando = false;
            if (tempoGasto < PlayerPrefs.GetFloat("MenorTempo"))
                PlayerPrefs.SetFloat("MenorTempo", tempoGasto);
            UI.instancia.Venceu();
        }
    }
}
