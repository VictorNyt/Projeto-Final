﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextPadoru : MonoBehaviour
{
    [SerializeField]
    GameObject go;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<TextMeshProUGUI>().text = go.GetComponent<ContadorDePadoru>().ToString();
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<TextMeshProUGUI>().text = go.GetComponent<ContadorDePadoru>().ToString();
    }
}