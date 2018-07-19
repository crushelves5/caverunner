using UnityEngine;
using System.Collections;

public class ActivateGravity : MonoBehaviour {
    public GameObject player;
    public float gravityscale;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject == player)
        {
            gravityscale = 10;
            GetComponent<Rigidbody2D>().gravityScale = gravityscale;
        }
    }
}
