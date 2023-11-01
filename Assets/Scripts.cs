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

    //Variables Exercici 3

    [SerializeField] private int num3 = 4;
    [SerializeField] private int num4 = 8;

    //Variables Exercici 4

    [SerializeField] private string nota;

    //Variables Exercicis 5 i 7

    [SerializeField] private int days = 0;
    [SerializeField] private int months = 0;
    [SerializeField] private int years = 0;

    // Variables Exercici 8

    [SerializeField] private string diasetmana;

    //Variables Exercici 9

    [SerializeField] private int edat;
    [SerializeField] private string rango;

    // Variables Exercici 10

    [SerializeField] private float angle1;
    [SerializeField] private float angle2;
    [SerializeField] private float angle3;


    private void Start()
    {

        //Exercici 1

        result = Math.Max(num1, num2);
        Debug.Log($"El numero mayor entre {num1} y {num2} es: {result}");


        //Exercici 2

        if (letra == "A" || letra == "E" || letra == "I" || letra == "O" || letra == "U")
        {
            Debug.Log($" la letra {letra} es una vocal");
        }
        else
        {
            Debug.Log($" la letra {letra} es una consonante");
        }

        //Exercici 3

        if (num3 % num4 == 0)
        {
            Debug.Log($"{num3} es divisible per {num4}");
        }
        else
        {
            Debug.Log($"{num3} no es divisible per {num4}");
        }

        //Exercici 4

        if (nota == "A")
        {
            Debug.Log("excellent");
        }
        else if (nota == "B")
        {
            Debug.Log("notable");
        }
        else if (nota == "C")
        {
            Debug.Log("passed");
        }
        else if (nota == "D")
        {
            Debug.Log("fail");
        }

        //ejercicio 5


        if (months == 1 || months == 3 || months == 5 || months == 7 || months == 9 || months == 11)
        {
            if (days <= 31 && days > 0 && years > 0)
            {
                Debug.Log($" {days} / {months} / {years} es una fetxa valida");
            }
            else
            {
                Debug.Log(" aixo no es una fetxa valid");
            }

        }
        else if (months == 2)
        {
            if (days <= 28 && days > 0 && years > 0)
            {
                Debug.Log($" {days} / {months} / {years} es una fetxa valida");
            }
            else
            {
                Debug.Log(" aixo no es una fetxa valid");
            }

        }
        else if (months == 4 || months == 6 || months == 8 || months == 10 || months == 12)
        {
            if (days <= 30 && days > 0 && years > 0)
            {
                Debug.Log($" {days} / {months} / {years} es una fetxa valida");

            }
            else
            {
                Debug.Log(" aixo no es una fetxa valida");
            }
        }
        else
        {
            Debug.Log("aixo no es una fetxa valida");
        }


        //Exercici 7

        if (months == 1 && days >= 1 && days < 20)
        {

            Debug.Log("el teu horoscopo es capricornio");
        }
        else if (months == 1 && days >= 20 && days < 32)
        {

            Debug.Log("el teu horoscopo es acuario");
        }
        else if (months == 2 && days >= 1 && days < 19)
        {

            Debug.Log("el teu horoscopo es acuario");
        }
        else if (months == 2 && days >= 19 && days < 29)
        {

            Debug.Log("el teu horoscopo es piscis");
        }
        else if (months == 3 && days >= 1 && days < 21)
        {

            Debug.Log("el teu horoscopo es piscis");
        }
        else if (months == 3 && days >= 21 && days < 32)
        {

            Debug.Log("el teu horoscopo es aries");
        }
        else if (months == 4 && days >= 1 && days < 20)
        {

            Debug.Log("el teu horoscopo es aries");
        }
        else if (months == 4 && days >= 21 && days < 31)
        {

            Debug.Log("el teu horoscopo es tauro");
        }
        else if (months == 5 && days >= 1 && days < 21)
        {

            Debug.Log("el teu horoscopo es tauro");
        }
        else if (months == 5 && days >= 21 && days < 32)
        {

            Debug.Log("el teu horoscopo es geminis");
        }
        else if (months == 6 && days >= 1 && days < 21)
        {

            Debug.Log("el teu horoscopo es geminis");
        }
        else if (months == 6 && days >= 21 && days < 31)
        {

            Debug.Log("el teu horoscopo es cancer");
        }
        else if (months == 7 && days >= 1 && days < 23)
        {

            Debug.Log("el teu horoscopo es cancer");
        }
        else if (months == 7 && days >= 23 && days < 32)
        {

            Debug.Log("el teu horoscopo es leo");
        }
        else if (months == 8 && days >= 1 && days < 23)
        {

            Debug.Log("el teu horoscopo es leo");
        }
        else if (months == 8 && days >= 23 && days < 32)
        {

            Debug.Log("el teu horoscopo es virgo");
        }
        else if (months == 9 && days >= 1 && days < 23)
        {

            Debug.Log("el teu horoscopo es virgo");
        }
        else if (months == 9 && days >= 23 && days < 31)
        {

            Debug.Log("el teu horoscopo es libra");
        }
        else if (months == 10 && days >= 1 && days < 23)
        {

            Debug.Log("el teu horoscopo es libra");
        }
        else if (months == 10 && days >= 23 && days < 32)
        {

            Debug.Log("el teu horoscopo es escorpio");
        }
        else if (months == 11 && days >= 1 && days < 22)
        {

            Debug.Log("el teu horoscopo es escorpio");
        }
        else if (months == 11 && days >= 22 && days < 31)
        {

            Debug.Log("el teu horoscopo es sagitario");
        }
        else if (months == 12 && days >= 1 && days < 22)
        {

            Debug.Log("el teu horoscopo es sagitario");
        }
        else if (months == 12 && days >= 22 && days < 32)
        {

            Debug.Log("el teu horoscopo es capricornio");
        }

        //Exercici 8

        if (diasetmana == "dilluns" || diasetmana == "dimarts" || diasetmana == "dimecres" || diasetmana == "dijous" || diasetmana == "divendres")
        {
            Debug.Log("no es cap de setmana");
        }
        else
        {
            Debug.Log("es cap de setmana");
        }

        //Exercici 9

        if (edat >= 18 && edat < 65)
        {
            if (rango == "or")
            {
                Debug.Log("tens un 75% de descompte");
            }
            else if (rango == "plata")
            {
                Debug.Log("tens un 50% de descompte");
            }
            else if (rango == "bronze")
            {
                Debug.Log("tens un 25% de descompte");
            }

        }
        else if (edat > 65)
        {
            if (rango == "or")
            {
                Debug.Log("tens un 50% de descompte");
            }
            else if (rango == "plata")
            {
                Debug.Log("tens un 25% de descompte");
            }
            else if (rango == "bronze")
            {
                Debug.Log("tens un 15% de descompte");
            }
        }
        else if (edat < 18)
        {
            Debug.Log("no pots comprar a la tenda perque ets menor");
        }

        //Exercici 10


        if (angle1 + angle2 + angle3 == 180)
        {
            Debug.Log("aquests angles poden ser els interns d'un triangle");
        }
        if (angle1 + angle2 + angle3 != 180)
        {
            Debug.Log("aquests angles no poden ser els interns d'un triangle");
        }


    }

    // Update is called once per frame
    void Update()
    {

    }
}