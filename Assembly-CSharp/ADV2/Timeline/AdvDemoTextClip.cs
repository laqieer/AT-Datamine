// Decompiled with JetBrains decompiler
// Type: ADV2.Timeline.AdvDemoTextClip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

#nullable disable
namespace ADV2.Timeline
{
  [Token(Token = "0x2003E69")]
  [Serializable]
  public class AdvDemoTextClip : PlayableAsset, ITimelineClipAsset
  {
    [Token(Token = "0x40111DA")]
    [FieldOffset(Offset = "0x18")]
    public AdvDemoTextBehaviour TextTagInfo;

    [Token(Token = "0x17005183")]
    public ClipCaps clipCaps
    {
      [Token(Token = "0x60191D6"), Address(RVA = "0x2CF2A04", Offset = "0x2CF2A04", VA = "0x2CF2A04", Slot = "9")] get
      {
        return new ClipCaps();
      }
    }

    [Token(Token = "0x60191D7")]
    [Address(RVA = "0x2CF2A0C", Offset = "0x2CF2A0C", VA = "0x2CF2A0C")]
    public void Initialize(GameObject bindTarget, double lifeTime)
    {
    }

    [Token(Token = "0x60191D8")]
    [Address(RVA = "0x2CF2A24", Offset = "0x2CF2A24", VA = "0x2CF2A24")]
    public void SetIgnoreTweenIn()
    {
    }

    [Token(Token = "0x60191D9")]
    [Address(RVA = "0x2CF2A44", Offset = "0x2CF2A44", VA = "0x2CF2A44")]
    public void SetIgnoreTweenOut()
    {
    }

    [Token(Token = "0x60191DA")]
    [Address(RVA = "0x2CF2A64", Offset = "0x2CF2A64", VA = "0x2CF2A64", Slot = "6")]
    public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
    {
      return new Playable();
    }

    [Token(Token = "0x60191DB")]
    [Address(RVA = "0x2CF2B50", Offset = "0x2CF2B50", VA = "0x2CF2B50")]
    public AdvDemoTextClip()
    {
    }
  }
}
