// Decompiled with JetBrains decompiler
// Type: Battle.UI.CameraConfigPanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x200230C")]
  public sealed class CameraConfigPanel : MonoBehaviour
  {
    [Token(Token = "0x400944C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [HideInInspector]
    private CameraConfigTween tweener;
    [Token(Token = "0x400944D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Toggle[] toggles;
    [Token(Token = "0x400944E")]
    [FieldOffset(Offset = "0x28")]
    private CameraConfigPanel.ICameraConfigHandler handler;

    [Token(Token = "0x600D626")]
    [Address(RVA = "0x1D1B058", Offset = "0x1D1B058", VA = "0x1D1B058")]
    public void Show(CameraConfigPanel.ICameraConfigHandler handler, CameraDirector cameraDirector)
    {
    }

    [Token(Token = "0x600D627")]
    [Address(RVA = "0x1D1B340", Offset = "0x1D1B340", VA = "0x1D1B340")]
    public void Hide()
    {
    }

    [Token(Token = "0x600D628")]
    [Address(RVA = "0x1D1B408", Offset = "0x1D1B408", VA = "0x1D1B408")]
    public void OnValueChanged(int index, bool isOn)
    {
    }

    [Token(Token = "0x600D629")]
    [Address(RVA = "0x1D1B4CC", Offset = "0x1D1B4CC", VA = "0x1D1B4CC")]
    public void OnClickBackButton()
    {
    }

    [Token(Token = "0x600D62A")]
    [Address(RVA = "0x1D1B574", Offset = "0x1D1B574", VA = "0x1D1B574")]
    public CameraConfigPanel()
    {
    }

    [Token(Token = "0x200230D")]
    public interface ICameraConfigHandler
    {
      [Token(Token = "0x600D62B")]
      void OnChangeCamera(int index);

      [Token(Token = "0x600D62C")]
      void OnCloseCameraConfig();
    }
  }
}
