using UnityEngine;

class SumOfNumbers : MonoBehaviour
{
    [SerializeField] int number;
    [SerializeField] int sum;




    void OnValidate()
    
    {
        sum = 0;
      
        for (int i = 1; i <= number; i++) 
             
              sum += i;
    }
}