using Lustie.QuickRef;
using UnityEngine;

//[RequireComponent(typeof(Animator))]
public class TestRefBehaviour : MonoBehaviour
{
    [GetComponent, SerializeField]
    private Animator self_animator;

    [GetComponentInChildren]
    public Rigidbody children_rigidbody;

    [GetComponentInParent]
    public SphereCollider parent_sphereCollider;

    private void Start()
    {
        Debug.Log("GetComponent" + self_animator);
        Debug.Log("GetComponentInChildren" + children_rigidbody);
        Debug.Log("GetComponentInParent" + parent_sphereCollider);
    }
}