using System.Collections;
using UnityEngine;

public class week4_HashTable : MonoBehaviour
{

    public class Goblin { }
    public class Slime { }
    private void Awake()
    {
        //�÷��� �ڷᱸ���� ������ ������ new�� �޸𸮸� �Ҵ��ؾ� ����� �� �ִ�.
        Hashtable hash = new Hashtable();

        //�÷��� �ڷᱸ���� objectŸ���� �����ϱ� ������ Ŭ���� �ν��Ͻ��� ���� ����
        Goblin goblin = new Goblin();
        Slime slime = new Slime();

        //��� �߰� ([]������)
        hash["Goblin"] = goblin;

        //��� �߰� (Add �޼ҵ�)
        hash.Add("Slime", slime);
        hash.Add(1, "����");
        hash.Add(1.2f, "�Ǽ�");
        hash.Add("�ȳ��ϼ���. ��ڻ��Դϴ�", "���ڿ�");

        //Hashtable, Dictionary ��� ���� ������ for���� Ȱ����
        //���������� ������ Ž���� �Ұ����� �� ����ϴ� �ݺ���
        //foreach ( ������Ÿ�� ������ in �迭 �� ������ ���� )
        foreach (object key in hash.Keys)
        {
            Debug.Log($"hash[{key}] = {hash[key]}");
        }

        // �ؽ����̺� "Slime"Ű�� ������ ��Ұ� �ִ��� Ž��
        if (hash.ContainsKey("Slime"))
        {
            Debug.Log($"Slime Ű ����");
        }

        //�ؽ����̺� goblin���� ������ ��Ұ� �ִ��� Ž��
        if (hash.ContainsValue(goblin))
        {
            Debug.Log($"{goblin}�� ����");
        }

        //���� �ؽ����̺� ����� ����� ����
        Debug.Log($"Hashtable Count : {hash.Count}");

        //�ؽ����̺��� �Ű������� �Էµ� "Slime"�� ������ ��� ����
        hash.Remove("Slime");

        //���� �ؽ����̺� ����� ����� ����
        Debug.Log($"Hashtable Count : {hash.Count}");

        //�ؽ����̺��� ��� ��� ����
        hash.Clear();

        //���� �ؽ����̺� ����� ����� ����
        Debug.Log($"Hashtable Count : {hash.Count}"); //0
    }

}