using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHandler : MonoBehaviour
{

    [SerializeField] Animator animator;
    [SerializeField] string currentState = "Idle";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeAnimation(string newState) {
        if (currentState.Equals(newState)) {
            return;
        }
        currentState = newState;
        animator.Play(currentState);
    }
}
