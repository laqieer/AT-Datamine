// Decompiled with JetBrains decompiler
// Type: StaqData.Expendable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Network.Param;
using Scenes.OutGame;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002035")]
  public sealed class Expendable : Item
  {
    [Token(Token = "0x4008915")]
    [FieldOffset(Offset = "0x28")]
    private ExpendablesData baseData;

    [Token(Token = "0x17002856")]
    public ExpendablesData MasterData
    {
      [Token(Token = "0x600C0EA"), Address(RVA = "0x201185C", Offset = "0x201185C", VA = "0x201185C")] get
      {
        return (ExpendablesData) null;
      }
    }

    [Token(Token = "0x17002857")]
    public override string Name
    {
      [Token(Token = "0x600C0EB"), Address(RVA = "0x2011930", Offset = "0x2011930", VA = "0x2011930", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002858")]
    public override ItemTypeEnum ItemType
    {
      [Token(Token = "0x600C0EC"), Address(RVA = "0x201194C", Offset = "0x201194C", VA = "0x201194C", Slot = "5")] get
      {
        return new ItemTypeEnum();
      }
    }

    [Token(Token = "0x17002859")]
    public override RarityTypeEnum Rarity
    {
      [Token(Token = "0x600C0ED"), Address(RVA = "0x2011968", Offset = "0x2011968", VA = "0x2011968", Slot = "6")] get
      {
        return new RarityTypeEnum();
      }
    }

    [Token(Token = "0x1700285A")]
    public override bool IsSellable
    {
      [Token(Token = "0x600C0EE"), Address(RVA = "0x2011984", Offset = "0x2011984", VA = "0x2011984", Slot = "7")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600C0EF")]
    [Address(RVA = "0x20119A0", Offset = "0x20119A0", VA = "0x20119A0")]
    private Expendable()
    {
    }

    [Token(Token = "0x600C0F0")]
    [Address(RVA = "0x20119A8", Offset = "0x20119A8", VA = "0x20119A8")]
    public void Apply(PlayerExpendableType entity)
    {
    }

    [Token(Token = "0x600C0F1")]
    [Address(RVA = "0x20119C4", Offset = "0x20119C4", VA = "0x20119C4")]
    public static Expendable CreateByServerData(PlayerExpendableType entity) => (Expendable) null;

    [Token(Token = "0x600C0F2")]
    [Address(RVA = "0x2011A74", Offset = "0x2011A74", VA = "0x2011A74")]
    public static Expendable CreateByDummyData(int id) => (Expendable) null;

    [Token(Token = "0x600C0F3")]
    [Address(RVA = "0x2011B64", Offset = "0x2011B64", VA = "0x2011B64")]
    public static Expendable CreateByMasterData(ExpendablesData data) => (Expendable) null;

    [Token(Token = "0x600C0F4")]
    [Address(RVA = "0x2011C44", Offset = "0x2011C44", VA = "0x2011C44")]
    public ItemListData GetItemListData(ItemUtility.Parameter parameter) => (ItemListData) null;
  }
}
