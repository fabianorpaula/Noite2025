using UnityEngine;

public class Gerador : MonoBehaviour
{
    public GameObject MeuObjeto;
    public float meuTempo;
    void Update()
    {
        meuTempo += Time.deltaTime;

        if( meuTempo > 1)
        {
            float posX = Random.Range(-3, 3);
            Vector3 novapos = new Vector3(posX, 5.7f, 0);

            Instantiate(MeuObjeto,
            novapos,
            Quaternion.identity);
            meuTempo = 0;
        }
        


    }
}
