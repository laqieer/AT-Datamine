// Decompiled with JetBrains decompiler
// Type: UnitDetail.Customize.ParameterDetail.BasicParameterAdditionCell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UnitDetail.Customize.ParameterDetail
{
  [Token(Token = "0x20004F3")]
  public class BasicParameterAdditionCell : MonoBehaviour
  {
    [Token(Token = "0x40019E2")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text initial;
    [Token(Token = "0x40019E3")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text abilityBoard;
    [Token(Token = "0x40019E4")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text equipment;

    [Token(Token = "0x6001C51")]
    [Address(RVA = "0x2C33724", Offset = "0x2C33724", VA = "0x2C33724")]
    public void UpdateCell(int initial, int abilityBoard, int equipment)
    {
    }

    [Token(Token = "0x6001C52")]
    [Address(RVA = "0x2C3386C", Offset = "0x2C3386C", VA = "0x2C3386C")]
    public BasicParameterAdditionCell()
    {
    }
  }
}
