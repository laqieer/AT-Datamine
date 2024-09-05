// Decompiled with JetBrains decompiler
// Type: NormalAttackTimelineData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine.Timeline;

#nullable disable
[Token(Token = "0x20000FB")]
[Serializable]
public class NormalAttackTimelineData
{
  [Token(Token = "0x40004B7")]
  [FieldOffset(Offset = "0x10")]
  public DuelCharacterAnimation.NormalAttackType normalAttackType;
  [Token(Token = "0x40004B8")]
  [FieldOffset(Offset = "0x14")]
  public DuelCharacterAnimation.MainAnimationRange range;
  [Token(Token = "0x40004B9")]
  [FieldOffset(Offset = "0x18")]
  public List<TimelineAsset> timelineAssets;
  [Token(Token = "0x40004BA")]
  [FieldOffset(Offset = "0x20")]
  public float distanceFromTarget;

  [Token(Token = "0x60006E1")]
  [Address(RVA = "0x41886EC", Offset = "0x41886EC", VA = "0x41886EC")]
  public NormalAttackTimelineData()
  {
  }
}
