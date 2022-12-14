using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance; 

    public AudioClip ChickenCaugthRelease; 
    public AudioClip ChickenRun; 
    public AudioClip ChickenKilled; 
    public AudioClip FoxCaughtRelease; 
    public AudioClip FoxKill;
    public AudioClip FoxFigth;
    public AudioClip GameOver;
    public AudioClip Victory;
    public AudioClip Cheering;
    public AudioClip DingDingDing;
    public AudioClip Quit;

    private Vector3 cameraPosition; 

    // Start is called before the first frame update
    void Awake()
    {
        Instance = this; // 1
        cameraPosition = Camera.main.transform.position; // 2
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void PlaySound(AudioClip clip) 
    {
        AudioSource.PlayClipAtPoint(clip, cameraPosition); 
    }
    public void PlayChickenCaugthRelease()
    {
        PlaySound(ChickenCaugthRelease);
    }
    public void PlayChickenRun()
    {
        PlaySound(ChickenRun);
    }
    public void PlayChickenKilled()
    {
        PlaySound(ChickenKilled);
    }
    public void PlayFoxCaughtRelease()
    {
        PlaySound(FoxCaughtRelease);
    }
    public void PlayFoxKill()
    {
        PlaySound(FoxKill);
    }
    public void PlayFoxFigth()
    {
        PlaySound(FoxFigth);
    }
    public void PlayGameOver()
    {
        PlaySound(GameOver);
    }
    public void PlayVictory()
    {
        PlaySound(Victory);
    }
    public void PlayCheering()
    {
        PlaySound(Cheering);
    }
    public void PlayDingDingDing()
    {
        PlaySound(DingDingDing);
    }
    public void PlayQuit()
    {
        PlaySound(Quit);
    }
  
}
