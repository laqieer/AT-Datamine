// Decompiled with JetBrains decompiler
// Type: UnitDetail.Customize.ParameterCell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UnitDetail.Customize
{
  [Token(Token = "0x20004E4")]
  public class ParameterCell : MonoBehaviour
  {
    [Token(Token = "0x4001974")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text label;
    [Token(Token = "0x4001975")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text parameter;
    [Token(Token = "0x4001976")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Image limitedImage;
    [Token(Token = "0x4001977")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Color paramUpColor;
    [Token(Token = "0x4001978")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text pinValue;
    [Token(Token = "0x4001979")]
    [FieldOffset(Offset = "0x48")]
    private int index;
    [Token(Token = "0x400197A")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Toggle toggle;

    [Token(Token = "0x17000377")]
    public bool isOn
    {
      [Token(Token = "0x6001BB1"), Address(RVA = "0x2C2CED0", Offset = "0x2C2CED0", VA = "0x2C2CED0")] get
      {
        return new bool();
      }
      [Token(Token = "0x6001BB2"), Address(RVA = "0x2C2CEEC", Offset = "0x2C2CEEC", VA = "0x2C2CEEC")] set
      {
      }
    }

    [Token(Token = "0x17000378")]
    public Action<int> OnChangeToggle
    {
      [Token(Token = "0x6001BB3"), Address(RVA = "0x2C2D018", Offset = "0x2C2D018", VA = "0x2C2D018")] get
      {
        return (Action<int>) null;
      }
      [Token(Token = "0x6001BB4"), Address(RVA = "0x2C2D020", Offset = "0x2C2D020", VA = "0x2C2D020")] set
      {
      }
    }

    [Token(Token = "0x6001BB5")]
    [Address(RVA = "0x2C2D028", Offset = "0x2C2D028", VA = "0x2C2D028")]
    public void UpdateParameter(string label, int parameter, int maxParameter)
    {
    }

    [Token(Token = "0x6001BB6")]
    [Address(RVA = "0x2C2D120", Offset = "0x2C2D120", VA = "0x2C2D120")]
    public void UpdateParameter(int index, string label, int parameter)
    {
    }

    [Token(Token = "0x6001BB7")]
    [Address(RVA = "0x2C2D1F8", Offset = "0x2C2D1F8", VA = "0x2C2D1F8")]
    public void UpdateParametarByUpParam(string label, int parameter, bool isUpParam)
    {
    }

    [Token(Token = "0x6001BB8")]
    [Address(RVA = "0x2C2D308", Offset = "0x2C2D308", VA = "0x2C2D308")]
    public void SetBeforePinAverageValue(float pinAverage)
    {
    }

    [Token(Token = "0x6001BB9")]
    [Address(RVA = "0x2C2D3A4", Offset = "0x2C2D3A4", VA = "0x2C2D3A4")]
    public void OnClickToToggle(bool isOn)
    {
    }

    [Token(Token = "0x6001BBA")]
    [Address(RVA = "0x2C2D3C8", Offset = "0x2C2D3C8", VA = "0x2C2D3C8")]
    public ParameterCell()
    {
    }
  }
}
