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


}
