using JetBrains.Annotations;
using Unity.ProjectAuditor.Editor.Core;
using UnityEngine;

public class Bloque_Mystery : Bloque

{
    public GameObject[] bloques;
    public GameObject[] variantesPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected override void Start()
    {
        base.Start();
        resistencia = 1;
        bloques = GameObject.FindGameObjectsWithTag("Block");
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

    public void Efecto()
    {
        foreach (GameObject bloque in bloques)
        {
            if(bloque != null && bloque != this.gameObject)
            {
                int indiceRandom = Random.Range(0, variantesPrefab.Length);
                GameObject prefabElegido = variantesPrefab[indiceRandom];

                Instantiate(prefabElegido, bloque.transform.position, bloque.transform.rotation, bloque.transform.parent);
                Destroy(bloque);

            }
        }
    }
}
