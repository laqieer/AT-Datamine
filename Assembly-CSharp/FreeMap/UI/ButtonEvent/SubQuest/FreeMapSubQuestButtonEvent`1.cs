// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.ButtonEvent.SubQuest.FreeMapSubQuestButtonEvent`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Parameter.UIParam.SubQuest;
using Il2CppDummyDll;
using StaqData;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace FreeMap.UI.ButtonEvent.SubQuest
{
  [Token(Token = "0x200172B")]
  public abstract class FreeMapSubQuestButtonEvent<TParam> : FreeMapIconButtonEventBase<TParam> where TParam : FreeMapSubQuestEventUIParam
  {
    [Token(Token = "0x4006712")]
    [FieldOffset(Offset = "0x0")]
    protected int SubQuestADVLabel;

    [Token(Token = "0x17001486")]
    private Transform notifyRoot
    {
      [Token(Token = "0x600830F")] get => (Transform) null;
    }

    [Token(Token = "0x6008310")]
    public FreeMapSubQuestButtonEvent(TParam param, FreeMapCommonElement commonElement)
    {
    }

    [Token(Token = "0x6008311")]
    protected IEnumerator ViewRewardNotifyCoroutine(IEnumerable<RewardData> items)
    {
      return (IEnumerator) null;
    }
  }
}
