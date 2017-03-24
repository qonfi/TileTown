//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;
//using UnityEngine.Networking; // with NetworkBehaviour
//using UnityEngine.UI;
//

namespace Labo
{
    public class SelfDestroy : MonoBehaviour
    {
        #region
        [SerializeField]
        private float LifeTime;
        private float passedTime;
        #endregion

        private void Update()
        {
            passedTime += Time.deltaTime;

            if (LifeTime < passedTime)  {  Destroy(this.gameObject); }
        }
    }
}