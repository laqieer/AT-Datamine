// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.DamageEffectData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x200278B")]
  public class DamageEffectData : EffectData, IDamageEffect, IEffectValue
  {
    [Token(Token = "0x400A8A4")]
    [FieldOffset(Offset = "0x80")]
    private IDamageEffect.ContextIndexInfo contextIndex;

    [Token(Token = "0x170034E8")]
    public IDamageEffect.ContextIndexInfo ContextIndex
    {
      [Token(Token = "0x600F6CF"), Address(RVA = "0x1ED8548", Offset = "0x1ED8548", VA = "0x1ED8548", Slot = "8")] get
      {
        return new IDamageEffect.ContextIndexInfo();
      }
    }

    [Token(Token = "0x170034E9")]
    public EffectValue EffectValue
    {
      [Token(Token = "0x600F6D0"), Address(RVA = "0x1ED855C", Offset = "0x1ED855C", VA = "0x1ED855C", Slot = "9")] get
      {
        return new EffectValue();
      }
      [Token(Token = "0x600F6D1"), Address(RVA = "0x1ED8564", Offset = "0x1ED8564", VA = "0x1ED8564")] private set
      {
      }
    }

    [Token(Token = "0x170034EA")]
    public ElementTypeEnum Element
    {
      [Token(Token = "0x600F6D2"), Address(RVA = "0x1ED856C", Offset = "0x1ED856C", VA = "0x1ED856C", Slot = "11")] get
      {
        return new ElementTypeEnum();
      }
      [Token(Token = "0x600F6D3"), Address(RVA = "0x1ED8574", Offset = "0x1ED8574", VA = "0x1ED8574")] private set
      {
      }
    }

    [Token(Token = "0x170034EB")]
    public WeaponAttackTypeEnum WeaponAttackType
    {
      [Token(Token = "0x600F6D4"), Address(RVA = "0x1ED857C", Offset = "0x1ED857C", VA = "0x1ED857C", Slot = "10")] get
      {
        return new WeaponAttackTypeEnum();
      }
      [Token(Token = "0x600F6D5"), Address(RVA = "0x1ED8584", Offset = "0x1ED8584", VA = "0x1ED8584")] private set
      {
      }
    }

    [Token(Token = "0x170034EC")]
    public AttackTypeEnum AttackType
    {
      [Token(Token = "0x600F6D6"), Address(RVA = "0x1ED858C", Offset = "0x1ED858C", VA = "0x1ED858C", Slot = "12")] get
      {
        return new AttackTypeEnum();
      }
      [Token(Token = "0x600F6D7"), Address(RVA = "0x1ED8594", Offset = "0x1ED8594", VA = "0x1ED8594")] private set
      {
      }
    }

    [Token(Token = "0x170034ED")]
    public bool IsMercy
    {
      [Token(Token = "0x600F6D8"), Address(RVA = "0x1ED859C", Offset = "0x1ED859C", VA = "0x1ED859C", Slot = "13")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F6D9"), Address(RVA = "0x1ED85A4", Offset = "0x1ED85A4", VA = "0x1ED85A4")] private set
      {
      }
    }

    [Token(Token = "0x170034EE")]
    public virtual bool ConsiderBarrier
    {
      [Token(Token = "0x600F6DA"), Address(RVA = "0x1ED85B0", Offset = "0x1ED85B0", VA = "0x1ED85B0", Slot = "18")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170034EF")]
    public virtual bool IsCriticalable
    {
      [Token(Token = "0x600F6DB"), Address(RVA = "0x1ED85B8", Offset = "0x1ED85B8", VA = "0x1ED85B8", Slot = "19")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600F6DC")]
    [Address(RVA = "0x1ED85C0", Offset = "0x1ED85C0", VA = "0x1ED85C0")]
    public static DamageEffectData Create(EffectSource source) => (DamageEffectData) null;

    [Token(Token = "0x600F6DD")]
    [Address(RVA = "0x1ED865C", Offset = "0x1ED865C", VA = "0x1ED865C")]
    protected DamageEffectData(EffectSource source)
    {
    }

    [Token(Token = "0x600F6DE")]
    [Address(RVA = "0x1ED87D0", Offset = "0x1ED87D0", VA = "0x1ED87D0", Slot = "7")]
    protected override void CreateKey()
    {
    }

    [Token(Token = "0x170034F0")]
    public BattleEffectValueTypeEnum ValueType
    {
      [Token(Token = "0x600F6DF"), Address(RVA = "0x1ED8838", Offset = "0x1ED8838", VA = "0x1ED8838", Slot = "16")] get
      {
        return new BattleEffectValueTypeEnum();
      }
    }

    [Token(Token = "0x170034F1")]
    public int Value
    {
      [Token(Token = "0x600F6E0"), Address(RVA = "0x1ED8840", Offset = "0x1ED8840", VA = "0x1ED8840", Slot = "17")] get
      {
        return new int();
      }
    }
  }
}
