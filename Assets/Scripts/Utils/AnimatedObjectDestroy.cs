using UnityEngine;

public class AnimatedObjectDestro : MonoBehaviour
{
    [SerializeField] private Animator animator;

    void Start()
    {
        Destroy(gameObject, animator.GetCurrentAnimatorStateInfo(0).length);
    }
}
