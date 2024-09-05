// Decompiled with JetBrains decompiler
// Type: NavMeshAgentControlTrack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Playables;
using UnityEngine.Timeline;

#nullable disable
[Token(Token = "0x2000348")]
[TrackBindingType(typeof (NavMeshAgent))]
[TrackClipType(typeof (NavMeshAgentControlClip))]
[TrackColor(0.855f, 0.8623f, 0.87f)]
public class NavMeshAgentControlTrack : TrackAsset
{
  [Token(Token = "0x600131A")]
  [Address(RVA = "0x2866474", Offset = "0x2866474", VA = "0x2866474", Slot = "24")]
  public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
  {
    return new Playable();
  }

  [Token(Token = "0x600131B")]
  [Address(RVA = "0x2866514", Offset = "0x2866514", VA = "0x2866514")]
  public NavMeshAgentControlTrack()
  {
  }
}
