// Decompiled with JetBrains decompiler
// Type: Scenes.Expedition.Popup.ExpeditionStyleExpPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using Network.Param;
using Scenes.Expedition.Main;
using Scenes.OutGame.StyleLevelUp;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.Expedition.Popup
{
  [Token(Token = "0x2002C76")]
  public class ExpeditionStyleExpPopup : PopupBase
  {
    [Token(Token = "0x400BD75")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private CommonButton bgButton;
    [Token(Token = "0x400BD76")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private CommonButton tapNextButton;
    [Token(Token = "0x400BD77")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private ExpeditionStyleExpUnitList[] unitLists;
    [Token(Token = "0x400BD78")]
    [FieldOffset(Offset = "0xA0")]
    private Action closeAction;
    [Token(Token = "0x400BD79")]
    [FieldOffset(Offset = "0xA8")]
    private bool isTapEnable;
    [Token(Token = "0x400BD7A")]
    [FieldOffset(Offset = "0xB0")]
    private List<PlayerUnitType> playerUnits;
    [Token(Token = "0x400BD7B")]
    [FieldOffset(Offset = "0xB8")]
    private StyleLevelUpEffect styleLevelUpEffect;
    [Token(Token = "0x400BD7C")]
    [FieldOffset(Offset = "0xC0")]
    private Dictionary<int, Style> oldStyleDic;
    [Token(Token = "0x400BD7D")]
    [FieldOffset(Offset = "0xC8")]
    private bool playEffectLevelUP;

    [Token(Token = "0x6011674")]
    [Address(RVA = "0x4E201B4", Offset = "0x4E201B4", VA = "0x4E201B4")]
    public static ExpeditionOrganization.ExpeditionOldParty[] GetExpeditionOldPartyData(
      int partyCount)
    {
      return (ExpeditionOrganization.ExpeditionOldParty[]) null;
    }

    [Token(Token = "0x6011675")]
    [Address(RVA = "0x4E20708", Offset = "0x4E20708", VA = "0x4E20708")]
    public static bool IsAddExp(
      ExpeditionOrganization.ExpeditionOldParty[] oldPartys)
    {
      return new bool();
    }

    [Token(Token = "0x6011676")]
    [Address(RVA = "0x4E20894", Offset = "0x4E20894", VA = "0x4E20894")]
    public void Initialized(
      ExpeditionOrganization.ExpeditionOldParty[] oldPartys,
      List<PlayerUnitType> playerUnits)
    {
    }

    [Token(Token = "0x6011677")]
    [Address(RVA = "0x4E20E40", Offset = "0x4E20E40", VA = "0x4E20E40")]
    private IEnumerator LevelUpEffectWait() => (IEnumerator) null;

    [Token(Token = "0x6011678")]
    [Address(RVA = "0x4E20ED0", Offset = "0x4E20ED0", VA = "0x4E20ED0")]
    public void SetCloseAction(Action closeAction)
    {
    }

    [Token(Token = "0x6011679")]
    [Address(RVA = "0x4E20ED8", Offset = "0x4E20ED8", VA = "0x4E20ED8", Slot = "9")]
    public override void Close()
    {
    }

    [Token(Token = "0x601167A")]
    [Address(RVA = "0x4E20EFC", Offset = "0x4E20EFC", VA = "0x4E20EFC")]
    private void OnLevelUpStyle(Style style)
    {
    }

    [Token(Token = "0x601167B")]
    [Address(RVA = "0x4E20F34", Offset = "0x4E20F34", VA = "0x4E20F34")]
    private IEnumerator EffectLevelUP(Style style) => (IEnumerator) null;

    [Token(Token = "0x601167C")]
    [Address(RVA = "0x4E20FD0", Offset = "0x4E20FD0", VA = "0x4E20FD0")]
    private void FinishStartStyleLevelUp()
    {
    }

    [Token(Token = "0x601167D")]
    [Address(RVA = "0x4E21050", Offset = "0x4E21050", VA = "0x4E21050")]
    public ExpeditionStyleExpPopup()
    {
    }
  }
}
