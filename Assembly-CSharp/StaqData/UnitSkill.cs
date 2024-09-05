// Decompiled with JetBrains decompiler
// Type: StaqData.UnitSkill
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Network.Param;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x200210B")]
  public class UnitSkill
  {
    [Token(Token = "0x17002BFF")]
    public SkillData SkillData
    {
      [Token(Token = "0x600CA0D"), Address(RVA = "0x1BA08D4", Offset = "0x1BA08D4", VA = "0x1BA08D4")] get
      {
        return (SkillData) null;
      }
      [Token(Token = "0x600CA0E"), Address(RVA = "0x1BA08DC", Offset = "0x1BA08DC", VA = "0x1BA08DC")] private set
      {
      }
    }

    [Token(Token = "0x17002C00")]
    public int SkillId
    {
      [Token(Token = "0x600CA0F"), Address(RVA = "0x1BA08E4", Offset = "0x1BA08E4", VA = "0x1BA08E4")] get
      {
        return new int();
      }
      [Token(Token = "0x600CA10"), Address(RVA = "0x1BA08EC", Offset = "0x1BA08EC", VA = "0x1BA08EC")] private set
      {
      }
    }

    [Token(Token = "0x17002C01")]
    public int Level
    {
      [Token(Token = "0x600CA11"), Address(RVA = "0x1BA08F4", Offset = "0x1BA08F4", VA = "0x1BA08F4")] get
      {
        return new int();
      }
      [Token(Token = "0x600CA12"), Address(RVA = "0x1BA08FC", Offset = "0x1BA08FC", VA = "0x1BA08FC")] private set
      {
      }
    }

    [Token(Token = "0x600CA13")]
    [Address(RVA = "0x1BA0904", Offset = "0x1BA0904", VA = "0x1BA0904")]
    public UnitSkill()
    {
    }

    [Token(Token = "0x600CA14")]
    [Address(RVA = "0x1BA090C", Offset = "0x1BA090C", VA = "0x1BA090C")]
    public void Apply(PlayerUnitSkillType entity)
    {
    }

    [Token(Token = "0x600CA15")]
    [Address(RVA = "0x1BA09CC", Offset = "0x1BA09CC", VA = "0x1BA09CC")]
    public void Apply(int skillId, int skillLevel)
    {
    }

    [Token(Token = "0x600CA16")]
    [Address(RVA = "0x1BA09C4", Offset = "0x1BA09C4", VA = "0x1BA09C4")]
    private void Reset()
    {
    }
  }
}
