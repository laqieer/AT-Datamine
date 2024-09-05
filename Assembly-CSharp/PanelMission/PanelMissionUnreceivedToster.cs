// Decompiled with JetBrains decompiler
// Type: PanelMission.PanelMissionUnreceivedToster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.UIControls;
using Il2CppDummyDll;
using System;
using TMPro;
using UnityEngine;

#nullable disable
namespace PanelMission
{
  [Token(Token = "0x2000A3B")]
  public class PanelMissionUnreceivedToster : MonoBehaviour
  {
    [Token(Token = "0x4002F78")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CommonButton _commonButton;
    [Token(Token = "0x4002F79")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextMeshProUGUI _remainText;
    [Token(Token = "0x4002F7A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private LocalizeText _localizeText;

    [Token(Token = "0x6003A6B")]
    [Address(RVA = "0x3315F28", Offset = "0x3315F28", VA = "0x3315F28")]
    public void SetOnClickReceive(Action onClickReceive)
    {
    }

    [Token(Token = "0x6003A6C")]
    [Address(RVA = "0x3316018", Offset = "0x3316018", VA = "0x3316018")]
    public void SetRemainDays(int remainDay)
    {
    }

    [Token(Token = "0x6003A6D")]
    [Address(RVA = "0x33160D0", Offset = "0x33160D0", VA = "0x33160D0")]
    public PanelMissionUnreceivedToster()
    {
    }
  }
}
