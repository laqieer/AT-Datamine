// Decompiled with JetBrains decompiler
// Type: UI.Resolution.ResolutionScaler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace UI.Resolution
{
  [Token(Token = "0x20008B4")]
  public class ResolutionScaler : MonoBehaviour
  {
    [Token(Token = "0x40028CF")]
    [FieldOffset(Offset = "0x18")]
    private float screenWidth;
    [Token(Token = "0x40028D0")]
    [FieldOffset(Offset = "0x1C")]
    private float screenHeight;
    [Token(Token = "0x40028D1")]
    [FieldOffset(Offset = "0x20")]
    private float safeAreaOutsideLeftLength;
    [Token(Token = "0x40028D2")]
    [FieldOffset(Offset = "0x24")]
    private float safeAreaOutsideRightLength;
    [Token(Token = "0x40028D3")]
    [FieldOffset(Offset = "0x28")]
    private float safeAreaOutsideTopLength;
    [Token(Token = "0x40028D4")]
    [FieldOffset(Offset = "0x2C")]
    private float safeAreaOutsideBottomLength;
    [Token(Token = "0x40028D5")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private ResolutionScaler.ScaleMode scaleMode;
    [Token(Token = "0x40028D6")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    [Range(0.0f, 1f)]
    private float horizontalAnchor;
    [Token(Token = "0x40028D7")]
    [FieldOffset(Offset = "0x38")]
    [Range(0.0f, 1f)]
    [SerializeField]
    private float verticalAnchor;
    [Token(Token = "0x40028D8")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private bool safeArea;

    [Token(Token = "0x6003171")]
    [Address(RVA = "0x3C179D0", Offset = "0x3C179D0", VA = "0x3C179D0")]
    private void Start()
    {
    }

    [Token(Token = "0x6003172")]
    [Address(RVA = "0x3C17D3C", Offset = "0x3C17D3C", VA = "0x3C17D3C")]
    private static float CalcScale(
      ResolutionScaler.ScaleMode mode,
      float parentWidth,
      float parentHeight,
      float width,
      float height)
    {
      return new float();
    }

    [Token(Token = "0x6003173")]
    [Address(RVA = "0x3C17DA0", Offset = "0x3C17DA0", VA = "0x3C17DA0")]
    private void GetSafeAreaOutsideLength()
    {
    }

    [Token(Token = "0x6003174")]
    [Address(RVA = "0x3C17E30", Offset = "0x3C17E30", VA = "0x3C17E30")]
    private void GetScreenSize()
    {
    }

    [Token(Token = "0x6003175")]
    [Address(RVA = "0x3C179D4", Offset = "0x3C179D4", VA = "0x3C179D4")]
    private void Apply()
    {
    }

    [Token(Token = "0x6003176")]
    [Address(RVA = "0x3C17E90", Offset = "0x3C17E90", VA = "0x3C17E90")]
    public ResolutionScaler()
    {
    }

    [Token(Token = "0x20008B5")]
    public enum ScaleMode
    {
      [Token(Token = "0x40028DA")] Horizontal,
      [Token(Token = "0x40028DB")] Vertical,
      [Token(Token = "0x40028DC")] Min,
      [Token(Token = "0x40028DD")] Max,
    }
  }
}
