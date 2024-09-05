// Decompiled with JetBrains decompiler
// Type: Gacha.Timeline.GachaStyleImageFocusPlayableAsset
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
  [Token(Token = "0x200159A")]
  public class GachaStyleImageFocusPlayableAsset : PlayableAsset, ITimelineClipAsset
  {
    [Token(Token = "0x4006312")]
    [FieldOffset(Offset = "0x18")]
    [HideInInspector]
    public GachaStyleImageFocusTrack track;
    [Token(Token = "0x4006313")]
    [FieldOffset(Offset = "0x20")]
    public string SequenceId;

    [Token(Token = "0x170012C8")]
    public ClipCaps clipCaps
    {
      [Token(Token = "0x6007A75"), Address(RVA = "0x229CC70", Offset = "0x229CC70", VA = "0x229CC70", Slot = "9")] get
      {
        return new ClipCaps();
      }
    }

    [Token(Token = "0x6007A76")]
    [Address(RVA = "0x229CC78", Offset = "0x229CC78", VA = "0x229CC78", Slot = "6")]
    public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
    {
      return new Playable();
    }

    [Token(Token = "0x6007A77")]
    [Address(RVA = "0x229CD14", Offset = "0x229CD14", VA = "0x229CD14")]
    public GachaStyleImageFocusPlayableAsset()
    {
    }
  }
}
