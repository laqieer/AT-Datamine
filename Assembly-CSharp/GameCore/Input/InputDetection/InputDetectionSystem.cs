// Decompiled with JetBrains decompiler
// Type: GameCore.Input.InputDetection.InputDetectionSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DesignPattern;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace GameCore.Input.InputDetection
{
  [Token(Token = "0x2001454")]
  public class InputDetectionSystem : Singleton<InputDetectionSystem>
  {
    [Token(Token = "0x4005DB4")]
    [FieldOffset(Offset = "0x0")]
    private static Time[] beganTime;
    [Token(Token = "0x4005DB5")]
    [FieldOffset(Offset = "0x8")]
    private static Vector2[] lastEndPos;
    [Token(Token = "0x4005DB6")]
    [FieldOffset(Offset = "0x10")]
    private static bool[] tap;
    [Token(Token = "0x4005DB7")]
    [FieldOffset(Offset = "0x18")]
    private static Vector2[] tapStartPos;
    [Token(Token = "0x4005DB8")]
    [FieldOffset(Offset = "0x20")]
    private static bool[] move;
    [Token(Token = "0x4005DB9")]
    [FieldOffset(Offset = "0x28")]
    private static bool[] stop;
    [Token(Token = "0x4005DBA")]
    [FieldOffset(Offset = "0x30")]
    private static float flickDistance;
    [Token(Token = "0x4005DBB")]
    [FieldOffset(Offset = "0x34")]
    private static float thresholdTapTime;
    [Token(Token = "0x4005DBC")]
    public const int TouchIndexMax = 5;
    [Token(Token = "0x4005DBD")]
    public const float ThresholdTapTime = 0.4f;
    [Token(Token = "0x4005DBE")]
    [FieldOffset(Offset = "0x10")]
    private Touch[] touch;
    [Token(Token = "0x4005DBF")]
    [FieldOffset(Offset = "0x18")]
    private InputDetectionSystem.DoubleTouch doubleTouch;

    [Token(Token = "0x60072A4")]
    [Address(RVA = "0x405122C", Offset = "0x405122C", VA = "0x405122C")]
    public void Initialize()
    {
    }

    [Token(Token = "0x60072A5")]
    [Address(RVA = "0x40515D0", Offset = "0x40515D0", VA = "0x40515D0")]
    public int GetTouchCount() => new int();

    [Token(Token = "0x60072A6")]
    [Address(RVA = "0x4051644", Offset = "0x4051644", VA = "0x4051644")]
    public static void SetTouchPosition(int touchId, ref Vector2 position)
    {
    }

    [Token(Token = "0x60072A7")]
    [Address(RVA = "0x4051720", Offset = "0x4051720", VA = "0x4051720")]
    public static bool GetMovePosition(int touchId, ref Vector2 position) => new bool();

    [Token(Token = "0x60072A8")]
    [Address(RVA = "0x40517CC", Offset = "0x40517CC", VA = "0x40517CC")]
    public bool GetPinchLength(out float length) => new bool();

    [Token(Token = "0x60072A9")]
    [Address(RVA = "0x4051864", Offset = "0x4051864", VA = "0x4051864")]
    public InputDetectionSystem()
    {
    }

    [Token(Token = "0x2001455")]
    private class DoubleTouch
    {
      [Token(Token = "0x4005DC0")]
      [FieldOffset(Offset = "0x10")]
      public InputDetectionSystem.DoubleTouch.State state;
      [Token(Token = "0x4005DC1")]
      [FieldOffset(Offset = "0x14")]
      public bool isout;
      [Token(Token = "0x4005DC2")]
      [FieldOffset(Offset = "0x18")]
      public Vector2 Vector;

      [Token(Token = "0x60072AA")]
      [Address(RVA = "0x4051908", Offset = "0x4051908", VA = "0x4051908")]
      public DoubleTouch()
      {
      }

      [Token(Token = "0x2001456")]
      public enum State
      {
        [Token(Token = "0x4005DC4")] None,
        [Token(Token = "0x4005DC5")] Pinchi,
      }
    }
  }
}
