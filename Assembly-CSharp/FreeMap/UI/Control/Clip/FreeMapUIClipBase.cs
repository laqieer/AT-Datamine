// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Control.Clip.FreeMapUIClipBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.UI.Control.Clip
{
  [Token(Token = "0x20016BA")]
  public abstract class FreeMapUIClipBase : IFreeMapUIClip
  {
    [Token(Token = "0x40065C9")]
    [FieldOffset(Offset = "0x10")]
    protected FreeMapUITransformHolder uiTransformHolder;

    [Token(Token = "0x6008093")]
    [Address(RVA = "0x41F562C", Offset = "0x41F562C", VA = "0x41F562C")]
    public FreeMapUIClipBase(FreeMapUITransformHolder uiTransformHolder)
    {
    }

    [Token(Token = "0x6008094")]
    public abstract bool UpdateClip(Camera usingCamera, Transform playerTransform);

    [Token(Token = "0x6008095")]
    [Address(RVA = "0x41F5654", Offset = "0x41F5654", VA = "0x41F5654")]
    protected bool UpdateCameraClip(Camera usingCamera) => new bool();
  }
}
