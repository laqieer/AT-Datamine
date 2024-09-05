// Decompiled with JetBrains decompiler
// Type: Network.API.APIFriendApplyRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C53")]
  [Serializable]
  public class APIFriendApplyRequest
  {
    [Token(Token = "0x400795B")]
    [FieldOffset(Offset = "0x10")]
    public string target_player_id;

    [Token(Token = "0x600A6D1")]
    [Address(RVA = "0x190C148", Offset = "0x190C148", VA = "0x190C148")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A6D2")]
    [Address(RVA = "0x190C190", Offset = "0x190C190", VA = "0x190C190")]
    public APIFriendApplyRequest()
    {
    }
  }
}
