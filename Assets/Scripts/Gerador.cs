using UnityEngine;
using System.Collections.Generic;

public class Gerador : MonoBehaviour
{
    public List<GameObject> MeusObjetos;
    public float meuTempo;
    public float meuTempo2;
    void Update()
    {
        meuTempo += Time.deltaTime;
        

        if ( meuTempo > 1)
        {
            
            float posX = Random.Range(-7, 7);
            Vector3 novapos = new Vector3(posX, 5.7f, 0);

            int ponteiro = Random.Range(0, MeusObjetos.Count);

            GameObject novoMonstro = Instantiate(MeusObjetos[ponteiro],
            novapos,
            Quaternion.identity);
            Destroy(novoMonstro,3f);

            meuTempo = 0;
        }
        

        

    }
}
