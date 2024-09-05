// Decompiled with JetBrains decompiler
// Type: staq.SaveData.ChatSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using staq.SaveSchema;
using System.Collections.Generic;

#nullable disable
namespace staq.SaveData
{
  [Token(Token = "0x2003D01")]
  public class ChatSaveData
  {
    [Token(Token = "0x4010C93")]
    [FieldOffset(Offset = "0x10")]
    public List<ChatSaveData.ChatSaveLog> chatLogList;

    [Token(Token = "0x1700501D")]
    public static string Path
    {
      [Token(Token = "0x6018852"), Address(RVA = "0x293CAA4", Offset = "0x293CAA4", VA = "0x293CAA4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6018853")]
    [Address(RVA = "0x293CB14", Offset = "0x293CB14", VA = "0x293CB14")]
    public void Delete()
    {
    }

    [Token(Token = "0x6018854")]
    [Address(RVA = "0x293CB34", Offset = "0x293CB34", VA = "0x293CB34")]
    public void Load()
    {
    }

    [Token(Token = "0x6018855")]
    [Address(RVA = "0x293CBE8", Offset = "0x293CBE8", VA = "0x293CBE8")]
    public void Read(byte[] buf)
    {
    }

    [Token(Token = "0x6018856")]
    [Address(RVA = "0x293D128", Offset = "0x293D128", VA = "0x293D128")]
    public void Add(string content, int msgType, string msgID)
    {
    }

    [Token(Token = "0x6018857")]
    [Address(RVA = "0x293D57C", Offset = "0x293D57C", VA = "0x293D57C")]
    public void Save()
    {
    }

    [Token(Token = "0x6018858")]
    [Address(RVA = "0x293D874", Offset = "0x293D874", VA = "0x293D874")]
    private Offset<Log> Serialize(FlatBufferBuilder fbb, ChatSaveData.ChatSaveLog item)
    {
      return new Offset<Log>();
    }

    [Token(Token = "0x6018859")]
    [Address(RVA = "0x293D8E0", Offset = "0x293D8E0", VA = "0x293D8E0")]
    public ChatSaveData()
    {
    }

    [Token(Token = "0x2003D02")]
    public class ChatSaveLog
    {
      [Token(Token = "0x4010C94")]
      [FieldOffset(Offset = "0x10")]
      public string content;
      [Token(Token = "0x4010C95")]
      [FieldOffset(Offset = "0x18")]
      public int typeID;
      [Token(Token = "0x4010C96")]
      [FieldOffset(Offset = "0x20")]
      public string messageID;
      [Token(Token = "0x4010C97")]
      [FieldOffset(Offset = "0x28")]
      public bool isLocking;

      [Token(Token = "0x601885A")]
      [Address(RVA = "0x293D0A0", Offset = "0x293D0A0", VA = "0x293D0A0")]
      public ChatSaveLog(string content, int typeID, string msgID, bool islock)
      {
      }
    }
  }
}
