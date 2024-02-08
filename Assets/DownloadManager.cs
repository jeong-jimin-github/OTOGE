using System.IO;
using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using UnityEngine.UI;

public class DownloadManager : MonoBehaviour
{
    public string[,] DLList = { 
        { "https://drive.google.com/uc?export=download&id=1MFgwxIRMpus1swZXMr9sQZgr3pTCSAYk", "ôøëå«ß«¯ªÎá¼ã÷.mp3" },
        { "https://drive.google.com/uc?export=download&id=1rpLfjQsL0-SSy1mVZPPvTc7xRB3zMmNr",  "ôøëå«ß«¯ªÎá¼ã÷.mp4" },
        { "https://drive.google.com/uc?export=download&id=1RiL7mzA59UeQL7aS9srGiXeX4eOmsAkM", "«¢«¹«Î«è«¾«éôúÌüÚì.mp3" },
        { "https://drive.google.com/uc?export=download&id=1mI-S_oFnc-c9pxmgQmWGh_sKfoed8ycV", "«¢«¹«Î«è«¾«éôúÌüÚì.mp4" }
    };
    int DLKasu = 3;
    public GameObject panel;
    public Text Suu;
    void Start()
    {
            StartCoroutine(DownLoadGet());
    }

    public IEnumerator DownLoadGet()
    {
        panel.SetActive(true);
        Suu.text = "0/" + (DLKasu + 1).ToString();
        for (int i = 0; i <= DLKasu; i++)
        {
            string URL = DLList[i, 0];
            string filename = DLList[i, 1];
            if (File.Exists(Application.persistentDataPath + "/" + filename))
            {
            }

            else
            {
                UnityWebRequest request = UnityWebRequest.Get(URL);

                yield return request.SendWebRequest();

                //¿¡·¯ ¹ß»ı½Ã
                if (request.result == UnityWebRequest.Result.ConnectionError || request.result == UnityWebRequest.Result.ProtocolError)
                {
                    Debug.Log(request.error);
                }
                else
                {
                    //´Ù¿î·Îµå µ¥ÀÌÅÍ¸¦ ÆÄÀÏ·Î ÀúÀå
                    File.WriteAllBytes(Application.persistentDataPath + "/" + filename, request.downloadHandler.data);
                    Suu.text = (i + 1).ToString() + "/" + (DLKasu + 1).ToString();
                }
            }
        }
        panel.SetActive(false);
    }
}