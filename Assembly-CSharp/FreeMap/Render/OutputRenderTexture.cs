// Decompiled with JetBrains decompiler
// Type: FreeMap.Render.OutputRenderTexture
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.UI;

#nullable disable
namespace FreeMap.Render
{
  [Token(Token = "0x2001854")]
  [RequireComponent(typeof (Camera))]
  public class OutputRenderTexture : MonoBehaviour
  {
    [Token(Token = "0x4006A09")]
    [FieldOffset(Offset = "0x18")]
    private Camera targetCamera;
    [Token(Token = "0x4006A0A")]
    [FieldOffset(Offset = "0x20")]
    private RenderTexture renderTexture;
    [Token(Token = "0x4006A0B")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private RawImage targetRawImage;
    [Token(Token = "0x4006A0C")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    [Min(0.0f)]
    private int width;
    [Token(Token = "0x4006A0D")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    [Min(0.0f)]
    private int height;
    [Token(Token = "0x4006A0E")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private int depth;
    [Token(Token = "0x4006A0F")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private GraphicsFormat graphicsFormat;

    [Token(Token = "0x6008989")]
    [Address(RVA = "0x43E5B2C", Offset = "0x43E5B2C", VA = "0x43E5B2C")]
    private void Awake()
    {
    }

    [Token(Token = "0x600898A")]
    [Address(RVA = "0x43E5BFC", Offset = "0x43E5BFC", VA = "0x43E5BFC")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600898B")]
    [Address(RVA = "0x43E5CA4", Offset = "0x43E5CA4", VA = "0x43E5CA4")]
    public OutputRenderTexture()
    {
    }
  }
}
