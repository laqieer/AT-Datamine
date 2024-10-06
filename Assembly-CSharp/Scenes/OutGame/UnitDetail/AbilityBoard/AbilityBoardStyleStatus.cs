// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.UnitDetail.AbilityBoard.AbilityBoardStyleStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using UI.Common;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.UnitDetail.AbilityBoard
{
  [Token(Token = "0x2003340")]
  public class AbilityBoardStyleStatus : MonoBehaviour
  {
    [Token(Token = "0x400DDEC")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text Lv_Txt_Num;
    [Token(Token = "0x400DDED")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text Lv_Txt_Num_Max;
    [Token(Token = "0x400DDEE")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GaugeScale expSlider;
    [Token(Token = "0x400DDEF")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text Txt_CombatPower_Num;
    [Token(Token = "0x400DDF0")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text Status_Life_Txt_Value;
    [Token(Token = "0x400DDF1")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text Status_Strength_Txt_Value;
    [Token(Token = "0x400DDF2")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Text Status_Mag_Txt_Value;
    [Token(Token = "0x400DDF3")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Text Status_Def_Txt_Value;
    [Token(Token = "0x400DDF4")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Text Status_Spirit_Txt_Value;
    [Token(Token = "0x400DDF5")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Text Status_Speed_Txt_Value;
    [Token(Token = "0x400DDF6")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Text Status_Tech_Txt_Value;
    [Token(Token = "0x400DDF7")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Text Status_Luck_Txt_Value;
    [Token(Token = "0x400DDF8")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Text Status_Move_Txt_Value;
    [Token(Token = "0x400DDF9")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private CommonButton Btn_Detail;

    [Token(Token = "0x6014239")]
    [Address(RVA = "0x20CF964", Offset = "0x20CF964", VA = "0x20CF964")]
    public void UpdateParameterText(Style style)
    {
    }

    [Token(Token = "0x601423A")]
    [Address(RVA = "0x20CFE9C", Offset = "0x20CFE9C", VA = "0x20CFE9C")]
    public AbilityBoardStyleStatus()
    {
    }
  }
}
