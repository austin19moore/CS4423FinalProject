using UnityEngine;

public class ButtonHandler : MonoBehaviour
{

     Rigidbody2D rb;
     GameObject[] destroyableObjects;
     GameObject interactText;
    [SerializeField] LayerMask Player;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        destroyableObjects = GameObject.FindGameObjectsWithTag("destroyable");
        interactText = GameObject.Find("Canvas");
        interactText.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (Physics2D.OverlapCircleAll(transform.position, 1f, Player).Length > 0) {
            print("here");
            // display message to user
            interactText.SetActive(true);

            if (Input.GetKey(KeyCode.F)) {
                GetComponent<AudioSource>().Play();
                Destroy();
                interactText.SetActive(false);
            }
        } else {
            interactText.SetActive(false);
        }
    }

    void Destroy() {
        for (int i = 0; i < destroyableObjects.Length; i++) {
            // destroyableObjects[i].PlaySound();
            Destroy(destroyableObjects[i]);
        }
    }
}
