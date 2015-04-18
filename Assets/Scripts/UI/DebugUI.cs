using UnityEngine;
using UnityEngine.UI;

public class DebugUI : MonoBehaviour
{

    public GameObject player;

    public Text _velocityText;

    public Text _multipleJumpsText;

    public Image _dUp;
    public Image _dDown;
    public Image _dLeft;
    public Image _dRight;

    public Image _a;
    public Image _b;
    public Image _x;
    public Image _y;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        // _multipleJumpsText.text = playerStats.jumpCount.ToString() + "/" + playerStats.maxJumps.ToString();

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        if (h > 0)
        {
            _dRight.CrossFadeAlpha(1f, 0.1f, true);
        }
        else
        {
            _dRight.CrossFadeAlpha(0.5f, 0.1f, true);
        }

        if (h < 0)
        {
            _dLeft.CrossFadeAlpha(1f, 0.1f, true);
        }
        else
        {
            _dLeft.CrossFadeAlpha(0.5f, 0.1f, true);
        }

        if (v > 0)
        {
            _dUp.CrossFadeAlpha(1f, 0.1f, true);
        }
        else
        {
            _dUp.CrossFadeAlpha(0.5f, 0.1f, true);
        }

        if (v < 0)
        {
            _dDown.CrossFadeAlpha(1f, 0.1f, true);
        }
        else
        {
            _dDown.CrossFadeAlpha(0.5f, 0.1f, true);
        }

        bool a = Input.GetButton("Jump");
        bool b = Input.GetButton("Fire2");
        float aAlpha = a ? 1 : 0.5f;
        float bAlpha = b ? 1 : 0.5f;
        _a.CrossFadeAlpha(aAlpha, 0.05f, true);
        _b.CrossFadeAlpha(bAlpha, 0.05f, true);
    }
}