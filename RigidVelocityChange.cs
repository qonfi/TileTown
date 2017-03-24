//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;
//using UnityEngine.Networking; // with NetworkBehaviour
//using UnityEngine.UI;
//

namespace Labo
{
    public class RigidVelocityChange : MonoBehaviour
    {

        #region
        private Rigidbody rBody;
        public float ForwardVelocity;
        public float RightwardVelocity;
        public float UpwardVelocity;
        #endregion


        private void Start()
        {
            rBody = GetComponent<Rigidbody>();
            if (ForwardVelocity == 0 && RightwardVelocity == 0 && UpwardVelocity == 0) { ForwardVelocity = 1; }

            VelocityChange();
        }


        private void FixedUpdate()
        {
            VelocityChange();
        }

        private void VelocityChange()
        {
            rBody.velocity =
               Vector3.forward * ForwardVelocity +
               Vector3.right * RightwardVelocity +
               Vector3.up * UpwardVelocity;
        }
    }
}