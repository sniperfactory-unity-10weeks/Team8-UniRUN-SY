using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flyingblock : MonoBehaviour
{
    public float speed = 15f; // �̵� �ӵ�

    private void Update()
    {
        if (!GameManager.instance.isGameover)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        // ���� ������Ʈ�� �������� ���� �ӵ��� ���� �̵��ϴ� ó��
    }
}
