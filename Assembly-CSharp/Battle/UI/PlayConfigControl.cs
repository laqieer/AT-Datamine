// Decompiled with JetBrains decompiler
// Type: Battle.UI.PlayConfigControl
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Il2CppDummyDll;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x200232E")]
  public sealed class PlayConfigControl : MonoBehaviour
  {
    [Token(Token = "0x400953C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [Header("カメラ")]
    private Button changeCameraSettingButton;
    [Token(Token = "0x400953D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextMeshProUGUI cameraSettingText;
    [Token(Token = "0x400953E")]
    [FieldOffset(Offset = "0x28")]
    [Header("倍速")]
    [SerializeField]
    private Toggle switchFastModeToggle;
    [Token(Token = "0x400953F")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Image switchFastImage;
    [Token(Token = "0x4009540")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject txtFast1;
    [Token(Token = "0x4009541")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject txtFast2;
    [Token(Token = "0x4009542")]
    [FieldOffset(Offset = "0x48")]
    [Header("オート")]
    [SerializeField]
    private CommonButton switchAutoModeOn;
    [Token(Token = "0x4009543")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private CommonButton switchAutoModeOff;
    [Token(Token = "0x4009544")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Image switchAutoModeOffImage;
    [Token(Token = "0x4009545")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Image switchAutoModeOffImageCircle;
    [Token(Token = "0x4009546")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    [Header("ステータス")]
    private Toggle changeStatusIconToggle;
    [Token(Token = "0x4009547")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private GameObject statusIconOffText;
    [Token(Token = "0x4009548")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private GameObject statusIconOnText;
    [Token(Token = "0x4009549")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    [Header("危険エリア")]
    private Toggle changeDangerAreaToggle;
    [Token(Token = "0x400954A")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private GameObject dangerAreaOffText;
    [Token(Token = "0x400954B")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private GameObject dangerAreaOnText;
    [Token(Token = "0x400954C")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    [Header("スキップ")]
    private CommonButton skipButton;
    [Token(Token = "0x400954D")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private List<GameObject> objectList;
    [Token(Token = "0x400954E")]
    [FieldOffset(Offset = "0xA8")]
    private PlayConfigControl.ViewState state;
    [Token(Token = "0x400954F")]
    [FieldOffset(Offset = "0xAC")]
    private bool canAuto;

    [Token(Token = "0x17002E5F")]
    public CommonButton SwitchAutoModeOn
    {
      [Token(Token = "0x600D708"), Address(RVA = "0x1D24E5C", Offset = "0x1D24E5C", VA = "0x1D24E5C")] get
      {
        return (CommonButton) null;
      }
    }

    [Token(Token = "0x17002E60")]
    public CommonButton SwitchAutoModeOff
    {
      [Token(Token = "0x600D709"), Address(RVA = "0x1D24E64", Offset = "0x1D24E64", VA = "0x1D24E64")] get
      {
        return (CommonButton) null;
      }
    }

    [Token(Token = "0x600D70A")]
    [Address(RVA = "0x1D24E6C", Offset = "0x1D24E6C", VA = "0x1D24E6C")]
    public void Initialize(ISystemFlags systemFlags, bool canAuto)
    {
    }

    [Token(Token = "0x600D70B")]
    [Address(RVA = "0x1D24FA8", Offset = "0x1D24FA8", VA = "0x1D24FA8")]
    private void InitializeButton(Button target, Transform root = null)
    {
    }

    [Token(Token = "0x600D70C")]
    [Address(RVA = "0x1D2508C", Offset = "0x1D2508C", VA = "0x1D2508C")]
    public void SetSystemControlStatements(ISystemFlags flags)
    {
    }

    [Token(Token = "0x600D70D")]
    [Address(RVA = "0x1D255F8", Offset = "0x1D255F8", VA = "0x1D255F8")]
    public void SetCameraSettingNumber(int index)
    {
    }

    [Token(Token = "0x600D70E")]
    [Address(RVA = "0x1D24FF4", Offset = "0x1D24FF4", VA = "0x1D24FF4")]
    private void InitializeButton(Toggle target, Transform root = null)
    {
    }

    [Token(Token = "0x600D70F")]
    [Address(RVA = "0x1D256AC", Offset = "0x1D256AC", VA = "0x1D256AC")]
    public void SetSystemControlHandler(PlayConfigControl.ISystemControlHandler handler)
    {
    }

    [Token(Token = "0x600D710")]
    [Address(RVA = "0x1D25AC4", Offset = "0x1D25AC4", VA = "0x1D25AC4")]
    private void SetCallback(Button target, UnityAction callback)
    {
    }

    [Token(Token = "0x600D711")]
    [Address(RVA = "0x1D25B18", Offset = "0x1D25B18", VA = "0x1D25B18")]
    private void SetCallback(Toggle target, UnityAction<bool> callback)
    {
    }

    [Token(Token = "0x600D712")]
    [Address(RVA = "0x1D2556C", Offset = "0x1D2556C", VA = "0x1D2556C")]
    private void SettingFastModeView(bool val)
    {
    }

    [Token(Token = "0x600D713")]
    [Address(RVA = "0x1D255C8", Offset = "0x1D255C8", VA = "0x1D255C8")]
    private void SettingSkipButton(bool isSkip)
    {
    }

    [Token(Token = "0x600D714")]
    [Address(RVA = "0x1D254E4", Offset = "0x1D254E4", VA = "0x1D254E4")]
    public void SettingToggleStatusIcon(bool isActive)
    {
    }

    [Token(Token = "0x600D715")]
    [Address(RVA = "0x1D25434", Offset = "0x1D25434", VA = "0x1D25434")]
    public void SettingToggleDangerArea(bool isActive)
    {
    }

    [Token(Token = "0x600D716")]
    [Address(RVA = "0x1D25B94", Offset = "0x1D25B94", VA = "0x1D25B94")]
    public void Show()
    {
    }

    [Token(Token = "0x600D717")]
    [Address(RVA = "0x1D25BB8", Offset = "0x1D25BB8", VA = "0x1D25BB8")]
    public void Hide()
    {
    }

    [Token(Token = "0x600D718")]
    [Address(RVA = "0x1D25BDC", Offset = "0x1D25BDC", VA = "0x1D25BDC")]
    public void IsActiveCameraPosition(bool active)
    {
    }

    [Token(Token = "0x600D719")]
    [Address(RVA = "0x1D25BE8", Offset = "0x1D25BE8", VA = "0x1D25BE8")]
    private void IsActiveObject(PlayConfigControl.ConfigObject config, bool active)
    {
    }

    [Token(Token = "0x600D71A")]
    [Address(RVA = "0x1D25C5C", Offset = "0x1D25C5C", VA = "0x1D25C5C")]
    public void IsActiveFastMode(bool active)
    {
    }

    [Token(Token = "0x600D71B")]
    [Address(RVA = "0x1D25C68", Offset = "0x1D25C68", VA = "0x1D25C68")]
    public void IsActiveAutoModeToggle(bool active)
    {
    }

    [Token(Token = "0x600D71C")]
    [Address(RVA = "0x1D25C74", Offset = "0x1D25C74", VA = "0x1D25C74")]
    public void IsActiveAutoModeInteractable(bool active)
    {
    }

    [Token(Token = "0x600D71D")]
    [Address(RVA = "0x1D25CB8", Offset = "0x1D25CB8", VA = "0x1D25CB8")]
    public void IsActiveChangeStatusIconToggle(bool active)
    {
    }

    [Token(Token = "0x600D71E")]
    [Address(RVA = "0x1D25CC4", Offset = "0x1D25CC4", VA = "0x1D25CC4")]
    public void IsActiveDangerArea(bool active)
    {
    }

    [Token(Token = "0x600D71F")]
    [Address(RVA = "0x1D25040", Offset = "0x1D25040", VA = "0x1D25040")]
    private void SwitchActiveObject()
    {
    }

    [Token(Token = "0x600D720")]
    [Address(RVA = "0x1D25CD0", Offset = "0x1D25CD0", VA = "0x1D25CD0")]
    private void SetTutorialButton()
    {
    }

    [Token(Token = "0x600D721")]
    [Address(RVA = "0x1D25D80", Offset = "0x1D25D80", VA = "0x1D25D80")]
    public void AllToggleViewRest()
    {
    }

    [Token(Token = "0x600D722")]
    [Address(RVA = "0x1D25E98", Offset = "0x1D25E98", VA = "0x1D25E98")]
    public void DisActivePlayConfigControl()
    {
    }

    [Token(Token = "0x600D723")]
    [Address(RVA = "0x1D25F20", Offset = "0x1D25F20", VA = "0x1D25F20")]
    public void InitializeArenaSetting()
    {
    }

    [Token(Token = "0x600D724")]
    [Address(RVA = "0x1D25F84", Offset = "0x1D25F84", VA = "0x1D25F84")]
    public PlayConfigControl()
    {
    }

    [Token(Token = "0x200232F")]
    public interface ISystemControlHandler
    {
      [Token(Token = "0x600D725")]
      void OnChangeMapViewCameraSetting();

      [Token(Token = "0x600D726")]
      void OnSwitchAutoModeOn();

      [Token(Token = "0x600D727")]
      void OnSwitchAutoModeOff();

      [Token(Token = "0x600D728")]
      void OnSwitchFastMode(bool val);

      [Token(Token = "0x600D729")]
      void OnSwitchStatusIcon(bool val);

      [Token(Token = "0x600D72A")]
      void OnSwitchDangerArea(bool val);

      [Token(Token = "0x600D72B")]
      void OnSkip();

      [Token(Token = "0x600D72C")]
      void OnSwitchGridView(bool val);

      [Token(Token = "0x600D72D")]
      void OnChangeDuelAnimation(bool val);
    }

    [Token(Token = "0x2002330")]
    private enum ViewState
    {
      [Token(Token = "0x4009551")] Default,
      [Token(Token = "0x4009552")] Tutorial,
    }

    [Token(Token = "0x2002331")]
    private enum ConfigObject
    {
      [Token(Token = "0x4009554")] None = -1, // 0xFFFFFFFF
      [Token(Token = "0x4009555")] Camera = 0,
      [Token(Token = "0x4009556")] Fast = 1,
      [Token(Token = "0x4009557")] Auto = 2,
      [Token(Token = "0x4009558")] Status = 3,
      [Token(Token = "0x4009559")] DangerArea = 4,
      [Token(Token = "0x400955A")] Skip = 5,
    }
  }
}
