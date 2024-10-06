// Decompiled with JetBrains decompiler
// Type: StaqData.CommunicationSkill
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Network.Param;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x20020FC")]
  public class CommunicationSkill
  {
    [Token(Token = "0x4008BC2")]
    [FieldOffset(Offset = "0x10")]
    private int communicationSkillID;

    [Token(Token = "0x17002B57")]
    public int CommunicationSkillID
    {
      [Token(Token = "0x600C864"), Address(RVA = "0x1CE266C", Offset = "0x1CE266C", VA = "0x1CE266C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002B58")]
    public int SkillID
    {
      [Token(Token = "0x600C865"), Address(RVA = "0x1CE2674", Offset = "0x1CE2674", VA = "0x1CE2674")] get
      {
        return new int();
      }
      [Token(Token = "0x600C866"), Address(RVA = "0x1CE267C", Offset = "0x1CE267C", VA = "0x1CE267C")] private set
      {
      }
    }

    [Token(Token = "0x17002B59")]
    public int CharacterID
    {
      [Token(Token = "0x600C867"), Address(RVA = "0x1CE2684", Offset = "0x1CE2684", VA = "0x1CE2684")] get
      {
        return new int();
      }
      [Token(Token = "0x600C868"), Address(RVA = "0x1CE268C", Offset = "0x1CE268C", VA = "0x1CE268C")] private set
      {
      }
    }

    [Token(Token = "0x17002B5A")]
    public int SkillLevel
    {
      [Token(Token = "0x600C869"), Address(RVA = "0x1CE2694", Offset = "0x1CE2694", VA = "0x1CE2694")] get
      {
        return new int();
      }
      [Token(Token = "0x600C86A"), Address(RVA = "0x1CE269C", Offset = "0x1CE269C", VA = "0x1CE269C")] private set
      {
      }
    }

    [Token(Token = "0x600C86B")]
    [Address(RVA = "0x1CE26A4", Offset = "0x1CE26A4", VA = "0x1CE26A4")]
    public static CommunicationSkill Create(PlayerCommunicationSkillType param)
    {
      return (CommunicationSkill) null;
    }

    [Token(Token = "0x600C86C")]
    [Address(RVA = "0x1CE2754", Offset = "0x1CE2754", VA = "0x1CE2754")]
    public static CommunicationSkill Create(CommunicationSkillData master, int skillLevel)
    {
      return (CommunicationSkill) null;
    }

    [Token(Token = "0x600C86D")]
    [Address(RVA = "0x1CE2718", Offset = "0x1CE2718", VA = "0x1CE2718")]
    public void Apply(PlayerCommunicationSkillType param)
    {
    }

    [Token(Token = "0x600C86E")]
    [Address(RVA = "0x1CE27DC", Offset = "0x1CE27DC", VA = "0x1CE27DC")]
    public CommunicationSkillData GetCommunicationSkillData() => (CommunicationSkillData) null;

    [Token(Token = "0x600C86F")]
    [Address(RVA = "0x1CE2878", Offset = "0x1CE2878", VA = "0x1CE2878")]
    public CharacterData GetCharacterData() => (CharacterData) null;

    [Token(Token = "0x600C870")]
    [Address(RVA = "0x1CE2914", Offset = "0x1CE2914", VA = "0x1CE2914")]
    public SkillData GetSkillData() => (SkillData) null;

    [Token(Token = "0x600C871")]
    [Address(RVA = "0x1CE2710", Offset = "0x1CE2710", VA = "0x1CE2710")]
    public CommunicationSkill()
    {
    }
  }
}
