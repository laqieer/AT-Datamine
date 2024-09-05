// Decompiled with JetBrains decompiler
// Type: StaqData.StyleMasterBonus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Network.Param;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x20020F4")]
  public class StyleMasterBonus
  {
    [Token(Token = "0x4008B88")]
    [FieldOffset(Offset = "0x18")]
    private StyleMasterBonusExperience styleMasterBonusExperience;

    [Token(Token = "0x17002B18")]
    public int MasterId
    {
      [Token(Token = "0x600C7CC"), Address(RVA = "0x1CE0A30", Offset = "0x1CE0A30", VA = "0x1CE0A30")] get
      {
        return new int();
      }
      [Token(Token = "0x600C7CD"), Address(RVA = "0x1CE0A38", Offset = "0x1CE0A38", VA = "0x1CE0A38")] private set
      {
      }
    }

    [Token(Token = "0x17002B19")]
    public int Experience
    {
      [Token(Token = "0x600C7CE"), Address(RVA = "0x1CE0A40", Offset = "0x1CE0A40", VA = "0x1CE0A40")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002B1A")]
    public StyleMasterBonusData MasterData
    {
      [Token(Token = "0x600C7CF"), Address(RVA = "0x1CE0A5C", Offset = "0x1CE0A5C", VA = "0x1CE0A5C")] get
      {
        return (StyleMasterBonusData) null;
      }
      [Token(Token = "0x600C7D0"), Address(RVA = "0x1CE0A64", Offset = "0x1CE0A64", VA = "0x1CE0A64")] private set
      {
      }
    }

    [Token(Token = "0x17002B1B")]
    public int Level
    {
      [Token(Token = "0x600C7D1"), Address(RVA = "0x1CE0A6C", Offset = "0x1CE0A6C", VA = "0x1CE0A6C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002B1C")]
    public int NextLevelExperience
    {
      [Token(Token = "0x600C7D2"), Address(RVA = "0x1CE0AB0", Offset = "0x1CE0AB0", VA = "0x1CE0AB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002B1D")]
    public int DeltaNextLevelExperience
    {
      [Token(Token = "0x600C7D3"), Address(RVA = "0x1CE0AF4", Offset = "0x1CE0AF4", VA = "0x1CE0AF4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002B1E")]
    public bool IsMaxLevel
    {
      [Token(Token = "0x600C7D4"), Address(RVA = "0x1CE0B40", Offset = "0x1CE0B40", VA = "0x1CE0B40")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600C7D5")]
    [Address(RVA = "0x1CE0B74", Offset = "0x1CE0B74", VA = "0x1CE0B74")]
    private StyleMasterBonus()
    {
    }

    [Token(Token = "0x600C7D6")]
    [Address(RVA = "0x1CE0B7C", Offset = "0x1CE0B7C", VA = "0x1CE0B7C")]
    public void Apply(PlayerStyleMasterBonusType entity)
    {
    }

    [Token(Token = "0x600C7D7")]
    [Address(RVA = "0x1CE0BA0", Offset = "0x1CE0BA0", VA = "0x1CE0BA0")]
    public static StyleMasterBonus CreateByServerData(PlayerStyleMasterBonusType entity)
    {
      return (StyleMasterBonus) null;
    }

    [Token(Token = "0x600C7D8")]
    [Address(RVA = "0x1CE0D08", Offset = "0x1CE0D08", VA = "0x1CE0D08")]
    public StyleMasterBonusDescriptionData GetStyleMasterBonusEffect(Style style)
    {
      return (StyleMasterBonusDescriptionData) null;
    }

    [Token(Token = "0x600C7D9")]
    [Address(RVA = "0x1CE1064", Offset = "0x1CE1064", VA = "0x1CE1064")]
    public StyleMasterBonusDescriptionData GetStyleMasterBonusEffect(StyleData style)
    {
      return (StyleMasterBonusDescriptionData) null;
    }
  }
}
