using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class countManager : MonoBehaviour
{

    [SerializeField] projectileCounter count1;
    [SerializeField] projectileCounter count2;
    [SerializeField] projectileCounter count3;
    [SerializeField] GameObject destroy1;
    [SerializeField] GameObject destroy2;
    private int count = 0;
    private bool success = false;

    // Update is called once per frame
    void Update()
    {
        bool check = Check();

        if (!this.success && check) {
            GameObject.Find("successSoundHandler").GetComponent<AudioSource>().Play();
            Destroy(destroy1);
            Destroy(destroy2);
            success = true;
        }
    }

    bool Check() {

        if (count % 60 != 0) {
            return false;
        }
        if (count >= 32000) {
            count = 0;
        }


        bool ifTrue = true;
        
        if (count1.GetCount() != 6) {
            ifTrue = false;
        }
        if (count2.GetCount() != 1) {
            ifTrue = false;
        }
        if (count3.GetCount() != 3) {
            ifTrue = false;
        }

        return ifTrue;
    }

}
