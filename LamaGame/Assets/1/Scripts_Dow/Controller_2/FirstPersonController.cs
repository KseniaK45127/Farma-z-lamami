using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lessons.FPS
{
    public class FirstPersonController : MonoBehaviour
    {

        // �������� ������������ ������
        [SerializeField] private float speed = 10.0f;

        // ��������� CharacterController
        private CharacterController cc;

        void Start()
        {
            // �������� ��������� CharacterController
            cc = GetComponent<CharacterController>();
        }

        void FixedUpdate()
        {
            // �������� ������� ����������������� ������
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            // ���������� ������ � ��������� ����������
            Vector2 input = new Vector2(horizontal, vertical);
            // ���������� ����������� ��������
            Vector3 desiredMove = transform.forward * input.y + transform.right * input.x;
            Vector3 moveDir = new Vector3(desiredMove.x * speed, 0, desiredMove.z * speed);
            // ����������� ������
            cc.Move(moveDir * Time.fixedDeltaTime);
        }
    }
}