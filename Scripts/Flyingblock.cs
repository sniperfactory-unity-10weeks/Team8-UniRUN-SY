using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flyingblock : MonoBehaviour
{
    public float speed = 15f; // 이동 속도

    private void Update()
    {
        if (!GameManager.instance.isGameover)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        // 게임 오브젝트를 왼쪽으로 일정 속도로 평행 이동하는 처리
    }
}
