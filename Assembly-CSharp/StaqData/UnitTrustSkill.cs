// Decompiled with JetBrains decompiler
// Type: StaqData.UnitTrustSkill
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002029")]
  public class UnitTrustSkill : GrowableEquipmentSkill
  {
    [Token(Token = "0x1700282A")]
    public override int NextLevelExp
    {
      [Token(Token = "0x600C065"), Address(RVA = "0x200C70C", Offset = "0x200C70C", VA = "0x200C70C", Slot = "15")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700282B")]
    public override float NextLevelExpRate
    {
      [Token(Token = "0x600C066"), Address(RVA = "0x200C714", Offset = "0x200C714", VA = "0x200C714", Slot = "16")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x600C067")]
    [Address(RVA = "0x200C58C", Offset = "0x200C58C", VA = "0x200C58C")]
    public UnitTrustSkill(UniqueID uID, int id, int exp, int level)
    {
    }

    [Token(Token = "0x600C068")]
    [Address(RVA = "0x200C71C", Offset = "0x200C71C", VA = "0x200C71C")]
    public UnitTrustSkill(UnitTrustSkill other)
    {
    }

    [Token(Token = "0x600C069")]
    [Address(RVA = "0x200C0C0", Offset = "0x200C0C0", VA = "0x200C0C0")]
    public UnitTrustSkill(PlayerGearUnitTrustType entity, int skillId)
    {
    }

    [Token(Token = "0x600C06A")]
    [Address(RVA = "0x200C744", Offset = "0x200C744", VA = "0x200C744", Slot = "17")]
    public override (int, int) GetPredictExperience(int value) => ();
  }
}
