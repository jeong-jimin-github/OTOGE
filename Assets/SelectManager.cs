using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectManager : MonoBehaviour
{
    public Button ³»ÀÏÀÇ¹ãÇÏ´ÃÃÊ°è¹İ;
    public Button ÇÏÃ÷³×¹ÌÄíÀÇ¼Ò½Ç;
    public Sprite ³»ÀÏÀÇ¹ãÇÏ´ÃÃÊ°è¹İ¾ÆÆ®;
    public Sprite ÇÏÃ÷³×¹ÌÄíÀÇ¼Ò½Ç¾ÆÆ®;
    public Image image;
    public Text title;
    public Text auther;
    public Text bpm;
    // Start is called before the first frame update
    void Start()
    {
        ³»ÀÏÀÇ¹ãÇÏ´ÃÃÊ°è¹İ.onClick.AddListener(asu);
        ÇÏÃ÷³×¹ÌÄíÀÇ¼Ò½Ç.onClick.AddListener(shousitu);
        asu();
    }
    void asu()
    {
        SaveSelect("«¢«¹«Î«è«¾«éôúÌüÚì");
        image.sprite = ³»ÀÏÀÇ¹ãÇÏ´ÃÃÊ°è¹İ¾ÆÆ®;
        title.text = "«¢«¹«Î«è«¾«éôúÌüÚì";
        auther.text = "Orangestar";
        bpm.text = "BPM 185";
    }
    void shousitu()
    {
        SaveSelect("ôøëå«ß«¯ªÎá¼ã÷");
        image.sprite = ÇÏÃ÷³×¹ÌÄíÀÇ¼Ò½Ç¾ÆÆ®;
        title.text = "ôøëå«ß«¯ªÎá¼ã÷";
        auther.text = "cosMo@øìñËp";
        bpm.text = "BPM 240";
    }
    void SaveSelect(string name)
    {
        PlayerPrefs.SetString("Song", name);
    
PlayerPrefs.Save();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
