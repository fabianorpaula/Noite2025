using UnityEngine;
using UnityEngine.UIElements;

public class Personagem : MonoBehaviour
{
    public int vida = 10;
    private Controlador CJ;
    public GameObject MeuTiro;

    public void Start()
    {
        CJ = GameObject.
            FindGameObjectWithTag("GameController"). 
            GetComponent<Controlador>();
    }

    private void OnCollisionEnter2D(Collision2D colisao)
    {
        if(colisao.gameObject.tag == "Inimigo")
        {
            vida--;
            Destroy(colisao.gameObject);

            if(vida <= 0)
            {
                Destroy(this.gameObject);
            }
        }
    }


    private void Update()
    {
        if (CJ.InformarJogo() == true)
        {
            Mover();
            Atirar();
        }
        
    }

    void Atirar()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject Tiro1 = Instantiate(MeuTiro,
                transform.position,
                Quaternion.identity);
            Destroy(Tiro1, 3f);
        }
    }

    void Mover()
    {
        Vector3 destino = Input.mousePosition;
        Vector3 posTela = Camera.main.ScreenToWorldPoint(destino);
        Vector3 posCorrecao = new Vector3(posTela.x, -4.05f, 0);
        transform.position = Vector3.MoveTowards(
            transform.position,
            posCorrecao,
            0.05f);
    }


}
