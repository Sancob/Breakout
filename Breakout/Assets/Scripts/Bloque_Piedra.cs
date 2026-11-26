using UnityEngine;

public class Bloque_Piedra : Bloque
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    protected override void Start()
    {
        base.Start();
        resistencia = 5;
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
    }
}
