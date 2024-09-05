// Decompiled with JetBrains decompiler
// Type: Battle.UI.UnitStatusParamFactor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x2002359")]
  public sealed class UnitStatusParamFactor : UnitStatusFactorBase
  {
    [Token(Token = "0x400962D")]
    private const string DEFAULT_OFFSET_VALUE_STRING = "(-)";
    [Token(Token = "0x400962E")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private UnitStatusParamFactor.UnitStatusParamUISet life;
    [Token(Token = "0x400962F")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private UnitStatusParamFactor.UnitStatusParamUISet strength;
    [Token(Token = "0x4009630")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private UnitStatusParamFactor.UnitStatusParamUISet vitality;
    [Token(Token = "0x4009631")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private UnitStatusParamFactor.UnitStatusParamUISet intelligence;
    [Token(Token = "0x4009632")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private UnitStatusParamFactor.UnitStatusParamUISet mind;
    [Token(Token = "0x4009633")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private UnitStatusParamFactor.UnitStatusParamUISet agility;
    [Token(Token = "0x4009634")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private UnitStatusParamFactor.UnitStatusParamUISet dexterity;
    [Token(Token = "0x4009635")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private UnitStatusParamFactor.UnitStatusParamUISet luck;
    [Token(Token = "0x4009636")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Color plusColor;
    [Token(Token = "0x4009637")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Color minusColor;

    [Token(Token = "0x600D7DC")]
    [Address(RVA = "0x1B8C798", Offset = "0x1B8C798", VA = "0x1B8C798", Slot = "4")]
    public override void Initialize(UnitStatusFactorBase.Context context)
    {
    }

    [Token(Token = "0x600D7DD")]
    [Address(RVA = "0x1B8CAB4", Offset = "0x1B8CAB4", VA = "0x1B8CAB4", Slot = "5")]
    public override void Set(UnitParameterData unit, BattlePlayerData owner)
    {
    }

    [Token(Token = "0x600D7DE")]
    [Address(RVA = "0x1B8C870", Offset = "0x1B8C870", VA = "0x1B8C870")]
    private void SetParam(
      UnitStatusParamFactor.UnitStatusParamUISet uiSet,
      int original,
      int corrected,
      int offset)
    {
    }

    [Token(Token = "0x600D7DF")]
    [Address(RVA = "0x1B8D554", Offset = "0x1B8D554", VA = "0x1B8D554")]
    public UnitStatusParamFactor()
    {
    }

    [Token(Token = "0x200235A")]
    [Serializable]
    private class UnitStatusParamUISet
    {
      [Token(Token = "0x4009638")]
      [FieldOffset(Offset = "0x10")]
      public Text original;
      [Token(Token = "0x4009639")]
      [FieldOffset(Offset = "0x18")]
      public Text corrected;
      [Token(Token = "0x400963A")]
      [FieldOffset(Offset = "0x20")]
      public Text diff;

      [Token(Token = "0x600D7E0")]
      [Address(RVA = "0x1B8D56C", Offset = "0x1B8D56C", VA = "0x1B8D56C")]
      public UnitStatusParamUISet()
      {
      }
    }
  }
}
