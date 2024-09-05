// Decompiled with JetBrains decompiler
// Type: Network.API.APIAdvertisementProvide_ratioResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001B60")]
  [Serializable]
  public class APIAdvertisementProvide_ratioResponse
  {
    [Token(Token = "0x4007557")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<AdvertisementProvideRatioType> entities;

    [Token(Token = "0x17001D53")]
    public List<AdvertisementProvideRatioType> Entities
    {
      [Token(Token = "0x600A0BC"), Address(RVA = "0x46C57A0", Offset = "0x46C57A0", VA = "0x46C57A0")] get
      {
        return (List<AdvertisementProvideRatioType>) null;
      }
    }

    [Token(Token = "0x600A0BD")]
    [Address(RVA = "0x46C57A8", Offset = "0x46C57A8", VA = "0x46C57A8")]
    public APIAdvertisementProvide_ratioResponse()
    {
    }
  }
}
