// Decompiled with JetBrains decompiler
// Type: Scenes.Raid.RaidUpdateButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Raid
{
  [Token(Token = "0x20029E5")]
  internal class RaidUpdateButton : MonoBehaviour
  {
    [Token(Token = "0x400B298")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tween;
    [Token(Token = "0x400B299")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CommonButton button;
    [Token(Token = "0x400B29A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Image buttonImage;
    [Token(Token = "0x400B29B")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text buttonText;
    [Token(Token = "0x400B29C")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text countText;
    [Token(Token = "0x400B29D")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private float manualInterval;
    [Token(Token = "0x400B29E")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private float autoInterval;
    [Token(Token = "0x400B29F")]
    [FieldOffset(Offset = "0x48")]
    private int beforeRemain;
    [Token(Token = "0x400B2A0")]
    [FieldOffset(Offset = "0x4C")]
    private float elapsedTime;
    [Token(Token = "0x400B2A1")]
    [FieldOffset(Offset = "0x50")]
    private bool isValid;
    [Token(Token = "0x400B2A2")]
    [FieldOffset(Offset = "0x51")]
    private bool conecting;
    [Token(Token = "0x400B2A3")]
    [FieldOffset(Offset = "0x58")]
    private Action updateAction;
    [Token(Token = "0x400B2A4")]
    [FieldOffset(Offset = "0x60")]
    private string autoText;
    [Token(Token = "0x400B2A5")]
    [FieldOffset(Offset = "0x68")]
    private string manualText;
    [Token(Token = "0x400B2A6")]
    [FieldOffset(Offset = "0x70")]
    private string remainText;

    [Token(Token = "0x6010720")]
    [Address(RVA = "0x488C5D0", Offset = "0x488C5D0", VA = "0x488C5D0")]
    public void Initialize(Action updateAction)
    {
    }

    [Token(Token = "0x6010721")]
    [Address(RVA = "0x488F28C", Offset = "0x488F28C", VA = "0x488F28C")]
    public void ResetCount()
    {
    }

    [Token(Token = "0x6010722")]
    [Address(RVA = "0x488F264", Offset = "0x488F264", VA = "0x488F264")]
    public void SetActive(bool state)
    {
    }

    [Token(Token = "0x6010723")]
    [Address(RVA = "0x488FB68", Offset = "0x488FB68", VA = "0x488FB68")]
    private void Update()
    {
    }

    [Token(Token = "0x6010724")]
    [Address(RVA = "0x488FCB8", Offset = "0x488FCB8", VA = "0x488FCB8")]
    private void AutoUpdate()
    {
    }

    [Token(Token = "0x6010725")]
    [Address(RVA = "0x488FD04", Offset = "0x488FD04", VA = "0x488FD04")]
    private void ManualUpdate()
    {
    }

    [Token(Token = "0x6010726")]
    [Address(RVA = "0x488FBB8", Offset = "0x488FBB8", VA = "0x488FBB8")]
    private void SetCountText()
    {
    }

    [Token(Token = "0x6010727")]
    [Address(RVA = "0x488FDD0", Offset = "0x488FDD0", VA = "0x488FDD0")]
    private void OnUpdate()
    {
    }

    [Token(Token = "0x6010728")]
    [Address(RVA = "0x488FE0C", Offset = "0x488FE0C", VA = "0x488FE0C")]
    public RaidUpdateButton()
    {
    }
  }
}
