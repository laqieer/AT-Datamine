// Decompiled with JetBrains decompiler
// Type: Story.Calendar.CalendarCapture
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Story.Calendar
{
  [Token(Token = "0x200071F")]
  [RequireComponent(typeof (RawImage))]
  internal class CalendarCapture : MonoBehaviour
  {
    [Token(Token = "0x400210B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Camera captureCamera;
    [Token(Token = "0x400210C")]
    [FieldOffset(Offset = "0x20")]
    private RenderTexture renderTexture;
    [Token(Token = "0x400210D")]
    [FieldOffset(Offset = "0x28")]
    private RawImage targetImage;

    [Token(Token = "0x170005EE")]
    public Camera CaptureCamera
    {
      [Token(Token = "0x6002810"), Address(RVA = "0x367222C", Offset = "0x367222C", VA = "0x367222C")] get
      {
        return (Camera) null;
      }
    }

    [Token(Token = "0x6002811")]
    [Address(RVA = "0x3672234", Offset = "0x3672234", VA = "0x3672234")]
    private void Awake()
    {
    }

    [Token(Token = "0x6002812")]
    [Address(RVA = "0x3672320", Offset = "0x3672320", VA = "0x3672320")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6002813")]
    [Address(RVA = "0x3672324", Offset = "0x3672324", VA = "0x3672324")]
    public void RemoveRenderTexture()
    {
    }

    [Token(Token = "0x6002814")]
    [Address(RVA = "0x36723A0", Offset = "0x36723A0", VA = "0x36723A0")]
    public void Capture()
    {
    }

    [Token(Token = "0x6002815")]
    [Address(RVA = "0x3672414", Offset = "0x3672414", VA = "0x3672414")]
    public CalendarCapture()
    {
    }
  }
}
