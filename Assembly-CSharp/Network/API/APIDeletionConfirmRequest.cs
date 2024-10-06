// Decompiled with JetBrains decompiler
// Type: Network.API.APIDeletionConfirmRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C0B")]
  [Serializable]
  public class APIDeletionConfirmRequest
  {
    [Token(Token = "0x4007807")]
    [FieldOffset(Offset = "0x10")]
    public string flow_token;
    [Token(Token = "0x4007808")]
    [FieldOffset(Offset = "0x18")]
    public int confirm_time;
    [Token(Token = "0x4007809")]
    [FieldOffset(Offset = "0x1C")]
    public int confirm_progress;

    [Token(Token = "0x600A4DF")]
    [Address(RVA = "0x1905EC0", Offset = "0x1905EC0", VA = "0x1905EC0")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A4E0")]
    [Address(RVA = "0x1905F08", Offset = "0x1905F08", VA = "0x1905F08")]
    public APIDeletionConfirmRequest()
    {
    }
  }
}
