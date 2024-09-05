// Decompiled with JetBrains decompiler
// Type: GridFade
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

#nullable disable
[Token(Token = "0x200018E")]
[PostProcess(typeof (GridFadeRenderer), PostProcessEvent.AfterStack, "Custom/GridFade", true)]
[Serializable]
public sealed class GridFade : PostProcessEffectSettings
{
  [Token(Token = "0x4000A32")]
  [FieldOffset(Offset = "0x30")]
  [Tooltip("Dimensions.")]
  public Vector2Parameter dimensions;
  [Token(Token = "0x4000A33")]
  [FieldOffset(Offset = "0x38")]
  [Range(0.0f, 1f)]
  [Tooltip("Progress.")]
  public FloatParameter progress;
  [Token(Token = "0x4000A34")]
  [FieldOffset(Offset = "0x40")]
  [Tooltip("Additional render target.")]
  public TextureParameter outputRT;

  [Token(Token = "0x6000ABB")]
  [Address(RVA = "0x4BBA71C", Offset = "0x4BBA71C", VA = "0x4BBA71C")]
  public GridFade()
  {
  }
}
