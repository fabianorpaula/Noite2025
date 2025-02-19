using UnityEngine;
using System.Collections.Generic;

public class Gerador : MonoBehaviour
{
    public List<GameObject> MeusObjetos;
    public float meuTempo;
    void Update()
    {
        meuTempo += Time.deltaTime;

        if( meuTempo > 1)
        {
            float posX = Random.Range(-7, 7);
            Vector3 novapos = new Vector3(posX, 5.7f, 0);

            int ponteiro = Random.Range(0, MeusObjetos.Count);

            Instantiate(MeusObjetos[ponteiro],
            novapos,
            Quaternion.identity);
            meuTempo = 0;
        }
        


    }
}
