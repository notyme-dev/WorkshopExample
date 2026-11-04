using System;
using UnityEngine;

public class Killzone : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private Transform respawn;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        other.gameObject.transform.position = respawn.position;
        Debug.Log("respawn");
    }
}
