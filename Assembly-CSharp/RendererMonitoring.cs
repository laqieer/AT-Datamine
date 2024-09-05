// Decompiled with JetBrains decompiler
// Type: RendererMonitoring
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20000DD")]
public class RendererMonitoring : MonoBehaviour
{
  [Token(Token = "0x40003DD")]
  [FieldOffset(Offset = "0x18")]
  protected Renderer owner;
  [Token(Token = "0x40003DE")]
  [FieldOffset(Offset = "0x20")]
  protected RendererMonitoring.CallBackRendererVisible callbackVisible;

  [Token(Token = "0x6000671")]
  [Address(RVA = "0x4182DA8", Offset = "0x4182DA8", VA = "0x4182DA8")]
  public static RendererMonitoring Create(
    Renderer target,
    RendererMonitoring.CallBackRendererVisible callback)
  {
    return (RendererMonitoring) null;
  }

  [Token(Token = "0x6000672")]
  [Address(RVA = "0x4182E7C", Offset = "0x4182E7C", VA = "0x4182E7C")]
  private void OnBecameInvisible()
  {
  }

  [Token(Token = "0x6000673")]
  [Address(RVA = "0x4182EA8", Offset = "0x4182EA8", VA = "0x4182EA8")]
  private void OnBecameVisible()
  {
  }

  [Token(Token = "0x6000674")]
  [Address(RVA = "0x4182ED4", Offset = "0x4182ED4", VA = "0x4182ED4")]
  public RendererMonitoring()
  {
  }

  [Token(Token = "0x20000DE")]
  public delegate void CallBackRendererVisible(Renderer target, bool isVisible);
}
