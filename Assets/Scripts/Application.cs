using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Application : MonoBehaviour
{
    [SerializeField] Button m_btnAddGreen;
    [SerializeField] Button m_btnAddBlue;
    [SerializeField] Button m_btnReset;
    [SerializeField] Button m_btnClearConsole;
    [SerializeField] TextMeshProUGUI m_txtGreen;
    [SerializeField] TextMeshProUGUI m_txtBlue;
    [SerializeField] TextMeshProUGUI m_txtConsole;

    int m_intGreenCount;
    int m_intBlueCount;

    // Start is called before the first frame update
    void Start()
    {
        Debug.LogError("tsusai Application:Start");
        ResetValue();
        ResetConsole();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ResetValue()
    {
        m_intGreenCount = 0;
        m_intBlueCount = 0;
        UpdateValue();
    }

    private void UpdateValue()
    {
        m_txtGreen.text = m_intGreenCount.ToString();
        m_txtBlue.text = m_intBlueCount.ToString();
    }

    private void ResetConsole()
    {
        m_txtConsole.text = string.Empty;
    }

    private void UpdateConsole(string str)
    {
        string finalString = str + "\n" + m_txtConsole.text;
        m_txtConsole.text = finalString;
    }

    public void ButtonGreenOnClick()
    {
        Debug.LogError("tsusai Application:ButtonGreenOnClick");
        m_intGreenCount++;
        UpdateValue();

        string str = "Green increased to " + m_intGreenCount.ToString();
        UpdateConsole(str);
    }

    public void ButtonBlueOnClick()
    {
        Debug.LogError("tsusai Application:ButtonBlueOnClick");
        m_intBlueCount++;
        UpdateValue();

        string str = "Blue increased to " + m_intBlueCount.ToString();
        UpdateConsole(str);
    }

    public void ButtonResetOnClick()
    {
        Debug.LogError("tsusai Application:ButtonResetOnClick");
        ResetValue();

        string str = "All values are reset";
        UpdateConsole(str);
    }

    public void ButtonClearConsoleOnClick()
    {
        Debug.LogError("tsusai Application:ButtonClearConsoleOnClick");
        ResetConsole();
    }
}
