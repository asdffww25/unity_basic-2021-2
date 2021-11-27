using System.Collections;
using UnityEngine;

public class WeaponAssaultRifle : MonoBehaviour
{
    [Header("Audio Clips")]
    [SerializeField]
    private AudioClip audioClipTakeOutWeapon;

    [Header("Weapon Setting")]
    [SerializeField]
    private WeaposSetting weaponSeetting;  //무기 설정

    private float lastAttackTime = 0;

    private AudioSource audioSource;

    private void Awake()
    {
        {
            audioSource = GetComponent<AudioSource>();
        }
    }
    private void OnEnable()
    {
        PlaySound(audioClipTakeOutWeapon);
    }
    private void PlaySound(AudioClip clip)
    {
        audioSource.Stop();
        audioSource.clip = clip;
        audioSource.Play();
    }
}
