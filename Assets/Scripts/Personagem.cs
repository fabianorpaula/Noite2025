using UnityEngine;

public class Personagem : MonoBehaviour
{
    public int vida = 10;


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
        Mover();
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
