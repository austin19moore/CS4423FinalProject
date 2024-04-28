using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{

    [SerializeField] List<Transform> checkpoints;
    [SerializeField] float pauseTime = 2f;
    [SerializeField] float moveTime = 4f;
    [SerializeField] int index = 0;
    // Start is called before the first frame update
    void Start()
    {
        Move();
    }

    void Move() {
        StartCoroutine(MoveRoutine());

        IEnumerator MoveRoutine() {
            while (true) {
                yield return new WaitForSeconds(pauseTime);

                float timer = 0;
                int nextIndex = (index + 1) % checkpoints.Count;
                while (timer < moveTime) {
                    yield return null;
                    timer += Time.deltaTime;
                    transform.localPosition = Vector3.Lerp(checkpoints[index].position, checkpoints[nextIndex].position, timer / moveTime);
                }
                transform.localPosition = checkpoints[nextIndex].position;
                index = (index + 1) % checkpoints.Count;
            }
        }
    }
}
