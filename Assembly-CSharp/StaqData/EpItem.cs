// Decompiled with JetBrains decompiler
// Type: StaqData.EpItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Network.Param;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002016")]
  public sealed class EpItem : Item
  {
    [Token(Token = "0x40088A0")]
    [FieldOffset(Offset = "0x28")]
    private EpItemData baseData;

    [Token(Token = "0x170027C3")]
    public EpItemData MasterData
    {
      [Token(Token = "0x600BF35"), Address(RVA = "0x2005E00", Offset = "0x2005E00", VA = "0x2005E00")] get
      {
        return (EpItemData) null;
      }
    }

    [Token(Token = "0x170027C4")]
    public override string Name
    {
      [Token(Token = "0x600BF36"), Address(RVA = "0x2005ED4", Offset = "0x2005ED4", VA = "0x2005ED4", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170027C5")]
    public override ItemTypeEnum ItemType
    {
      [Token(Token = "0x600BF37"), Address(RVA = "0x2005EF0", Offset = "0x2005EF0", VA = "0x2005EF0", Slot = "5")] get
      {
        return new ItemTypeEnum();
      }
    }

    [Token(Token = "0x170027C6")]
    public override RarityTypeEnum Rarity
    {
      [Token(Token = "0x600BF38"), Address(RVA = "0x2005F0C", Offset = "0x2005F0C", VA = "0x2005F0C", Slot = "6")] get
      {
        return new RarityTypeEnum();
      }
    }

    [Token(Token = "0x170027C7")]
    public override bool IsSellable
    {
      [Token(Token = "0x600BF39"), Address(RVA = "0x2005F28", Offset = "0x2005F28", VA = "0x2005F28", Slot = "7")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600BF3A")]
    [Address(RVA = "0x2005F44", Offset = "0x2005F44", VA = "0x2005F44")]
    private EpItem()
    {
    }

    [Token(Token = "0x600BF3B")]
    [Address(RVA = "0x2005F4C", Offset = "0x2005F4C", VA = "0x2005F4C")]
    public void Apply(PlayerEpType entity)
    {
    }

    [Token(Token = "0x600BF3C")]
    [Address(RVA = "0x2005F68", Offset = "0x2005F68", VA = "0x2005F68")]
    public static EpItem CreateByServerData(PlayerEpType entity) => (EpItem) null;
  }
}
