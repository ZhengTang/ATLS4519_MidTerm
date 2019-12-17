using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[ExecuteInEditMode]

public class ClassPostEffect : MonoBehaviour
{
    public Material postEffectMaterial;

    private void OnRenderImage(RenderTexture src, RenderTexture dest)
    {
        Graphics.Blit(src, dest, postEffectMaterial);
    }

}
