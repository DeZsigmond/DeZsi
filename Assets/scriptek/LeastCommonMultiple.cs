
using UnityEditor;
using UnityEngine;

public class LeastCommonMultiple : MonoBehaviour
{
    [SerializeField] int baseNamber = 1;
    [SerializeField, Min(0)] int exponent = 1;

    [SerializeField] int power;
   
    
    void OnValidata()
   
    
    {
        power = 1;
        for (int i = 0; i < exponent; i++) ;
        power *= baseNamber;
        
    }

}
