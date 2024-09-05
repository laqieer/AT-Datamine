// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerChatHistoryPin
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A98")]
  [Serializable]
  public class PlayerChatHistoryPin
  {
    [Token(Token = "0x40071FF")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string id;
    [Token(Token = "0x4007200")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string content;
    [Token(Token = "0x4007201")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private int message_type_id;

    [Token(Token = "0x17001A4C")]
    public string Id
    {
      [Token(Token = "0x60099B0"), Address(RVA = "0x48F0C78", Offset = "0x48F0C78", VA = "0x48F0C78")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60099B1"), Address(RVA = "0x48F0C80", Offset = "0x48F0C80", VA = "0x48F0C80")] set
      {
      }
    }

    [Token(Token = "0x17001A4D")]
    public string Content
    {
      [Token(Token = "0x60099B2"), Address(RVA = "0x48F0C88", Offset = "0x48F0C88", VA = "0x48F0C88")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60099B3"), Address(RVA = "0x48F0C90", Offset = "0x48F0C90", VA = "0x48F0C90")] set
      {
      }
    }

    [Token(Token = "0x17001A4E")]
    public int MessageTypeId
    {
      [Token(Token = "0x60099B4"), Address(RVA = "0x48F0C98", Offset = "0x48F0C98", VA = "0x48F0C98")] get
      {
        return new int();
      }
      [Token(Token = "0x60099B5"), Address(RVA = "0x48F0CA0", Offset = "0x48F0CA0", VA = "0x48F0CA0")] set
      {
      }
    }

    [Token(Token = "0x60099B6")]
    [Address(RVA = "0x48F0CA8", Offset = "0x48F0CA8", VA = "0x48F0CA8")]
    public PlayerChatHistoryPin()
    {
    }
  }
}
