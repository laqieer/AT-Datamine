// Decompiled with JetBrains decompiler
// Type: Network.API.APIAreaQuestDirectionResponse
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
  [Token(Token = "0x2001B7C")]
  [Serializable]
  public class APIAreaQuestDirectionResponse : ICommonApiResult
  {
    [Token(Token = "0x40075DF")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;

    [Token(Token = "0x17001D97")]
    public NoticeData Notice
    {
      [Token(Token = "0x600A170"), Address(RVA = "0x46C7D84", Offset = "0x46C7D84", VA = "0x46C7D84", Slot = "4")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x600A171")]
    [Address(RVA = "0x46C7D8C", Offset = "0x46C7D8C", VA = "0x46C7D8C")]
    public APIAreaQuestDirectionResponse()
    {
    }
  }
}
