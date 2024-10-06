// Decompiled with JetBrains decompiler
// Type: TMPro.RubyTMP_DefaultControls
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace TMPro
{
  [Token(Token = "0x200037B")]
  public static class RubyTMP_DefaultControls
  {
    [Token(Token = "0x400145E")]
    private const float kWidth = 160f;
    [Token(Token = "0x400145F")]
    private const float kThickHeight = 30f;
    [Token(Token = "0x4001460")]
    private const float kThinHeight = 20f;
    [Token(Token = "0x4001461")]
    [FieldOffset(Offset = "0x0")]
    private static Vector2 s_ThickElementSize;
    [Token(Token = "0x4001462")]
    [FieldOffset(Offset = "0x8")]
    private static Vector2 s_ThinElementSize;
    [Token(Token = "0x4001463")]
    [FieldOffset(Offset = "0x10")]
    private static Color s_DefaultSelectableColor;
    [Token(Token = "0x4001464")]
    [FieldOffset(Offset = "0x20")]
    private static Color s_TextColor;

    [Token(Token = "0x60013EE")]
    [Address(RVA = "0x2522D58", Offset = "0x2522D58", VA = "0x2522D58")]
    private static GameObject CreateUIElementRoot(string name, Vector2 size) => (GameObject) null;

    [Token(Token = "0x60013EF")]
    [Address(RVA = "0x2522E00", Offset = "0x2522E00", VA = "0x2522E00")]
    private static GameObject CreateUIObject(string name, GameObject parent) => (GameObject) null;

    [Token(Token = "0x60013F0")]
    [Address(RVA = "0x2522FC0", Offset = "0x2522FC0", VA = "0x2522FC0")]
    private static void SetDefaultTextValues(TMP_Text lbl)
    {
    }

    [Token(Token = "0x60013F1")]
    [Address(RVA = "0x2523048", Offset = "0x2523048", VA = "0x2523048")]
    private static void SetDefaultColorTransitionValues(Selectable slider)
    {
    }

    [Token(Token = "0x60013F2")]
    [Address(RVA = "0x2522EC0", Offset = "0x2522EC0", VA = "0x2522EC0")]
    private static void SetParentAndAlign(GameObject child, GameObject parent)
    {
    }

    [Token(Token = "0x60013F3")]
    [Address(RVA = "0x25230A8", Offset = "0x25230A8", VA = "0x25230A8")]
    private static void SetLayerRecursively(GameObject go, int layer)
    {
    }

    [Token(Token = "0x60013F4")]
    [Address(RVA = "0x252318C", Offset = "0x252318C", VA = "0x252318C")]
    public static GameObject CreateScrollbar(RubyTMP_DefaultControls.Resources resources)
    {
      return (GameObject) null;
    }

    [Token(Token = "0x60013F5")]
    [Address(RVA = "0x2523458", Offset = "0x2523458", VA = "0x2523458")]
    public static GameObject CreateButton(RubyTMP_DefaultControls.Resources resources)
    {
      return (GameObject) null;
    }

    [Token(Token = "0x60013F6")]
    [Address(RVA = "0x2523718", Offset = "0x2523718", VA = "0x2523718")]
    public static GameObject CreateText(RubyTMP_DefaultControls.Resources resources)
    {
      return (GameObject) null;
    }

    [Token(Token = "0x60013F7")]
    [Address(RVA = "0x25237F0", Offset = "0x25237F0", VA = "0x25237F0")]
    static RubyTMP_DefaultControls()
    {
    }

    [Token(Token = "0x200037C")]
    public struct Resources
    {
      [Token(Token = "0x4001465")]
      [FieldOffset(Offset = "0x0")]
      public Sprite standard;
      [Token(Token = "0x4001466")]
      [FieldOffset(Offset = "0x8")]
      public Sprite background;
      [Token(Token = "0x4001467")]
      [FieldOffset(Offset = "0x10")]
      public Sprite inputField;
      [Token(Token = "0x4001468")]
      [FieldOffset(Offset = "0x18")]
      public Sprite knob;
      [Token(Token = "0x4001469")]
      [FieldOffset(Offset = "0x20")]
      public Sprite checkmark;
      [Token(Token = "0x400146A")]
      [FieldOffset(Offset = "0x28")]
      public Sprite dropdown;
      [Token(Token = "0x400146B")]
      [FieldOffset(Offset = "0x30")]
      public Sprite mask;
    }
  }
}
