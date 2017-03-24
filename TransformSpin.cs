//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;
//using UnityEngine.Networking; // with NetworkBehaviour
//using UnityEngine.UI;
//

namespace Labo
{
    public class TransformSpin : MonoBehaviour
    {
        #region
        [SerializeField]
        private float pitchForce;
        [SerializeField]
        private float yawForce;
        [SerializeField]
        private float rollForce;

        private Vector3 pitch;
        private Vector3 yaw;
        private Vector3 roll;
        #endregion

        private void Start()
        {
            pitch = new Vector3(1f, 0, 0);
            yaw = new Vector3(0, 1f, 0);
            roll = new Vector3(0, 0, 1f);
        }

        private void Update()
        {
            this.transform.Rotate(
                pitch * pitchForce +
                yaw * yawForce +
                roll * rollForce
                );
        }
    }
}