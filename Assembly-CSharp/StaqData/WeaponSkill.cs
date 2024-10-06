// Decompiled with JetBrains decompiler
// Type: StaqData.WeaponSkill
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002032")]
  public sealed class WeaponSkill : GrowableEquipmentSkill
  {
    [Token(Token = "0x4008912")]
    private const float ExpRateMax = 1f;

    [Token(Token = "0x17002849")]
    public override int NextLevelExp
    {
      [Token(Token = "0x600C0D2"), Address(RVA = "0x2010C98", Offset = "0x2010C98", VA = "0x2010C98", Slot = "15")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700284A")]
    public override float NextLevelExpRate
    {
      [Token(Token = "0x600C0D3"), Address(RVA = "0x2010DA4", Offset = "0x2010DA4", VA = "0x2010DA4", Slot = "16")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x600C0D4")]
    [Address(RVA = "0x2010ED0", Offset = "0x2010ED0", VA = "0x2010ED0")]
    public WeaponSkill(UniqueID uID, int id, int skillID, int exp, int level)
    {
    }

    [Token(Token = "0x600C0D5")]
    [Address(RVA = "0x2011054", Offset = "0x2011054", VA = "0x2011054")]
    public WeaponSkill(WeaponSkill other)
    {
    }

    [Token(Token = "0x600C0D6")]
    [Address(RVA = "0x2010404", Offset = "0x2010404", VA = "0x2010404")]
    public WeaponSkill(PlayerGearWeaponSkillType entity)
    {
    }

    [Token(Token = "0x600C0D7")]
    [Address(RVA = "0x20110B0", Offset = "0x20110B0", VA = "0x20110B0", Slot = "17")]
    public override (int, int) GetPredictExperience(int value) => ();
  }
}
