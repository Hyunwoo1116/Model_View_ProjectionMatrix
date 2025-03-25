using System.Runtime.CompilerServices;
using UnityEngine;

public class MVPMatrix : MonoBehaviour
{
    public Material customMaterial;  // ƒøΩ∫≈“ ºŒ¿Ã¥ı(Material)
    public Transform Cube;


    // Start is called once before the first execution of Update after the MonoBehaviour is created


    void Update()
    {
        PrintMatrix();
    }
    private void PrintMatrix()
    {
        Matrix4x4 modelMatrix = Cube.localToWorldMatrix;
        Matrix4x4 viewMatrix = Camera.main.worldToCameraMatrix;
        Matrix4x4 projMatrix = Camera.main.projectionMatrix;

        Debug.Log($"ModelMatrix\n{modelMatrix}");
        Debug.Log($"ViewMatrix\n{viewMatrix}");
        Debug.Log($"ProjectionMatrix\n{projMatrix}");
    }
}
