
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
 private void OnTriggerEnter2D(Collider2D other)
 {
    if(other.gameObject.layer == LayerMask.NameToLayer("Invader"))
    {
        this.gameObject.SetActive(false);
    }
 }
}
