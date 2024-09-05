// Decompiled with JetBrains decompiler
// Type: Battle.ShakeVector3Curve
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Battle
{
  [Token(Token = "0x20022A8")]
  public sealed class ShakeVector3Curve : ValueCurve<Vector3>
  {
    [Token(Token = "0x400920E")]
    [FieldOffset(Offset = "0x48")]
    private float roughness;
    [Token(Token = "0x400920F")]
    [FieldOffset(Offset = "0x4C")]
    private float frequency;

    [Token(Token = "0x600D35F")]
    [Address(RVA = "0x19D62A0", Offset = "0x19D62A0", VA = "0x19D62A0")]
    public ShakeVector3Curve(float roughness, float frequency)
    {
    }

    [Token(Token = "0x600D360")]
    [Address(RVA = "0x19D632C", Offset = "0x19D632C", VA = "0x19D632C", Slot = "5")]
    protected override Vector3 EvaluateInternal(float curveValue) => new Vector3();

    [Token(Token = "0x600D361")]
    [Address(RVA = "0x19D6438", Offset = "0x19D6438", VA = "0x19D6438", Slot = "4")]
    protected override Vector3 GetValueOnCompleted() => new Vector3();
  }
}
