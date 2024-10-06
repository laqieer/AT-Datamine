// Decompiled with JetBrains decompiler
// Type: ChatApiManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DesignPattern;
using Il2CppDummyDll;
using Network;
using System;
using System.Collections;

#nullable disable
[Token(Token = "0x2000251")]
public class ChatApiManager : Singleton<ChatApiManager>
{
  [Token(Token = "0x6000EA5")]
  [Address(RVA = "0x1C90B28", Offset = "0x1C90B28", VA = "0x1C90B28")]
  public IEnumerator RequestChatLogList(int roomID, string latestMsgID) => (IEnumerator) null;

  [Token(Token = "0x6000EA6")]
  [Address(RVA = "0x1C90BD0", Offset = "0x1C90BD0", VA = "0x1C90BD0")]
  public IEnumerator SendChatMessage(int roomID, string content, string latestMsgID, int msgType)
  {
    return (IEnumerator) null;
  }

  [Token(Token = "0x6000EA7")]
  [Address(RVA = "0x1C90C8C", Offset = "0x1C90C8C", VA = "0x1C90C8C")]
  private IEnumerator OnError(NetworkErrorResult networkErrorResult) => (IEnumerator) null;

  [Token(Token = "0x6000EA8")]
  [Address(RVA = "0x1C90D1C", Offset = "0x1C90D1C", VA = "0x1C90D1C")]
  public ChatApiManager()
  {
  }

  [Token(Token = "0x2000252")]
  [Serializable]
  private class ChatErrorMessage
  {
    [Token(Token = "0x4000DCF")]
    [FieldOffset(Offset = "0x10")]
    public string error_code;
    [Token(Token = "0x4000DD0")]
    [FieldOffset(Offset = "0x18")]
    public ChatApiManager.ChatErrorMessageJson extra;

    [Token(Token = "0x6000EA9")]
    [Address(RVA = "0x1C90D64", Offset = "0x1C90D64", VA = "0x1C90D64")]
    public ChatErrorMessage()
    {
    }
  }

  [Token(Token = "0x2000253")]
  [Serializable]
  private class ChatErrorMessageJson
  {
    [Token(Token = "0x4000DD1")]
    [FieldOffset(Offset = "0x10")]
    public string code;

    [Token(Token = "0x6000EAA")]
    [Address(RVA = "0x1C90D6C", Offset = "0x1C90D6C", VA = "0x1C90D6C")]
    public ChatErrorMessageJson()
    {
    }
  }

  [Token(Token = "0x2000254")]
  private enum ChatErrorType
  {
    [Token(Token = "0x4000DD3")] DEFAULT = 0,
    [Token(Token = "0x4000DD4")] NG_WORD = 100, // 0x00000064
    [Token(Token = "0x4000DD5")] BANNED = 101, // 0x00000065
    [Token(Token = "0x4000DD6")] IN_THROTTLE = 102, // 0x00000066
    [Token(Token = "0x4000DD7")] TOO_LONG = 103, // 0x00000067
    [Token(Token = "0x4000DD8")] INVALID_MESSAGE_TYPE = 104, // 0x00000068
    [Token(Token = "0x4000DD9")] INVALID_STAMP = 105, // 0x00000069
    [Token(Token = "0x4000DDA")] NEED_RETRY = 200, // 0x000000C8
    [Token(Token = "0x4000DDB")] ALREADY_REPORTED = 300, // 0x0000012C
    [Token(Token = "0x4000DDC")] CANNOT_REPORT = 301, // 0x0000012D
  }
}
