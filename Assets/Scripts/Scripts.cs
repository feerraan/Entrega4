using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Scripts : MonoBehaviour
{
    //Variables Exercici 1
    [SerializeField] private int num1;
    [SerializeField] private int num2;
    private float result;

    //Variables Exercici 2

    [SerializeField] private string letra;

    //Variables Exercicis 5 i 6

    [SerializeField] private int days = 0;
    [SerializeField] private int months = 0;
    [SerializeField] private int years = 0;


    //Variables Exercici 4

    [SerializeField] private int year;

    //Variables Exercici 8
    [SerializeField] private float basetriangulo;
    [SerializeField] private float alturatriangulo;

    //Variable Exercici 10
   
        [SerializeField] private float impar;
    
    



private void Start()
    {

        //Exercici 10
        if (impar % 2 == 0)
        {
            Debug.Log($"true");
        }
        else
        {
            Debug.Log($"false");
        }


        //Exercici 1

        result = Math.Min(num1, num2);
        Debug.Log($"El numero menor entre {num1} y {num2} es: {result}");


        //Exercici 2

        if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
        {
            Debug.Log($"true");
        }
        else
        {
            Debug.Log($"false");
        }

        //Exercici 3

        if (months == 1 || months == 3 || months == 5 || months == 7 || months == 9 || months == 11)
        {
            if (days <= 31 && days > 0 && years > 0)
            {
                Debug.Log($"true");
            }
            else
            {
                Debug.Log("false");
            }

        }
        else if (months == 2)
        {
            if (days <= 28 && days > 0 && years > 0)
            {
                Debug.Log($"true");
            }
            else
            {
                Debug.Log("false");
            }

        }
        else if (months == 4 || months == 6 || months == 8 || months == 10 || months == 12)
        {
            if (days <= 30 && days > 0 && years > 0)
            {
                Debug.Log($"true");

            }
            else
            {
                Debug.Log("false");
            }
        }
        else
        {
            Debug.Log("false");
        }



        //Exercici 4

            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
            Debug.Log($"true");
            }
            else
            {
            Debug.Log($"false");
        }
       


        //Exercici 8

        if (basetriangulo <= 0 || alturatriangulo <= 0)
        {
            throw new ArgumentException("La base y la altura tienen que ser positivos");
        }

        Debug.Log($"La base del triangulo es {0.5 * basetriangulo * alturatriangulo}");

        //Exercici 6

        DateTime datemenos = new DateTime(years, months, days);
        datemenos = datemenos.AddDays(- 1);
        Debug.Log(datemenos);

        //Exercici 5

        DateTime datemas = new DateTime(years, months, days);
        datemas = datemas.AddDays(+ 1);
        Debug.Log(datemas);


    }


    }

    
    