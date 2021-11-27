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
        //���콺 Ŀ�� �Ⱥ��̰� �ϰ�, ���� ��ġ ����.
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
