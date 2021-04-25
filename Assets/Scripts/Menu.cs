﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Button loadMenu1;
    public Button loadSofa;
    public Button loadImage;
    public GameObject menu1;
    public GameObject sofa1;
    public GameObject image12;
    public int counter;
    // Start is called before the first frame update
    void Start()
    {
        loadMenu1.onClick.AddListener(menu);
        loadSofa.onClick.AddListener(sofaPage);
        loadImage.onClick.AddListener(image1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void menu()
    {
        counter++;
        if(counter%2 == 1){
            menu1.SetActive(true);
        }
        else{
            menu1.SetActive(false);
        }
        
    }

    public void sofaPage()
    {
        menu1.SetActive(false);
        sofa1.SetActive(true);

    }

    public void image1()
    {
        sofa1.SetActive(false);
        image12.SetActive(true);

    }
}
