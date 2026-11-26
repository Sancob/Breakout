using UnityEngine;

public class Bloque : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [HideInInspector] public GameObject bola;
    public int resistencia = 1;
    private float velocidadBola;
    private int ballDamage;

    protected virtual void Start()
    {
        bola = GameObject.FindGameObjectWithTag("Ball");
        velocidadBola = bola.GetComponent<Bola>().speed;
        ballDamage = bola.GetComponent<Bola>().damage;
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        
    }

    public virtual void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Debug.Log("Colisión con la bola");
            rebotarBola();
            resistencia -= ballDamage;

            if (resistencia <= 0)
            {
                Destroy(this.gameObject);
            }
            
        }
    }

    public virtual void rebotarBola()
    {

    }
}
