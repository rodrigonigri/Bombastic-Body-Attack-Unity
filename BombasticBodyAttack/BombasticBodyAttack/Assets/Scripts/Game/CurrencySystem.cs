using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CurrencySystem : MonoBehaviour
{
    //FIELDS
    //currency txt UI
    public TextMeshProUGUI txt_Currency;

    //default currency value
    public int defaultCurrency;

    //current currency value
    public int currency;

    //METHODS
    //Init
    public void Init(){
        currency = defaultCurrency;
        txt_Currency.text = currency.ToString();
    }
    //Gain currency (input value)
    public void Gain(int val){
        currency += val;
        UpdateUI();
    }
    //Lose currency (input value)
    public bool Use(int val){
        if (EnoughCurrency(val)){
            currency -= val;
            UpdateUI();
            return true;
        }
        else{
            return false;
        }
        
    }
    //Check available currency
    public bool EnoughCurrency(int val){
        if (currency >= val){
            return true;
        }
        else{
            return false;
        }
    }

    //Update txt UI
    void UpdateUI(){
        txt_Currency.text = currency.ToString();
    }

    public void USE_TEST(){
        Debug.Log(Use(3));
    }
}
