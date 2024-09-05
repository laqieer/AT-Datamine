// Decompiled with JetBrains decompiler
// Type: Network.API.APIAdvertisementIronsourceUpdate_statusResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001B5C")]
  [Serializable]
  public class APIAdvertisementIronsourceUpdate_statusResponse
  {
    [Token(Token = "0x4007549")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string advertisement_id;
    [Token(Token = "0x400754A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int ad_status;

    [Token(Token = "0x17001D4B")]
    public string AdvertisementId
    {
      [Token(Token = "0x600A0A4"), Address(RVA = "0x46C5244", Offset = "0x46C5244", VA = "0x46C5244")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001D4C")]
    public int AdStatus
    {
      [Token(Token = "0x600A0A5"), Address(RVA = "0x46C524C", Offset = "0x46C524C", VA = "0x46C524C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600A0A6")]
    [Address(RVA = "0x46C5254", Offset = "0x46C5254", VA = "0x46C5254")]
    public APIAdvertisementIronsourceUpdate_statusResponse()
    {
    }
  }
}
