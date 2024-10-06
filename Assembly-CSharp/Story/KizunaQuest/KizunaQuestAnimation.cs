// Decompiled with JetBrains decompiler
// Type: Story.KizunaQuest.KizunaQuestAnimation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UI.Direction;
using UnityEngine;

#nullable disable
namespace Story.KizunaQuest
{
  [Token(Token = "0x200067C")]
  public class KizunaQuestAnimation
  {
    [Token(Token = "0x4001F2D")]
    [FieldOffset(Offset = "0x10")]
    private readonly Dictionary<int, UITimelineController> settingObjectMap;

    [Token(Token = "0x1700056F")]
    public bool IsPlaying
    {
      [Token(Token = "0x6002513"), Address(RVA = "0x2F3594C", Offset = "0x2F3594C", VA = "0x2F3594C")] get
      {
        return new bool();
      }
      [Token(Token = "0x6002514"), Address(RVA = "0x2F35954", Offset = "0x2F35954", VA = "0x2F35954")] private set
      {
      }
    }

    [Token(Token = "0x6002515")]
    [Address(RVA = "0x2F35960", Offset = "0x2F35960", VA = "0x2F35960")]
    public void SetObject(KizunaQuestLoader.TimelinePattern timelinePattern, GameObject gameObject)
    {
    }

    [Token(Token = "0x6002516")]
    [Address(RVA = "0x2F35A2C", Offset = "0x2F35A2C", VA = "0x2F35A2C")]
    public IEnumerator SetTimelineAsset(
      KizunaQuestLoader.TimelinePattern timelinePattern,
      UITimelineSettingAsset settingAsset,
      Action finishCallback = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6002517")]
    [Address(RVA = "0x2F35AE0", Offset = "0x2F35AE0", VA = "0x2F35AE0")]
    public void PlayToIn(
      KizunaQuestLoader.TimelinePattern timelinePattern,
      string assetBundleName,
      Action finishCallback)
    {
    }

    [Token(Token = "0x6002518")]
    [Address(RVA = "0x2F35C0C", Offset = "0x2F35C0C", VA = "0x2F35C0C")]
    public void PlayToOut(
      KizunaQuestLoader.TimelinePattern timelinePattern,
      string assetBundleName,
      Action finishCallback)
    {
    }

    [Token(Token = "0x6002519")]
    [Address(RVA = "0x2F35D3C", Offset = "0x2F35D3C", VA = "0x2F35D3C")]
    public void Release()
    {
    }

    [Token(Token = "0x600251A")]
    [Address(RVA = "0x2F35D8C", Offset = "0x2F35D8C", VA = "0x2F35D8C")]
    public KizunaQuestAnimation()
    {
    }
  }
}
