
using UnityEngine;

 class SumOfEvens : MonoBehaviour
{
    [SerializeField] int number;  //szám

    [SerializeField] int summa;   // érték
    [SerializeField] int mean;    // átlag
   
    
    void OnValidate()
    
    {
        number = 0;                           // 0-val kezdünk
        for (int i = 0; i < number; i++)      
            summa += 1 *  (2 * i);
            mean = summa / number;
        
    }
}
