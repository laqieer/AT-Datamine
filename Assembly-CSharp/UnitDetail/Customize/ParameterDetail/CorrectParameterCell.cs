// Decompiled with JetBrains decompiler
// Type: UnitDetail.Customize.ParameterDetail.CorrectParameterCell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UnitDetail.Customize.ParameterDetail
{
  [Token(Token = "0x20004F8")]
  public class CorrectParameterCell : MonoBehaviour
  {
    [Token(Token = "0x40019F5")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text label;
    [Token(Token = "0x40019F6")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text corrected;

    [Token(Token = "0x6001C5B")]
    [Address(RVA = "0x2C33E7C", Offset = "0x2C33E7C", VA = "0x2C33E7C")]
    public void UpdateCell(string label, int corrected)
    {
    }

    [Token(Token = "0x6001C5C")]
    [Address(RVA = "0x2C33F4C", Offset = "0x2C33F4C", VA = "0x2C33F4C")]
    public CorrectParameterCell()
    {
    }
  }
}
