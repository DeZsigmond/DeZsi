
using UnityEngine;

public class FizzBuzz : MonoBehaviour
{
    [SerializeField, Min(1)] int number = 1;


    void Start()
    
     

    {
        for (int i = 1; i <= number; i++)
        {
            bool fizz = i % 3 == 0;
            bool buzz = i % 5 == 0;
            if (fizz && buzz)
                Debug.Log("FizzBuzz");
            else if (fizz)
                Debug.Log("Fizz");
            else if (buzz)
                Debug.Log("Buzz");
            else
                Debug.Log(i);


        }





    }

    
}
