// Decompiled with JetBrains decompiler
// Type: Battle.UI.FieldOptionSelectButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x2002327")]
  public class FieldOptionSelectButton : MonoBehaviour
  {
    [Token(Token = "0x400950B")]
    [FieldOffset(Offset = "0x18")]
    [Header("ON/OFFボタン")]
    [SerializeField]
    private Button onActiveButton;
    [Token(Token = "0x400950C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Button onDeactiveButton;
    [Token(Token = "0x400950D")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Button offActiveButton;
    [Token(Token = "0x400950E")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Button offDeactiveButton;
    [Token(Token = "0x400950F")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Image onDeactiveButtonImg;
    [Token(Token = "0x4009510")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Image offDeactiveButtonImg;
    [Token(Token = "0x4009511")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Image[] autoChildIcons;
    [Token(Token = "0x4009512")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private TextMeshProUGUI[] deactiveTxtOnGray;
    [Token(Token = "0x4009513")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Text buttonText;
    [Token(Token = "0x4009514")]
    [FieldOffset(Offset = "0x60")]
    [Header("スピード設定")]
    [SerializeField]
    private Button[] speedActiveButton;
    [Token(Token = "0x4009515")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Button[] speedDeactiveButton;
    [Token(Token = "0x4009516")]
    [FieldOffset(Offset = "0x70")]
    [Header("サウンド設定")]
    [SerializeField]
    private Slider soundOptionSlider;
    [Token(Token = "0x4009517")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Text soundOptionValue;
    [Token(Token = "0x4009518")]
    [FieldOffset(Offset = "0x80")]
    public string busName;
    [Token(Token = "0x4009519")]
    [FieldOffset(Offset = "0x88")]
    public bool isOn;
    [Token(Token = "0x400951A")]
    [FieldOffset(Offset = "0x89")]
    public bool isSpeed;
    [Token(Token = "0x400951B")]
    [FieldOffset(Offset = "0x8C")]
    public float isSliderValue;
    [Token(Token = "0x400951C")]
    [FieldOffset(Offset = "0x90")]
    private UnityAction callback;
    [Token(Token = "0x400951D")]
    [FieldOffset(Offset = "0x98")]
    private bool buttonEnable;

    [Token(Token = "0x17002E54")]
    public UnityAction OnDeactiveButtonEvent
    {
      [Token(Token = "0x600D6E1"), Address(RVA = "0x1D24290", Offset = "0x1D24290", VA = "0x1D24290")] set
      {
      }
    }

    [Token(Token = "0x17002E55")]
    public UnityAction OffDeactiveButtonEvent
    {
      [Token(Token = "0x600D6E2"), Address(RVA = "0x1D242B4", Offset = "0x1D242B4", VA = "0x1D242B4")] set
      {
      }
    }

    [Token(Token = "0x600D6E3")]
    [Address(RVA = "0x1D2012C", Offset = "0x1D2012C", VA = "0x1D2012C")]
    public void InitializeOnOffButton(UnityAction callbackAction = null)
    {
    }

    [Token(Token = "0x600D6E4")]
    [Address(RVA = "0x1D20200", Offset = "0x1D20200", VA = "0x1D20200")]
    public void InitializeSpeedButton(UnityAction callbackAction = null)
    {
    }

    [Token(Token = "0x600D6E5")]
    [Address(RVA = "0x1D20324", Offset = "0x1D20324", VA = "0x1D20324")]
    public void OnOffButtonActiveSet(bool active)
    {
    }

    [Token(Token = "0x600D6E6")]
    [Address(RVA = "0x1D208F4", Offset = "0x1D208F4", VA = "0x1D208F4")]
    public void AutoButtonDeactiveSet(bool active)
    {
    }

    [Token(Token = "0x600D6E7")]
    [Address(RVA = "0x1D242D8", Offset = "0x1D242D8", VA = "0x1D242D8")]
    private void ButtonActive()
    {
    }

    [Token(Token = "0x600D6E8")]
    [Address(RVA = "0x1D243A4", Offset = "0x1D243A4", VA = "0x1D243A4")]
    private void ButtonDeactive()
    {
    }

    [Token(Token = "0x600D6E9")]
    [Address(RVA = "0x1D24460", Offset = "0x1D24460", VA = "0x1D24460")]
    private void SpeedButtonOff()
    {
    }

    [Token(Token = "0x600D6EA")]
    [Address(RVA = "0x1D24468", Offset = "0x1D24468", VA = "0x1D24468")]
    private void SpeedButton2()
    {
    }

    [Token(Token = "0x600D6EB")]
    [Address(RVA = "0x1D2057C", Offset = "0x1D2057C", VA = "0x1D2057C")]
    public void SpeedButtonActiveSet(bool val)
    {
    }

    [Token(Token = "0x600D6EC")]
    [Address(RVA = "0x1D207E8", Offset = "0x1D207E8", VA = "0x1D207E8")]
    public void SoundSliderValueSet(float value, string busName)
    {
    }

    [Token(Token = "0x600D6ED")]
    [Address(RVA = "0x1D24470", Offset = "0x1D24470", VA = "0x1D24470")]
    public void OnValueSlider()
    {
    }

    [Token(Token = "0x600D6EE")]
    [Address(RVA = "0x1D245EC", Offset = "0x1D245EC", VA = "0x1D245EC")]
    public FieldOptionSelectButton()
    {
    }

    [Token(Token = "0x2002328")]
    public enum SpeedNumEnum
    {
      [Token(Token = "0x400951F")] Off,
      [Token(Token = "0x4009520")] Speed2,
    }
  }
}
