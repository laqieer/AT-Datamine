// Decompiled with JetBrains decompiler
// Type: UnitDetail.Customize.ParameterDetail.ParameterAdditionCell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UnitDetail.Customize.ParameterDetail
{
  [Token(Token = "0x20004F9")]
  public class ParameterAdditionCell : MonoBehaviour
  {
    [Token(Token = "0x40019F7")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text initial;
    [Token(Token = "0x40019F8")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text abilityBoard;
    [Token(Token = "0x40019F9")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text customSkill;
    [Token(Token = "0x40019FA")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text equipment;

    [Token(Token = "0x6001C5D")]
    [Address(RVA = "0x2C33F54", Offset = "0x2C33F54", VA = "0x2C33F54")]
    public void UpdateCell(int initial, int abilityBoard, int customSkill, int equipment)
    {
    }

    [Token(Token = "0x6001C5E")]
    [Address(RVA = "0x2C340EC", Offset = "0x2C340EC", VA = "0x2C340EC")]
    public ParameterAdditionCell()
    {
    }
  }
}
