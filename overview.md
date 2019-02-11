# Getting Started

K-Studio 2.0 은 영림원 ERP에서 제공되는 모든 프로그램 화면을 구현할 수 있는 디자인, 이벤트, 데이터 통신을 구성할 수 있도록 지원하는 개발 도구 이다.

## K-Studio 2.0 설치

* K-Studio 2.0은 기본적인 ERP 설치를 진행한 경우 설치경로의 bin 폴더에 아래와 같이 실행 파일이 생성되게 되어있다.

![](/path/to/DevTools.JPG)

## C#구문

```csharp

public string getText(object Control)
{
  return Control.Text;
}
```

## IO 테이블 예시
* `Input Data`

    데이터 블록 | 항목명 | 항목ID | 데이터 유형 | 자리수 | 소수점
    -----------|--------|-------|------------|--------|------
    DataBlock1 | 부서코드 | DeptSeq | INT | 0 | 0
* `Output Data`

    데이터 블록 | 항목명 | 항목ID | 데이터 유형 | 자리수 | 소수점
    -----------|--------|-------|------------|--------|------
    DataBlock1 | 부서명 | DeptName | NVARCHAR | 100 | 0
