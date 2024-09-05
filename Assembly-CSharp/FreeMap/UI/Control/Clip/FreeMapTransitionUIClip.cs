// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Control.Clip.FreeMapTransitionUIClip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.UI.Control.Clip
{
  [Token(Token = "0x20016B8")]
  public class FreeMapTransitionUIClip : IFreeMapUIClip
  {
    [Token(Token = "0x40065C8")]
    [FieldOffset(Offset = "0x10")]
    protected FreeMapUITransformHolder uiTransformHolder;

    [Token(Token = "0x600808F")]
    [Address(RVA = "0x41F55B8", Offset = "0x41F55B8", VA = "0x41F55B8")]
    public FreeMapTransitionUIClip(FreeMapUITransformHolder uiTransformHolder)
    {
    }

    [Token(Token = "0x6008090")]
    [Address(RVA = "0x41F55E0", Offset = "0x41F55E0", VA = "0x41F55E0", Slot = "4")]
    public bool UpdateClip(Camera usingCamera, Transform playerTransform) => new bool();

    [Token(Token = "0x6008091")]
    [Address(RVA = "0x41F55E8", Offset = "0x41F55E8", VA = "0x41F55E8")]
    protected bool DummyCameraClip(Camera usingCamera) => new bool();
  }
}
