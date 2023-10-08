using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameButton : MonoBehaviour
{
        private void FixedUpdate()
        {
                transform.Rotate(5, 5,5);
        }

        public void HoverStart()
        {
                transform.localScale = Vector3.one * 1.1f;
        }

        public void HoverEnd()
        {
                transform.localScale = Vector3.one;
        }

        public void ClickStart()
        { 
                MeshRenderer mr = GetComponent<MeshRenderer>();
                mr.material.color = Color.gray;
                mr.material.SetColor("_EmissionColor",Color.gray);
        }

        public void ClickEnd()
        {
                MeshRenderer mr = GetComponent<MeshRenderer>();
                mr.material.color = Color.white;
                mr.material.SetColor("_EmissionColor", Color.white);
        }

        public void click()
        {
                SceneManager.LoadScene("GameScene");
        }
}