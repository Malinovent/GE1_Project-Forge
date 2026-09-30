using UnityEngine;

public class Attacker : MonoBehaviour
{

    [SerializeField] private int degats;

    private void OnTriggerEnter2D(Collider2D otherCollider)
    {

        Vie vie = otherCollider.GetComponent<Vie>();
        if(vie != null)
        {
            vie.PrendsDegats(degats);
        }


        Dipose();
    }

    private void Dipose()
    {
        Destroy(this.gameObject);
    }





    private void OnTriggerStay2D(Collider2D collision)
    {
        //Debug.Log(otherCollider.gameObject.name);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //Debug.Log(collision.gameObject.name);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log(collision.gameObject.name);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        //Debug.Log(collision.gameObject.name);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        ///Debug.Log(collision.gameObject.name);
    }
}
