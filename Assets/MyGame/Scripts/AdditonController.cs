using UnityEngine;
using UnityEngine.UI;

public class AdditonController : MonoBehaviour
{
    public InputField ifTermA, ifTermB;
    public Text randomSum;
    
    // Start is called before the first frame update

    int sum;

    void Start()
    {
        sum = GetRandomSum(0, 10);
        randomSum.text = sum.ToString();
    }

    int GetRandomSum(int min, int max)
    {
     
        return UnityEngine.Random.Range(min, max);
       
    }

    public bool ValuesParsable()
    {
        bool parseable = true;
        try
        {
            int.Parse(ifTermA.text);

        }
        catch (System.FormatException e)
        {
            ifTermA.image.color = Color.red;
            parseable = false;
        }

        try
        {
            int.Parse(ifTermB.text);

        }
        catch (System.FormatException e)
        {
            ifTermB.image.color = Color.red;
            parseable = false;
        }

        return parseable;
    }

    public bool CheckAdditionResult()
    {
        int termA = -1; 
        int termB = -1;

        try
        {
            termA = int.Parse(ifTermA.text);
            
        }
        catch(System.FormatException e)
        {
            ifTermA.image.color = Color.red;
        }

        try
        {
            termB = int.Parse(ifTermB.text);

        }
        catch (System.FormatException e)
        {
            ifTermB.image.color = Color.red;
        }


        return (termA + termB) == sum;
    }

    public void ResetInputFieldColor()
    {
        ifTermA.image.color = Color.white;
        ifTermB.image.color = Color.white;
    }

    public void NewRandomSum()
    {
        sum = GetRandomSum(0, 10);
        randomSum.text = sum.ToString();
    }

    public void SetInputFieldsInteractible(bool isInteractible)
    {
        ifTermA.interactable = isInteractible;
        ifTermB.interactable = isInteractible;
    }
    



}
