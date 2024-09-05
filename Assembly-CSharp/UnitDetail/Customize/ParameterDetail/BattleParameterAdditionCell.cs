// Decompiled with JetBrains decompiler
// Type: UnitDetail.Customize.ParameterDetail.BattleParameterAdditionCell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UnitDetail.Customize.ParameterDetail
{
  [Token(Token = "0x20004F5")]
  public class BattleParameterAdditionCell : MonoBehaviour
  {
    [Token(Token = "0x40019EA")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text unit;
    [Token(Token = "0x40019EB")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text abilityBoard;
    [Token(Token = "0x40019EC")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text customSkill;
    [Token(Token = "0x40019ED")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text equipment;

    [Token(Token = "0x6001C55")]
    [Address(RVA = "0x2C33A08", Offset = "0x2C33A08", VA = "0x2C33A08")]
    public void UpdateCell(int unit, int abilityBoard, int customSkill, int equipment)
    {
    }

    [Token(Token = "0x6001C56")]
    [Address(RVA = "0x2C33BA0", Offset = "0x2C33BA0", VA = "0x2C33BA0")]
    public BattleParameterAdditionCell()
    {
    }
  }
}
