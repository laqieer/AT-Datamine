// Decompiled with JetBrains decompiler
// Type: StaqData.StyleMasterBonusExperience
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x20020F5")]
  public class StyleMasterBonusExperience
  {
    [Token(Token = "0x4008B8A")]
    [FieldOffset(Offset = "0x10")]
    private int experience;
    [Token(Token = "0x4008B8D")]
    [FieldOffset(Offset = "0x28")]
    private int expTableID;

    [Token(Token = "0x17002B1F")]
    public int Experience
    {
      [Token(Token = "0x600C7DA"), Address(RVA = "0x1CE1394", Offset = "0x1CE1394", VA = "0x1CE1394")] get
      {
        return new int();
      }
      [Token(Token = "0x600C7DB"), Address(RVA = "0x1CE0B9C", Offset = "0x1CE0B9C", VA = "0x1CE0B9C")] set
      {
      }
    }

    [Token(Token = "0x17002B20")]
    public int NextLevelExperience
    {
      [Token(Token = "0x600C7DC"), Address(RVA = "0x1CE0ADC", Offset = "0x1CE0ADC", VA = "0x1CE0ADC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002B21")]
    public int DeltaNextLevelExperience
    {
      [Token(Token = "0x600C7DD"), Address(RVA = "0x1CE0B24", Offset = "0x1CE0B24", VA = "0x1CE0B24")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002B22")]
    public int Level
    {
      [Token(Token = "0x600C7DE"), Address(RVA = "0x1CE0A98", Offset = "0x1CE0A98", VA = "0x1CE0A98")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002B23")]
    public bool IsMaxLevel
    {
      [Token(Token = "0x600C7DF"), Address(RVA = "0x1CE0B64", Offset = "0x1CE0B64", VA = "0x1CE0B64")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002B24")]
    public StyleMasterBonusExpDescriptionData CurrentExpData
    {
      [Token(Token = "0x600C7E0"), Address(RVA = "0x1CE1460", Offset = "0x1CE1460", VA = "0x1CE1460")] get
      {
        return (StyleMasterBonusExpDescriptionData) null;
      }
      [Token(Token = "0x600C7E1"), Address(RVA = "0x1CE1468", Offset = "0x1CE1468", VA = "0x1CE1468")] private set
      {
      }
    }

    [Token(Token = "0x17002B25")]
    public StyleMasterBonusExpDescriptionData NextExpData
    {
      [Token(Token = "0x600C7E2"), Address(RVA = "0x1CE1470", Offset = "0x1CE1470", VA = "0x1CE1470")] get
      {
        return (StyleMasterBonusExpDescriptionData) null;
      }
      [Token(Token = "0x600C7E3"), Address(RVA = "0x1CE1478", Offset = "0x1CE1478", VA = "0x1CE1478")] private set
      {
      }
    }

    [Token(Token = "0x600C7E4")]
    [Address(RVA = "0x1CE0CD4", Offset = "0x1CE0CD4", VA = "0x1CE0CD4")]
    public StyleMasterBonusExperience(int expTableID, int experience)
    {
    }

    [Token(Token = "0x600C7E5")]
    [Address(RVA = "0x1CE139C", Offset = "0x1CE139C", VA = "0x1CE139C")]
    private void ApplyExperience(int experience)
    {
    }
  }
}
