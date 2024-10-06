// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.LimitedEventQuest.EventQuestStageThumbnail
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using GameCore.UIControls;
using Il2CppDummyDll;
using System.Collections.Generic;
using TMPro;
using UI.Utilities.SerializeUI;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.LimitedEventQuest
{
  [Token(Token = "0x200363B")]
  public class EventQuestStageThumbnail : MonoBehaviour
  {
    [Token(Token = "0x400EBEB")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tween;
    [Token(Token = "0x400EBEC")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CanvasGroup canvasGroup;
    [Token(Token = "0x400EBED")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private CommonButton selectButton;
    [Token(Token = "0x400EBEE")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private UIGraphicLaycastCollider selectButtonCollider;
    [Token(Token = "0x400EBEF")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Image questStageThumbnail;
    [Token(Token = "0x400EBF0")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private UI.Utilities.SerializeUI.TextContainer stageNameText;
    [Token(Token = "0x400EBF1")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GameObject leftTimeRootObject;
    [Token(Token = "0x400EBF2")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private TextMeshProUGUI timeHour;
    [Token(Token = "0x400EBF3")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private TextMeshProUGUI timeMinute;
    [Token(Token = "0x400EBF4")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private GameObject missionRootObject;
    [Token(Token = "0x400EBF5")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private ActiveObjectContainers missionContainers;
    [Token(Token = "0x400EBF6")]
    [FieldOffset(Offset = "0x70")]
    private UnityAction<EventQuestStageThumbnail> selectStageEvnet;
    [Token(Token = "0x400EBF7")]
    [FieldOffset(Offset = "0x78")]
    private List<string> tweenPlayList;
    [Token(Token = "0x400EBF8")]
    [FieldOffset(Offset = "0x80")]
    private int numMission;

    [Token(Token = "0x60155A0")]
    [Address(RVA = "0x18D3474", Offset = "0x18D3474", VA = "0x18D3474")]
    public void SetUp(
      int questStageId,
      Sprite thumbnailSprite,
      string stageName,
      (int leftHours, int leftMinutes)? openLeftTime,
      List<bool> missionClears,
      bool stageLock,
      bool bossIcon,
      UnityAction<EventQuestStageThumbnail> selectStageEvnet)
    {
    }

    [Token(Token = "0x170046F9")]
    private bool HasMissions
    {
      [Token(Token = "0x60155A1"), Address(RVA = "0x18D3D74", Offset = "0x18D3D74", VA = "0x18D3D74")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60155A2")]
    [Address(RVA = "0x18D3C94", Offset = "0x18D3C94", VA = "0x18D3C94")]
    private void SetActiveMissionRoot(bool isActive)
    {
    }

    [Token(Token = "0x60155A3")]
    [Address(RVA = "0x18D3D84", Offset = "0x18D3D84", VA = "0x18D3D84")]
    public void NewBadgeOff()
    {
    }

    [Token(Token = "0x60155A4")]
    [Address(RVA = "0x18D3DD4", Offset = "0x18D3DD4", VA = "0x18D3DD4")]
    public void Show()
    {
    }

    [Token(Token = "0x60155A5")]
    [Address(RVA = "0x18D3E20", Offset = "0x18D3E20", VA = "0x18D3E20")]
    public void Hide()
    {
    }

    [Token(Token = "0x60155A6")]
    [Address(RVA = "0x18D3AB8", Offset = "0x18D3AB8", VA = "0x18D3AB8")]
    public void SetOpenStageLeftTime((int leftHours, int leftMinutes)? leftTime)
    {
    }

    [Token(Token = "0x60155A7")]
    [Address(RVA = "0x18D3E6C", Offset = "0x18D3E6C", VA = "0x18D3E6C")]
    private void SelectButtonEvent()
    {
    }

    [Token(Token = "0x60155A8")]
    [Address(RVA = "0x18D3BEC", Offset = "0x18D3BEC", VA = "0x18D3BEC")]
    public void AddTweenPlayList(string groupId)
    {
    }

    [Token(Token = "0x60155A9")]
    [Address(RVA = "0x18D3CC4", Offset = "0x18D3CC4", VA = "0x18D3CC4")]
    public void PlayTweenPlayList()
    {
    }

    [Token(Token = "0x60155AA")]
    [Address(RVA = "0x18D3E8C", Offset = "0x18D3E8C", VA = "0x18D3E8C")]
    public void ResetTweenPlayList(bool isRollback)
    {
    }

    [Token(Token = "0x60155AB")]
    [Address(RVA = "0x18D401C", Offset = "0x18D401C", VA = "0x18D401C")]
    public EventQuestStageThumbnail()
    {
    }
  }
}
