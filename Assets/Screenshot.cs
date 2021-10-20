using System;
using UnityEngine;
 
 public class Screenshot : MonoBehaviour
 {
     private void Update()
     {
         if (Input.GetKeyDown(KeyCode.K))
         {
             ScreenCapture.CaptureScreenshot(Application.dataPath + "/screenshots/" + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".png");
             UnityEditor.AssetDatabase.Refresh();
         }
     }
}