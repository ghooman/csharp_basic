using System.Text;

Console.WriteLine("시작 부분!");

// int money = 10000;
// float floatMoney = 10.0f;
// double doubleMoney = 20.0d;
// string letter = "안녕 나야";

// // int money -> string letter
// letter = money.ToString();
// letter = money + "";

// // float floatMoney -> double doubleMoney
// doubleMoney = floatMoney;

// //double doubleMoney -> float floatMoney
// floatMoney = (float)doubleMoney; // 문제 발생 소지 큼

// // string letter -> int money
// // money = int.Parse(letter); // 안전하지 않음
// int.TryParse(letter, out money); // letter 가 안되면 초기값이 들어감, 안전. 

// double value = 30.0 + 10.1f; // 더블 쪽으로 변환됨
// float value2 = 30.0 + 10.1f; // 플롯이라서 더블로 변환된 값이 들어갈수 없음 에러.


// // value type (값 타입), reference type (참조 타입)

// // [Stack]
// // value type (primitive type)
// int aPersonMoney = 10000;
// int bPersonMoney = aPersonMoney;

// aPersonMoney = 20000;


// // [Heap] GC
// // reference type
// GiftBox aPersonGiftBox = new GiftBox()
// {
//   Letter = "안녕",
//   Money = 10000,
// };

// GiftBox bPersonGiftBox = aPersonGiftBox;
// bPersonGiftBox.Money = 20000;

// // string
// string letter = "안녕"; // reference type
// string otherLetter = letter;
// letter = "안녕2";

// int money = 10000;
// GiftBoxInfo giftBoxInfo = SetMoney(money);
// money = giftBoxInfo.Money;

// GiftBox giftBox = new()
// { Money = 10000, };
// SetGiftBox(giftBox);


// // call by value
// static GiftBoxInfo SetMoney(int money)
// {
//   GiftBoxInfo giftBoxInfo = new();
//   giftBoxInfo.Money = 50000;
//   return giftBoxInfo;
// }

// // call by reference
// static void SetGiftBox(GiftBox info)
// {
//   info.Money = 50000;
// }

// class GiftBoxInfo
// {
//   public int Money;
// }

// Contains, Replace, Trim, ToLower, SubString, IndexOf, Split
// string letter = " 친구야 잘 지내니? ";
// bool isContains = letter.Contains("지내");
// Console.WriteLine("Contains : " + isContains);

// string replace = letter.Replace("친구", "문송이야");
// Console.WriteLine("Replace : " + replace);

// string trim = letter.Trim();
// Console.WriteLine("Trim : " + trim);

// string letterEn = "Hi my friend";
// string toLower = letterEn.ToLower();
// string toUpper = letterEn.ToUpper();
// Console.WriteLine("ToLower : " + toLower);
// Console.WriteLine("ToUpper : " + toUpper);

// string substring = letter.Substring(0, 3);
// string substring2 = letter[2..3];

// Console.WriteLine("Substring : " + substring);
// Console.WriteLine("Substring2 : " + substring2);

// int indexOf = letter.IndexOf("잘");
// Console.WriteLine("IndexOf : " + indexOf);

// string friends = "재현,호민,재호/여진,민재,호동";
// // 0 재현,호민,재호
// // 1 여진,민재,호동
// string[] arrGroup = friends.Split('/');
// foreach (var item in arrGroup)
// {
//   Console.WriteLine(item);
//   string[] arrFriend = item.Split(',');
//   Console.WriteLine("Split:");
//   // 0 재현
//   // 1 호민
//   // 2 재호
//   // 0 여진
//   // 1 민재
//   // 2 호동
//   foreach (var friend in arrFriend)
//   {
//     Console.WriteLine(friend);
//   }
// }


// string.format, toString(), $, +, StringBuilder
// ㄴ string.format (반올림, 통화 표시, 1의자리 앞에 0표시, 천의 자리 콤마 표시, 절대 값 표시)

// string name = "민아";
// int point = 3000;

// Console.WriteLine(name + "고객님, 적립금 " + point + "원 있으십니다.");
// Console.WriteLine(string.Format("{0}고객님, 적립금 {1}원 있으십니다.", name, point));
// Console.WriteLine($"{name}고객님, 적립금 {point}원 있으십니다.");

// double sPoint = 234.239;
// Console.WriteLine(Math.Round(sPoint, 2));
// Console.WriteLine(string.Format("{0:0.00}", sPoint));

// Console.WriteLine(string.Format("{0:C}", sPoint));
// string point2 = string.Format("{0:C}", sPoint);
// Console.WriteLine(point2.Replace(point2.Substring(0, 1), point2.Substring(0, 1) + " "));

// Console.WriteLine(string.Format("{0:D2}", 3));

// Console.WriteLine(string.Format("{0:N0}", 123123123));

// Console.WriteLine(Math.Abs(-123123123));
// Console.WriteLine((int)-123123.123);

// Console.WriteLine(123123123.ToString("N0"));

// // + 로 붙이기 (간단, 적을 때 OK)
// Console.WriteLine(name + "고객님, 적립금 " + point + "원 있으십니다.");

// // StringBuilder 로 이어붙이기 (많이 붙일 때 빠름)
// StringBuilder sb = new();
// sb.Append(name);
// sb.Append("고객님, 적립금 ");
// sb.Append(point.ToString());
// sb.Append("원 있으십니다.");
// Console.WriteLine(sb.ToString());


// 데이터 표현 - 날짜와 시간 가공
// Local, Utc, toLocal, toUtc, ToTimeStamp, ToLocal, 원하는 형식 출력, DateTime에 시간 더하기 빼기, hour, day, DateTime끼리 빼기

// local (내 컴퓨터 지역 시간)
Console.WriteLine("Local: " + DateTime.Now);

// Utc (세계 표준시)
Console.WriteLine("Utc: " + DateTime.UtcNow);

// toLocal (Utc 시간을 내 지역 시간으로 변환)
DateTime dateTime = DateTime.UtcNow;
Console.WriteLine("toLocal: " + dateTime.ToLocalTime());
Console.WriteLine("toLocal: " + DateTime.UtcNow.ToLocalTime());

// toUtc
Console.WriteLine("toUtc: " + DateTime.Now.ToUniversalTime());

// ToTimeStamp
DateTimeOffset dateTimeOffset = DateTimeOffset.UtcNow;
Console.WriteLine("ToTimeStamp: " + dateTimeOffset.ToUnixTimeSeconds());
Console.WriteLine("ToTimeStamp: " + dateTimeOffset.ToUnixTimeMilliseconds());

// ToLocal
Console.WriteLine("ToLocal: " + DateTimeOffset.FromUnixTimeSeconds(dateTimeOffset.ToUnixTimeSeconds()));
Console.WriteLine("ToLocal: " + DateTimeOffset.FromUnixTimeSeconds(dateTimeOffset.ToUnixTimeSeconds()).ToLocalTime());

// 원하는 형식 출력
Console.WriteLine("원하는 형식 출력: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss z"));


// DateaTime에 시간 더하기 빼기
Console.WriteLine(DateTime.Now.AddHours(3));
Console.WriteLine(DateTime.Now.AddHours(-3));

Console.WriteLine(DateTime.Now.Hour);
Console.WriteLine(DateTime.Now.Minute);
Console.WriteLine(DateTime.Now.DayOfWeek);

// DateTime끼리 빼기
TimeSpan timeSpan = DateTime.Now - DateTime.Now.AddHours(232);
Console.WriteLine("DateTime끼리 빼기: " + timeSpan.Hours); // 24시간이 넘어가는 값을 생략
Console.WriteLine("DateTime끼리 빼기: " + timeSpan.TotalHours);


// 산술연산자의 형변환 (+, -,*,/,%), 증감 연산자(x++, ++x)
// 1. 산술연산자의 형변환 (+, -,*,/,%)
// a 정수 + 실수 연산
var value = 1 + 2.3f; // 정수와 실수 연산에서는 실수 위주로 연산이 된다.
Console.WriteLine("정수 + 실수 연산: " + value);

// b 실수 끼리 연산
var value2 = 1.3f + 2.3d; // 실수의 연산에서는 큰 형식으로 자동 형변환 됨.
Console.WriteLine("실수 끼리 연산: " + value2);

// c 숫자 + 문자 연산
Console.WriteLine("숫자 + 문자 연산: " + (1 + "문자")); // 숫자는 문자로 자동 형변환 됨.

// d / 나눗셈의 목표
int value3 = 10 / 3; // 정수끼리 나누면 정수 형식으로 나옴(몫만 나옴)
Console.WriteLine(value3);
var value4 = 10 / 3f; // 실수 형식으로 계산 됨.
Console.WriteLine(value4);

// e % 나머지 구하기
Console.WriteLine("나머지 구하기: " + 6 % 5);

// f 연산자 우선순위
Console.WriteLine("연산자 우선순위: " + (2 + 5 * 4));

// 2. 증감 연산자(x++, ++x)
var value5 = 10;
// value5 = value5 + 1;
++value5;

Console.WriteLine(value5);

int index = 0;
int[] arr = { 100, 200, 300 };
Console.WriteLine(arr[index++]);
Console.WriteLine(arr[index++]);
Console.WriteLine(arr[index++]);



// 관계 연산자(==, !=, >=, >), 논리연산자 (||, &&), 부정연산자 !, 할당연산자 +=
// 1. 관계 연산자
// a ==   두 값이 같으면 true
Console.WriteLine(3 == 3);
// b !=   두 값이 다르면 true
Console.WriteLine(3 != 5);
// c >=, <=   크거나같다 / 작거나같다
Console.WriteLine(5 >= 5);
Console.WriteLine(3 <= 2);
// 2. 논리연산자
// a &&   둘 다 true여야 true
Console.WriteLine(true && false);
// b ||   하나라도 true면 true
Console.WriteLine(true || false);
// 3. 부정연산자 !   true/false를 반대로 뒤집음
Console.WriteLine(!true);
// 4. 할당연산자 +=   기존 값에 더해서 다시 저장
int score = 100;
score += 50;
Console.WriteLine(score);
