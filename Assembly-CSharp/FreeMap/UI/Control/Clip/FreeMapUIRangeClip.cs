// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Control.Clip.FreeMapUIRangeClip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.UI.Control.Clip
{
  [Token(Token = "0x20016BE")]
  public class FreeMapUIRangeClip : FreeMapUIClipBase, IFreeMapUIRangeClip
  {
    [Token(Token = "0x40065CD")]
    [FieldOffset(Offset = "0x18")]
    private FreeMapUIRangeClipHandler handler;
    [Token(Token = "0x40065CE")]
    [FieldOffset(Offset = "0x20")]
    private int rangeClipIndex;

    [Token(Token = "0x600809C")]
    [Address(RVA = "0x41F5884", Offset = "0x41F5884", VA = "0x41F5884")]
    public FreeMapUIRangeClip(FreeMapUITransformHolder uiTransformHolder)
    {
    }

    [Token(Token = "0x600809D")]
    [Address(RVA = "0x41F58CC", Offset = "0x41F58CC", VA = "0x41F58CC", Slot = "6")]
    public void AdaptationRangeHandler(FreeMapUIRangeClipHandler handler)
    {
    }

    [Token(Token = "0x600809E")]
    [Address(RVA = "0x41F595C", Offset = "0x41F595C", VA = "0x41F595C", Slot = "5")]
    public override bool UpdateClip(Camera usingCamera, Transform playerTransform) => new bool();
  }
}
