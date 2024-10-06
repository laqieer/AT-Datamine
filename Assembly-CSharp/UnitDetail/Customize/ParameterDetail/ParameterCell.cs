// Decompiled with JetBrains decompiler
// Type: UnitDetail.Customize.ParameterDetail.ParameterCell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UnitDetail.Customize.ParameterDetail
{
  [Token(Token = "0x20004FA")]
  public class ParameterCell : MonoBehaviour
  {
    [Token(Token = "0x40019FB")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text label;
    [Token(Token = "0x40019FC")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text total;

    [Token(Token = "0x6001C5F")]
    [Address(RVA = "0x2C340F4", Offset = "0x2C340F4", VA = "0x2C340F4")]
    public void UpdateCell(string label, int total)
    {
    }

    [Token(Token = "0x6001C60")]
    [Address(RVA = "0x2C341C4", Offset = "0x2C341C4", VA = "0x2C341C4")]
    public ParameterCell()
    {
    }
  }
}
