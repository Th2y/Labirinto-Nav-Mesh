using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public GameObject venceuPainel;
    public GameObject perdeuPainel;
    public static UI instancia;
    public GameObject[] desativarAOGanhar;
    public TextMeshProUGUI menorTempo;
    public TextMeshProUGUI tempoAtual;
    public GameObject painelInstrucao;

    void Start()
    {
        painelInstrucao.SetActive(true);
        desativarAOGanhar[0].SetActive(false);
        desativarAOGanhar[1].SetActive(false);

        instancia = this;
        venceuPainel.SetActive(false);
        perdeuPainel.SetActive(false);
    }

    public void Venceu()
    {
        venceuPainel.SetActive(true);
        desativarAOGanhar[0].SetActive(false);
        desativarAOGanhar[1].SetActive(false);
        menorTempo.text = PlayerPrefs.GetFloat("MenorTempo").ToString();
        tempoAtual.text = Player.tempoAtual.ToString();
    }

    public void Perdeu()
    {
        perdeuPainel.SetActive(true);
        desativarAOGanhar[0].SetActive(false);
        desativarAOGanhar[1].SetActive(false);
    }

    public void Iniciar()
    {
        painelInstrucao.SetActive(false);
        desativarAOGanhar[0].SetActive(true);
        desativarAOGanhar[1].SetActive(true);
    }

    public void Reiniciar()
    {
        SceneManager.LoadScene("Jogo");
    }
}
