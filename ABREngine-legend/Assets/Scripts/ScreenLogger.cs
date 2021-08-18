using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenLogger : MonoBehaviour
{
    /// Static instance of this class so the singleton can be accessed from all
    /// over
    private static ScreenLogger _instance;
    public static ScreenLogger Instance
    {
        get { return _instance; }
    }

    void OnEnable()
    {
        if (!Instance)
        {
            _instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        this.transform.GetChild(0).gameObject.SetActive(false);
        this.transform.GetChild(0).GetChild(0).GetComponent<Text>().text = "";
    }

    public void Log(string text) {
        this.transform.GetChild(0).gameObject.SetActive(true);
        this.transform.GetChild(0).GetChild(0).GetComponent<Text>().text += "\n";
        this.transform.GetChild(0).GetChild(0).GetComponent<Text>().text += text;
    }
}
