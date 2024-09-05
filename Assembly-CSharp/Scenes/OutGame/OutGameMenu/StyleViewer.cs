// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.StyleViewer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using StaqData;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003AC5")]
  internal class StyleViewer : MonoBehaviour
  {
    [Token(Token = "0x401029D")]
    [FieldOffset(Offset = "0x18")]
    private StyleStatusSubScene styleStatusSubScene;
    [Token(Token = "0x401029E")]
    [FieldOffset(Offset = "0x20")]
    private Style dispStyle;
    [Token(Token = "0x401029F")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text cvText;
    [Token(Token = "0x40102A0")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text illustText;
    [Token(Token = "0x40102A1")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private CommonButton rotateButton;
    [Token(Token = "0x40102A2")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private CommonButton profileButton;
    [Token(Token = "0x40102A3")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Image characterImage;
    [Token(Token = "0x40102A4")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private RectTransform imageRect;
    [Token(Token = "0x40102A5")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private RectTransform moveAreaRect;
    [Token(Token = "0x40102A6")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private float imageScaleDefault;
    [Token(Token = "0x40102A7")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    private int maxZoomRatio;
    [Token(Token = "0x40102A8")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private float minZoomRatio;
    [Token(Token = "0x40102A9")]
    [FieldOffset(Offset = "0x6C")]
    [SerializeField]
    private float zoomRatio;
    [Token(Token = "0x40102AA")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private float minPinchDelta;
    [Token(Token = "0x40102AB")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private CommonGesturePanel commonGesturePanel;
    [Token(Token = "0x40102AC")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private Canvas mainUICanvas;
    [Token(Token = "0x40102AD")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private UITweenGroup tween;
    [Token(Token = "0x40102AE")]
    [FieldOffset(Offset = "0x90")]
    private StyleViewerProfilePopup profilePopup;
    [Token(Token = "0x40102AF")]
    [FieldOffset(Offset = "0x98")]
    private bool isRotate;
    [Token(Token = "0x40102B0")]
    [FieldOffset(Offset = "0x99")]
    private bool isHide;
    [Token(Token = "0x40102B1")]
    [FieldOffset(Offset = "0x9A")]
    private bool isDefault;
    [Token(Token = "0x40102B2")]
    [FieldOffset(Offset = "0x9B")]
    private bool isBackGround;

    [Token(Token = "0x17004B97")]
    private RectTransform rectTransform
    {
      [Token(Token = "0x60171E2"), Address(RVA = "0x2CEF9AC", Offset = "0x2CEF9AC", VA = "0x2CEF9AC")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x60171E3")]
    [Address(RVA = "0x2CEFA0C", Offset = "0x2CEFA0C", VA = "0x2CEFA0C")]
    private void OnApplicationPause(bool pauseStatus)
    {
    }

    [Token(Token = "0x60171E4")]
    [Address(RVA = "0x2CEFA58", Offset = "0x2CEFA58", VA = "0x2CEFA58")]
    private void OnApplicationFocus(bool hasFocus)
    {
    }

    [Token(Token = "0x60171E5")]
    [Address(RVA = "0x2CEFA14", Offset = "0x2CEFA14", VA = "0x2CEFA14")]
    private void ChangeBackgroundStatus(bool state)
    {
    }

    [Token(Token = "0x60171E6")]
    [Address(RVA = "0x2CE8E00", Offset = "0x2CE8E00", VA = "0x2CE8E00")]
    public void Initialized(StyleStatusSubScene statusSubScene, Style style)
    {
    }

    [Token(Token = "0x60171E7")]
    [Address(RVA = "0x2CE729C", Offset = "0x2CE729C", VA = "0x2CE729C")]
    public void Finalized()
    {
    }

    [Token(Token = "0x60171E8")]
    [Address(RVA = "0x2CEFA9C", Offset = "0x2CEFA9C", VA = "0x2CEFA9C")]
    private void Rotate()
    {
    }

    [Token(Token = "0x60171E9")]
    [Address(RVA = "0x2CEFB20", Offset = "0x2CEFB20", VA = "0x2CEFB20")]
    private void OnClickProfile()
    {
    }

    [Token(Token = "0x60171EA")]
    [Address(RVA = "0x2CEFD20", Offset = "0x2CEFD20", VA = "0x2CEFD20")]
    private void SwichHideUI()
    {
    }

    [Token(Token = "0x60171EB")]
    [Address(RVA = "0x2CEFA64", Offset = "0x2CEFA64", VA = "0x2CEFA64")]
    private void SetDefaultScale()
    {
    }

    [Token(Token = "0x60171EC")]
    [Address(RVA = "0x2CEFDA4", Offset = "0x2CEFDA4", VA = "0x2CEFDA4")]
    private void SetMaxScale()
    {
    }

    [Token(Token = "0x60171ED")]
    [Address(RVA = "0x2CEFDE0", Offset = "0x2CEFDE0", VA = "0x2CEFDE0")]
    private void SetMinScale()
    {
    }

    [Token(Token = "0x60171EE")]
    [Address(RVA = "0x2CEFE1C", Offset = "0x2CEFE1C", VA = "0x2CEFE1C")]
    private void OnSingleClick(Vector2 pos)
    {
    }

    [Token(Token = "0x60171EF")]
    [Address(RVA = "0x2CEFE2C", Offset = "0x2CEFE2C", VA = "0x2CEFE2C")]
    private void OnDoubleClick(Vector2 pos)
    {
    }

    [Token(Token = "0x60171F0")]
    [Address(RVA = "0x2CF029C", Offset = "0x2CF029C", VA = "0x2CF029C")]
    private void OnSinglePointerMove(Vector2 pos, Vector2 delta)
    {
    }

    [Token(Token = "0x60171F1")]
    [Address(RVA = "0x2CF03C4", Offset = "0x2CF03C4", VA = "0x2CF03C4")]
    private void OnSinglePointerMoveEnd(Vector2 pos)
    {
    }

    [Token(Token = "0x60171F2")]
    [Address(RVA = "0x2CF03C8", Offset = "0x2CF03C8", VA = "0x2CF03C8")]
    private void OnPinchStart(Vector2 center)
    {
    }

    [Token(Token = "0x60171F3")]
    [Address(RVA = "0x2CF0710", Offset = "0x2CF0710", VA = "0x2CF0710")]
    private void OnPinch(float delta)
    {
    }

    [Token(Token = "0x60171F4")]
    [Address(RVA = "0x2CF07B0", Offset = "0x2CF07B0", VA = "0x2CF07B0")]
    private void OnPinchEnd(Vector2 center)
    {
    }

    [Token(Token = "0x60171F5")]
    [Address(RVA = "0x2CEFFC0", Offset = "0x2CEFFC0", VA = "0x2CEFFC0")]
    private void ValidatePosition()
    {
    }

    [Token(Token = "0x60171F6")]
    [Address(RVA = "0x2CF0484", Offset = "0x2CF0484", VA = "0x2CF0484")]
    private Vector2 CalcPivot(Vector2 touch) => new Vector2();

    [Token(Token = "0x60171F7")]
    [Address(RVA = "0x2CF057C", Offset = "0x2CF057C", VA = "0x2CF057C")]
    private void ChangePivot(Vector2 pivot)
    {
    }

    [Token(Token = "0x60171F8")]
    [Address(RVA = "0x2CF0828", Offset = "0x2CF0828", VA = "0x2CF0828")]
    public StyleViewer()
    {
    }
  }
}
