using Unity.XR.OpenVR;
using UnityEngine;

public class Bloque_Goma : Bloque
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected override void Start()
    {
        base.Start();
        resistencia = 1;
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
    }

    public override void rebotarBola()
    {
        Efecto();
        base.rebotarBola();
    }

    void Efecto()
    {
        Bola scriptBola = bola.GetComponent<Bola>();
        {
            if (scriptBola != null)
            {
                scriptBola.ActivarBoostVel();
            }
        }
    }
}
