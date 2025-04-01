using UnityEngine;
using UnityEngine.UI;


public class VisualCoracao : MonoBehaviour
{
    public Image FundoImagem;

    void Update()
    {
        float vida = GameObject.
            FindGameObjectWithTag("Player").
            GetComponent<Personagem>().vida;

        int minhaVida = GameObject.
            FindGameObjectWithTag("Player").
            GetComponent<Personagem>().vida * 135;

        FundoImagem.rectTransform.sizeDelta = 
            new Vector2(minhaVida, 100);

    }
}
