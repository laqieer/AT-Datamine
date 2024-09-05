// Decompiled with JetBrains decompiler
// Type: Network.API.APIMissionData_linkRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D6F")]
  [Serializable]
  public class APIMissionData_linkRequest
  {
    [Token(Token = "0x4007DC6")]
    [FieldOffset(Offset = "0x10")]
    public int data_link_type_id;

    [Token(Token = "0x600ADBD")]
    [Address(RVA = "0x1A4AA6C", Offset = "0x1A4AA6C", VA = "0x1A4AA6C")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600ADBE")]
    [Address(RVA = "0x1A4AAB4", Offset = "0x1A4AAB4", VA = "0x1A4AAB4")]
    public APIMissionData_linkRequest()
    {
    }
  }
}
