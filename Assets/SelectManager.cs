using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectManager : MonoBehaviour
{
    public Button �����ǹ��ϴ��ʰ��;
    public Button �����׹����Ǽҽ�;
    public Sprite �����ǹ��ϴ��ʰ�ݾ�Ʈ;
    public Sprite �����׹����ǼҽǾ�Ʈ;
    public Image image;
    public Text title;
    public Text auther;
    public Text bpm;
    // Start is called before the first frame update
    void Start()
    {
        �����ǹ��ϴ��ʰ��.onClick.AddListener(asu);
        �����׹����Ǽҽ�.onClick.AddListener(shousitu);
        asu();
    }
    void asu()
    {
        SaveSelect("�����Ϋ諾��������");
        image.sprite = �����ǹ��ϴ��ʰ�ݾ�Ʈ;
        title.text = "�����Ϋ諾��������";
        auther.text = "Orangestar";
        bpm.text = "BPM 185";
    }
    void shousitu()
    {
        SaveSelect("����߫������");
        image.sprite = �����׹����ǼҽǾ�Ʈ;
        title.text = "����߫������";
        auther.text = "cosMo@����p";
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
