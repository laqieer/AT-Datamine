// Decompiled with JetBrains decompiler
// Type: TransformTweenClip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

#nullable disable
[Token(Token = "0x2000357")]
[Serializable]
public class TransformTweenClip : PlayableAsset, ITimelineClipAsset
{
  [Token(Token = "0x40013D1")]
  [FieldOffset(Offset = "0x18")]
  public TransformTweenBehaviour template;
  [Token(Token = "0x40013D2")]
  [FieldOffset(Offset = "0x20")]
  public ExposedReference<Transform> startLocation;
  [Token(Token = "0x40013D3")]
  [FieldOffset(Offset = "0x30")]
  public ExposedReference<Transform> endLocation;

  [Token(Token = "0x170001DD")]
  public ClipCaps clipCaps
  {
    [Token(Token = "0x600133F"), Address(RVA = "0x2867FA8", Offset = "0x2867FA8", VA = "0x2867FA8", Slot = "9")] get
    {
      return new ClipCaps();
    }
  }

  [Token(Token = "0x6001340")]
  [Address(RVA = "0x2867FB0", Offset = "0x2867FB0", VA = "0x2867FB0", Slot = "6")]
  public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) => new Playable();

  [Token(Token = "0x6001341")]
  [Address(RVA = "0x2868108", Offset = "0x2868108", VA = "0x2868108")]
  public TransformTweenClip()
  {
  }
}
