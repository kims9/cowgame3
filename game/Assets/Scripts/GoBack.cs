using UnityEngine;
using System.Collections;

public class GoBack : MonoBehaviour
{
    public void ChangeToScene(int sceneToChangeTo) {
        Application.LoadLevel(sceneToChangeTo);
    }
}