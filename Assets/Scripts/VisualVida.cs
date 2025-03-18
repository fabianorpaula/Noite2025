using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class VisualVida : MonoBehaviour
{
    public TMP_Text meuTexto;
 
    void Update()
    {
        float vida = GameObject.
            FindGameObjectWithTag("Player").
            GetComponent<Personagem>().vida;

        meuTexto.text = "VIDA: "+vida.ToString(); 
    }
}
