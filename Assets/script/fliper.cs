using UnityEngine;

public class fliper : MonoBehaviour
{
    public Animator animL;
    public Animator animR;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            animL.SetTrigger("flip");
            animR.SetTrigger("flip");
        }
    }
    
}
