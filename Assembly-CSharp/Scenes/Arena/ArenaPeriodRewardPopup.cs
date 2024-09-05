// Decompiled with JetBrains decompiler
// Type: Scenes.Arena.ArenaPeriodRewardPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Arena
{
  [Token(Token = "0x2003145")]
  public class ArenaPeriodRewardPopup : PopupBase
  {
    [Token(Token = "0x400D1C5")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Text descriptionText;
    [Token(Token = "0x400D1C6")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private ArenaPeriodRewardItem iconPrefab;
    [Token(Token = "0x400D1C7")]
    [FieldOffset(Offset = "0x98")]
    private Action callback;

    [Token(Token = "0x60133AB")]
    [Address(RVA = "0x4A20D04", Offset = "0x4A20D04", VA = "0x4A20D04")]
    public IEnumerator InitializeWithOpen(List<Reward> rewards, Action callback)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60133AC")]
    [Address(RVA = "0x4A20DA8", Offset = "0x4A20DA8", VA = "0x4A20DA8", Slot = "8")]
    public override void Open()
    {
    }

    [Token(Token = "0x60133AD")]
    [Address(RVA = "0x4A20DB0", Offset = "0x4A20DB0", VA = "0x4A20DB0", Slot = "9")]
    public override void Close()
    {
    }

    [Token(Token = "0x60133AE")]
    [Address(RVA = "0x4A20DE4", Offset = "0x4A20DE4", VA = "0x4A20DE4")]
    public ArenaPeriodRewardPopup()
    {
    }
  }
}
