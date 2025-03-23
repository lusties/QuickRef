using Lustie.QuickRef;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class TestRefBehaviour : MonoBehaviour
{
    [GetComponent, SerializeField]
    private Animator selfAnimator;

    [GetComponentInChildren]
    public Rigidbody childrenRigidbody;

    [GetComponentInParent]
    public SphereCollider parentSphereCollider;

    [SerializeField, FindObjectOfType, NoDisplay]
    private Camera nonDisplayCamera;

    [SerializeField, FindObjectOfType]
    private Camera shownCamera;

    [Disabled]
    public int disabledNumber;

    private void Start()
    {
        Debug.Log("GetComponent " + selfAnimator);
        Debug.Log("GetComponentInChildren " + childrenRigidbody);
        Debug.Log("GetComponentInParent " + parentSphereCollider);
        Debug.Log("FindObjectOfType (No display)" + nonDisplayCamera);
        Debug.Log("FindObjectOfType " + shownCamera);
    }
}