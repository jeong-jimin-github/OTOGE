using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Video;

public class Video : MonoBehaviour
{
    public VideoPlayer vid;
    int i = 0;
    public GameObject timer;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TestVideoPlayer());
    }

    IEnumerator TestVideoPlayer()
    {
        string path = "file://" + Application.persistentDataPath + "/" + PlayerPrefs.GetString("Song") + ".mp4";

        using (UnityWebRequest www = UnityWebRequest.Get(path))
        {
            yield return www.SendWebRequest();

            if (www.result == UnityWebRequest.Result.Success)
            {
                byte[] videoBytes = www.downloadHandler.data;

                // �ӽ� ���Ϸ� ������ �����մϴ�.
                string tempFilePath = Application.persistentDataPath + "/tempVideo.mp4";
                System.IO.File.WriteAllBytes(tempFilePath, videoBytes);

                // ���� �÷��̾ ������ �Ҵ��մϴ�.
                vid.url = "file://" + tempFilePath;
                vid.Prepare();

                // ������ �غ�� ������ ����մϴ�.
                while (!vid.isPrepared)
                {
                    yield return null;
                }

                // ������ ����մϴ�.
            }
            else
            {
                Debug.LogError("UnityWebRequest failed: " + www.error);
            }
        }
    }


    private void Update()
    {
        if (timer.GetComponent<timer>().start == true)
        {
            if (i == 0)
            {
                vid.Play();
                i++;
            }
        }
    }
}