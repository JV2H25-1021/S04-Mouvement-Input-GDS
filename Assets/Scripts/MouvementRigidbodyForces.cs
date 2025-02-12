using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementRigidbodyForces : MonoBehaviour
{
    public Vector3 forceInitiale = Vector3.zero;
    private Rigidbody _rb;
    //private AudioSource _as;

    void Start()
    {
        // Prends une réference au Rigidbody attaché a cet objet.
        _rb = GetComponent<Rigidbody>();
       // _as = GetComponent<AudioSource>();

        _rb.AddForce(forceInitiale);
    }

}
