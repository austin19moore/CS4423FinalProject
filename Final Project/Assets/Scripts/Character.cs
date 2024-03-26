using UnityEngine;

public class Character : MonoBehaviour
{

    Rigidbody2D rb;
    [SerializeField] LayerMask terrain;
    bool ifLighter = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.drag = 0f;
        rb.angularDrag = .2f;
        rb.gravityScale = 2;
        rb.isKinematic = false;
    }

    public void Jump() {
        if (Physics2D.OverlapCircleAll(transform.position + new Vector3(0, -1f, 0), .38f, terrain).Length > 0) {
            GetComponent<AudioSource>().Play();
            rb.AddForce(Vector3.up * 8f, ForceMode2D.Impulse);
        }
    }

    public void Move(Vector3 v) {

        if (v.x > 0) {
            GetComponent<SpriteRenderer>().flipX = true;
        } else if (v.x < 0) {
            GetComponent<SpriteRenderer>().flipX = false;
        }

        if (rb.velocity.magnitude < 4f) {
            rb.AddForce(v * .08f, ForceMode2D.Impulse);
        }
        
    }

    public void SetLighter(bool iftrue) {
        ifLighter = iftrue;
    }

    public bool HasLighter() {
        return ifLighter;
    }
}
