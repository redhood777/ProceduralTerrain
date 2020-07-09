﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapDisplay : MonoBehaviour
{
    public Renderer textureRenderer;
    public MeshFilter meshFiler;
    public MeshRenderer meshRenderer;

    public void DrawTexture(Texture2D texture)
    {    
        textureRenderer.sharedMaterial.mainTexture = texture;
        textureRenderer.transform.localScale = new Vector3(texture.width, 1,texture.height);
    }

    public void DrawMesh(MeshData meshData, Texture2D texture)
    {
        meshFiler.sharedMesh = meshData.CreateMesh();
        meshRenderer.sharedMaterial.mainTexture = texture;
    }
    
}
