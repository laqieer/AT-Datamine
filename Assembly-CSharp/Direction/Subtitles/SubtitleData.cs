// Decompiled with JetBrains decompiler
// Type: Direction.Subtitles.SubtitleData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Direction.Subtitles
{
  [Token(Token = "0x2001F24")]
  [Serializable]
  public class SubtitleData
  {
    [Token(Token = "0x400858B")]
    [FieldOffset(Offset = "0x10")]
    public float StartTime;
    [Token(Token = "0x400858C")]
    [FieldOffset(Offset = "0x14")]
    public float EndTime;
    [Token(Token = "0x400858D")]
    [FieldOffset(Offset = "0x18")]
    public SubtitleData.ActionType Type;
    [Token(Token = "0x400858E")]
    [FieldOffset(Offset = "0x20")]
    public string Talker;
    [Token(Token = "0x400858F")]
    [FieldOffset(Offset = "0x28")]
    public string Data;

    [Token(Token = "0x600B8EA")]
    [Address(RVA = "0x213849C", Offset = "0x213849C", VA = "0x213849C")]
    public bool IsValid() => new bool();

    [Token(Token = "0x600B8EB")]
    [Address(RVA = "0x21384AC", Offset = "0x21384AC", VA = "0x21384AC")]
    public SubtitleData()
    {
    }

    [Token(Token = "0x2001F25")]
    [Serializable]
    public enum ActionType
    {
      [Token(Token = "0x4008591")] SetText,
      [Token(Token = "0x4008592")] Active,
      [Token(Token = "0x4008593")] Inactive,
    }
  }
}
