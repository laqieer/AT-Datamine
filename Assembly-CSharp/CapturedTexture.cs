// Decompiled with JetBrains decompiler
// Type: CapturedTexture
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x20002CA")]
[RequireComponent(typeof (RawImage))]
public class CapturedTexture : MonoBehaviour
{
  [Token(Token = "0x400104B")]
  [FieldOffset(Offset = "0x18")]
  private RawImage targetImage;

  [Token(Token = "0x170001B7")]
  public bool ActiveSelf
  {
    [Token(Token = "0x6001171"), Address(RVA = "0x1BF2C84", Offset = "0x1BF2C84", VA = "0x1BF2C84")] get
    {
      return new bool();
    }
    [Token(Token = "0x6001172"), Address(RVA = "0x1BF2CA4", Offset = "0x1BF2CA4", VA = "0x1BF2CA4")] set
    {
    }
  }

  [Token(Token = "0x6001173")]
  [Address(RVA = "0x1BF2CCC", Offset = "0x1BF2CCC", VA = "0x1BF2CCC")]
  private void Awake()
  {
  }

  [Token(Token = "0x6001174")]
  [Address(RVA = "0x1BF2D1C", Offset = "0x1BF2D1C", VA = "0x1BF2D1C")]
  public void StartCapture(int width, int height)
  {
  }

  [Token(Token = "0x6001175")]
  [Address(RVA = "0x1BF2E00", Offset = "0x1BF2E00", VA = "0x1BF2E00")]
  private void OnCaptureComplete(RenderTexture texture)
  {
  }

  [Token(Token = "0x6001176")]
  [Address(RVA = "0x1BF2EB4", Offset = "0x1BF2EB4", VA = "0x1BF2EB4")]
  public void RemoveRenderTexture()
  {
  }

  [Token(Token = "0x6001177")]
  [Address(RVA = "0x1BF2ED4", Offset = "0x1BF2ED4", VA = "0x1BF2ED4")]
  public CapturedTexture()
  {
  }
}
