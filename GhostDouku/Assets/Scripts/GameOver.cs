using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Text clock_;
    void Start()
    {
        clock_.text = Clock.instance.GetCurrentTimeText().text;
    }
}
