// Decompiled with JetBrains decompiler
// Type: ExampleWheelController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20000A6")]
public class ExampleWheelController : MonoBehaviour
{
  [Token(Token = "0x4000293")]
  [FieldOffset(Offset = "0x18")]
  public float acceleration;
  [Token(Token = "0x4000294")]
  [FieldOffset(Offset = "0x20")]
  public Renderer motionVectorRenderer;
  [Token(Token = "0x4000295")]
  [FieldOffset(Offset = "0x28")]
  private Rigidbody m_Rigidbody;

  [Token(Token = "0x6000567")]
  [Address(RVA = "0x44B1CD8", Offset = "0x44B1CD8", VA = "0x44B1CD8")]
  private void Start()
  {
  }

  [Token(Token = "0x6000568")]
  [Address(RVA = "0x44B1D3C", Offset = "0x44B1D3C", VA = "0x44B1D3C")]
  private void Update()
  {
  }

  [Token(Token = "0x6000569")]
  [Address(RVA = "0x44B1E98", Offset = "0x44B1E98", VA = "0x44B1E98")]
  public ExampleWheelController()
  {
  }

  [Token(Token = "0x20000A7")]
  private static class Uniforms
  {
    [Token(Token = "0x4000296")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly int _MotionAmount;

    [Token(Token = "0x600056A")]
    [Address(RVA = "0x44B1EA0", Offset = "0x44B1EA0", VA = "0x44B1EA0")]
    static Uniforms()
    {
    }
  }
}
