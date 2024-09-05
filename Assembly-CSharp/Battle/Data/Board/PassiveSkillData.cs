// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.PassiveSkillData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x20027F7")]
  public class PassiveSkillData : SkillData
  {
    [Token(Token = "0x17003632")]
    public bool HasSupportGuard
    {
      [Token(Token = "0x600F9E8"), Address(RVA = "0x44C5C44", Offset = "0x44C5C44", VA = "0x44C5C44")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17003633")]
    public List<SupportGuardEffectData> SupportGuardEffects
    {
      [Token(Token = "0x600F9E9"), Address(RVA = "0x44C5C94", Offset = "0x44C5C94", VA = "0x44C5C94")] get
      {
        return (List<SupportGuardEffectData>) null;
      }
      [Token(Token = "0x600F9EA"), Address(RVA = "0x44C5C9C", Offset = "0x44C5C9C", VA = "0x44C5C9C")] private set
      {
      }
    }

    [Token(Token = "0x600F9EB")]
    [Address(RVA = "0x44C5CA4", Offset = "0x44C5CA4", VA = "0x44C5CA4", Slot = "5")]
    public override bool IsConditionable(
      SkillTriggerTimingTypeEnum timing,
      UnitParameterData unit,
      WeaponParameterData weaponParam,
      BoardData board)
    {
      return new bool();
    }

    [Token(Token = "0x600F9EC")]
    [Address(RVA = "0x44C5DB8", Offset = "0x44C5DB8", VA = "0x44C5DB8")]
    public PassiveSkillData()
    {
    }
  }
}
