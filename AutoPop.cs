using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;
//using UnityEngine.Networking; // with NetworkBehaviour
//using UnityEngine.UI;
//

namespace Labo
{
    public class AutoPop : MonoBehaviour
    {
        #region
        [SerializeField]
        private GameObject ObjectToPop;
        [SerializeField]
        private Vector3 PopPlaceOffset;
        [SerializeField, Range(0, 60)]
        private float PopIntervalSecond;
        [SerializeField, Range(0, 100)]
        private int Repeat;
        #endregion


        private void Start()
        {
            if (PopIntervalSecond < 0.1) { PopIntervalSecond = 3f; }
            if (Repeat == 0) { Repeat = 1; }
            StartCoroutine(Coroutine());
        }




        private IEnumerator Coroutine()
        {
            for (int i = 0; i < Repeat; i++)
            {
                // n 秒待つ
                yield return new WaitForSeconds(PopIntervalSecond);
                Pop();
            }
        }



        private void Pop()
        {
            Instantiate(ObjectToPop, this.transform.position + PopPlaceOffset, Quaternion.identity);
        }
    }
}