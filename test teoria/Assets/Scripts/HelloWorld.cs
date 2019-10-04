using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    double MileNaKilometr (double a)
    {
        a = a * 1.609344;
        print(a);
        return 0;
    }
    // Start is called before the first frame update
    //Białe znaki spacja, enter
    void Start()
    {
        MileNaKilometr(14.5);
        int min = 1;
        int max = 1000;
        print("Hello World");
        print("Hello World");
        //zmienna to nazwana czesc pamienci komputera
        //RAM/ROM
        //RAM [][][][][]
        //łancuch znakow
        print("Witaj w Liczbowym Czrodzieju");
        print("wybierz liczbe z przedzialu od 1 do 1000");
        print("Maksymalna liczba jaka mozesz wybrac to" + max);
        // + operator przeciazenia powoduje ze mozemy typy string
        print("Minimalna liczba jaka mozesz wybrac to" + min);
        //Metoda = funkcja krotki kawalek kodu ktory ma za zadanie wykonac jakies
        // strrin / int/ float/ double/ long/ char
        //string Ala ma kota
        //int 1,2,3,4,5
        print("Czy twoja liczba jest mniejsza lub wiekasza niz 500");
        print("Nacisnij gorna strzlke aby odpowiedziec ze wieksza");
        print("Nacisnij dolna strzlke aby odpowiedziec ze mniejsza");
        print("Nacisnij enter aby potwierdzic");
        if (Input.GetKeyDown(KeyCode.UpArrow)) //instrukcja warunkowa
        {


        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
