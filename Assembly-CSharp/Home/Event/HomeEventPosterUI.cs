// Decompiled with JetBrains decompiler
// Type: Home.Event.HomeEventPosterUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections;
using TMPro;
using UI.Direction;
using UnityEngine;

#nullable disable
namespace Home.Event
{
  [Token(Token = "0x2000B6F")]
  public class HomeEventPosterUI : MonoBehaviour
  {
    [Token(Token = "0x400341B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController timeLineController;
    [Token(Token = "0x400341C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CanvasGroup canvasGroup;
    [Token(Token = "0x400341D")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TextMeshProUGUI eventName;
    [Token(Token = "0x400341E")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private CommonButton backButton;
    [Token(Token = "0x400341F")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private HomeEventPosterButton eventButton1;
    [Token(Token = "0x4003420")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private HomeEventPosterButton eventButton2;
    [Token(Token = "0x4003421")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private HomeEventPosterButton eventButton3;
    [Token(Token = "0x4003422")]
    [FieldOffset(Offset = "0x50")]
    private HomeEventData master;
    [Token(Token = "0x4003423")]
    [FieldOffset(Offset = "0x58")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x4003424")]
    [FieldOffset(Offset = "0x60")]
    private Action closeAction;
    [Token(Token = "0x4003425")]
    [FieldOffset(Offset = "0x68")]
    private Action backKeyActionByFunction;
    [Token(Token = "0x4003426")]
    [FieldOffset(Offset = "0x70")]
    private bool backKeyEnable;

    [Token(Token = "0x6004118")]
    [Address(RVA = "0x2A2D7A0", Offset = "0x2A2D7A0", VA = "0x2A2D7A0")]
    public void Initialize(
      HomeEventData master,
      AssetCachedSpawner assetCachedSpawner,
      Action closeAction = null)
    {
    }

    [Token(Token = "0x6004119")]
    [Address(RVA = "0x2A2D8F8", Offset = "0x2A2D8F8", VA = "0x2A2D8F8")]
    public void SetBackKeyAction(Action action)
    {
    }

    [Token(Token = "0x600411A")]
    [Address(RVA = "0x2A2BE88", Offset = "0x2A2BE88", VA = "0x2A2BE88")]
    public void ClearBackKeyAction()
    {
    }

    [Token(Token = "0x600411B")]
    [Address(RVA = "0x2A2D900", Offset = "0x2A2D900", VA = "0x2A2D900")]
    public void OnBackKey()
    {
    }

    [Token(Token = "0x600411C")]
    [Address(RVA = "0x2A2D95C", Offset = "0x2A2D95C", VA = "0x2A2D95C")]
    public void Open(Action finishAction = null)
    {
    }

    [Token(Token = "0x600411D")]
    [Address(RVA = "0x2A2C07C", Offset = "0x2A2C07C", VA = "0x2A2C07C")]
    public void Close(Action finishAction = null)
    {
    }

    [Token(Token = "0x600411E")]
    [Address(RVA = "0x2A2DA38", Offset = "0x2A2DA38", VA = "0x2A2DA38")]
    private IEnumerator PlayTimeline(UITimelineController.DirectionType type, Action finishAction = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600411F")]
    [Address(RVA = "0x2A2AA98", Offset = "0x2A2AA98", VA = "0x2A2AA98")]
    public void SetInteractable(bool interactable)
    {
    }

    [Token(Token = "0x6004120")]
    [Address(RVA = "0x2A2DAE8", Offset = "0x2A2DAE8", VA = "0x2A2DAE8")]
    public HomeEventPosterUI()
    {
    }
  }
}
