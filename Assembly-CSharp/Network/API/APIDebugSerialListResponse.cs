// Decompiled with JetBrains decompiler
// Type: Network.API.APIDebugSerialListResponse
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
  [Token(Token = "0x2001BF4")]
  [Serializable]
  public class APIDebugSerialListResponse
  {
    [Token(Token = "0x40077B1")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<DebugSerialInfoType> serial_info_list;

    [Token(Token = "0x17001E9E")]
    public List<DebugSerialInfoType> SerialInfoList
    {
      [Token(Token = "0x600A457"), Address(RVA = "0x46D1F04", Offset = "0x46D1F04", VA = "0x46D1F04")] get
      {
        return (List<DebugSerialInfoType>) null;
      }
    }

    [Token(Token = "0x600A458")]
    [Address(RVA = "0x46D1F0C", Offset = "0x46D1F0C", VA = "0x46D1F0C")]
    public APIDebugSerialListResponse()
    {
    }
  }
}
