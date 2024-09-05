// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.ButtonEvent.FreeMapRewardButtonEvent`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Parameter.UIParam;
using Il2CppDummyDll;
using StaqData;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace FreeMap.UI.ButtonEvent
{
  [Token(Token = "0x200170D")]
  public abstract class FreeMapRewardButtonEvent<TParam> : FreeMapIconButtonEventBase<TParam> where TParam : FreeMapRewardUIParam
  {
    [Token(Token = "0x17001461")]
    private Transform notifyRoot
    {
      [Token(Token = "0x6008271")] get => (Transform) null;
    }

    [Token(Token = "0x6008272")]
    public FreeMapRewardButtonEvent(TParam param, FreeMapCommonElement commonElement)
    {
    }

    [Token(Token = "0x6008273")]
    protected IEnumerator ShowRewardNofity(IReadOnlyList<RewardData> dataList, string contentText = "")
    {
      return (IEnumerator) null;
    }
  }
}
