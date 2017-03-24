//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;
//using UnityEngine.Networking; // with NetworkBehaviour
//using UnityEngine.UI;
//

namespace Labo
{
    public class RigidSpin : MonoBehaviour
    {
        #region
        private Rigidbody rBody;

        // 回転方向の一般的な呼び方がわからなかったので、航空機で使う呼称にしてみた。
        private Vector3 pitch;
        private Vector3 yaw;
        private Vector3 roll;

        [SerializeField]
        private float pitchForce;
        [SerializeField]
        private float yawForce;
        [SerializeField]
        private float rollForce;
        #endregion


        private void Start()
        {
            rBody = GetComponent<Rigidbody>();
            //rBody.angularDrag = 0f;     // トルクにより回転する際に、オブジェクトに影響する空気抵抗の大きさ。0 の場合、空気抵抗なし。
            rBody.mass = 0.1f;

            // 見た目がややこしくなるのでVector.forward などはわざと使ってない。
            pitch = new Vector3(1, 0, 0);
            yaw = new Vector3(0, 1, 0);
            roll = new Vector3(0, 0, 1);
        }



        private void FixedUpdate()
        {
            rBody.AddTorque((pitch * pitchForce) + (yaw * yawForce) + (roll * rollForce));
        }
    }
}