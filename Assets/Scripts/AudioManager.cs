using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource effectsAudioSource;
    [SerializeField] private AudioSource defaultAudioSource;
    [SerializeField] private AudioSource bossAudioSource;
    [SerializeField] private AudioClip shootClip;
    [SerializeField] private AudioClip reLoadClip;
    [SerializeField] private AudioClip energyClip;

    public void PlayShootSound()
    {
        effectsAudioSource.PlayOneShot(shootClip);
    }
    public void PlayReLoadSound()
    {
        effectsAudioSource.PlayOneShot(reLoadClip);
    }
    public void PlayEnergySound()
    {
        effectsAudioSource.PlayOneShot(energyClip);
    }
    public void PlayDefaultAudio()
    {
        bossAudioSource.Stop();
        defaultAudioSource.Play();
    }
    public void PlayBossAudio()
    {
        defaultAudioSource.Stop();
        bossAudioSource.Play();
        
    }
    public void StopAudioGame()
    {
        effectsAudioSource.Stop();
        defaultAudioSource.Stop();
        bossAudioSource.Stop();
    }
}
