using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityUI : MonoBehaviour
{
    // 사용자 인터페이스(User Interface)
    // 유저가 프로그램과 의사소통을 할 수 있도록 만든 매개체
    // 버튼, 스크롤, 텍스트 등 소프트웨어적으로 유니티와 사용작용 할 수 있는 수단

    // <캔버스>
    // UI 요소들을 가지고 있는 UI 구성들
    // 모든 UI 요소는 캔버스 안에 위치해야함
    // 위치가 겹칠 경우 나중에 그려지는 UI 요소가 이전 UI 요소를 덮어씀

    // <Event System>
    // 키보드, 마우스, 터치, 커스텀 입력 등 입력 기반 어플리케이션의 오브젝트에 이벤트를 전송하는 방법
    // UI를 추가하는 경우 자동으로 씬에 포함되지만, 런타임 당시에 UI를 생성하는 경우에 주의

    // <UI 컴포넌트>
    // 비주얼 컴포넌트 : 정보 표시만을 위한 컴포넌트(텍스트, 이미지, 등)
    // 상호작용 컴포넌트 : 마우스 및 터치 이벤트 등을 사용하여 이루어지는 상호작용을 처리하는 UI 시스템의 컴포넌트
    // 상호작용 컴포넌트 자체가 사용자에게 보여지지 않으므로, 하나 이상의 비주얼 컴포넌트와 결합하여 사용
    // (버튼, 토글, 토글 그룹, 슬라이더, 스크롤바, 드롭다운, 입력필드, 스크롤뷰 등)
    // 입력 이벤트를 감지하기 위해서 게임씬 내에 Event System 컴포넌트가 필요함

    // <기본 레이아웃>
    // Rect Transform : UI 컴포넌트의 기본 구성요소로 일반 Transform 컴포넌트 대신 사용됨
    // Rect Transform은 Transform을 상속한 서브클래스로 Transform의 모든 기능이 있음
    // 추가적으로 사각형의 크기를 지정하기 위한 폭, 높이, UI의 구성인 앵커, 피벗이 있음
    // 앵커(Anchor) : 자식컴포넌트의 부모 상대위치의 설정 기준 적용
    // 피벗(Pivot) : 위치, 회전, 크기의 중심 위치
}
