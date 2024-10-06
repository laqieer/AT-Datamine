// Decompiled with JetBrains decompiler
// Type: TeamOrganization.EquipSkillData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x20007C7")]
  public class EquipSkillData
  {
    [Token(Token = "0x1700068A")]
    public int SkillId
    {
      [Token(Token = "0x6002C10"), Address(RVA = "0x3877DA4", Offset = "0x3877DA4", VA = "0x3877DA4")] get
      {
        return new int();
      }
      [Token(Token = "0x6002C11"), Address(RVA = "0x3877DAC", Offset = "0x3877DAC", VA = "0x3877DAC")] private set
      {
      }
    }

    [Token(Token = "0x1700068B")]
    public int SkillLevel
    {
      [Token(Token = "0x6002C12"), Address(RVA = "0x3877DB4", Offset = "0x3877DB4", VA = "0x3877DB4")] get
      {
        return new int();
      }
      [Token(Token = "0x6002C13"), Address(RVA = "0x3877DBC", Offset = "0x3877DBC", VA = "0x3877DBC")] private set
      {
      }
    }

    [Token(Token = "0x6002C14")]
    [Address(RVA = "0x3877DC4", Offset = "0x3877DC4", VA = "0x3877DC4")]
    public EquipSkillData(int id, int level)
    {
    }

    [Token(Token = "0x6002C15")]
    [Address(RVA = "0x3877DF0", Offset = "0x3877DF0", VA = "0x3877DF0")]
    public SkillData GetSkillData() => (SkillData) null;
  }
}
