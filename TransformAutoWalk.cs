//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;
//using UnityEngine.Networking; // with NetworkBehaviour
//using UnityEngine.UI;
//

namespace Labo
{
    public class TransformAutoWalk : MonoBehaviour
    {
        #region
        public float ForwardMovement;
        public float RightwardMovement;
        public float UpwardMovement;

        public bool MovementPerSecond;
        #endregion


        private void Start()
        {
            if (ForwardMovement == 0 && RightwardMovement == 0 && UpwardMovement == 0) { ForwardMovement = 1; }
        }


        private void Update()
        {
            Translate();
        }

        private void Translate()
        {
            Vector3 movement =
                this.transform.forward * ForwardMovement +
                this.transform.right * RightwardMovement +
                this.transform.up * UpwardMovement;

            if (MovementPerSecond) { movement *= Time.deltaTime; }

            this.transform.Translate(movement);
        }
    }
}