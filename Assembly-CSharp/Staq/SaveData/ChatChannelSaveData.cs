// Decompiled with JetBrains decompiler
// Type: staq.SaveData.ChatChannelSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace staq.SaveData
{
  [Token(Token = "0x2003CFF")]
  public class ChatChannelSaveData
  {
    [Token(Token = "0x4010C8F")]
    [FieldOffset(Offset = "0x10")]
    public int simpleChatChannel;
    [Token(Token = "0x4010C90")]
    [FieldOffset(Offset = "0x14")]
    public int chatDialogChannel;

    [Token(Token = "0x1700501B")]
    public static string Path
    {
      [Token(Token = "0x6018843"), Address(RVA = "0x293C284", Offset = "0x293C284", VA = "0x293C284")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6018844")]
    [Address(RVA = "0x293C2F4", Offset = "0x293C2F4", VA = "0x293C2F4")]
    public void Delete()
    {
    }

    [Token(Token = "0x6018845")]
    [Address(RVA = "0x293C314", Offset = "0x293C314", VA = "0x293C314")]
    public void Load()
    {
    }

    [Token(Token = "0x6018846")]
    [Address(RVA = "0x293C3BC", Offset = "0x293C3BC", VA = "0x293C3BC")]
    public void Read(byte[] buf)
    {
    }

    [Token(Token = "0x6018847")]
    [Address(RVA = "0x293C5E8", Offset = "0x293C5E8", VA = "0x293C5E8")]
    public void SetSimpleChatChannel(int channel)
    {
    }

    [Token(Token = "0x6018848")]
    [Address(RVA = "0x293C5F0", Offset = "0x293C5F0", VA = "0x293C5F0")]
    public void SetChatDialogChannel(int channel)
    {
    }

    [Token(Token = "0x6018849")]
    [Address(RVA = "0x293C5F8", Offset = "0x293C5F8", VA = "0x293C5F8")]
    public void Save()
    {
    }

    [Token(Token = "0x601884A")]
    [Address(RVA = "0x293C6C0", Offset = "0x293C6C0", VA = "0x293C6C0")]
    public ChatChannelSaveData()
    {
    }
  }
}
