// Decompiled with JetBrains decompiler
// Type: NavMeshAgentControlClip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

#nullable disable
[Token(Token = "0x2000346")]
[Serializable]
public class NavMeshAgentControlClip : PlayableAsset, ITimelineClipAsset
{
  [Token(Token = "0x40013AE")]
  [FieldOffset(Offset = "0x18")]
  public ExposedReference<Transform> destination;
  [Token(Token = "0x40013AF")]
  [FieldOffset(Offset = "0x28")]
  [HideInInspector]
  public NavMeshAgentControlBehaviour template;

  [Token(Token = "0x170001D9")]
  public ClipCaps clipCaps
  {
    [Token(Token = "0x6001315"), Address(RVA = "0x2866064", Offset = "0x2866064", VA = "0x2866064", Slot = "9")] get
    {
      return new ClipCaps();
    }
  }

  [Token(Token = "0x6001316")]
  [Address(RVA = "0x286606C", Offset = "0x286606C", VA = "0x286606C", Slot = "6")]
  public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) => new Playable();

  [Token(Token = "0x6001317")]
  [Address(RVA = "0x28661A0", Offset = "0x28661A0", VA = "0x28661A0")]
  public NavMeshAgentControlClip()
  {
  }
}
