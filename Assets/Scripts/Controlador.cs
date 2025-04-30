using UnityEngine;

public class Controlador : MonoBehaviour
{
    private bool EstadoJogo = false;

    void Start()
    {
        Time.timeScale = 0;
    }

    
    void Update()
    {
        
    }

    public void IniciarJogo()
    {
        Time.timeScale = 0.5f;
        EstadoJogo=true;
        
    }


    public bool InformarJogo()
    {
        return EstadoJogo;
    }
}
