// Decompiled with JetBrains decompiler
// Type: StaqData.RuntimeDataValueGetter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Scenes.OutGame;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002083")]
  public class RuntimeDataValueGetter
  {
    [Token(Token = "0x600C4B0")]
    [Address(RVA = "0x19FB3A8", Offset = "0x19FB3A8", VA = "0x19FB3A8")]
    public int Get(PaymentTypeEnum type, int id) => new int();

    [Token(Token = "0x600C4B1")]
    [Address(RVA = "0x19FC57C", Offset = "0x19FC57C", VA = "0x19FC57C")]
    public int Get(RewardTypeEnum type, int id) => new int();

    [Token(Token = "0x600C4B2")]
    [Address(RVA = "0x19FC8B0", Offset = "0x19FC8B0", VA = "0x19FC8B0")]
    public PossessionAmountInfo GetPossessionAmountInfo(int amount) => new PossessionAmountInfo();

    [Token(Token = "0x600C4B3")]
    [Address(RVA = "0x19FC8BC", Offset = "0x19FC8BC", VA = "0x19FC8BC")]
    public PossessionAmountInfo GetPossessionAmountInfo(ItemTypeEnum type, int id)
    {
      return new PossessionAmountInfo();
    }

    [Token(Token = "0x600C4B4")]
    [Address(RVA = "0x19FC8F0", Offset = "0x19FC8F0", VA = "0x19FC8F0")]
    public PossessionAmountInfo GetPossessionAmountInfo(RewardTypeEnum type, int id)
    {
      return new PossessionAmountInfo();
    }

    [Token(Token = "0x600C4B5")]
    [Address(RVA = "0x19FC924", Offset = "0x19FC924", VA = "0x19FC924")]
    public PossessionAmountInfo GetPossessionAmountInfo(PaymentTypeEnum type, int id)
    {
      return new PossessionAmountInfo();
    }

    [Token(Token = "0x600C4B6")]
    [Address(RVA = "0x19FC4D4", Offset = "0x19FC4D4", VA = "0x19FC4D4")]
    public int GetGeneralItem(int id) => new int();

    [Token(Token = "0x600C4B7")]
    [Address(RVA = "0x19FC71C", Offset = "0x19FC71C", VA = "0x19FC71C")]
    public int GetUnit(int id) => new int();

    [Token(Token = "0x600C4B8")]
    [Address(RVA = "0x19FB774", Offset = "0x19FB774", VA = "0x19FB774")]
    public int Get(ItemTypeEnum type, int id) => new int();

    [Token(Token = "0x600C4B9")]
    [Address(RVA = "0x19FC958", Offset = "0x19FC958", VA = "0x19FC958")]
    public int GetValue(ConditionTypeEnum type, int id) => new int();

    [Token(Token = "0x600C4BA")]
    [Address(RVA = "0x19FB628", Offset = "0x19FB628", VA = "0x19FB628")]
    private int GetCurrencyAmount(int id) => new int();

    [Token(Token = "0x600C4BB")]
    [Address(RVA = "0x19FCA30", Offset = "0x19FCA30", VA = "0x19FCA30")]
    public int GetCurrencyChapterCoinAmount() => new int();

    [Token(Token = "0x600C4BC")]
    [Address(RVA = "0x19FCA3C", Offset = "0x19FCA3C", VA = "0x19FCA3C")]
    public int GetCurrencyZenyAmount() => new int();

    [Token(Token = "0x600C4BD")]
    [Address(RVA = "0x19FCA48", Offset = "0x19FCA48", VA = "0x19FCA48")]
    public PossessionAmountInfo GetCurrencyZenyPossessionAmountInfo() => new PossessionAmountInfo();

    [Token(Token = "0x600C4BE")]
    [Address(RVA = "0x19FCA7C", Offset = "0x19FCA7C", VA = "0x19FCA7C")]
    public List<ItemListData> GetNurturingMaterialSaleList() => (List<ItemListData>) null;

    [Token(Token = "0x600C4BF")]
    [Address(RVA = "0x19FD954", Offset = "0x19FD954", VA = "0x19FD954")]
    public int GetAp() => new int();

    [Token(Token = "0x600C4C0")]
    [Address(RVA = "0x19FD960", Offset = "0x19FD960", VA = "0x19FD960")]
    public int GetEp(int itemId) => new int();

    [Token(Token = "0x600C4C1")]
    [Address(RVA = "0x19F8960", Offset = "0x19F8960", VA = "0x19F8960")]
    public RuntimeDataValueGetter()
    {
    }
  }
}
