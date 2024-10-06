// Decompiled with JetBrains decompiler
// Type: Scenes.Story.Date.TimeElapsedCustomClipBehaviour
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

#nullable disable
namespace Scenes.Story.Date
{
  [Token(Token = "0x2002EB1")]
  public class TimeElapsedCustomClipBehaviour : PlayableBehaviour
  {
    [Token(Token = "0x400C82A")]
    [FieldOffset(Offset = "0x10")]
    public AnimationCurve Easing;
    [Token(Token = "0x400C82B")]
    [FieldOffset(Offset = "0x18")]
    public float FromAngle;
    [Token(Token = "0x400C82C")]
    [FieldOffset(Offset = "0x1C")]
    public float ToAngle;

    [Token(Token = "0x601239C")]
    [Address(RVA = "0x4597FDC", Offset = "0x4597FDC", VA = "0x4597FDC", Slot = "21")]
    public override void ProcessFrame(Playable playable, FrameData info, object playerData)
    {
    }

    [Token(Token = "0x601239D")]
    [Address(RVA = "0x4598188", Offset = "0x4598188", VA = "0x4598188")]
    public TimeElapsedCustomClipBehaviour()
    {
    }
  }
}
