using UnityEngine;

public class Player1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector3 pos = transform.position;
        pos.x += horizontalInput * 0.01f;
        transform.position = pos;
    }
}
