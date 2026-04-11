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

GiftBox[] giftBoxes = new GiftBox[3];
giftBoxes[0] = AddressA;
giftBoxes[1] = AddressB;
giftBoxes[2] = AddressC;
// giftBoxes[3] = AddressD; // 에러 발생
Console.WriteLine(giftBoxes.Length);

GiftBox[] giftBoxes2 = { AddressA, AddressB, AddressC, AddressD, AddressE };
Console.WriteLine(giftBoxes2.Length);



GiftBox GiftBoxMaker(string letter, int money)
{
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


