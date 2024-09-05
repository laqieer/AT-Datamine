// Decompiled with JetBrains decompiler
// Type: GameCore.UIControls.ItemRewardPopupManage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace GameCore.UIControls
{
  [Token(Token = "0x2000BFD")]
  public class ItemRewardPopupManage
  {
    [Token(Token = "0x4003668")]
    [FieldOffset(Offset = "0x10")]
    private ItemRewardPopupContainer popupcontainer;
    [Token(Token = "0x4003669")]
    [FieldOffset(Offset = "0x18")]
    private List<string> needABnames;
    [Token(Token = "0x400366A")]
    [FieldOffset(Offset = "0x20")]
    private ItemRewardPopup popup;
    [Token(Token = "0x400366B")]
    [FieldOffset(Offset = "0x28")]
    private GameObject popupGo;
    [Token(Token = "0x400366C")]
    [FieldOffset(Offset = "0x30")]
    private Action outEndCallback;
    [Token(Token = "0x400366D")]
    [FieldOffset(Offset = "0x38")]
    private bool showEffect;
    [Token(Token = "0x400366E")]
    [FieldOffset(Offset = "0x39")]
    private bool ended;

    [Token(Token = "0x60044C0")]
    [Address(RVA = "0x364BFC4", Offset = "0x364BFC4", VA = "0x364BFC4")]
    public IEnumerator SystemInitializeProcess(string ABName = "ui_common_prefabs", string ABAssetName = "Container_Popup_ItemReward")
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60044C1")]
    [Address(RVA = "0x364C068", Offset = "0x364C068", VA = "0x364C068")]
    public void SetBGActive(int value)
    {
    }

    [Token(Token = "0x60044C2")]
    [Address(RVA = "0x364C080", Offset = "0x364C080", VA = "0x364C080")]
    public void SetContentsData(List<DisplayItemRewardInfoData> infos, string contentText)
    {
    }

    [Token(Token = "0x60044C3")]
    [Address(RVA = "0x364C0A4", Offset = "0x364C0A4", VA = "0x364C0A4")]
    public IEnumerator ContentsLoadProcess(bool numDisplay = true) => (IEnumerator) null;

    [Token(Token = "0x60044C4")]
    [Address(RVA = "0x364C148", Offset = "0x364C148", VA = "0x364C148")]
    public IEnumerator ExecuteToEnded(bool useDelay = true) => (IEnumerator) null;

    [Token(Token = "0x60044C5")]
    [Address(RVA = "0x364C1EC", Offset = "0x364C1EC", VA = "0x364C1EC")]
    public void Execute(bool useDelay = true)
    {
    }

    [Token(Token = "0x60044C6")]
    [Address(RVA = "0x364C2FC", Offset = "0x364C2FC", VA = "0x364C2FC")]
    private void OnEnded()
    {
    }

    [Token(Token = "0x60044C7")]
    [Address(RVA = "0x364C338", Offset = "0x364C338", VA = "0x364C338")]
    public void SetExecuteEndedCallback(Action callback)
    {
    }

    [Token(Token = "0x60044C8")]
    [Address(RVA = "0x364C340", Offset = "0x364C340", VA = "0x364C340")]
    public void SetEffectState(bool isShow = true)
    {
    }

    [Token(Token = "0x60044C9")]
    [Address(RVA = "0x364C34C", Offset = "0x364C34C", VA = "0x364C34C")]
    public ItemRewardPopupContainer GetContainer() => (ItemRewardPopupContainer) null;

    [Token(Token = "0x60044CA")]
    [Address(RVA = "0x364C354", Offset = "0x364C354", VA = "0x364C354")]
    public void UnloadAll()
    {
    }

    [Token(Token = "0x60044CB")]
    [Address(RVA = "0x364C528", Offset = "0x364C528", VA = "0x364C528")]
    public void Destroy()
    {
    }

    [Token(Token = "0x60044CC")]
    [Address(RVA = "0x364C5BC", Offset = "0x364C5BC", VA = "0x364C5BC")]
    public static IEnumerator PlayHelper(List<DisplayItemRewardInfoData> infos, string contentText)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60044CD")]
    [Address(RVA = "0x364C658", Offset = "0x364C658", VA = "0x364C658")]
    public ItemRewardPopupManage()
    {
    }
  }
}
