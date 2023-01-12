using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    [SerializeField] private LayerMask _ground;
    public bool isGrounded;

    private void OnTriggerStay(Collider collider)
    {
        isGrounded = collider != null && (((1 << collider.gameObject.layer) & _ground) != 0);
    }

    private void OnTriggerExit(Collider other)
    {
        isGrounded = false;
    }
}
