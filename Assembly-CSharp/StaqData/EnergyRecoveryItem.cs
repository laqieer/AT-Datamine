// Decompiled with JetBrains decompiler
// Type: StaqData.EnergyRecoveryItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Network.Param;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002015")]
  public sealed class EnergyRecoveryItem : Item
  {
    [Token(Token = "0x400889F")]
    [FieldOffset(Offset = "0x28")]
    private EnergyRecoveryData baseData;

    [Token(Token = "0x170027BE")]
    public EnergyRecoveryData MasterData
    {
      [Token(Token = "0x600BF2D"), Address(RVA = "0x2005BB8", Offset = "0x2005BB8", VA = "0x2005BB8")] get
      {
        return (EnergyRecoveryData) null;
      }
    }

    [Token(Token = "0x170027BF")]
    public override string Name
    {
      [Token(Token = "0x600BF2E"), Address(RVA = "0x2005C8C", Offset = "0x2005C8C", VA = "0x2005C8C", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170027C0")]
    public override ItemTypeEnum ItemType
    {
      [Token(Token = "0x600BF2F"), Address(RVA = "0x2005CA8", Offset = "0x2005CA8", VA = "0x2005CA8", Slot = "5")] get
      {
        return new ItemTypeEnum();
      }
    }

    [Token(Token = "0x170027C1")]
    public override RarityTypeEnum Rarity
    {
      [Token(Token = "0x600BF30"), Address(RVA = "0x2005CC4", Offset = "0x2005CC4", VA = "0x2005CC4", Slot = "6")] get
      {
        return new RarityTypeEnum();
      }
    }

    [Token(Token = "0x170027C2")]
    public override bool IsSellable
    {
      [Token(Token = "0x600BF31"), Address(RVA = "0x2005CE0", Offset = "0x2005CE0", VA = "0x2005CE0", Slot = "7")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600BF32")]
    [Address(RVA = "0x2005CFC", Offset = "0x2005CFC", VA = "0x2005CFC")]
    private EnergyRecoveryItem()
    {
    }

    [Token(Token = "0x600BF33")]
    [Address(RVA = "0x2005D04", Offset = "0x2005D04", VA = "0x2005D04")]
    public void Apply(PlayerRecoveryItemType entity)
    {
    }

    [Token(Token = "0x600BF34")]
    [Address(RVA = "0x2005D20", Offset = "0x2005D20", VA = "0x2005D20")]
    public static EnergyRecoveryItem CreateByServerData(PlayerRecoveryItemType entity)
    {
      return (EnergyRecoveryItem) null;
    }
  }
}
