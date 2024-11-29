using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animGameOb : MonoBehaviour
{
    public Animator animator; // ������ �� ��������� ���������

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TouchObject")) // ���������, ��� ������, � ������� �����������, ����� ��� "TouchObject"
        {
            animator.SetTrigger("TriggerName"); // �������� �������� �� ����� ��������
        }
    }
}
