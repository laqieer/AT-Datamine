// Decompiled with JetBrains decompiler
// Type: PanelMission.PanelMissionPanelSelectButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace PanelMission
{
  [Token(Token = "0x2000A28")]
  public class PanelMissionPanelSelectButton : MonoBehaviour
  {
    [Token(Token = "0x4002F06")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextMeshProUGUI _missionName;
    [Token(Token = "0x4002F07")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Button _selectButton;
    [Token(Token = "0x4002F08")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject _remainDaysRoot;
    [Token(Token = "0x4002F09")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text _remainDays;
    [Token(Token = "0x4002F0A")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject _remainTimeRoot;
    [Token(Token = "0x4002F0B")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text _remainTime;
    [Token(Token = "0x4002F0C")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GameObject _remainReceiptRoot;
    [Token(Token = "0x4002F0D")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Text _remainReceiptTime;
    [Token(Token = "0x4002F0E")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private GameObject _selectMarker;
    [Token(Token = "0x4002F0F")]
    [FieldOffset(Offset = "0x60")]
    private Action<int> OnPressSelectButton;
    [Token(Token = "0x4002F10")]
    [FieldOffset(Offset = "0x68")]
    private UITweenGroup _tweenGroup;

    [Token(Token = "0x1700084C")]
    public int MissionId
    {
      [Token(Token = "0x60039EE"), Address(RVA = "0x3115FEC", Offset = "0x3115FEC", VA = "0x3115FEC")] get
      {
        return new int();
      }
      [Token(Token = "0x60039EF"), Address(RVA = "0x3115FF4", Offset = "0x3115FF4", VA = "0x3115FF4")] set
      {
      }
    }

    [Token(Token = "0x60039F0")]
    [Address(RVA = "0x3115FFC", Offset = "0x3115FFC", VA = "0x3115FFC")]
    public void Initialize()
    {
    }

    [Token(Token = "0x60039F1")]
    [Address(RVA = "0x311604C", Offset = "0x311604C", VA = "0x311604C")]
    public void SetBadgeActive(bool value)
    {
    }

    [Token(Token = "0x60039F2")]
    [Address(RVA = "0x31160C4", Offset = "0x31160C4", VA = "0x31160C4")]
    public void SetSelectingState(bool value)
    {
    }

    [Token(Token = "0x60039F3")]
    [Address(RVA = "0x311613C", Offset = "0x311613C", VA = "0x311613C")]
    public void SetMissionName(string missionName)
    {
    }

    [Token(Token = "0x60039F4")]
    [Address(RVA = "0x3116160", Offset = "0x3116160", VA = "0x3116160")]
    public void SetRemainDays(int days)
    {
    }

    [Token(Token = "0x60039F5")]
    [Address(RVA = "0x31161E0", Offset = "0x31161E0", VA = "0x31161E0")]
    public void SetRemainTime(int hour, int minutes)
    {
    }

    [Token(Token = "0x60039F6")]
    [Address(RVA = "0x311629C", Offset = "0x311629C", VA = "0x311629C")]
    public void SetRemainReceiptDays(int days)
    {
    }

    [Token(Token = "0x60039F7")]
    [Address(RVA = "0x3116334", Offset = "0x3116334", VA = "0x3116334")]
    public void SetRemainReceiptTime(int hour, int minutes)
    {
    }

    [Token(Token = "0x60039F8")]
    [Address(RVA = "0x31163F0", Offset = "0x31163F0", VA = "0x31163F0")]
    public void SetRemainTimeObjectActive(bool remainDays, bool remainTime, bool receiveReward)
    {
    }

    [Token(Token = "0x60039F9")]
    [Address(RVA = "0x311644C", Offset = "0x311644C", VA = "0x311644C")]
    public void SetOnPressSelectButton(Action<int> action)
    {
    }

    [Token(Token = "0x60039FA")]
    [Address(RVA = "0x3116500", Offset = "0x3116500", VA = "0x3116500")]
    public PanelMissionPanelSelectButton()
    {
    }
  }
}
