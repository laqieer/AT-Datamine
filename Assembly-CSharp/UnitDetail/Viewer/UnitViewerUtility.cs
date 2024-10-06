// Decompiled with JetBrains decompiler
// Type: UnitDetail.Viewer.UnitViewerUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace UnitDetail.Viewer
{
  [Token(Token = "0x20004C1")]
  public static class UnitViewerUtility
  {
    [Token(Token = "0x4001934")]
    [FieldOffset(Offset = "0x0")]
    public static readonly IReadOnlyList<UnitViewerUtility.MotionInfo> UnitMotionList;
    [Token(Token = "0x4001935")]
    [FieldOffset(Offset = "0x8")]
    public static readonly IReadOnlyList<UnitViewerUtility.MotionInfo> UnitDotMotionList;
    [Token(Token = "0x4001936")]
    [FieldOffset(Offset = "0x10")]
    public static readonly IReadOnlyList<UnitViewerUtility.VoiceInfo> UnitVoiceList;

    [Token(Token = "0x6001B02")]
    [Address(RVA = "0x2C25E00", Offset = "0x2C25E00", VA = "0x2C25E00")]
    public static Vector2 Clamp(Vector2 value, Vector2 min, Vector2 max) => new Vector2();

    [Token(Token = "0x6001B03")]
    [Address(RVA = "0x2C2A7EC", Offset = "0x2C2A7EC", VA = "0x2C2A7EC")]
    public static Vector3 Clamp(Vector3 value, Vector3 min, Vector3 max) => new Vector3();

    [Token(Token = "0x6001B04")]
    [Address(RVA = "0x2C2A828", Offset = "0x2C2A828", VA = "0x2C2A828")]
    static UnitViewerUtility()
    {
    }

    [Token(Token = "0x20004C2")]
    public enum UnitMotionIndices
    {
      [Token(Token = "0x4001938")] Idle,
      [Token(Token = "0x4001939")] Run,
      [Token(Token = "0x400193A")] Win,
    }

    [Token(Token = "0x20004C3")]
    public class MotionInfo
    {
      [Token(Token = "0x400193B")]
      [FieldOffset(Offset = "0x10")]
      public string motionName;
      [Token(Token = "0x400193C")]
      [FieldOffset(Offset = "0x18")]
      public string stateName;
      [Token(Token = "0x400193D")]
      [FieldOffset(Offset = "0x20")]
      public string soundName;

      [Token(Token = "0x6001B05")]
      [Address(RVA = "0x2C2B4F4", Offset = "0x2C2B4F4", VA = "0x2C2B4F4")]
      public MotionInfo()
      {
      }
    }

    [Token(Token = "0x20004C4")]
    public class VoiceInfo
    {
      [Token(Token = "0x400193E")]
      [FieldOffset(Offset = "0x10")]
      public string voiceName;
      [Token(Token = "0x400193F")]
      [FieldOffset(Offset = "0x18")]
      public string soundName;

      [Token(Token = "0x6001B06")]
      [Address(RVA = "0x2C2B4FC", Offset = "0x2C2B4FC", VA = "0x2C2B4FC")]
      public VoiceInfo()
      {
      }
    }
  }
}
