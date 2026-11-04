using TMPro;
using UnityEngine;

public class TextFade : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private float speed = 1.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TextMeshProUGUI tmp = GetComponent<TextMeshProUGUI>();
        Color c = tmp.color;
        tmp.color  = new Color(c.r, c.g, c.b, 
            Mathf.Max(0,c.a - Time.deltaTime * speed));
    }
}
