// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Control.Clip.FreeMapUIDistanceClip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.UI.Control.Clip
{
  [Token(Token = "0x20016BB")]
  public class FreeMapUIDistanceClip : FreeMapUIClipBase
  {
    [Token(Token = "0x40065CA")]
    [FieldOffset(Offset = "0x18")]
    private float displayDistanceRange;

    [Token(Token = "0x6008096")]
    [Address(RVA = "0x41F5698", Offset = "0x41F5698", VA = "0x41F5698")]
    public FreeMapUIDistanceClip(FreeMapUITransformHolder uiTransformHolder, float distanceRange)
    {
    }

    [Token(Token = "0x6008097")]
    [Address(RVA = "0x41F56D0", Offset = "0x41F56D0", VA = "0x41F56D0", Slot = "5")]
    public override bool UpdateClip(Camera usingCamera, Transform playerTransform) => new bool();
  }
}
