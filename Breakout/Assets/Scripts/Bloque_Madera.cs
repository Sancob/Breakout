using UnityEngine;

public class Bloque_Madera : Bloque
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    protected override void Start()
    {
        resistencia = 3;
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
    }

    public override void rebotarBola()
    {
        base.rebotarBola();
    }
}
