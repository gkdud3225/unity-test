using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Animal cat = new Animal();
        cat.name = "고양이";
        cat.sound = "야옹!";

        cat.PlaySound();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
