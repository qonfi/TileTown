//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;
//using UnityEngine.Networking; // with NetworkBehaviour
//using UnityEngine.UI;
//

namespace Labo {
    public class ParabolaElevator : MonoBehaviour {

        private ParabolicCalculator calculator;
        [Range(0, 100)] public float Amplitude;
        [Range(0, 10)] public float SpeedScale;
        [Range(0, 10)] public float ForwardScale;
        [Range(0, 10)] public float RightwardScale;
        [Range(0, 10)] public float UpwardScale;

        private void Start()
        {
            calculator = new ParabolicCalculator();

            // テスト用
            if (Amplitude == 0) { Amplitude = 10; }
            if (SpeedScale == 0) { SpeedScale = 1; }
            if (ForwardScale == 0 && RightwardScale == 0 && UpwardScale == 0) { ForwardScale = 1; }
        }


        private void Update()
        {
            Vector3 directionScale = Vector3.zero;
            directionScale =
                (ForwardScale * Vector3.forward) +
                (RightwardScale * Vector3.right) +
                (UpwardScale * Vector3.up);

            calculator.Amplitude = Amplitude;
            calculator.SpeedScale = SpeedScale;

            transform.Translate( directionScale * calculator.UpdateMovement());
        }
    }
}