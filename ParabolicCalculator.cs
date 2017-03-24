//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;
//using UnityEngine.Networking; // with NetworkBehaviour
//using UnityEngine.UI;
//

namespace Labo
{
    // つねに等しい放物線(正弦波?)ではなく、波ごとに誤差があるので注意。floatでの計算をintで行ったら変わるのかそれとも論理バグなのか
    public class ParabolicCalculator
    {
        #region
        private float passedTime = 0f;
        public float Amplitude { get; set; } // 振幅
        public float SpeedScale { get; set; }

        // Amplitude の値1fにつき 大体1fぐらいの移動量となるために最終的な値を調整する。誤差はある。
        private float adjuster = 0.00829f;
        #endregion


        // Constructor
        public ParabolicCalculator(float speedScale = 1f, float amplitude = 1f)
        {
            SpeedScale = speedScale;
            Amplitude = amplitude;
            SpeedScale *= 3f; // 
        }


        public float UpdateMovement()
        {
            passedTime += Time.deltaTime;


            #region メモ
            // ラジアン = 円(扇形)の弧の長さ / 円の半径
            // 度数法での180°  =  弧度法でのπ[rad]
            //
            // 角度θの直角三角形
            // 半径 * sinθ が単振動の動き？
            // 書き足しすぎてわけがわからなくなってきてしまった。
            // 元の式はMathf.Sin(passedTime ) * Amplitude;
            #endregion
            return Mathf.Sin(passedTime * SpeedScale) * Amplitude * adjuster * SpeedScale;
        }
    }
}