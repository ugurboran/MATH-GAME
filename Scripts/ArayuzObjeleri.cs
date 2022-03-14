using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ArayuzObjeleri : MonoBehaviour
{
    public TMP_Text number1, number2, operation, answer, result, true_count, wrong_count;
    public TMP_InputField result_guess;
    int n1, n2, operation_sign, operation_result, true_number, wrong_number;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void check_answer(){
        if(int.Parse(result_guess.text) == operation_result){
            result.text = "CEVABINIZ DOGRU:)";
            true_number++;
            true_count.text = true_number + "";
        }
        else{
            result.text = "CEVABINIZ YANLIS!";
            wrong_number++;
            wrong_count.text = wrong_number + "";
        }
    }

    public void soru(){

        result.text = "";
        result_guess.text = "";
        n1 = Random.Range(1,10);
        n2 = Random.Range(1,10);
        operation_sign = Random.Range(1,5);

        switch(operation_sign){
            
            case 1:
            operation.text = "+";
            operation_result = n1 + n2;
            break;

            case 2:
            operation.text = "-";
            operation_result = n1 - n2;
            break;

            case 3:
            operation.text = "*";
            operation_result = n1 * n2;
            break;

            case 4:
            operation.text = "/";
            n1 = n1 * n2 ;
            operation_result = n1 / n2;
            break;
        }

        number1.text = n1 + "";
        number2.text = n2 + "";


    }
}
