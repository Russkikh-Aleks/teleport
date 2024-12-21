using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{

    public string sceneName = SceneManager.GetActiveScene().name;

    void OnTriggerEnter(Collider other)
    {
        //������ ���� � ������
        SceneManager.LoadScene(sceneName);
    }

}
