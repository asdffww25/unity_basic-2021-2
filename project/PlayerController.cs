using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Audio Clips")]

    private RotateToMouse rotateToMouse;
    private PlayerAnimatorController animator;
    private AudioSource audioSource;

    private void Awake()
    {
        //마우스 커서 안보이게 하고, 현재 위치 고정.
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        rotateToMouse = GetComponent<RotateToMouse>();
        animator = GetComponent<PlayerAnimatorController>();
        audioSource = GetComponent<AudioSource>();
    }
    private void Update()
    {
        UpdateRotate();
    }
    private void UpdateRotate()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        rotateToMouse.UpdateRotate(mouseX, mouseY);
    }
}
