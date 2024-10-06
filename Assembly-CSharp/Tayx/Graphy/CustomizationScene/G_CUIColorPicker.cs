// Decompiled with JetBrains decompiler
// Type: Tayx.Graphy.CustomizationScene.G_CUIColorPicker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Tayx.Graphy.CustomizationScene
{
  [Token(Token = "0x20003A4")]
  public class G_CUIColorPicker : MonoBehaviour
  {
    [Token(Token = "0x400159A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Slider alphaSlider;
    [Token(Token = "0x400159B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Image alphaSliderBGImage;
    [Token(Token = "0x400159C")]
    [FieldOffset(Offset = "0x28")]
    private Color _color;
    [Token(Token = "0x400159D")]
    [FieldOffset(Offset = "0x38")]
    private Action<Color> _onValueChange;
    [Token(Token = "0x400159E")]
    [FieldOffset(Offset = "0x40")]
    private Action _update;

    [Token(Token = "0x1700022C")]
    public Color Color
    {
      [Token(Token = "0x60014FE"), Address(RVA = "0x252EDB8", Offset = "0x252EDB8", VA = "0x252EDB8")] get
      {
        return new Color();
      }
      [Token(Token = "0x60014FF"), Address(RVA = "0x252EDC4", Offset = "0x252EDC4", VA = "0x252EDC4")] set
      {
      }
    }

    [Token(Token = "0x6001500")]
    [Address(RVA = "0x252F478", Offset = "0x252F478", VA = "0x252F478")]
    public void SetOnValueChangeCallback(Action<Color> onValueChange)
    {
    }

    [Token(Token = "0x6001501")]
    [Address(RVA = "0x252F480", Offset = "0x252F480", VA = "0x252F480")]
    private static void RGBToHSV(Color color, out float h, out float s, out float v)
    {
    }

    [Token(Token = "0x6001502")]
    [Address(RVA = "0x252F650", Offset = "0x252F650", VA = "0x252F650")]
    private static bool GetLocalMouse(GameObject go, out Vector2 result) => new bool();

    [Token(Token = "0x6001503")]
    [Address(RVA = "0x252F7EC", Offset = "0x252F7EC", VA = "0x252F7EC")]
    private static Vector2 GetWidgetSize(GameObject go) => new Vector2();

    [Token(Token = "0x6001504")]
    [Address(RVA = "0x252F880", Offset = "0x252F880", VA = "0x252F880")]
    private GameObject GO(string name) => (GameObject) null;

    [Token(Token = "0x6001505")]
    [Address(RVA = "0x252EDC8", Offset = "0x252EDC8", VA = "0x252EDC8")]
    private void Setup(Color inputColor)
    {
    }

    [Token(Token = "0x6001506")]
    [Address(RVA = "0x252F8BC", Offset = "0x252F8BC", VA = "0x252F8BC")]
    public void SetRandomColor()
    {
    }

    [Token(Token = "0x6001507")]
    [Address(RVA = "0x252F9D8", Offset = "0x252F9D8", VA = "0x252F9D8")]
    private void Awake()
    {
    }

    [Token(Token = "0x6001508")]
    [Address(RVA = "0x252F9F0", Offset = "0x252F9F0", VA = "0x252F9F0")]
    private void Start()
    {
    }

    [Token(Token = "0x6001509")]
    [Address(RVA = "0x252FA98", Offset = "0x252FA98", VA = "0x252FA98")]
    private void Update()
    {
    }

    [Token(Token = "0x600150A")]
    [Address(RVA = "0x252FAB4", Offset = "0x252FAB4", VA = "0x252FAB4")]
    public G_CUIColorPicker()
    {
    }
  }
}
