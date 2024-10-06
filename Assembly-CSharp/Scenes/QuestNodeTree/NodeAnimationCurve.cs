// Decompiled with JetBrains decompiler
// Type: Scenes.QuestNodeTree.NodeAnimationCurve
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Scenes.QuestNodeTree
{
  [Token(Token = "0x2002A1C")]
  public class NodeAnimationCurve
  {
    [Token(Token = "0x400B328")]
    [FieldOffset(Offset = "0x10")]
    private AnimationCurve Curve;
    [Token(Token = "0x400B329")]
    [FieldOffset(Offset = "0x18")]
    private float curveLastTime;
    [Token(Token = "0x400B32A")]
    [FieldOffset(Offset = "0x1C")]
    private float actionTimeMax;

    [Token(Token = "0x60107D7")]
    [Address(RVA = "0x4C20928", Offset = "0x4C20928", VA = "0x4C20928")]
    public void Setup(AnimationCurve curve, float timeMax)
    {
    }

    [Token(Token = "0x60107D8")]
    [Address(RVA = "0x4C20A0C", Offset = "0x4C20A0C", VA = "0x4C20A0C")]
    public float GetCoefficient(float actionTime) => new float();

    [Token(Token = "0x60107D9")]
    [Address(RVA = "0x4C20AE0", Offset = "0x4C20AE0", VA = "0x4C20AE0")]
    public NodeAnimationCurve()
    {
    }
  }
}
