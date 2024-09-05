// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.MasterBonus.IMasterBonusData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Scenes.OutGame.MasterBonus
{
  [Token(Token = "0x2003513")]
  public interface IMasterBonusData
  {
    [Token(Token = "0x17004502")]
    int Level { [Token(Token = "0x6014D13")] get; }

    [Token(Token = "0x17004503")]
    int Experience { [Token(Token = "0x6014D14")] get; }

    [Token(Token = "0x17004504")]
    int NextExperience { [Token(Token = "0x6014D15")] get; }

    [Token(Token = "0x17004505")]
    int DeltaNextExperience { [Token(Token = "0x6014D16")] get; }

    [Token(Token = "0x17004506")]
    int NowLevelExperienceFrom { [Token(Token = "0x6014D17")] get; }

    [Token(Token = "0x17004507")]
    int MasterId { [Token(Token = "0x6014D18")] get; }

    [Token(Token = "0x17004508")]
    bool IsMaxLevel { [Token(Token = "0x6014D19")] get; }

    [Token(Token = "0x6014D1A")]
    bool IsMatchConditionType(int conditionType);
  }
}
