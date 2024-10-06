// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.SupportGuardEffectData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x20027D9")]
  public class SupportGuardEffectData : EffectData
  {
    [Token(Token = "0x400A9A2")]
    [FieldOffset(Offset = "0x80")]
    private Dictionary<WeaponAttackTypeEnum, EffectValue> effectValueDic;

    [Token(Token = "0x600F8D8")]
    [Address(RVA = "0x44BCEAC", Offset = "0x44BCEAC", VA = "0x44BCEAC")]
    public static SupportGuardEffectData Create(EffectSource source)
    {
      return (SupportGuardEffectData) null;
    }

    [Token(Token = "0x600F8D9")]
    [Address(RVA = "0x44BCF48", Offset = "0x44BCF48", VA = "0x44BCF48")]
    public SupportGuardEffectData(EffectSource source)
    {
    }

    [Token(Token = "0x600F8DA")]
    [Address(RVA = "0x44BD0AC", Offset = "0x44BD0AC", VA = "0x44BD0AC")]
    public EffectValue GetEffectValue(WeaponParameterData weaponParam, IDamageEffect damageEffect)
    {
      return new EffectValue();
    }

    [Token(Token = "0x600F8DB")]
    [Address(RVA = "0x44BD0D4", Offset = "0x44BD0D4", VA = "0x44BD0D4")]
    private EffectValue GetEffectValue(WeaponAttackTypeEnum weaponAttackType) => new EffectValue();

    [Token(Token = "0x20027DA")]
    private enum ContextType
    {
      [Token(Token = "0x400A9A4")] ValueType,
      [Token(Token = "0x400A9A5")] PhysicsValue,
      [Token(Token = "0x400A9A6")] MagicValue,
    }
  }
}
