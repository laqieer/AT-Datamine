// Decompiled with JetBrains decompiler
// Type: NavMeshAgentControlBehaviour
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Playables;

#nullable disable
[Token(Token = "0x2000345")]
[Serializable]
public class NavMeshAgentControlBehaviour : PlayableBehaviour
{
  [Token(Token = "0x40013AC")]
  [FieldOffset(Offset = "0x10")]
  public Transform destination;
  [Token(Token = "0x40013AD")]
  [FieldOffset(Offset = "0x18")]
  public bool destinationSet;

  [Token(Token = "0x6001313")]
  [Address(RVA = "0x2866054", Offset = "0x2866054", VA = "0x2866054", Slot = "15")]
  public override void OnPlayableCreate(Playable playable)
  {
  }

  [Token(Token = "0x6001314")]
  [Address(RVA = "0x286605C", Offset = "0x286605C", VA = "0x286605C")]
  public NavMeshAgentControlBehaviour()
  {
  }
}
