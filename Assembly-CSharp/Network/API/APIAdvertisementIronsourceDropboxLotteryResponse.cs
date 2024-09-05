// Decompiled with JetBrains decompiler
// Type: Network.API.APIAdvertisementIronsourceDropboxLotteryResponse
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
  [Token(Token = "0x2001B54")]
  [Serializable]
  public class APIAdvertisementIronsourceDropboxLotteryResponse
  {
    [Token(Token = "0x400752B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<RewardGiveResultEntityType> result;

    [Token(Token = "0x17001D3D")]
    public List<RewardGiveResultEntityType> Result
    {
      [Token(Token = "0x600A076"), Address(RVA = "0x46C479C", Offset = "0x46C479C", VA = "0x46C479C")] get
      {
        return (List<RewardGiveResultEntityType>) null;
      }
    }

    [Token(Token = "0x600A077")]
    [Address(RVA = "0x46C47A4", Offset = "0x46C47A4", VA = "0x46C47A4")]
    public APIAdvertisementIronsourceDropboxLotteryResponse()
    {
    }
  }
}
