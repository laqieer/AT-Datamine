// Decompiled with JetBrains decompiler
// Type: Battle.UI.FieldDamageTween
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x20022F1")]
  public class FieldDamageTween : TweenWrapper
  {
    [Token(Token = "0x40093BF")]
    [FieldOffset(Offset = "0x0")]
    private static readonly Color DamageColor;
    [Token(Token = "0x40093C0")]
    [FieldOffset(Offset = "0x10")]
    private static readonly Color HealingColor;
    [Token(Token = "0x40093C1")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Image damageRightDigit;
    [Token(Token = "0x40093C2")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Image damageCenterDigit;
    [Token(Token = "0x40093C3")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Image damageLeftDigit;
    [Token(Token = "0x40093C4")]
    [FieldOffset(Offset = "0x38")]
    [HideInInspector]
    [SerializeField]
    private string inTweenName;
    [Token(Token = "0x40093C5")]
    [FieldOffset(Offset = "0x40")]
    [HideInInspector]
    [SerializeField]
    private string outTweenName;
    [Token(Token = "0x40093C6")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Sprite[] numberSprites;
    [Token(Token = "0x40093C7")]
    [FieldOffset(Offset = "0x50")]
    private bool setCallbackOnCompletedInTween;

    [Token(Token = "0x600D5AB")]
    [Address(RVA = "0x1D165E4", Offset = "0x1D165E4", VA = "0x1D165E4")]
    public void Play(int damageValue, Vector3 screenPosition, bool isDamage)
    {
    }

    [Token(Token = "0x600D5AC")]
    [Address(RVA = "0x1D16A18", Offset = "0x1D16A18", VA = "0x1D16A18")]
    private void OnCompletedInTween()
    {
    }

    [Token(Token = "0x600D5AD")]
    [Address(RVA = "0x1D16B40", Offset = "0x1D16B40", VA = "0x1D16B40")]
    public FieldDamageTween()
    {
    }

    [Token(Token = "0x600D5AE")]
    [Address(RVA = "0x1D16BC4", Offset = "0x1D16BC4", VA = "0x1D16BC4")]
    static FieldDamageTween()
    {
    }
  }
}
