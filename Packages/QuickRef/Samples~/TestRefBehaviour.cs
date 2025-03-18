using Lustie.QuickRef;
using UnityEngine;

//[RequireComponent(typeof(Animator))]
public class TestRefBehaviour : MonoBehaviour
{
    [GetComponent, SerializeField]
    private Animator slef_animator;

    [GetComponentInChildren]
    public Rigidbody children_rigidbody;

    [GetComponentInParent]
    public SphereCollider parent_sphereCollider;
}