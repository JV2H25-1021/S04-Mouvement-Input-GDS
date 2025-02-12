using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementTranslateWorld : MonoBehaviour
{
    //[SerializeReference] private float _vitesse = 0;
    //[SerializeReference] private float _directionX = 0;
    //[SerializeReference] private float _directionY = 0;
    //[SerializeReference] private float _directionZ = 0;
    //void Update()
    //{
    //    transform.Translate(_directionX , _directionY, _directionZ, Space.World);

    //    //Vector3 deplacement = new Vector3(1f, 0, 0);
    //    //transform.Translate(deplacement * Time.deltaTime, Space.World);
    //}

    [SerializeField] private Vector3 _deplacement;

    private void Update()
    {
        transform.Translate(_deplacement* Time.deltaTime , Space.World);
    }

}
