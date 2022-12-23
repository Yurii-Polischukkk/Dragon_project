using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;
using static Unity.Burst.Intrinsics.X86;

public class ExitLevel : MonoBehaviour
{

[SerializeField] private int nextLevelIndex;

    private void OnTriggerEnter2D(Collider2D collision) {

        if (collision.gameObject.tag == "Player"){
            ChangeScene();
        }
    }

    private void ChangeScene() {
        SceneManager.LoadScene(nextLevelIndex);
    }
}