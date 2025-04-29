using System.Collections.ObjectModel;
using System.Collections;
using UnityEngine;

public class week3 : MonoBehaviour
{
    private void Awake()
    {
        //컬렉션 자료구조는 선언한 변수에 메모리를 할당해야 사용할 수 있다.
        ArrayList arrayList = new ArrayList();
        

        //요소에 접근할 때는 첨자 연산자 []를 이용한다.
        //object 타입이기 때문에 여러 종류의 데이터 저장 가능
        Debug.Log(arrayList.Add(0));

        //데이터 출력
        PrintArrayList(arrayList);

        //요소 추가(원하는 위치)
        ArrayList.Insert(1, 100);

        PrintArrayList(arrayList);

        //요소 추가(범위, ICollection)
        Collection<int> data = new Collection<int>();
        data.Add(1);
        data.Add(3);
        data.Add(2);
        arrayList.AddRange(data);

        //데이터 출력
        PrintArrayList(arrayList);

        //데이터 오름차순 정렬 (ArrayList에 정수 데이터만 있을 때 한정으로 사용 가능)
        //그 외 데이터가 들어있을 경우 에러 발생
        arrayList.Sort();

        //요소 삭제(매개변수에 입력된 데이터)
        arrayList.Remove(10);

        //요소 삭제(매개변수에 입력된 위치 요소)
        arrayList.RemoveAt(0);

        //요소 삭제(첫 번째 매개변수 위치부터 두 번째 매개변수 개수만큼 삭제)
        arrayList.RemoveRange(0, 2);

        //모든 요소 삭제
        arrayList.Clear();

        //요소 개수 출력
        Debug.Log(arrayList.Count); 
    }

}
