using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Inimigo : MonoBehaviour
{
    public NavMeshAgent agente;
    public GameObject destino;

    void FixedUpdate()
    {
        agente.SetDestination(destino.transform.position);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Item"))
        {
            UI.instancia.Perdeu();
        }
    }
}