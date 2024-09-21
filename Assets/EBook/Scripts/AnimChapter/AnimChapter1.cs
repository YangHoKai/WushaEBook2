using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimChapter1 : MonoBehaviour
{
    public GameObject PlayButton;
    public GameObject StopButton;
    public GameObject ScrollView;
    public GameObject Content;
    public GameObject Anim;

    public Image Chapter11;
    public Image Chapter12;
    public Image Chapter13;
    public Image Chapter14;
    public Image Chapter15;
    public Image Chapter16;
    public Image Chapter17;
    public Image Chapter18;
    public Image Chapter19;
    public Image Chapter110;
    public Image Chapter111;
    public Image Chapter112;

    float ContextX;
    public float TotalTime;
    public int ImageCount;
    public float ColorCount;
    void Start()
    {
        ContextX = Content.transform.position.x;
    }
    void Update()
    {
        
    }
    public void ClosePlayButton()
    {
        StopButton.SetActive(true);
        Anim.SetActive(true);
        PlayButton.SetActive(false);
        ScrollView.SetActive(false);
        PlayAnim();
        Invoke("AddTime", 1);
    }
    public void CloseStopButton()
    {
        PlayButton.SetActive(true);
        ScrollView.SetActive(true);
        Content.transform.localPosition = new Vector2(ContextX, 0);
        StopButton.SetActive(false);
        Anim.SetActive(false);
        End();
    }
    public void AddTime()
    {
        TotalTime += 1;
        Invoke("AddTime", 1);
    }
    public void PlayAnim()
    {
        ImageCount = 1;
        AddColor();//夹肈
        Invoke("ChangeImage", 1.3f);//场だ1
        Invoke("ChangeImage", 30.7f);//场だ2
        Invoke("ChangeImage", 73);//场だ3
        Invoke("ChangeImage", 100);//场だ4
        Invoke("ChangeImage", 141);//场だ5
        Invoke("ChangeImage", 174);//场だ6
        Invoke("ChangeImage", 216);//场だ7
        Invoke("ChangeImage", 247);//场だ8
        Invoke("ChangeImage", 284);//场だ9
        Invoke("ChangeImage", 324);//场だ10
        Invoke("ChangeImage", 364);//场だ11
        Invoke("ReduceColor", 399);
        Invoke("CloseStopButton", 402);
    }
    public void ChangeImage()
    {
        ReduceColor();
        Invoke("AddColor", 1);
    }
    public void AddColor()
    {
        if (ColorCount <= 1)
        {
            ColorCount += 0.1f;
            ImageDetection();
            Invoke("AddColor", 0.05f);
        }
        print(ColorCount);
    }
    public void ReduceColor()
    {
        if (ColorCount >= 0)
        {
            ColorCount -= 0.1f;
            ImageDetection();
            Invoke("ReduceColor", 0.05f);
        }
        else
        {
            ImageCount += 1;
        }
        print(ColorCount);
    }
    void ImageDetection()
    {
        if (ImageCount == 1)
            Chapter11.color = new Color(1, 1, 1, ColorCount);
        if (ImageCount == 2)
            Chapter12.color = new Color(1, 1, 1, ColorCount);
        if (ImageCount == 3)
            Chapter13.color = new Color(1, 1, 1, ColorCount);
        if (ImageCount == 4)
            Chapter14.color = new Color(1, 1, 1, ColorCount);
        if (ImageCount == 5)
            Chapter15.color = new Color(1, 1, 1, ColorCount);
        if (ImageCount == 6)
            Chapter16.color = new Color(1, 1, 1, ColorCount);
        if (ImageCount == 7)
            Chapter17.color = new Color(1, 1, 1, ColorCount);
        if (ImageCount == 8)
            Chapter18.color = new Color(1, 1, 1, ColorCount);
        if (ImageCount == 9)
            Chapter19.color = new Color(1, 1, 1, ColorCount);
        if (ImageCount == 10)
            Chapter110.color = new Color(1, 1, 1, ColorCount);
        if (ImageCount == 11)
            Chapter111.color = new Color(1, 1, 1, ColorCount);
        if (ImageCount == 12)
            Chapter112.color = new Color(1, 1, 1, ColorCount);
    }
    void End()
    {
        CancelInvoke();
        TotalTime = 0;
        ImageCount = 0;
        ColorCount = 0;
        Chapter11.color = new Color(1, 1, 1, 0);
        Chapter12.color = new Color(1, 1, 1, 0);
        Chapter13.color = new Color(1, 1, 1, 0);
        Chapter14.color = new Color(1, 1, 1, 0);
        Chapter15.color = new Color(1, 1, 1, 0);
        Chapter16.color = new Color(1, 1, 1, 0);
        Chapter17.color = new Color(1, 1, 1, 0);
        Chapter18.color = new Color(1, 1, 1, 0);
        Chapter19.color = new Color(1, 1, 1, 0);
        Chapter110.color = new Color(1, 1, 1, 0);
        Chapter111.color = new Color(1, 1, 1, 0);
        Chapter112.color = new Color(1, 1, 1, 0);
    }
}
