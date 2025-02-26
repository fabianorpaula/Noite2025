using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class Fundo : MonoBehaviour
{

    public float meuTempo;

    void Update()
    {
        meuTempo += Time.deltaTime;
        if (meuTempo > 0.1f)
        {
            transform.position = transform.position +
                new Vector3(0, -0.01f, 0);
            meuTempo = 0;
        }
        if (transform.position.y < -15)
        {
            transform.position = new Vector3(0, 19, 0);
        }
    }
}
