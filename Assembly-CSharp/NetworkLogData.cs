// Decompiled with JetBrains decompiler
// Type: NetworkLogData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
[Token(Token = "0x2000231")]
public class NetworkLogData
{
  [Token(Token = "0x4000CFD")]
  [FieldOffset(Offset = "0x10")]
  public string URL;
  [Token(Token = "0x4000CFE")]
  [FieldOffset(Offset = "0x18")]
  public bool IsError;
  [Token(Token = "0x4000CFF")]
  [FieldOffset(Offset = "0x20")]
  public TimeSpan ElapsedTime;
  [Token(Token = "0x4000D00")]
  [FieldOffset(Offset = "0x28")]
  public DateTime Time;
  [Token(Token = "0x4000D01")]
  [FieldOffset(Offset = "0x30")]
  public NetworkLogDetailData RequestData;
  [Token(Token = "0x4000D02")]
  [FieldOffset(Offset = "0x38")]
  public NetworkLogDetailData ResponseData;

  [Token(Token = "0x6000DDF")]
  [Address(RVA = "0x1C88B98", Offset = "0x1C88B98", VA = "0x1C88B98")]
  public NetworkLogData()
  {
  }
}
