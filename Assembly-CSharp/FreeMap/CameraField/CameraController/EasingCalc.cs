// Decompiled with JetBrains decompiler
// Type: FreeMap.CameraField.CameraController.EasingCalc
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace FreeMap.CameraField.CameraController
{
  [Token(Token = "0x2001960")]
  public class EasingCalc
  {
    [Token(Token = "0x60090B9")]
    [Address(RVA = "0x4D052F8", Offset = "0x4D052F8", VA = "0x4D052F8")]
    public static float Liner(float time, float start, float end, float totalTime) => new float();

    [Token(Token = "0x60090BA")]
    [Address(RVA = "0x4D0531C", Offset = "0x4D0531C", VA = "0x4D0531C")]
    public static float SinusoidalIn(float time, float start, float end, float totalTime)
    {
      return new float();
    }

    [Token(Token = "0x60090BB")]
    [Address(RVA = "0x4D05358", Offset = "0x4D05358", VA = "0x4D05358")]
    public static float SinusoidalOut(float time, float start, float end, float totalTime)
    {
      return new float();
    }

    [Token(Token = "0x60090BC")]
    [Address(RVA = "0x4D05394", Offset = "0x4D05394", VA = "0x4D05394")]
    public static float SinusoidalInOut(float time, float start, float end, float totalTime)
    {
      return new float();
    }

    [Token(Token = "0x60090BD")]
    [Address(RVA = "0x4D053E0", Offset = "0x4D053E0", VA = "0x4D053E0")]
    public EasingCalc()
    {
    }

    [Token(Token = "0x2001961")]
    public enum EaseType
    {
      [Token(Token = "0x4006D17")] Linear,
      [Token(Token = "0x4006D18")] EaseIn,
      [Token(Token = "0x4006D19")] EaseOut,
      [Token(Token = "0x4006D1A")] EaseInOut,
    }
  }
}
