// Decompiled with JetBrains decompiler
// Type: CaptureCamera
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DesignPattern;
using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;
using UniversalRenderPipeline.Renderers;

#nullable disable
[Token(Token = "0x20001C7")]
public class CaptureCamera : SingletonMonoBehaviour<CaptureCamera>
{
  [Token(Token = "0x4000AC1")]
  [FieldOffset(Offset = "0x20")]
  [SerializeField]
  private Camera targetCamera;
  [Token(Token = "0x4000AC2")]
  [FieldOffset(Offset = "0x28")]
  [SerializeField]
  private CapturedBlurFeature capturedBlurFeature;
  [Token(Token = "0x4000AC3")]
  [FieldOffset(Offset = "0x30")]
  [SerializeField]
  private GameObject blurObject;
  [Token(Token = "0x4000AC4")]
  [FieldOffset(Offset = "0x38")]
  private RenderTexture renderTexture;

  [Token(Token = "0x6000B95")]
  [Address(RVA = "0x4BCA80C", Offset = "0x4BCA80C", VA = "0x4BCA80C", Slot = "7")]
  protected override void Awake()
  {
  }

  [Token(Token = "0x6000B96")]
  [Address(RVA = "0x4BCA878", Offset = "0x4BCA878", VA = "0x4BCA878")]
  private void Start()
  {
  }

  [Token(Token = "0x6000B97")]
  [Address(RVA = "0x4BCA8A4", Offset = "0x4BCA8A4", VA = "0x4BCA8A4")]
  public void CaptureAsync(Action<RenderTexture> onCaptureComplete)
  {
  }

  [Token(Token = "0x6000B98")]
  [Address(RVA = "0x4BCAA30", Offset = "0x4BCAA30", VA = "0x4BCAA30")]
  public void CaptureAsync(RenderTexture targetTexture, Action<RenderTexture> onCaptureComplete)
  {
  }

  [Token(Token = "0x6000B99")]
  [Address(RVA = "0x4BCA9B4", Offset = "0x4BCA9B4", VA = "0x4BCA9B4")]
  private IEnumerator InternalCaptureAsync(
    RenderTexture targetTexture,
    Action<RenderTexture> onCaptureComplete)
  {
    return (IEnumerator) null;
  }

  [Token(Token = "0x6000B9A")]
  [Address(RVA = "0x4BCAA50", Offset = "0x4BCAA50", VA = "0x4BCAA50")]
  public void ViewingCaptureAsync(Action<RenderTexture> onCaptureComplete, int width, int height)
  {
  }

  [Token(Token = "0x6000B9B")]
  [Address(RVA = "0x4BCAB6C", Offset = "0x4BCAB6C", VA = "0x4BCAB6C")]
  private IEnumerator InternalViewingCaptureAsync(
    RenderTexture targetTexture,
    Action<RenderTexture> onCaptureComplete)
  {
    return (IEnumerator) null;
  }

  [Token(Token = "0x6000B9C")]
  [Address(RVA = "0x4BCABE8", Offset = "0x4BCABE8", VA = "0x4BCABE8")]
  public void RemoveRenderTexture()
  {
  }

  [Token(Token = "0x6000B9D")]
  [Address(RVA = "0x4BCAC80", Offset = "0x4BCAC80", VA = "0x4BCAC80")]
  public CaptureCamera()
  {
  }
}
