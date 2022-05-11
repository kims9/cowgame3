using UnityEngine;
using System.Collections;

public class Back : MonoBehaviour
{
    public void ChangeToScene(int sceneToChangeTo) {
        Application.LoadLevel(sceneToChangeTo);
    }
}