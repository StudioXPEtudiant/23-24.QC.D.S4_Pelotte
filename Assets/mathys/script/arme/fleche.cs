using UnityEngine;

public class fleche : MonoBehaviour
{ 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("mur"))
        {
            Destroy(transform.parent.parent.gameObject);
        }
        if (collision.CompareTag("Player"))
        {
            Destroy(transform.parent.parent.gameObject);
        }
    }  
}
