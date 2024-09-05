// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.UnitDetail.AbilityBoard.ItemData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Scenes.OutGame.UnitDetail.AbilityBoard
{
  [Token(Token = "0x2003329")]
  public class ItemData
  {
    [Token(Token = "0x400DD51")]
    [FieldOffset(Offset = "0x1C")]
    public int MoldType;

    [Token(Token = "0x1700435D")]
    public int NeedAmount
    {
      [Token(Token = "0x60141B9"), Address(RVA = "0x20C7ECC", Offset = "0x20C7ECC", VA = "0x20C7ECC")] get
      {
        return new int();
      }
      [Token(Token = "0x60141BA"), Address(RVA = "0x20C7ED4", Offset = "0x20C7ED4", VA = "0x20C7ED4")] private set
      {
      }
    }

    [Token(Token = "0x1700435E")]
    public int ItemID
    {
      [Token(Token = "0x60141BB"), Address(RVA = "0x20C7EDC", Offset = "0x20C7EDC", VA = "0x20C7EDC")] get
      {
        return new int();
      }
      [Token(Token = "0x60141BC"), Address(RVA = "0x20C7EE4", Offset = "0x20C7EE4", VA = "0x20C7EE4")] private set
      {
      }
    }

    [Token(Token = "0x1700435F")]
    public int ItemAmount
    {
      [Token(Token = "0x60141BD"), Address(RVA = "0x20C7EEC", Offset = "0x20C7EEC", VA = "0x20C7EEC")] get
      {
        return new int();
      }
      [Token(Token = "0x60141BE"), Address(RVA = "0x20C7EF4", Offset = "0x20C7EF4", VA = "0x20C7EF4")] set
      {
      }
    }

    [Token(Token = "0x60141BF")]
    [Address(RVA = "0x20C7EFC", Offset = "0x20C7EFC", VA = "0x20C7EFC")]
    public void SetData(int itemID, int needAmount, int moldType = 0)
    {
    }

    [Token(Token = "0x60141C0")]
    [Address(RVA = "0x20BBD50", Offset = "0x20BBD50", VA = "0x20BBD50")]
    public void AddNeedAmount(int needAmount)
    {
    }

    [Token(Token = "0x60141C1")]
    [Address(RVA = "0x20C7FBC", Offset = "0x20C7FBC", VA = "0x20C7FBC")]
    public ItemData()
    {
    }
  }
}
