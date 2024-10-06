// Decompiled with JetBrains decompiler
// Type: BattleTimelineScript.BattleSoundPlayableAssetNew
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

#nullable disable
namespace BattleTimelineScript
{
  [Token(Token = "0x20021FF")]
  public class BattleSoundPlayableAssetNew : PlayableAsset, ITimelineClipAsset
  {
    [Token(Token = "0x4008FA5")]
    [FieldOffset(Offset = "0x18")]
    public BattleSoundPlayableAssetNew.SoundType soundType;
    [Token(Token = "0x4008FA6")]
    [FieldOffset(Offset = "0x20")]
    public string soundName;
    [Token(Token = "0x4008FA7")]
    [FieldOffset(Offset = "0x28")]
    [NonSerialized]
    public TimelineClip owningClip;

    [Token(Token = "0x17002D1F")]
    private ClipCaps UnityEngine\u002ETimeline\u002EITimelineClipAsset\u002EclipCaps
    {
      [Token(Token = "0x600CF12"), Address(RVA = "0x4B69948", Offset = "0x4B69948", VA = "0x4B69948", Slot = "9")] get
      {
        return new ClipCaps();
      }
    }

    [Token(Token = "0x600CF13")]
    [Address(RVA = "0x4B69950", Offset = "0x4B69950", VA = "0x4B69950", Slot = "6")]
    public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
    {
      return new Playable();
    }

    [Token(Token = "0x600CF14")]
    [Address(RVA = "0x4B69AE0", Offset = "0x4B69AE0", VA = "0x4B69AE0")]
    public BattleSoundPlayableAssetNew()
    {
    }

    [Token(Token = "0x2002200")]
    public enum SoundType
    {
      [Token(Token = "0x4008FA9")] SE,
      [Token(Token = "0x4008FAA")] Voice,
      [Token(Token = "0x4008FAB")] BGM,
    }
  }
}
