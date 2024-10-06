// Decompiled with JetBrains decompiler
// Type: Battle.UI.FieldOptionTopPanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using GameCore.Input;
using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections;
using UI.Common;
using UI.Direction;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x2002329")]
  public class FieldOptionTopPanel : MonoBehaviour
  {
    [Token(Token = "0x4009521")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController timelineController;
    [Token(Token = "0x4009522")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject[] battleMenuList;
    [Token(Token = "0x4009523")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject[] arenaMenuList;
    [Token(Token = "0x4009524")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Button closeButton;
    [Token(Token = "0x4009525")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private BtnFullScreen closeBackgroundButton;
    [Token(Token = "0x4009526")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Button questInformationButton;
    [Token(Token = "0x4009527")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Button optionSettingButton;
    [Token(Token = "0x4009528")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Button unitInformationButton;
    [Token(Token = "0x4009529")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Button missionInformationButton;
    [Token(Token = "0x400952A")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Text missionText;
    [Token(Token = "0x400952B")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Button giveUpButton;
    [Token(Token = "0x400952C")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private CanvasGroup canvasGroup;
    [Token(Token = "0x400952D")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x400952E")]
    [FieldOffset(Offset = "0x80")]
    private bool arenaFlag;
    [Token(Token = "0x400952F")]
    [FieldOffset(Offset = "0x84")]
    private QuestTypeEnum questType;
    [Token(Token = "0x4009530")]
    [FieldOffset(Offset = "0x88")]
    private BattleConfigData battleConfig;

    [Token(Token = "0x17002E56")]
    public UnityAction CloseButtonEvent
    {
      [Token(Token = "0x600D6EF"), Address(RVA = "0x1D245FC", Offset = "0x1D245FC", VA = "0x1D245FC")] set
      {
      }
    }

    [Token(Token = "0x17002E57")]
    public UnityAction QuestInformationButtonEvent
    {
      [Token(Token = "0x600D6F0"), Address(RVA = "0x1D24658", Offset = "0x1D24658", VA = "0x1D24658")] set
      {
      }
    }

    [Token(Token = "0x17002E58")]
    public UnityAction OptionSettingButtonEvent
    {
      [Token(Token = "0x600D6F1"), Address(RVA = "0x1D2467C", Offset = "0x1D2467C", VA = "0x1D2467C")] set
      {
      }
    }

    [Token(Token = "0x17002E59")]
    public UnityAction UnitInformationButtonEvent
    {
      [Token(Token = "0x600D6F2"), Address(RVA = "0x1D246A0", Offset = "0x1D246A0", VA = "0x1D246A0")] set
      {
      }
    }

    [Token(Token = "0x17002E5A")]
    public UnityAction MissionInformationButtonEvent
    {
      [Token(Token = "0x600D6F3"), Address(RVA = "0x1D246C4", Offset = "0x1D246C4", VA = "0x1D246C4")] set
      {
      }
    }

    [Token(Token = "0x17002E5B")]
    public UnityAction GiveUpButtonEvent
    {
      [Token(Token = "0x600D6F4"), Address(RVA = "0x1D246E8", Offset = "0x1D246E8", VA = "0x1D246E8")] set
      {
      }
    }

    [Token(Token = "0x600D6F5")]
    [Address(RVA = "0x1D2470C", Offset = "0x1D2470C", VA = "0x1D2470C")]
    public IEnumerator InitializeCoroutine(QuestTypeEnum questType, BattleConfigData battleConfig)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600D6F6")]
    [Address(RVA = "0x1D247B4", Offset = "0x1D247B4", VA = "0x1D247B4")]
    public void Show()
    {
    }

    [Token(Token = "0x600D6F7")]
    [Address(RVA = "0x1D24988", Offset = "0x1D24988", VA = "0x1D24988")]
    public void Hide(UnityAction callback = null)
    {
    }

    [Token(Token = "0x600D6F8")]
    [Address(RVA = "0x1D2483C", Offset = "0x1D2483C", VA = "0x1D2483C")]
    private void MenuButtonListSet(bool arena)
    {
    }

    [Token(Token = "0x600D6F9")]
    [Address(RVA = "0x1D24A78", Offset = "0x1D24A78", VA = "0x1D24A78")]
    public FieldOptionTopPanel()
    {
    }
  }
}
