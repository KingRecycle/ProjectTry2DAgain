using UnityEngine;
using UnityEngine.UI;

public class FloatingText : MonoBehaviour
{
    private Text _text;

    // Use this for initialization
    void Awake()
    {
        _text = GetComponentInChildren<Text>();
    }

    void Start()
    {
        Destroy(transform.root.gameObject, 0.3f);
    }

    public void SetText(string txt)
    {
        _text.text = txt;
    }

    // Update is called once per frame
    void Update()
    {
        transform.root.Translate(Vector3.up * Time.deltaTime);
    }
}