// Decompiled with JetBrains decompiler
// Type: Network.API.APIHomeHot_dealResponse
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
  [Token(Token = "0x2001D30")]
  [Serializable]
  public class APIHomeHot_dealResponse : ICommonApiResult
  {
    [Token(Token = "0x4007CB3")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4007CB4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<HotDealInfoType> hot_deal_info_array;

    [Token(Token = "0x17002175")]
    public NoticeData Notice
    {
      [Token(Token = "0x600AC1E"), Address(RVA = "0x1A45404", Offset = "0x1A45404", VA = "0x1A45404", Slot = "4")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x17002176")]
    public List<HotDealInfoType> HotDealInfoArray
    {
      [Token(Token = "0x600AC1F"), Address(RVA = "0x1A4540C", Offset = "0x1A4540C", VA = "0x1A4540C")] get
      {
        return (List<HotDealInfoType>) null;
      }
    }

    [Token(Token = "0x600AC20")]
    [Address(RVA = "0x1A45414", Offset = "0x1A45414", VA = "0x1A45414")]
    public APIHomeHot_dealResponse()
    {
    }
  }
}
