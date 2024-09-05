// Decompiled with JetBrains decompiler
// Type: Gacha.Timeline.GachaStyleImageFocusTrack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

#nullable disable
namespace Gacha.Timeline
{
  [Token(Token = "0x200159D")]
  [TrackColor(0.0f, 1f, 0.0f)]
  [TrackClipType(typeof (GachaStyleImageFocusPlayableAsset))]
  public class GachaStyleImageFocusTrack : TrackAsset
  {
    [Token(Token = "0x4006316")]
    [FieldOffset(Offset = "0xA0")]
    public IllustLayoutInfo info;
    [Token(Token = "0x4006317")]
    [FieldOffset(Offset = "0xA8")]
    public IllustLayoutComponent imageLayout;

    [Token(Token = "0x6007A7F")]
    [Address(RVA = "0x229CF30", Offset = "0x229CF30", VA = "0x229CF30", Slot = "24")]
    public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
    {
      return new Playable();
    }

    [Token(Token = "0x6007A80")]
    [Address(RVA = "0x229D3C4", Offset = "0x229D3C4", VA = "0x229D3C4")]
    public GachaStyleImageFocusTrack()
    {
    }
  }
}
