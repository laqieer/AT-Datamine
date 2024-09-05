// Decompiled with JetBrains decompiler
// Type: UnitDetail.Customize.FeatureDetail.SpecialEffectCell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UnitDetail.Customize.FeatureDetail
{
  [Token(Token = "0x20004FE")]
  public class SpecialEffectCell : MonoBehaviour
  {
    [Token(Token = "0x4001A9E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text label;
    [Token(Token = "0x4001A9F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text value;
    [Token(Token = "0x4001AA0")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Color positiveColor;
    [Token(Token = "0x4001AA1")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Color negativeColor;

    [Token(Token = "0x6001C8B")]
    [Address(RVA = "0x29F2C3C", Offset = "0x29F2C3C", VA = "0x29F2C3C")]
    public void UpdateCell(string label, int value)
    {
    }

    [Token(Token = "0x6001C8C")]
    [Address(RVA = "0x29F2D58", Offset = "0x29F2D58", VA = "0x29F2D58")]
    public SpecialEffectCell()
    {
    }
  }
}
