
using UnityEngine;

 class SumOfEvens : MonoBehaviour
{
    [SerializeField] int number;  //sz�m

    [SerializeField] int summa;   // �rt�k
    [SerializeField] int mean;    // �tlag
   
    
    void OnValidate()
    
    {
        number = 0;                           // 0-val kezd�nk
        for (int i = 0; i < number; i++)      
            summa += 1 *  (2 * i);
            mean = summa / number;
        
    }
}
