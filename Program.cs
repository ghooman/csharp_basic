using System;

namespace c__basic;

class GiftBox
{
  public string Letter;
  public int Money;
}


class Program
{

  // Method
  // 1. 정리하기위해, 2. 반복을 단순히
  static void Main(string[] args)
  {
    // 선물생성 3개

    GiftBox addressA = GiftBoxMaker("A친구야 잘 지내니?", 100000);
    GiftBox addressB = GiftBoxMaker("B친구야 잘 지내니?", 200000);
    GiftBox addressC = GiftBoxMaker("C친구야 잘 지내니?", 300000);
  }

  private static GiftBox GiftBoxMaker(string letter, int money)
  {
    GiftBox address = new GiftBox()
    {
      Letter = letter,
      Money = money,
    };

    return address;
  }

}
