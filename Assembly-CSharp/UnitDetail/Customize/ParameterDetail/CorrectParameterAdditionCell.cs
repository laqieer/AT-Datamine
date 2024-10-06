// Decompiled with JetBrains decompiler
// Type: UnitDetail.Customize.ParameterDetail.CorrectParameterAdditionCell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UnitDetail.Customize.ParameterDetail
{
  [Token(Token = "0x20004F7")]
  public class CorrectParameterAdditionCell : MonoBehaviour
  {
    [Token(Token = "0x40019F0")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text changeRate;
    [Token(Token = "0x40019F1")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text total;
    [Token(Token = "0x40019F2")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text masterBonus;
    [Token(Token = "0x40019F3")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text guildStoneStatue;
    [Token(Token = "0x40019F4")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text weaponMasterBonus;

    [Token(Token = "0x6001C59")]
    [Address(RVA = "0x2C33C80", Offset = "0x2C33C80", VA = "0x2C33C80")]
    public void UpdateCell(
      int changeRate,
      int total,
      int masterBonus,
      int guildStoneStatue,
      int weaponMasterBonus)
    {
    }

    [Token(Token = "0x6001C5A")]
    [Address(RVA = "0x2C33E74", Offset = "0x2C33E74", VA = "0x2C33E74")]
    public CorrectParameterAdditionCell()
    {
    }
  }
}
