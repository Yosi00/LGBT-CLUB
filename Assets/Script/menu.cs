using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public int n_scene = 1;  // ������ ����������� ����� �� ���������, ������� � ��������� ����� ��������

    public void LoadScene(int index)
    {
        SceneManager.LoadScene(index);
    }

}
