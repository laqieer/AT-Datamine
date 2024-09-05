// Decompiled with JetBrains decompiler
// Type: Story.KizunaQuest.KizunaQuestPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Input;
using GameCore.Popup;
using GameCore.Tween;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Story.KizunaQuest
{
  [Token(Token = "0x2000688")]
  public class KizunaQuestPopup : PopupBase
  {
    [Token(Token = "0x4001F5E")]
    [FieldOffset(Offset = "0x88")]
    private Dictionary<KizunaQuestPopup.TweenGroupType, string> tweenAnimMap;
    [Token(Token = "0x4001F5F")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x4001F60")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private KizunaQuestContainer kizunaQuestContainer;
    [Token(Token = "0x4001F61")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private CommonButton confirmButton;
    [Token(Token = "0x4001F62")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private CommonButton cancelButton;
    [Token(Token = "0x4001F63")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private CanvasGroup canvasGroup;
    [Token(Token = "0x4001F64")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;

    [Token(Token = "0x17000579")]
    public Action OnClickFastTravelAction
    {
      [Token(Token = "0x600254B"), Address(RVA = "0x2F37E24", Offset = "0x2F37E24", VA = "0x2F37E24")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x600254C"), Address(RVA = "0x2F37E2C", Offset = "0x2F37E2C", VA = "0x2F37E2C")] set
      {
      }
    }

    [Token(Token = "0x600254D")]
    [Address(RVA = "0x2F37E34", Offset = "0x2F37E34", VA = "0x2F37E34")]
    public void SetActive(bool active)
    {
    }

    [Token(Token = "0x600254E")]
    [Address(RVA = "0x2F37E60", Offset = "0x2F37E60", VA = "0x2F37E60")]
    public void SetData(
      IKizunaQuestPopupParam uiParam,
      GameObject rankUpInfoPrefab,
      GameObject itemIcon)
    {
    }

    [Token(Token = "0x600254F")]
    [Address(RVA = "0x2F38174", Offset = "0x2F38174", VA = "0x2F38174")]
    public void PlayToAnim(KizunaQuestPopup.TweenGroupType tweenGroupType)
    {
    }

    [Token(Token = "0x6002550")]
    [Address(RVA = "0x2F381E8", Offset = "0x2F381E8", VA = "0x2F381E8")]
    public void OnClickToFastTravel()
    {
    }

    [Token(Token = "0x6002551")]
    [Address(RVA = "0x2F38204", Offset = "0x2F38204", VA = "0x2F38204")]
    private void OnClickFastTravelWithNoRankUp()
    {
    }

    [Token(Token = "0x6002552")]
    [Address(RVA = "0x2F382E0", Offset = "0x2F382E0", VA = "0x2F382E0")]
    public KizunaQuestPopup()
    {
    }

    [Token(Token = "0x2000689")]
    public enum TweenGroupType
    {
      [Token(Token = "0x4001F67")] TweenIn,
      [Token(Token = "0x4001F68")] TweenOut,
      [Token(Token = "0x4001F69")] KizunaQuestInfo,
      [Token(Token = "0x4001F6A")] RankUpReward,
    }

    [Token(Token = "0x200068A")]
    public class UIParam : IKizunaQuestPopupParam
    {
      [Token(Token = "0x4001F6B")]
      [FieldOffset(Offset = "0x10")]
      private readonly bool canProceedKizunaQuest;

      [Token(Token = "0x6002555")]
      [Address(RVA = "0x2F38430", Offset = "0x2F38430", VA = "0x2F38430")]
      public UIParam(Communication communication, bool canProceedKizunaQuest)
      {
      }

      [Token(Token = "0x1700057A")]
      public Communication CommunicationData
      {
        [Token(Token = "0x6002556"), Address(RVA = "0x2F38460", Offset = "0x2F38460", VA = "0x2F38460", Slot = "4")] get
        {
          return (Communication) null;
        }
      }

      [Token(Token = "0x6002557")]
      [Address(RVA = "0x2F38468", Offset = "0x2F38468", VA = "0x2F38468", Slot = "5")]
      public bool CanProceedKizunaQuest() => new bool();
    }
  }
}
