// Decompiled with JetBrains decompiler
// Type: UnitDetail.Customize.ParameterDetail.BattleParameterCell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UnitDetail.Customize.ParameterDetail
{
  [Token(Token = "0x20004F6")]
  public class BattleParameterCell : MonoBehaviour
  {
    [Token(Token = "0x40019EE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text label;
    [Token(Token = "0x40019EF")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text total;

    [Token(Token = "0x6001C57")]
    [Address(RVA = "0x2C33BA8", Offset = "0x2C33BA8", VA = "0x2C33BA8")]
    public void UpdateCell(string label, int total)
    {
    }

    [Token(Token = "0x6001C58")]
    [Address(RVA = "0x2C33C78", Offset = "0x2C33C78", VA = "0x2C33C78")]
    public BattleParameterCell()
    {
    }
  }
}
