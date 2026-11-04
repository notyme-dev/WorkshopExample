using UnityEngine;

public class rotator : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles = new Vector3(0,0,transform.eulerAngles.z + Time.deltaTime * speed);
    }
}
