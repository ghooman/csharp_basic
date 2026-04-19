class GiftBoxManager
{
  // 시작점
  public void SetInit()
  {
    GiftBox AddressA = GiftBoxMaker("A 친구야 잘 지내니?", 100000, ITEM_GRADE.NORMAL);
    GiftBox AddressB = GiftBoxMaker("B 친구야 잘 지내니?", 200000, ITEM_GRADE.RARE);
    GiftBox AddressC = GiftBoxMaker("C 친구야 잘 지내니?", 300000, ITEM_GRADE.UNIQUE);
    GiftBox AddressD = GiftBoxMaker("D 친구야 잘 지내니?", 400000, ITEM_GRADE.NORMAL);
    GiftBox AddressE = GiftBoxMaker("E 친구야 잘 지내니?", 500000, ITEM_GRADE.RARE);
  }

  // 함수 생성
  private GiftBox GiftBoxMaker(string letter, int money, ITEM_GRADE iTEM_GRADE)
  {
    // 인스턴스 생성
    GiftBox Box = new()
    {
      Letter = letter,
      Money = money,
      Grade = iTEM_GRADE
    };

    return Box;
  }

}