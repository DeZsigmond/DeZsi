using UnityEngine;

class ControlStructures : MonoBehaviour
{
    [SerializeField] int number;

    void Start()
    {

        if (number >= 10)
        {
            Debug.Log("Többjegyû szám");
        }
        else
        {
            Debug.Log("Egyjegyû szám");
        }

        string isEven;
        if (number % 2 == 0)
            isEven = "EVEN";
        isEven = number % 2 == 0 ? "EVEN" : "odd";

        int i = 1;
        while (i <= 100)
            Debug.Log(i * i);
        i++;
        for (int j = 1; j <= 100; j++)
            Debug.Log(j * j);


        int k = 1;
        do
        {
            Debug.Log(k * k);
        } while (k <= 100);



    }
}
