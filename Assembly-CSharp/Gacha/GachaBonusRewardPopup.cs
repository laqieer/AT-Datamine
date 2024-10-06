// Decompiled with JetBrains decompiler
// Type: Gacha.GachaBonusRewardPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Gacha
{
  [Token(Token = "0x2001542")]
  internal class GachaBonusRewardPopup
  {
    [Token(Token = "0x40061AA")]
    [FieldOffset(Offset = "0x10")]
    private List<GachaBonusRewardInfo> mergedBonusRewardInfos;
    [Token(Token = "0x40061AB")]
    [FieldOffset(Offset = "0x18")]
    private MonoBehaviour coroutineRunner;
    [Token(Token = "0x40061AC")]
    [FieldOffset(Offset = "0x20")]
    private Action onClosed;

    [Token(Token = "0x6007867")]
    [Address(RVA = "0x44FA138", Offset = "0x44FA138", VA = "0x44FA138")]
    public GachaBonusRewardPopup(
      MonoBehaviour coroutineRunner,
      IReadOnlyList<GachaBonusRewardInfo> gachaBonusRewardInfos)
    {
    }

    [Token(Token = "0x6007868")]
    [Address(RVA = "0x44FA5EC", Offset = "0x44FA5EC", VA = "0x44FA5EC")]
    public void Open(Action onClosed)
    {
    }

    [Token(Token = "0x6007869")]
    [Address(RVA = "0x44FA618", Offset = "0x44FA618", VA = "0x44FA618")]
    public IEnumerator OpenAsync() => (IEnumerator) null;
  }
}
