// Decompiled with JetBrains decompiler
// Type: CapturedBlurTexture
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x20002C9")]
[RequireComponent(typeof (RawImage))]
public class CapturedBlurTexture : MonoBehaviour
{
  [Token(Token = "0x4001046")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  [Tooltip("RenderTextureのインスタンスを生成するか？\n※※ 基本的には false を使う事 ※※\n【使用例】\nぼかしテクスチャの上にぼかしテクスチャを重ねるUI構成の場合、共通のRenderTextureインスタンスを参照していると表示がおかしくなる。ので、その場合に使用する。")]
  private bool IsCreateRenderTextureInstance;
  [Token(Token = "0x4001048")]
  [FieldOffset(Offset = "0x20")]
  private RawImage targetImage;
  [Token(Token = "0x4001049")]
  [FieldOffset(Offset = "0x28")]
  private Color initColor;
  [Token(Token = "0x400104A")]
  [FieldOffset(Offset = "0x38")]
  private RenderTexture createdRenderTexture;

  [Token(Token = "0x170001B6")]
  public bool IsCaptured
  {
    [Token(Token = "0x6001167"), Address(RVA = "0x1BF2630", Offset = "0x1BF2630", VA = "0x1BF2630")] get
    {
      return new bool();
    }
    [Token(Token = "0x6001168"), Address(RVA = "0x1BF2638", Offset = "0x1BF2638", VA = "0x1BF2638")] private set
    {
    }
  }

  [Token(Token = "0x6001169")]
  [Address(RVA = "0x1BF2644", Offset = "0x1BF2644", VA = "0x1BF2644")]
  private void Awake()
  {
  }

  [Token(Token = "0x600116A")]
  [Address(RVA = "0x1BF2694", Offset = "0x1BF2694", VA = "0x1BF2694")]
  private void OnEnable()
  {
  }

  [Token(Token = "0x600116B")]
  [Address(RVA = "0x1BF295C", Offset = "0x1BF295C", VA = "0x1BF295C")]
  private void OnDisable()
  {
  }

  [Token(Token = "0x600116C")]
  [Address(RVA = "0x1BF29EC", Offset = "0x1BF29EC", VA = "0x1BF29EC")]
  public void ReCapture()
  {
  }

  [Token(Token = "0x600116D")]
  [Address(RVA = "0x1BF2BCC", Offset = "0x1BF2BCC", VA = "0x1BF2BCC")]
  private void OnCaptureComplete(RenderTexture texture)
  {
  }

  [Token(Token = "0x600116E")]
  [Address(RVA = "0x1BF2874", Offset = "0x1BF2874", VA = "0x1BF2874")]
  private void CreateRenderTexture()
  {
  }

  [Token(Token = "0x600116F")]
  [Address(RVA = "0x1BF296C", Offset = "0x1BF296C", VA = "0x1BF296C")]
  private void ReleaseRenderTexture()
  {
  }

  [Token(Token = "0x6001170")]
  [Address(RVA = "0x1BF2C7C", Offset = "0x1BF2C7C", VA = "0x1BF2C7C")]
  public CapturedBlurTexture()
  {
  }
}
