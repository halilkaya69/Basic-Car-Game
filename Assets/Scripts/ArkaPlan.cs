using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArkaPlan : MonoBehaviour
{
    MeshRenderer meshRenderer;
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = 0.5f*Time.time;//yöne göre -yaparsak tersine akar
        meshRenderer.material.SetTextureOffset("_MainTex", new Vector2(x, 0));//yöne göre

    }
}
