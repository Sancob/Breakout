using System.Collections;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class Bola : MonoBehaviour
{
    public float speed = 5f;
    public float ogSpeed;
    public float speedMultiplier = 1.5f;
    public float duration = 10f;

    public int damage = 1;
    public int ogDamage = 1;
    private Coroutine efectoCoroutine;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ogSpeed = speed;
        ogDamage = damage;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivarBoostVel()
    {
        if (efectoCoroutine != null)
        {
            StopCoroutine(efectoCoroutine);
        }

        efectoCoroutine = StartCoroutine(BoostTemporal(speedMultiplier, duration));
    }

    virtual public IEnumerator BoostTemporal(float speedMultiplier, float duration)
    {
        speed = ogSpeed * speedMultiplier;
        damage = ogDamage = +1;

        yield return new WaitForSeconds(duration);

        speed = ogSpeed;
        damage = ogDamage;
        efectoCoroutine = null;
    }
}
