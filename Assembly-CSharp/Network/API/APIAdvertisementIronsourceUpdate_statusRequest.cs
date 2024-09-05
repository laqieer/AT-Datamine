// Decompiled with JetBrains decompiler
// Type: Network.API.APIAdvertisementIronsourceUpdate_statusRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001B5B")]
  [Serializable]
  public class APIAdvertisementIronsourceUpdate_statusRequest
  {
    [Token(Token = "0x4007545")]
    [FieldOffset(Offset = "0x10")]
    public string advertisement_id;
    [Token(Token = "0x4007546")]
    [FieldOffset(Offset = "0x18")]
    public int event_type_id;
    [Token(Token = "0x4007547")]
    [FieldOffset(Offset = "0x1C")]
    public int ad_status;
    [Token(Token = "0x4007548")]
    [FieldOffset(Offset = "0x20")]
    public int target_id;

    [Token(Token = "0x600A0A2")]
    [Address(RVA = "0x46C51F4", Offset = "0x46C51F4", VA = "0x46C51F4")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A0A3")]
    [Address(RVA = "0x46C523C", Offset = "0x46C523C", VA = "0x46C523C")]
    public APIAdvertisementIronsourceUpdate_statusRequest()
    {
    }
  }
}
