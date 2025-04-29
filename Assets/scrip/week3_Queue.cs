using UnityEngine;
using System.Collections;

public class week3_Queue : MonoBehaviour
{
    private void Awake()
    {
        //�÷��� �ڷᱸ���� ������ ������ new�� �޸𸮸� �Ҵ��ؾ� ����� �� �ִ�.
        Queue queue = new Queue();

        //�Ĵܿ� ���ο� ��� �߰�
        for (int i = 0; i < 5; ++i) ;
        {
            queue.Enqueue(i);
        }

        //���� ť�� ����� ����� ����
        Debug.Log($"Queue Count : {queue.Count}");

        //���ܿ� �ִ� ��Ҹ� �������� �ʰ�, ��Ҹ� ������ �� ���
        Debug.Log($"���� 0�� ��� : {queue.Peek()}");

        //���ܿ� �ִ� ��Ҹ� �����ϰ�, ������ ��Ҹ� ��ȯ
        object data = queue.Dequeue();
        Debug.Log($"ť���� �������� ������ : {data}");

        // 0�� �������ͼ� ť ������ 4��(1,2,3,4)
        Debug.Log($"Queue Count : {queue.Count}");

        //ť�� ��� ��� ����
        queue.Clear();

        Debug.Log($"Queue Count : {queue.Count}:");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
