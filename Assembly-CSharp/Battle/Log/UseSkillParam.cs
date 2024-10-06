// Decompiled with JetBrains decompiler
// Type: Battle.Log.UseSkillParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.Log
{
  [Token(Token = "0x2002524")]
  public class UseSkillParam
  {
    [Token(Token = "0x17003147")]
    public bool IsNormalAttack
    {
      [Token(Token = "0x600E575"), Address(RVA = "0x4868F04", Offset = "0x4868F04", VA = "0x4868F04")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E576"), Address(RVA = "0x4868F0C", Offset = "0x4868F0C", VA = "0x4868F0C")] private set
      {
      }
    }

    [Token(Token = "0x17003148")]
    public int SkillId
    {
      [Token(Token = "0x600E577"), Address(RVA = "0x4868F18", Offset = "0x4868F18", VA = "0x4868F18")] get
      {
        return new int();
      }
      [Token(Token = "0x600E578"), Address(RVA = "0x4868F20", Offset = "0x4868F20", VA = "0x4868F20")] private set
      {
      }
    }

    [Token(Token = "0x17003149")]
    public int SkillLevel
    {
      [Token(Token = "0x600E579"), Address(RVA = "0x4868F28", Offset = "0x4868F28", VA = "0x4868F28")] get
      {
        return new int();
      }
      [Token(Token = "0x600E57A"), Address(RVA = "0x4868F30", Offset = "0x4868F30", VA = "0x4868F30")] private set
      {
      }
    }

    [Token(Token = "0x1700314A")]
    public int WeaponId
    {
      [Token(Token = "0x600E57B"), Address(RVA = "0x4868F38", Offset = "0x4868F38", VA = "0x4868F38")] get
      {
        return new int();
      }
      [Token(Token = "0x600E57C"), Address(RVA = "0x4868F40", Offset = "0x4868F40", VA = "0x4868F40")] private set
      {
      }
    }

    [Token(Token = "0x1700314B")]
    public int Count
    {
      [Token(Token = "0x600E57D"), Address(RVA = "0x4868F48", Offset = "0x4868F48", VA = "0x4868F48")] get
      {
        return new int();
      }
      [Token(Token = "0x600E57E"), Address(RVA = "0x4868F50", Offset = "0x4868F50", VA = "0x4868F50")] private set
      {
      }
    }

    [Token(Token = "0x600E57F")]
    [Address(RVA = "0x4868CD0", Offset = "0x4868CD0", VA = "0x4868CD0")]
    public UseSkillParam(
      int skillId,
      int skillLevel,
      int weaponId,
      bool isNormalAttack,
      int count = 1)
    {
    }

    [Token(Token = "0x600E580")]
    [Address(RVA = "0x4868CC0", Offset = "0x4868CC0", VA = "0x4868CC0")]
    public void AddSkillCount(int count)
    {
    }
  }
}
