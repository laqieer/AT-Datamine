// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.MasterBonus.ElementStyleMasterBonusData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Scenes.OutGame.MasterBonus
{
  [Token(Token = "0x200352D")]
  public class ElementStyleMasterBonusData : IMasterBonusData
  {
    [Token(Token = "0x17004511")]
    public ElementTypeEnum elementType
    {
      [Token(Token = "0x6014D86"), Address(RVA = "0x1B40F20", Offset = "0x1B40F20", VA = "0x1B40F20")] get
      {
        return new ElementTypeEnum();
      }
      [Token(Token = "0x6014D87"), Address(RVA = "0x1B40F28", Offset = "0x1B40F28", VA = "0x1B40F28")] private set
      {
      }
    }

    [Token(Token = "0x17004512")]
    public int Level
    {
      [Token(Token = "0x6014D88"), Address(RVA = "0x1B40F30", Offset = "0x1B40F30", VA = "0x1B40F30", Slot = "4")] get
      {
        return new int();
      }
      [Token(Token = "0x6014D89"), Address(RVA = "0x1B40F38", Offset = "0x1B40F38", VA = "0x1B40F38")] private set
      {
      }
    }

    [Token(Token = "0x17004513")]
    public int Experience
    {
      [Token(Token = "0x6014D8A"), Address(RVA = "0x1B40F40", Offset = "0x1B40F40", VA = "0x1B40F40", Slot = "5")] get
      {
        return new int();
      }
      [Token(Token = "0x6014D8B"), Address(RVA = "0x1B40F48", Offset = "0x1B40F48", VA = "0x1B40F48")] private set
      {
      }
    }

    [Token(Token = "0x17004514")]
    public int NextExperience
    {
      [Token(Token = "0x6014D8C"), Address(RVA = "0x1B40F50", Offset = "0x1B40F50", VA = "0x1B40F50", Slot = "6")] get
      {
        return new int();
      }
      [Token(Token = "0x6014D8D"), Address(RVA = "0x1B40F58", Offset = "0x1B40F58", VA = "0x1B40F58")] private set
      {
      }
    }

    [Token(Token = "0x17004515")]
    public int DeltaNextExperience
    {
      [Token(Token = "0x6014D8E"), Address(RVA = "0x1B40F60", Offset = "0x1B40F60", VA = "0x1B40F60", Slot = "7")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004516")]
    public int NowLevelExperienceFrom
    {
      [Token(Token = "0x6014D8F"), Address(RVA = "0x1B40F70", Offset = "0x1B40F70", VA = "0x1B40F70", Slot = "8")] get
      {
        return new int();
      }
      [Token(Token = "0x6014D90"), Address(RVA = "0x1B40F78", Offset = "0x1B40F78", VA = "0x1B40F78")] private set
      {
      }
    }

    [Token(Token = "0x17004517")]
    public int MasterId
    {
      [Token(Token = "0x6014D91"), Address(RVA = "0x1B40F80", Offset = "0x1B40F80", VA = "0x1B40F80", Slot = "9")] get
      {
        return new int();
      }
      [Token(Token = "0x6014D92"), Address(RVA = "0x1B40F88", Offset = "0x1B40F88", VA = "0x1B40F88")] private set
      {
      }
    }

    [Token(Token = "0x17004518")]
    public bool IsMaxLevel
    {
      [Token(Token = "0x6014D93"), Address(RVA = "0x1B40F90", Offset = "0x1B40F90", VA = "0x1B40F90", Slot = "10")] get
      {
        return new bool();
      }
      [Token(Token = "0x6014D94"), Address(RVA = "0x1B40F98", Offset = "0x1B40F98", VA = "0x1B40F98")] private set
      {
      }
    }

    [Token(Token = "0x6014D95")]
    [Address(RVA = "0x1B3AC88", Offset = "0x1B3AC88", VA = "0x1B3AC88")]
    public ElementStyleMasterBonusData(ElementTypeEnum elementType, int masterId)
    {
    }

    [Token(Token = "0x6014D96")]
    [Address(RVA = "0x1B3ACB8", Offset = "0x1B3ACB8", VA = "0x1B3ACB8")]
    public void Apply(
      int level,
      int experience,
      int nextLevelExperience,
      bool isMax,
      int nowLevelExperienceFrom)
    {
    }

    [Token(Token = "0x6014D97")]
    [Address(RVA = "0x1B40D8C", Offset = "0x1B40D8C", VA = "0x1B40D8C", Slot = "11")]
    public bool IsMatchConditionType(int masterBonusType) => new bool();
  }
}
