// Decompiled with JetBrains decompiler
// Type: Network.API.APIChatPostRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001BD3")]
  [Serializable]
  public class APIChatPostRequest
  {
    [Token(Token = "0x4007732")]
    [FieldOffset(Offset = "0x10")]
    public int room_id;
    [Token(Token = "0x4007733")]
    [FieldOffset(Offset = "0x18")]
    public string content;
    [Token(Token = "0x4007734")]
    [FieldOffset(Offset = "0x20")]
    public string latest_message_id;
    [Token(Token = "0x4007735")]
    [FieldOffset(Offset = "0x28")]
    public int message_type_id;

    [Token(Token = "0x600A38C")]
    [Address(RVA = "0x46CF38C", Offset = "0x46CF38C", VA = "0x46CF38C")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A38D")]
    [Address(RVA = "0x46CF3D4", Offset = "0x46CF3D4", VA = "0x46CF3D4")]
    public APIChatPostRequest()
    {
    }
  }
}
