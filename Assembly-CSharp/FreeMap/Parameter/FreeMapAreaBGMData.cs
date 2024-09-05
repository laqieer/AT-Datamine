// Decompiled with JetBrains decompiler
// Type: FreeMap.Parameter.FreeMapAreaBGMData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace FreeMap.Parameter
{
  [Token(Token = "0x200185E")]
  [Serializable]
  public struct FreeMapAreaBGMData
  {
    [Token(Token = "0x4006A2E")]
    [FieldOffset(Offset = "0x0")]
    public string bgmBank;
    [Token(Token = "0x4006A2F")]
    [FieldOffset(Offset = "0x8")]
    public string bgmEvent;
    [Token(Token = "0x4006A30")]
    [FieldOffset(Offset = "0x10")]
    public string bgmSubEvent;
  }
}
