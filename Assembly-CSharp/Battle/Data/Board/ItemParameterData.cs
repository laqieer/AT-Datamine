// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.ItemParameterData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x20027F0")]
  public class ItemParameterData : IItemData
  {
    [Token(Token = "0x400A9E4")]
    public const int DefaultConsumeValue = 1;

    [Token(Token = "0x170035F8")]
    public int Id
    {
      [Token(Token = "0x600F96B"), Address(RVA = "0x44C217C", Offset = "0x44C217C", VA = "0x44C217C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170035F9")]
    public ItemData Data
    {
      [Token(Token = "0x600F96C"), Address(RVA = "0x44C21A0", Offset = "0x44C21A0", VA = "0x44C21A0")] get
      {
        return (ItemData) null;
      }
      [Token(Token = "0x600F96D"), Address(RVA = "0x44C21A8", Offset = "0x44C21A8", VA = "0x44C21A8")] private set
      {
      }
    }

    [Token(Token = "0x170035FA")]
    public int InitialAmount
    {
      [Token(Token = "0x600F96E"), Address(RVA = "0x44C21B0", Offset = "0x44C21B0", VA = "0x44C21B0")] get
      {
        return new int();
      }
      [Token(Token = "0x600F96F"), Address(RVA = "0x44C21B8", Offset = "0x44C21B8", VA = "0x44C21B8")] private set
      {
      }
    }

    [Token(Token = "0x170035FB")]
    public int Amount
    {
      [Token(Token = "0x600F970"), Address(RVA = "0x44C21C0", Offset = "0x44C21C0", VA = "0x44C21C0", Slot = "6")] get
      {
        return new int();
      }
      [Token(Token = "0x600F971"), Address(RVA = "0x44C21C8", Offset = "0x44C21C8", VA = "0x44C21C8")] private set
      {
      }
    }

    [Token(Token = "0x170035FC")]
    public SkillParameterData ItemSkillParam
    {
      [Token(Token = "0x600F972"), Address(RVA = "0x44C21D0", Offset = "0x44C21D0", VA = "0x44C21D0")] get
      {
        return (SkillParameterData) null;
      }
      [Token(Token = "0x600F973"), Address(RVA = "0x44C21D8", Offset = "0x44C21D8", VA = "0x44C21D8")] private set
      {
      }
    }

    [Token(Token = "0x600F974")]
    [Address(RVA = "0x44C21E0", Offset = "0x44C21E0", VA = "0x44C21E0")]
    public static ItemParameterData Create(
      ItemData item,
      int amount,
      SkillParameterData itemSkillParam)
    {
      return (ItemParameterData) null;
    }

    [Token(Token = "0x600F975")]
    [Address(RVA = "0x44C22CC", Offset = "0x44C22CC", VA = "0x44C22CC")]
    public static ItemParameterData Create(
      ItemData item,
      int initialAmount,
      int amount,
      SkillParameterData itemSkillParam)
    {
      return (ItemParameterData) null;
    }

    [Token(Token = "0x600F976")]
    [Address(RVA = "0x44C22F0", Offset = "0x44C22F0", VA = "0x44C22F0")]
    public void Consume(int value = 1)
    {
    }

    [Token(Token = "0x170035FD")]
    public int ConsumeAmount
    {
      [Token(Token = "0x600F977"), Address(RVA = "0x44C2364", Offset = "0x44C2364", VA = "0x44C2364")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170035FE")]
    public ExpendablesData MasterData
    {
      [Token(Token = "0x600F978"), Address(RVA = "0x44C2370", Offset = "0x44C2370", VA = "0x44C2370")] get
      {
        return (ExpendablesData) null;
      }
    }

    [Token(Token = "0x170035FF")]
    public ItemTypeEnum ItemType
    {
      [Token(Token = "0x600F979"), Address(RVA = "0x44C238C", Offset = "0x44C238C", VA = "0x44C238C", Slot = "4")] get
      {
        return new ItemTypeEnum();
      }
    }

    [Token(Token = "0x17003600")]
    public int ItemId
    {
      [Token(Token = "0x600F97A"), Address(RVA = "0x44C23A8", Offset = "0x44C23A8", VA = "0x44C23A8", Slot = "5")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003601")]
    public int MaxAmount
    {
      [Token(Token = "0x600F97B"), Address(RVA = "0x44C22A8", Offset = "0x44C22A8", VA = "0x44C22A8", Slot = "7")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003602")]
    public string Name
    {
      [Token(Token = "0x600F97C"), Address(RVA = "0x44C23CC", Offset = "0x44C23CC", VA = "0x44C23CC", Slot = "8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600F97D")]
    [Address(RVA = "0x44C23F0", Offset = "0x44C23F0", VA = "0x44C23F0")]
    public string ToJson() => (string) null;

    [Token(Token = "0x600F97E")]
    [Address(RVA = "0x44C22A0", Offset = "0x44C22A0", VA = "0x44C22A0")]
    public ItemParameterData()
    {
    }
  }
}
