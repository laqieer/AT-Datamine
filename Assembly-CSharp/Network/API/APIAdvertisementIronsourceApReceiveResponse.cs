// Decompiled with JetBrains decompiler
// Type: Network.API.APIAdvertisementIronsourceApReceiveResponse
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
  [Token(Token = "0x2001B50")]
  [Serializable]
  public class APIAdvertisementIronsourceApReceiveResponse
  {
    [Token(Token = "0x400751F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<RewardGiveResultEntityType> result;

    [Token(Token = "0x17001D36")]
    public List<RewardGiveResultEntityType> Result
    {
      [Token(Token = "0x600A05F"), Address(RVA = "0x46C4248", Offset = "0x46C4248", VA = "0x46C4248")] get
      {
        return (List<RewardGiveResultEntityType>) null;
      }
    }

    [Token(Token = "0x600A060")]
    [Address(RVA = "0x46C4250", Offset = "0x46C4250", VA = "0x46C4250")]
    public APIAdvertisementIronsourceApReceiveResponse()
    {
    }
  }
}
