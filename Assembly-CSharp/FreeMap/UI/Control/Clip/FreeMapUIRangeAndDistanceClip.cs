// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Control.Clip.FreeMapUIRangeAndDistanceClip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.UI.Control.Clip
{
  [Token(Token = "0x20016BC")]
  public class FreeMapUIRangeAndDistanceClip : FreeMapUIClipBase, IFreeMapUIRangeClip
  {
    [Token(Token = "0x40065CB")]
    [FieldOffset(Offset = "0x18")]
    private FreeMapUIRangeClip rangeClip;
    [Token(Token = "0x40065CC")]
    [FieldOffset(Offset = "0x20")]
    private FreeMapUIDistanceClip distanceClip;

    [Token(Token = "0x6008098")]
    [Address(RVA = "0x41F57B8", Offset = "0x41F57B8", VA = "0x41F57B8")]
    public FreeMapUIRangeAndDistanceClip(
      FreeMapUITransformHolder uiTransformHolder,
      float clipDistance)
    {
    }

    [Token(Token = "0x6008099")]
    [Address(RVA = "0x41F58B4", Offset = "0x41F58B4", VA = "0x41F58B4", Slot = "6")]
    public void AdaptationRangeHandler(FreeMapUIRangeClipHandler handler)
    {
    }

    [Token(Token = "0x600809A")]
    [Address(RVA = "0x41F58F8", Offset = "0x41F58F8", VA = "0x41F58F8", Slot = "5")]
    public override bool UpdateClip(Camera usingCamera, Transform playerTransform) => new bool();
  }
}
