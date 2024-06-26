using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityCamera : MonoBehaviour
{
    // 카메라
    // 게임월드를 플레이어에게 보여주는 장치
    // 하나의 씬에 카메라를 원하는 만큼 추가할 수 있음
    // 카메라가 랜더링하는 순서와 화면의 위치를 설정하며, 일부만 랜더링하도록 설정 가능

    // <주요 속성>
    // Clear Flags : 화면의 그려지지 않은 부분을 비울 방법을 선택
    // Background : 스카이박스가 없을 경우 여백 화면에 적용할 색상
    // Culling Mask : 카메라가 랜더링할 오브젝트의 레이어 선택
    // Projection : 카메라의 원근감 설정
    //  Perspective : 카메라의 원근감 적용
    //  Orthographic : 카메라의 원근감 없이 적용
    // Clipping Planes : 랜더닝을 시작 및 중지하기 위한 카메라부터의 거리
    // Viewport Rect : 카메라 뷰가 드로우될 화면의 위치를 나타내는 사각형

    // <시네머신 패키지>
    // 카메라의 촬영위치를 선정하기 위한 기능이 구현된 패키지
    // 시네머신 브레인 : 카메라에 부착되어 있으며 가장 우선순위가 높은 시네머신(촬영장소)으로 당겨짐
    // 시네머신 : 촬영장소이자 이동방법, 촬영대상, 기타 효과에 대해 정의
}
