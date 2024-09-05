// Decompiled with JetBrains decompiler
// Type: StaqData.BoxItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Network.Param;
using System;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002012")]
  public sealed class BoxItem : Item
  {
    [Token(Token = "0x4008898")]
    [FieldOffset(Offset = "0x28")]
    private BoxItemData baseData;

    [Token(Token = "0x170027A8")]
    public BoxItemData MasterData
    {
      [Token(Token = "0x600BF0B"), Address(RVA = "0x2005050", Offset = "0x2005050", VA = "0x2005050")] get
      {
        return (BoxItemData) null;
      }
    }

    [Token(Token = "0x170027A9")]
    public override string Name
    {
      [Token(Token = "0x600BF0C"), Address(RVA = "0x20050FC", Offset = "0x20050FC", VA = "0x20050FC", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170027AA")]
    public override ItemTypeEnum ItemType
    {
      [Token(Token = "0x600BF0D"), Address(RVA = "0x2005118", Offset = "0x2005118", VA = "0x2005118", Slot = "5")] get
      {
        return new ItemTypeEnum();
      }
    }

    [Token(Token = "0x170027AB")]
    public override RarityTypeEnum Rarity
    {
      [Token(Token = "0x600BF0E"), Address(RVA = "0x2005134", Offset = "0x2005134", VA = "0x2005134", Slot = "6")] get
      {
        return new RarityTypeEnum();
      }
    }

    [Token(Token = "0x170027AC")]
    public override bool IsSellable
    {
      [Token(Token = "0x600BF0F"), Address(RVA = "0x2005150", Offset = "0x2005150", VA = "0x2005150", Slot = "7")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170027AD")]
    public override bool HasExpirationDate
    {
      [Token(Token = "0x600BF10"), Address(RVA = "0x200516C", Offset = "0x200516C", VA = "0x200516C", Slot = "8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170027AE")]
    public override DateTime ExpirationBeginDate
    {
      [Token(Token = "0x600BF11"), Address(RVA = "0x2005188", Offset = "0x2005188", VA = "0x2005188", Slot = "9")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x170027AF")]
    public override DateTime ExpirationEndDate
    {
      [Token(Token = "0x600BF12"), Address(RVA = "0x20051A4", Offset = "0x20051A4", VA = "0x20051A4", Slot = "10")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x600BF13")]
    [Address(RVA = "0x20051C0", Offset = "0x20051C0", VA = "0x20051C0")]
    private BoxItem()
    {
    }

    [Token(Token = "0x600BF14")]
    [Address(RVA = "0x20051C8", Offset = "0x20051C8", VA = "0x20051C8")]
    public void Apply(PlayerBoxItemType entity)
    {
    }

    [Token(Token = "0x600BF15")]
    [Address(RVA = "0x20051E4", Offset = "0x20051E4", VA = "0x20051E4")]
    public static BoxItem CreateByServerData(PlayerBoxItemType entity) => (BoxItem) null;
  }
}
