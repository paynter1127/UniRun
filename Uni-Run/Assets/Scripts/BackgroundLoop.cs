using UnityEngine;

// 왼쪽 끝으로 이동한 배경을 오른쪽 끝으로 재배치하는 스크립트
public class BackgroundLoop : MonoBehaviour {
    private float width; // 배경의 가로 길이

    private void Awake() {
        // 가로 길이를 측정하는 처리
        //BoxCollider2D backgroundCollider = GetComponent<BoxCollider2D>();
        //width = backgroundCollider.size.x;
        //Debug.Log("콜라이더로 x 사이즈 : " + width);
        //Debug.Log("콜라이더로 y 사이즈 : " + backgroundCollider.size.y);
        //SpriteRenderer d = GetComponent<SpriteRenderer>();
        width = GetComponent<SpriteRenderer>().size.x;
        //Debug.Log("스프라이트렌더러로 x 사이즈 : " + width);
        //Debug.Log("스프라이트렌더러로 y 사이즈 : " + d.size.y);
    }

    private void Update() {
        // 현재 위치가 원점에서 왼쪽으로 width 이상 이동했을때 위치를 리셋
        if (transform.position.x <= -width) Reposition();
    }

    // 위치를 리셋하는 메서드
    private void Reposition() {
        Vector2 offset = new Vector2(width * 2f, 0);
        transform.position = (Vector2)transform.position + offset;
        
    }
}