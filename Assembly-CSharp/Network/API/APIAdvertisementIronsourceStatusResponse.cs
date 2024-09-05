// Decompiled with JetBrains decompiler
// Type: Network.API.APIAdvertisementIronsourceStatusResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System;
using UnityEngine;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001B58")]
  [Serializable]
  public class APIAdvertisementIronsourceStatusResponse
  {
    [Token(Token = "0x4007539")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private PlayerAdvertisementType player_advertisement;

    [Token(Token = "0x17001D44")]
    public PlayerAdvertisementType PlayerAdvertisement
    {
      [Token(Token = "0x600A08D"), Address(RVA = "0x46C4CF0", Offset = "0x46C4CF0", VA = "0x46C4CF0")] get
      {
        return (PlayerAdvertisementType) null;
      }
    }

    [Token(Token = "0x600A08E")]
    [Address(RVA = "0x46C4CF8", Offset = "0x46C4CF8", VA = "0x46C4CF8")]
    public APIAdvertisementIronsourceStatusResponse()
    {
    }
  }
}
