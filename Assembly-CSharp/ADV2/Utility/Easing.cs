// Decompiled with JetBrains decompiler
// Type: ADV2.Utility.Easing
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace ADV2.Utility
{
  [Token(Token = "0x2003F03")]
  public static class Easing
  {
    [Token(Token = "0x601976F")]
    [Address(RVA = "0x373951C", Offset = "0x373951C", VA = "0x373951C")]
    public static Easing.Method ParseMethod(string methodName) => new Easing.Method();

    [Token(Token = "0x6019770")]
    [Address(RVA = "0x373FECC", Offset = "0x373FECC", VA = "0x373FECC")]
    public static float Sample(Easing.Method method, float factor) => new float();

    [Token(Token = "0x6019771")]
    [Address(RVA = "0x373D40C", Offset = "0x373D40C", VA = "0x373D40C")]
    public static float Sample(Easing.Method method, float from, float to, float factor)
    {
      return new float();
    }

    [Token(Token = "0x6019772")]
    [Address(RVA = "0x373D600", Offset = "0x373D600", VA = "0x373D600")]
    public static Vector2 Sample(Easing.Method method, Vector2 from, Vector2 to, float factor)
    {
      return new Vector2();
    }

    [Token(Token = "0x6019773")]
    [Address(RVA = "0x373D810", Offset = "0x373D810", VA = "0x373D810")]
    public static Vector3 Sample(Easing.Method method, Vector3 from, Vector3 to, float factor)
    {
      return new Vector3();
    }

    [Token(Token = "0x6019774")]
    [Address(RVA = "0x373FF5C", Offset = "0x373FF5C", VA = "0x373FF5C")]
    public static Vector3 SampleAngle(
      Easing.Method method,
      Vector3 from,
      Vector3 to,
      float factor)
    {
      return new Vector3();
    }

    [Token(Token = "0x2003F04")]
    public enum Method
    {
      [Token(Token = "0x4011437")] Linear,
      [Token(Token = "0x4011438")] EaseIn,
      [Token(Token = "0x4011439")] EaseOut,
      [Token(Token = "0x401143A")] EaseInOut,
    }
  }
}
