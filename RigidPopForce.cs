//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;
//using UnityEngine.Networking; // with NetworkBehaviour
//using UnityEngine.UI;
//

namespace Labo
{
    public class RigidPopForce : MonoBehaviour
    {
        private Rigidbody rBody;
        [SerializeField]        private float ForwardForce;
        [SerializeField]        private float RightwardForce;
        [SerializeField]        private float UpwardForce;

        

        private void Start()
        {
            rBody = GetComponent<Rigidbody>();

            if (ForwardForce == 0 && RightwardForce == 0 && UpwardForce == 0) { UpwardForce = 1; }

            rBody.AddForce(
                this.transform.forward * ForwardForce +
                this.transform.right * RightwardForce +
                this.transform.up * UpwardForce,
                ForceMode.Impulse
                );
        }

    }
}