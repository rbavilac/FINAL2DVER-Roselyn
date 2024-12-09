using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.name == "Egg")
            {
                SceneManager.LoadScene("Win");
            }
        }
}
