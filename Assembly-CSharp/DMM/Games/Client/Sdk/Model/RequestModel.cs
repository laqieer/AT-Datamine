// Decompiled with JetBrains decompiler
// Type: DMM.Games.Client.Sdk.Model.RequestModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace DMM.Games.Client.Sdk.Model
{
  [Token(Token = "0x2003FC9")]
  [Serializable]
  public class RequestModel
  {
    [Token(Token = "0x4011777")]
    [FieldOffset(Offset = "0x10")]
    public string access_token;
    [Token(Token = "0x4011778")]
    [FieldOffset(Offset = "0x18")]
    public string sdk_version;
    [Token(Token = "0x4011779")]
    [FieldOffset(Offset = "0x20")]
    public string viewer_id;
    [Token(Token = "0x401177A")]
    [FieldOffset(Offset = "0x28")]
    public string onetime_token;
    [Token(Token = "0x401177B")]
    [FieldOffset(Offset = "0x30")]
    public string command;

    [Token(Token = "0x6019A6E")]
    [Address(RVA = "0x3787F74", Offset = "0x3787F74", VA = "0x3787F74")]
    public static RequestModel Create(NetGameApiSdk.Kind kind) => (RequestModel) null;

    [Token(Token = "0x6019A6F")]
    [Address(RVA = "0x3788714", Offset = "0x3788714", VA = "0x3788714")]
    public string ToJson() => (string) null;

    [Token(Token = "0x6019A70")]
    [Address(RVA = "0x378870C", Offset = "0x378870C", VA = "0x378870C")]
    public RequestModel()
    {
    }
  }
}
