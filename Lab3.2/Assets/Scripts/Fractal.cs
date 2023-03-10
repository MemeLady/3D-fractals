using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fractal : MonoBehaviour
{
    public int MaxDepth;
    public Mesh mesh;
    public Material material;
    public float childScale;
    public Mesh[] meshes;
    public float maxRotationSpeed;

    private float rotationSpeed;
    private int currentDepth;
    private static Vector3[] childDirections = { Vector3.up, Vector3.right, Vector3.left, Vector3.forward, Vector3.back };
    private static Quaternion[] childOrientations = { Quaternion.identity, Quaternion.Euler(0f, 0f, -90f), Quaternion.Euler(0f, 0f, 90f), Quaternion.Euler(90f, 0f, 0f), Quaternion.Euler(-90f, 0f, 0f) };
    private Material[,] materials;

    private void InitMaterial()
    {
        materials = new Material[MaxDepth + 1, 2];
        for (int i = 0; i <= MaxDepth; i++)
        {
            float t = i / (MaxDepth - 1f);
            t *= t;
            materials[i, 0] = new Material(material);
            materials[i, 0].color = Color.Lerp(Color.white, Color.yellow, t);
            materials[i, 1] = new Material(material);
            materials[i, 1].color = Color.Lerp(Color.white, Color.cyan, t);
        }
        materials[MaxDepth, 0].color = Color.magenta;
        materials[MaxDepth, 1].color = Color.red;
    }

    void Start()
    {
        rotationSpeed = Random.Range(-maxRotationSpeed, maxRotationSpeed);

        if (materials == null)
        {
            InitMaterial();
        }

        gameObject.AddComponent<MeshFilter>().mesh = meshes[Random.Range(0, meshes.Length)];
        gameObject.AddComponent<MeshRenderer>().material = materials[currentDepth, Random.Range(0, 2)];


        if (currentDepth < MaxDepth) 
        {
            StartCoroutine(CreateChildren());
        }
    }

    private IEnumerator CreateChildren()
    {
        for (int i = 0; i < childDirections.Length; i++)
        {
            yield return new WaitForSeconds(Random.Range(0.1f, 0.5f));
            new GameObject("Fractal Child").AddComponent<Fractal>().Init(this, i);
        }
    }

    void Update()
    {
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
    }

    public void Init(Fractal parent, int childIndex)
    {
        maxRotationSpeed = parent.maxRotationSpeed;
        mesh = parent.mesh;
        meshes = parent.meshes;
        material = parent.material;
        materials = parent.materials;
        MaxDepth = parent.MaxDepth;
        currentDepth = parent.currentDepth + 1;
        childScale = parent.childScale;
        transform.parent = parent.transform;
        transform.localScale = Vector3.one * childScale;
        transform.localPosition = childDirections[childIndex] * (0.5f + 0.5f * childScale);
        transform.localRotation = childOrientations[childIndex];
    }
}
