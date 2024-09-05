// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.ColorGradingCurve
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace UnityEngine.PostProcessing
{
  [Token(Token = "0x2003FB4")]
  [Serializable]
  public sealed class ColorGradingCurve
  {
    [Token(Token = "0x4011709")]
    [FieldOffset(Offset = "0x10")]
    public AnimationCurve curve;
    [Token(Token = "0x401170A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private bool m_Loop;
    [Token(Token = "0x401170B")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private float m_ZeroValue;
    [Token(Token = "0x401170C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private float m_Range;
    [Token(Token = "0x401170D")]
    [FieldOffset(Offset = "0x28")]
    private AnimationCurve m_InternalLoopingCurve;

    [Token(Token = "0x60199F2")]
    [Address(RVA = "0x343BEF8", Offset = "0x343BEF8", VA = "0x343BEF8")]
    public ColorGradingCurve(AnimationCurve curve, float zeroValue, bool loop, Vector2 bounds)
    {
    }

    [Token(Token = "0x60199F3")]
    [Address(RVA = "0x343129C", Offset = "0x343129C", VA = "0x343129C")]
    public void Cache()
    {
    }

    [Token(Token = "0x60199F4")]
    [Address(RVA = "0x343146C", Offset = "0x343146C", VA = "0x343146C")]
    public float Evaluate(float t) => new float();
  }
}
