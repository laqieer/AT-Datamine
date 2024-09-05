// Decompiled with JetBrains decompiler
// Type: Network.API.APIAdvertisementIronsourceStatusRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001B57")]
  [Serializable]
  public class APIAdvertisementIronsourceStatusRequest
  {
    [Token(Token = "0x4007537")]
    [FieldOffset(Offset = "0x10")]
    public int event_type_id;
    [Token(Token = "0x4007538")]
    [FieldOffset(Offset = "0x14")]
    public int target_id;

    [Token(Token = "0x600A08B")]
    [Address(RVA = "0x46C4CA0", Offset = "0x46C4CA0", VA = "0x46C4CA0")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A08C")]
    [Address(RVA = "0x46C4CE8", Offset = "0x46C4CE8", VA = "0x46C4CE8")]
    public APIAdvertisementIronsourceStatusRequest()
    {
    }
  }
}
