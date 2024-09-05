// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.MasterBonus.WeaponMasterBonusData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Scenes.OutGame.MasterBonus
{
  [Token(Token = "0x2003536")]
  public class WeaponMasterBonusData : IMasterBonusData
  {
    [Token(Token = "0x17004521")]
    public int Level
    {
      [Token(Token = "0x6014DBD"), Address(RVA = "0x1B4165C", Offset = "0x1B4165C", VA = "0x1B4165C", Slot = "4")] get
      {
        return new int();
      }
      [Token(Token = "0x6014DBE"), Address(RVA = "0x1B41664", Offset = "0x1B41664", VA = "0x1B41664")] private set
      {
      }
    }

    [Token(Token = "0x17004522")]
    public int Experience
    {
      [Token(Token = "0x6014DBF"), Address(RVA = "0x1B4166C", Offset = "0x1B4166C", VA = "0x1B4166C", Slot = "5")] get
      {
        return new int();
      }
      [Token(Token = "0x6014DC0"), Address(RVA = "0x1B41674", Offset = "0x1B41674", VA = "0x1B41674")] private set
      {
      }
    }

    [Token(Token = "0x17004523")]
    public int NextExperience
    {
      [Token(Token = "0x6014DC1"), Address(RVA = "0x1B4167C", Offset = "0x1B4167C", VA = "0x1B4167C", Slot = "6")] get
      {
        return new int();
      }
      [Token(Token = "0x6014DC2"), Address(RVA = "0x1B41684", Offset = "0x1B41684", VA = "0x1B41684")] private set
      {
      }
    }

    [Token(Token = "0x17004524")]
    public int DeltaNextExperience
    {
      [Token(Token = "0x6014DC3"), Address(RVA = "0x1B4168C", Offset = "0x1B4168C", VA = "0x1B4168C", Slot = "7")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004525")]
    public int NowLevelExperienceFrom
    {
      [Token(Token = "0x6014DC4"), Address(RVA = "0x1B4169C", Offset = "0x1B4169C", VA = "0x1B4169C", Slot = "8")] get
      {
        return new int();
      }
      [Token(Token = "0x6014DC5"), Address(RVA = "0x1B416A4", Offset = "0x1B416A4", VA = "0x1B416A4")] private set
      {
      }
    }

    [Token(Token = "0x17004526")]
    public int MasterId
    {
      [Token(Token = "0x6014DC6"), Address(RVA = "0x1B416AC", Offset = "0x1B416AC", VA = "0x1B416AC", Slot = "9")] get
      {
        return new int();
      }
      [Token(Token = "0x6014DC7"), Address(RVA = "0x1B416B4", Offset = "0x1B416B4", VA = "0x1B416B4")] private set
      {
      }
    }

    [Token(Token = "0x17004527")]
    public bool IsMaxLevel
    {
      [Token(Token = "0x6014DC8"), Address(RVA = "0x1B416BC", Offset = "0x1B416BC", VA = "0x1B416BC", Slot = "10")] get
      {
        return new bool();
      }
      [Token(Token = "0x6014DC9"), Address(RVA = "0x1B416C4", Offset = "0x1B416C4", VA = "0x1B416C4")] private set
      {
      }
    }

    [Token(Token = "0x6014DCA")]
    [Address(RVA = "0x1B3B8A4", Offset = "0x1B3B8A4", VA = "0x1B3B8A4")]
    public WeaponMasterBonusData(int masterId)
    {
    }

    [Token(Token = "0x6014DCB")]
    [Address(RVA = "0x1B3BD10", Offset = "0x1B3BD10", VA = "0x1B3BD10")]
    public void Apply(int level, int experience, bool isMax)
    {
    }

    [Token(Token = "0x6014DCC")]
    [Address(RVA = "0x1B414C8", Offset = "0x1B414C8", VA = "0x1B414C8", Slot = "11")]
    public bool IsMatchConditionType(int masterBonusId) => new bool();

    [Token(Token = "0x6014DCD")]
    [Address(RVA = "0x1B3E130", Offset = "0x1B3E130", VA = "0x1B3E130")]
    public string DisplayName() => (string) null;
  }
}
