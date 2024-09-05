// Decompiled with JetBrains decompiler
// Type: UnitDetail.Customize.ParameterDetail.BasicParameterCell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UnitDetail.Customize.ParameterDetail
{
  [Token(Token = "0x20004F4")]
  public class BasicParameterCell : MonoBehaviour
  {
    [Token(Token = "0x40019E5")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text label;
    [Token(Token = "0x40019E6")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text total;
    [Token(Token = "0x40019E7")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text levelup;
    [Token(Token = "0x40019E8")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text levelupLimit;
    [Token(Token = "0x40019E9")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Image limitedImage;

    [Token(Token = "0x6001C53")]
    [Address(RVA = "0x2C33874", Offset = "0x2C33874", VA = "0x2C33874")]
    public void UpdateCell(string label, int total, int levelup, int levelupLimit)
    {
    }

    [Token(Token = "0x6001C54")]
    [Address(RVA = "0x2C33A00", Offset = "0x2C33A00", VA = "0x2C33A00")]
    public BasicParameterCell()
    {
    }
  }
}
