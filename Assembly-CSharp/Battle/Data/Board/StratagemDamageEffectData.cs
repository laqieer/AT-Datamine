// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.StratagemDamageEffectData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x20027D7")]
  public class StratagemDamageEffectData : EffectData, IDamageEffect, IEffectValue
  {
    [Token(Token = "0x400A995")]
    [FieldOffset(Offset = "0x80")]
    private StratagemDamageEffectData.ContextIndexInfo contextIndex;
    [Token(Token = "0x400A99A")]
    [FieldOffset(Offset = "0xB0")]
    public Decimal HitRate;
    [Token(Token = "0x400A99B")]
    [FieldOffset(Offset = "0xC0")]
    public Decimal ElementCorrectionValue;

    [Token(Token = "0x170035B8")]
    private StratagemDamageEffectData.ContextIndexInfo ContextIndex
    {
      [Token(Token = "0x600F8C6"), Address(RVA = "0x44BCB74", Offset = "0x44BCB74", VA = "0x44BCB74")] get
      {
        return new StratagemDamageEffectData.ContextIndexInfo();
      }
    }

    [Token(Token = "0x170035B9")]
    private IDamageEffect.ContextIndexInfo Battle\u002EData\u002EBoard\u002EIDamageEffect\u002EContextIndex
    {
      [Token(Token = "0x600F8C7"), Address(RVA = "0x44BCB88", Offset = "0x44BCB88", VA = "0x44BCB88", Slot = "8")] get
      {
        return new IDamageEffect.ContextIndexInfo();
      }
    }

    [Token(Token = "0x170035BA")]
    public bool IsCriticalable
    {
      [Token(Token = "0x600F8C8"), Address(RVA = "0x44BCBC8", Offset = "0x44BCBC8", VA = "0x44BCBC8", Slot = "15")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170035BB")]
    public EffectValue EffectValue
    {
      [Token(Token = "0x600F8C9"), Address(RVA = "0x44BCBD0", Offset = "0x44BCBD0", VA = "0x44BCBD0", Slot = "9")] get
      {
        return new EffectValue();
      }
      [Token(Token = "0x600F8CA"), Address(RVA = "0x44BCBD8", Offset = "0x44BCBD8", VA = "0x44BCBD8")] private set
      {
      }
    }

    [Token(Token = "0x170035BC")]
    public WeaponAttackTypeEnum WeaponAttackType
    {
      [Token(Token = "0x600F8CB"), Address(RVA = "0x44BCBE0", Offset = "0x44BCBE0", VA = "0x44BCBE0", Slot = "10")] get
      {
        return new WeaponAttackTypeEnum();
      }
      [Token(Token = "0x600F8CC"), Address(RVA = "0x44BCBE8", Offset = "0x44BCBE8", VA = "0x44BCBE8")] private set
      {
      }
    }

    [Token(Token = "0x170035BD")]
    public ElementTypeEnum Element
    {
      [Token(Token = "0x600F8CD"), Address(RVA = "0x44BCBF0", Offset = "0x44BCBF0", VA = "0x44BCBF0", Slot = "11")] get
      {
        return new ElementTypeEnum();
      }
      [Token(Token = "0x600F8CE"), Address(RVA = "0x44BCBF8", Offset = "0x44BCBF8", VA = "0x44BCBF8")] private set
      {
      }
    }

    [Token(Token = "0x170035BE")]
    public AttackTypeEnum AttackType
    {
      [Token(Token = "0x600F8CF"), Address(RVA = "0x44BCC00", Offset = "0x44BCC00", VA = "0x44BCC00", Slot = "12")] get
      {
        return new AttackTypeEnum();
      }
      [Token(Token = "0x600F8D0"), Address(RVA = "0x44BCC08", Offset = "0x44BCC08", VA = "0x44BCC08")] private set
      {
      }
    }

    [Token(Token = "0x170035BF")]
    public bool IsMercy
    {
      [Token(Token = "0x600F8D1"), Address(RVA = "0x44BCC10", Offset = "0x44BCC10", VA = "0x44BCC10", Slot = "13")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170035C0")]
    public virtual bool ConsiderBarrier
    {
      [Token(Token = "0x600F8D2"), Address(RVA = "0x44BCC18", Offset = "0x44BCC18", VA = "0x44BCC18", Slot = "18")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170035C1")]
    public BattleEffectValueTypeEnum ValueType
    {
      [Token(Token = "0x600F8D3"), Address(RVA = "0x44BCC20", Offset = "0x44BCC20", VA = "0x44BCC20", Slot = "16")] get
      {
        return new BattleEffectValueTypeEnum();
      }
    }

    [Token(Token = "0x170035C2")]
    public int Value
    {
      [Token(Token = "0x600F8D4"), Address(RVA = "0x44BCC28", Offset = "0x44BCC28", VA = "0x44BCC28", Slot = "17")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600F8D5")]
    [Address(RVA = "0x44BCC30", Offset = "0x44BCC30", VA = "0x44BCC30")]
    public static StratagemDamageEffectData Create(EffectSource source)
    {
      return (StratagemDamageEffectData) null;
    }

    [Token(Token = "0x600F8D6")]
    [Address(RVA = "0x44BCCCC", Offset = "0x44BCCCC", VA = "0x44BCCCC")]
    protected StratagemDamageEffectData(EffectSource source)
    {
    }

    [Token(Token = "0x600F8D7")]
    [Address(RVA = "0x44BCE40", Offset = "0x44BCE40", VA = "0x44BCE40", Slot = "7")]
    protected override void CreateKey()
    {
    }

    [Token(Token = "0x20027D8")]
    public struct ContextIndexInfo
    {
      [Token(Token = "0x400A99C")]
      [FieldOffset(Offset = "0x0")]
      public int HpDamageValue;
      [Token(Token = "0x400A99D")]
      [FieldOffset(Offset = "0x4")]
      public int HitRate;
      [Token(Token = "0x400A99E")]
      [FieldOffset(Offset = "0x8")]
      public int AttackKind;
      [Token(Token = "0x400A99F")]
      [FieldOffset(Offset = "0xC")]
      public int Element;
      [Token(Token = "0x400A9A0")]
      [FieldOffset(Offset = "0x10")]
      public int ElementCorrectionValue;
      [Token(Token = "0x400A9A1")]
      [FieldOffset(Offset = "0x14")]
      public int AttackType;
    }
  }
}
