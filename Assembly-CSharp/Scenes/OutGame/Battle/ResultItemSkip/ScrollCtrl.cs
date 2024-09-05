// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Battle.ResultItemSkip.ScrollCtrl
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Battle.ResultItemSkip
{
  [Token(Token = "0x20037D1")]
  public class ScrollCtrl
  {
    [Token(Token = "0x400F3EE")]
    private const float playInBeginWaitSec = 0.4f;
    [Token(Token = "0x400F3EF")]
    private const float scrollTime = 0.2f;
    [Token(Token = "0x400F3F0")]
    [FieldOffset(Offset = "0x10")]
    private GameObject _gameObject;
    [Token(Token = "0x400F3F1")]
    [FieldOffset(Offset = "0x18")]
    private RectTransform _contentRect;
    [Token(Token = "0x400F3F2")]
    [FieldOffset(Offset = "0x20")]
    private List<BattleResultSkipCell> _cells;
    [Token(Token = "0x400F3F3")]
    [FieldOffset(Offset = "0x28")]
    private int _playInIndex;
    [Token(Token = "0x400F3F4")]
    [FieldOffset(Offset = "0x2C")]
    private bool _isPlayEnd;

    [Token(Token = "0x6015F74")]
    [Address(RVA = "0x232D3D8", Offset = "0x232D3D8", VA = "0x232D3D8")]
    public ScrollCtrl(
      GameObject gameObject,
      ScrollRect scrollRect,
      List<BattleResultSkipCell> cells)
    {
    }

    [Token(Token = "0x6015F75")]
    [Address(RVA = "0x232D47C", Offset = "0x232D47C", VA = "0x232D47C")]
    public IEnumerator PlayIn(Func<bool> skip) => (IEnumerator) null;

    [Token(Token = "0x6015F76")]
    [Address(RVA = "0x232D568", Offset = "0x232D568", VA = "0x232D568")]
    private void SetPosY(float y)
    {
    }

    [Token(Token = "0x6015F77")]
    [Address(RVA = "0x232D5A8", Offset = "0x232D5A8", VA = "0x232D5A8")]
    private IEnumerator TweenPosY(float begin, float end, float sec) => (IEnumerator) null;

    [Token(Token = "0x6015F78")]
    [Address(RVA = "0x232D65C", Offset = "0x232D65C", VA = "0x232D65C")]
    private IEnumerator Scroll() => (IEnumerator) null;

    [Token(Token = "0x6015F79")]
    [Address(RVA = "0x232D6EC", Offset = "0x232D6EC", VA = "0x232D6EC")]
    private IEnumerator ScrollSkip() => (IEnumerator) null;
  }
}
