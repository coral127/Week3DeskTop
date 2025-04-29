using System.Collections.ObjectModel;
using System.Collections;
using UnityEngine;

public class week3 : MonoBehaviour
{
    private void Awake()
    {
        //�÷��� �ڷᱸ���� ������ ������ �޸𸮸� �Ҵ��ؾ� ����� �� �ִ�.
        ArrayList arrayList = new ArrayList();
        

        //��ҿ� ������ ���� ÷�� ������ []�� �̿��Ѵ�.
        //object Ÿ���̱� ������ ���� ������ ������ ���� ����
        Debug.Log(arrayList.Add(0));

        //������ ���
        PrintArrayList(arrayList);

        //��� �߰�(���ϴ� ��ġ)
        ArrayList.Insert(1, 100);

        PrintArrayList(arrayList);

        //��� �߰�(����, ICollection)
        Collection<int> data = new Collection<int>();
        data.Add(1);
        data.Add(3);
        data.Add(2);
        arrayList.AddRange(data);

        //������ ���
        PrintArrayList(arrayList);

        //������ �������� ���� (ArrayList�� ���� �����͸� ���� �� �������� ��� ����)
        //�� �� �����Ͱ� ������� ��� ���� �߻�
        arrayList.Sort();

        //��� ����(�Ű������� �Էµ� ������)
        arrayList.Remove(10);

        //��� ����(�Ű������� �Էµ� ��ġ ���)
        arrayList.RemoveAt(0);

        //��� ����(ù ��° �Ű����� ��ġ���� �� ��° �Ű����� ������ŭ ����)
        arrayList.RemoveRange(0, 2);

        //��� ��� ����
        arrayList.Clear();

        //��� ���� ���
        Debug.Log(arrayList.Count); 
    }

}
