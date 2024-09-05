// Decompiled with JetBrains decompiler
// Type: ADV2.Timeline.AdvAreaSceneClip
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
  [Token(Token = "0x2003E64")]
  [Serializable]
  public class AdvAreaSceneClip : PlayableAsset, ITimelineClipAsset
  {
    [Token(Token = "0x40111CD")]
    [FieldOffset(Offset = "0x18")]
    public AdvAreaSceneBehaviour AreaSceneName;

    [Token(Token = "0x17005182")]
    public ClipCaps clipCaps
    {
      [Token(Token = "0x60191C1"), Address(RVA = "0x2CF186C", Offset = "0x2CF186C", VA = "0x2CF186C", Slot = "9")] get
      {
        return new ClipCaps();
      }
    }

    [Token(Token = "0x60191C2")]
    [Address(RVA = "0x2CF1874", Offset = "0x2CF1874", VA = "0x2CF1874")]
    public void Initialize(Adv2BindTrack bindTarget, int clipId)
    {
    }

    [Token(Token = "0x60191C3")]
    [Address(RVA = "0x2CF188C", Offset = "0x2CF188C", VA = "0x2CF188C", Slot = "6")]
    public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
    {
      return new Playable();
    }

    [Token(Token = "0x60191C4")]
    [Address(RVA = "0x2CF1978", Offset = "0x2CF1978", VA = "0x2CF1978")]
    public AdvAreaSceneClip()
    {
    }
  }
}
