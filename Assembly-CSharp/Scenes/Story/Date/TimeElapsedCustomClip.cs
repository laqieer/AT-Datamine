// Decompiled with JetBrains decompiler
// Type: Scenes.Story.Date.TimeElapsedCustomClip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

#nullable disable
namespace Scenes.Story.Date
{
  [Token(Token = "0x2002EB0")]
  public class TimeElapsedCustomClip : PlayableAsset
  {
    [Token(Token = "0x400C827")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private AnimationCurve easing;
    [Token(Token = "0x400C828")]
    [FieldOffset(Offset = "0x20")]
    public float FromAngle;
    [Token(Token = "0x400C829")]
    [FieldOffset(Offset = "0x24")]
    public float ToAngle;

    [Token(Token = "0x601239A")]
    [Address(RVA = "0x4597EB4", Offset = "0x4597EB4", VA = "0x4597EB4", Slot = "6")]
    public override Playable CreatePlayable(PlayableGraph graph, GameObject go) => new Playable();

    [Token(Token = "0x601239B")]
    [Address(RVA = "0x4597FA8", Offset = "0x4597FA8", VA = "0x4597FA8")]
    public TimeElapsedCustomClip()
    {
    }
  }
}
