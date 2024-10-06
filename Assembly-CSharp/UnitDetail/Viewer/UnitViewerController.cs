// Decompiled with JetBrains decompiler
// Type: UnitDetail.Viewer.UnitViewerController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnitDetail.Data.ScriptableObjects;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UnitDetail.Viewer
{
  [Token(Token = "0x20004B7")]
  public class UnitViewerController : MonoBehaviour
  {
    [Token(Token = "0x40018EE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ViewerSettingTable setting;
    [Token(Token = "0x40018EF")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Transform orientationTarget;
    [Token(Token = "0x40018F0")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Transform orientationTargetInCanvas;
    [Token(Token = "0x40018F1")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private UnitViewer2D unitViewer2D;
    [Token(Token = "0x40018F2")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private UnitViewerDot unitViewerDot;
    [Token(Token = "0x40018F3")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private RawImage arImage;
    [Token(Token = "0x40018F4")]
    [FieldOffset(Offset = "0x48")]
    private WebCamTexture webCamTexture;

    [Token(Token = "0x17000344")]
    public UnitViewer2D UnitViewer2D
    {
      [Token(Token = "0x6001AAC"), Address(RVA = "0x2C27C88", Offset = "0x2C27C88", VA = "0x2C27C88")] get
      {
        return (UnitViewer2D) null;
      }
    }

    [Token(Token = "0x17000345")]
    public UnitViewerDot UnitViewerDot
    {
      [Token(Token = "0x6001AAD"), Address(RVA = "0x2C27C90", Offset = "0x2C27C90", VA = "0x2C27C90")] get
      {
        return (UnitViewerDot) null;
      }
    }

    [Token(Token = "0x6001AAE")]
    [Address(RVA = "0x2C27C98", Offset = "0x2C27C98", VA = "0x2C27C98")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6001AAF")]
    [Address(RVA = "0x2C27CE0", Offset = "0x2C27CE0", VA = "0x2C27CE0")]
    public void SetLandscape()
    {
    }

    [Token(Token = "0x6001AB0")]
    [Address(RVA = "0x2C27DB4", Offset = "0x2C27DB4", VA = "0x2C27DB4")]
    public void SetPortrait()
    {
    }

    [Token(Token = "0x6001AB1")]
    [Address(RVA = "0x2C27EA0", Offset = "0x2C27EA0", VA = "0x2C27EA0")]
    public UnitViewerController()
    {
    }
  }
}
