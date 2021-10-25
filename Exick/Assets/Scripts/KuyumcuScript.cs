using UnityEngine;

public class KuyumcuScript : MonoBehaviour
{
    private void Start() 
    {
        Destroy(gameObject, 5);
    }

    private void Update() 
    {
        transform.position += Vector3.right * 2f * Time.deltaTime;
    }
}
