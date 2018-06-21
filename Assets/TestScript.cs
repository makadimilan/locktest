using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TestScript : MonoBehaviour
{
    [SerializeField] EventSystem eventSystem;
    [SerializeField] GameObject firstSelected;

    void Start()
    {
        eventSystem.SetSelectedGameObject(firstSelected);
    }

}
