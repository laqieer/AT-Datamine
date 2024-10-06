// Decompiled with JetBrains decompiler
// Type: Battle.UI.UnitStatusSpecialEffectFactor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;
using System.Text;
using UnityEngine;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x200235E")]
  public sealed class UnitStatusSpecialEffectFactor : UnitStatusFactorBase
  {
    [Token(Token = "0x4009646")]
    private const string EMPTY_STRING = "-";
    [Token(Token = "0x4009647")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private UnityEngine.UI.Text specialAttack;
    [Token(Token = "0x4009648")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private UnityEngine.UI.Text specialDefense;
    [Token(Token = "0x4009649")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Color plusColor;
    [Token(Token = "0x400964A")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Color minusColor;
    [Token(Token = "0x400964B")]
    [FieldOffset(Offset = "0x78")]
    private StringBuilder atkStr;
    [Token(Token = "0x400964C")]
    [FieldOffset(Offset = "0x80")]
    private StringBuilder defStr;

    [Token(Token = "0x600D7E9")]
    [Address(RVA = "0x1B8DC70", Offset = "0x1B8DC70", VA = "0x1B8DC70", Slot = "4")]
    public override void Initialize(UnitStatusFactorBase.Context context)
    {
    }

    [Token(Token = "0x600D7EA")]
    [Address(RVA = "0x1B8DD34", Offset = "0x1B8DD34", VA = "0x1B8DD34", Slot = "5")]
    public override void Set(UnitParameterData unit, BattlePlayerData owner)
    {
    }

    [Token(Token = "0x600D7EB")]
    [Address(RVA = "0x1B8EA18", Offset = "0x1B8EA18", VA = "0x1B8EA18")]
    private string CreateValueText(int value, string userText) => (string) null;

    [Token(Token = "0x600D7EC")]
    [Address(RVA = "0x1B8DDBC", Offset = "0x1B8DDBC", VA = "0x1B8DDBC")]
    private void CollectElementSlayValues(UnitParameterData unit)
    {
    }

    [Token(Token = "0x600D7ED")]
    [Address(RVA = "0x1B8E020", Offset = "0x1B8E020", VA = "0x1B8E020")]
    private void CollectSpeciesSlayValues(UnitParameterData unit)
    {
    }

    [Token(Token = "0x600D7EE")]
    [Address(RVA = "0x1B8E250", Offset = "0x1B8E250", VA = "0x1B8E250")]
    private void CollectArmorSlayValues(UnitParameterData unit)
    {
    }

    [Token(Token = "0x600D7EF")]
    [Address(RVA = "0x1B8E480", Offset = "0x1B8E480", VA = "0x1B8E480")]
    private void CollectRideSlayValues(UnitParameterData unit)
    {
    }

    [Token(Token = "0x600D7F0")]
    [Address(RVA = "0x1B8E6B0", Offset = "0x1B8E6B0", VA = "0x1B8E6B0")]
    private void CollectMoveSlayValues(UnitParameterData unit)
    {
    }

    [Token(Token = "0x600D7F1")]
    [Address(RVA = "0x1B8E8E0", Offset = "0x1B8E8E0", VA = "0x1B8E8E0")]
    private void SetSlayText()
    {
    }

    [Token(Token = "0x600D7F2")]
    [Address(RVA = "0x1B8E97C", Offset = "0x1B8E97C", VA = "0x1B8E97C")]
    private void SetResistSlayText()
    {
    }

    [Token(Token = "0x600D7F3")]
    [Address(RVA = "0x1B8ED78", Offset = "0x1B8ED78", VA = "0x1B8ED78")]
    public UnitStatusSpecialEffectFactor()
    {
    }
  }
}
