using UnityEngine;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
[ExecuteInEditMode]
public class CustomGrid : MonoBehaviour
{
	public float gridSize = 1;
    public Texture texture;
    private Material material;
    void Update()
    {
        Generate();
    }
    [ContextMenu("Generate")]
    void Generate(){
        material = GetComponent<MeshRenderer>().sharedMaterials[0];
        material.mainTexture = texture;
        Vector2 gridScale = new Vector2(transform.localScale.x/gridSize/2f, transform.localScale.z/gridSize/2f);
        material.mainTextureScale = gridScale;
    }
}