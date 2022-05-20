### 변수
* 변수  
  값을 저장하는 장소
  처음 1000골드를 가지고 시작하고, 200골드를 사용하는 코드
  ```csharp
  int gold = 1000;
  gold = gold - 200;
  ```
#### 변수.변수 선언하기
* 변수의 선언
  변수를 선언할 때에는 데이터의 종류를 표시해 줘야함
  ```csharp
  int gold;
  ```
  변수를 선언하는 동시에 변수를 초기화 하는 법
  ```csharp
  int gold = 1000;
  ```
* 변수의 형태
  ```csharp
  //부동 소수점 float
  float itemWeight = 1.34f;
  //불린값 bool
  bool isStoreOpen = true;
  //문자열 string
  string itemName = "포션";
  ```
---------------------------
### 함수(메서드)
* 함수
  미리 지정된 동작을 수행하는 코드 묶음  
  물체를 움직이는 기능을 제작, 상자에 적용
  ```
  //체력을 10 소모, 물제를 3m 이동
  void Move()
  {
      체력 10감소
      오브젝트 3미터 이동
      효과음 재생
  }
  ```
  나무상자와 금속상자같이 다른 오브젝트에 각각 적용이 가능
  ```
  나무상자 움직이기 : 
      Move();
  ```
  ```
  금속상자 움직이기 : 
      Move();
  ```
* 함수의 입력
  각 상자마다 필요한 체력과 이동거리를 다르게 하고 싶음  
  그러나 현재 Move();에는 10의 체력감소, 3미터의 이동이 고정되어 있기에 변경  
  함수에 입력을 사용해 변경이 가능함
  ```csharp
  void Move(int hp, int distance)
  {
      체력 hp만큼 감소
      오브젝트 distance미터 이동
      효과음 재생
  }
  ```
  ```
  나무상자 움직이기 : 
      Move(10, 3);
  ```
  ```
  금속상자 움직이기 : 
      Move(30, 1);
  ```
* 함수의 출력
  함수의 출력은 return, 반환값으로 처리결과를 반환할 수 있음
  ```csharp
  void GetRandomNumber()
  {
      int number = 0;
      number = 랜덤숫자;
      
      return number;
  }
  ```
  > return으로 전달할 데이터 타입을 미리 정해줘야 오류가 생기지 않음
  > 함수 앞에 반환값, 리턴값의 타입을 미리 표시해줘야함
  > ```csharp
  > // 반환값이 없음, void
  > void Function1();
  > // 반환값이 정수, int
  > int Function2();
  > // float, bool, int, 등 여러 데이터 타입을 사용할 수 있음
  > ```
  함수에 실행한 위치로 돌아가서 number의 값을 전달함
  ```csharp
  int randomNumber = GetRandomNumber();
  ```
  C#에서는 클래스의 함수를 메서드라고 부름
---------------------------
스크립트 작성  
코딩 규칙  
변수 연습  
함수, 메서드 연습  
제어문  
배열  
-> 유니티 프로젝트에 공부함
