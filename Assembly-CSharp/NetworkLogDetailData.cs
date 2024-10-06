// Decompiled with JetBrains decompiler
// Type: NetworkLogDetailData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
[Token(Token = "0x2000233")]
public class NetworkLogDetailData
{
  [Token(Token = "0x4000D07")]
  [FieldOffset(Offset = "0x10")]
  public string Body;
  [Token(Token = "0x4000D08")]
  [FieldOffset(Offset = "0x18")]
  public Dictionary<string, string> CustomFields;
  [Token(Token = "0x4000D09")]
  [FieldOffset(Offset = "0x20")]
  public Dictionary<string, string> Headers;

  [Token(Token = "0x6000DE9")]
  [Address(RVA = "0x1C8927C", Offset = "0x1C8927C", VA = "0x1C8927C")]
  public void SetCustomField(Dictionary<string, string> fields)
  {
  }

  [Token(Token = "0x6000DEA")]
  [Address(RVA = "0x1C895D4", Offset = "0x1C895D4", VA = "0x1C895D4")]
  public void SetBody(string body)
  {
  }

  [Token(Token = "0x6000DEB")]
  [Address(RVA = "0x1C89550", Offset = "0x1C89550", VA = "0x1C89550")]
  public void SetHeaders(Dictionary<string, string> headers)
  {
  }

  [Token(Token = "0x6000DEC")]
  [Address(RVA = "0x1C88C14", Offset = "0x1C88C14", VA = "0x1C88C14")]
  public NetworkLogDetailData()
  {
  }
}
