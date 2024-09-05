// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.MasterBonus.MovementStyleMasterBonusData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Scenes.OutGame.MasterBonus
{
  [Token(Token = "0x200352E")]
  public class MovementStyleMasterBonusData : IMasterBonusData
  {
    [Token(Token = "0x17004519")]
    public MoveTypeEnum moveType
    {
      [Token(Token = "0x6014D98"), Address(RVA = "0x1B40FA4", Offset = "0x1B40FA4", VA = "0x1B40FA4")] get
      {
        return new MoveTypeEnum();
      }
      [Token(Token = "0x6014D99"), Address(RVA = "0x1B40FAC", Offset = "0x1B40FAC", VA = "0x1B40FAC")] private set
      {
      }
    }

    [Token(Token = "0x1700451A")]
    public int Level
    {
      [Token(Token = "0x6014D9A"), Address(RVA = "0x1B40FB4", Offset = "0x1B40FB4", VA = "0x1B40FB4", Slot = "4")] get
      {
        return new int();
      }
      [Token(Token = "0x6014D9B"), Address(RVA = "0x1B40FBC", Offset = "0x1B40FBC", VA = "0x1B40FBC")] private set
      {
      }
    }

    [Token(Token = "0x1700451B")]
    public int Experience
    {
      [Token(Token = "0x6014D9C"), Address(RVA = "0x1B40FC4", Offset = "0x1B40FC4", VA = "0x1B40FC4", Slot = "5")] get
      {
        return new int();
      }
      [Token(Token = "0x6014D9D"), Address(RVA = "0x1B40FCC", Offset = "0x1B40FCC", VA = "0x1B40FCC")] private set
      {
      }
    }

    [Token(Token = "0x1700451C")]
    public int NextExperience
    {
      [Token(Token = "0x6014D9E"), Address(RVA = "0x1B40FD4", Offset = "0x1B40FD4", VA = "0x1B40FD4", Slot = "6")] get
      {
        return new int();
      }
      [Token(Token = "0x6014D9F"), Address(RVA = "0x1B40FDC", Offset = "0x1B40FDC", VA = "0x1B40FDC")] private set
      {
      }
    }

    [Token(Token = "0x1700451D")]
    public int DeltaNextExperience
    {
      [Token(Token = "0x6014DA0"), Address(RVA = "0x1B40FE4", Offset = "0x1B40FE4", VA = "0x1B40FE4", Slot = "7")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700451E")]
    public int NowLevelExperienceFrom
    {
      [Token(Token = "0x6014DA1"), Address(RVA = "0x1B40FF4", Offset = "0x1B40FF4", VA = "0x1B40FF4", Slot = "8")] get
      {
        return new int();
      }
      [Token(Token = "0x6014DA2"), Address(RVA = "0x1B40FFC", Offset = "0x1B40FFC", VA = "0x1B40FFC")] private set
      {
      }
    }

    [Token(Token = "0x1700451F")]
    public int MasterId
    {
      [Token(Token = "0x6014DA3"), Address(RVA = "0x1B41004", Offset = "0x1B41004", VA = "0x1B41004", Slot = "9")] get
      {
        return new int();
      }
      [Token(Token = "0x6014DA4"), Address(RVA = "0x1B4100C", Offset = "0x1B4100C", VA = "0x1B4100C")] private set
      {
      }
    }

    [Token(Token = "0x17004520")]
    public bool IsMaxLevel
    {
      [Token(Token = "0x6014DA5"), Address(RVA = "0x1B41014", Offset = "0x1B41014", VA = "0x1B41014", Slot = "10")] get
      {
        return new bool();
      }
      [Token(Token = "0x6014DA6"), Address(RVA = "0x1B4101C", Offset = "0x1B4101C", VA = "0x1B4101C")] private set
      {
      }
    }

    [Token(Token = "0x6014DA7")]
    [Address(RVA = "0x1B3ACCC", Offset = "0x1B3ACCC", VA = "0x1B3ACCC")]
    public MovementStyleMasterBonusData(MoveTypeEnum moveType, int masterId)
    {
    }

    [Token(Token = "0x6014DA8")]
    [Address(RVA = "0x1B3ACFC", Offset = "0x1B3ACFC", VA = "0x1B3ACFC")]
    public void Apply(
      int level,
      int experience,
      int nextLevelExperience,
      bool isMax,
      int nowLevelExperienceFrom)
    {
    }

    [Token(Token = "0x6014DA9")]
    [Address(RVA = "0x1B41028", Offset = "0x1B41028", VA = "0x1B41028", Slot = "11")]
    public bool IsMatchConditionType(int masterBonusType) => new bool();
  }
}
