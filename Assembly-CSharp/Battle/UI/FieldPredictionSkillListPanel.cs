// Decompiled with JetBrains decompiler
// Type: Battle.UI.FieldPredictionSkillListPanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x20023F7")]
  public class FieldPredictionSkillListPanel : MonoBehaviour
  {
    [Token(Token = "0x400999D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400999E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CommonButton skillWarningToasterButton;
    [Token(Token = "0x400999F")]
    [FieldOffset(Offset = "0x28")]
    private UnityAction tweenCallback;
    [Token(Token = "0x40099A0")]
    [FieldOffset(Offset = "0x30")]
    private List<string> tweenPlayReadyList;
    [Token(Token = "0x40099A1")]
    [FieldOffset(Offset = "0x38")]
    private Queue<string> tweenPlayExecuteQueue;
    [Token(Token = "0x40099A2")]
    [FieldOffset(Offset = "0x40")]
    private bool isShowing;

    [Token(Token = "0x600DC5E")]
    [Address(RVA = "0x2157C48", Offset = "0x2157C48", VA = "0x2157C48")]
    public void Show()
    {
    }

    [Token(Token = "0x600DC5F")]
    [Address(RVA = "0x2157F4C", Offset = "0x2157F4C", VA = "0x2157F4C")]
    public void Hide()
    {
    }

    [Token(Token = "0x600DC60")]
    [Address(RVA = "0x2157FB0", Offset = "0x2157FB0", VA = "0x2157FB0")]
    public void SetSkillWarningToasterButtonEvent(UnityAction callback)
    {
    }

    [Token(Token = "0x600DC61")]
    [Address(RVA = "0x2157FD4", Offset = "0x2157FD4", VA = "0x2157FD4")]
    public void SetDisplaySkillWarningToaster(bool active)
    {
    }

    [Token(Token = "0x600DC62")]
    [Address(RVA = "0x2157CB0", Offset = "0x2157CB0", VA = "0x2157CB0")]
    private void AddTweenPlayList(string groupId)
    {
    }

    [Token(Token = "0x600DC63")]
    [Address(RVA = "0x2158004", Offset = "0x2158004", VA = "0x2158004")]
    private void ResetTweenPlayList()
    {
    }

    [Token(Token = "0x600DC64")]
    [Address(RVA = "0x2157D58", Offset = "0x2157D58", VA = "0x2157D58")]
    private void PlayTweenPlayList(UnityAction callback = null)
    {
    }

    [Token(Token = "0x600DC65")]
    [Address(RVA = "0x2158088", Offset = "0x2158088", VA = "0x2158088")]
    public FieldPredictionSkillListPanel()
    {
    }
  }
}
