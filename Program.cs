// See https://aka.ms/new-console-template for more information


Console.WriteLine("시작 부분!");

GiftBox AddressA = GiftBoxMaker("A 친구야 잘 지내니?", 100000);
GiftBox AddressB = GiftBoxMaker("B 친구야 잘 지내니?", 200000);
GiftBox AddressC = GiftBoxMaker("C 친구야 잘 지내니?", 300000);
GiftBox AddressD = GiftBoxMaker("D 친구야 잘 지내니?", 400000);
GiftBox AddressE = GiftBoxMaker("E 친구야 잘 지내니?", 500000);

Console.WriteLine($"{AddressA.Letter} {AddressA.Money}");
Console.WriteLine(AddressB);
Console.WriteLine(AddressC);


// 뱌열
GiftBox[] giftBoxes = new GiftBox[3];
giftBoxes[0] = AddressA;
giftBoxes[1] = AddressB;
giftBoxes[2] = AddressC;
// giftBoxes[3] = AddressD; // 에러 발생
Console.WriteLine(giftBoxes.Length);

GiftBox[] giftBoxes2 = { AddressA, AddressB, AddressC, AddressD, AddressE };
Console.WriteLine(giftBoxes2.Length);

// 리스트
List<GiftBox> giftBoxList = new List<GiftBox>();
giftBoxList.Add(AddressA);
giftBoxList.Add(AddressB);
giftBoxList.Add(AddressC);
giftBoxList.Add(AddressD);
giftBoxList.Add(AddressE);

giftBoxList[0] = AddressA;
giftBoxList[0] = AddressB;
giftBoxList[0] = AddressC;
giftBoxList[0] = AddressD;
giftBoxList[0] = AddressE;

// giftBoxList.Clear(); // 모두 지움
// giftBoxList.Remove(AddressD); // 지정 지움
Console.WriteLine(giftBoxList.Count);


// 함수 생성
GiftBox GiftBoxMaker(string letter, int money)
{
  // 인스턴스 생성
  GiftBox Box = new GiftBox()
  {
    Letter = letter,
    Money = money,
  };

  return Box;
}



class GiftBox
{
  public string Letter;
  public int Money;
}


