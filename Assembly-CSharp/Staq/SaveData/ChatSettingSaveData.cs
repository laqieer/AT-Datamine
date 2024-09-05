// Decompiled with JetBrains decompiler
// Type: staq.SaveData.ChatSettingSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace staq.SaveData
{
  [Token(Token = "0x2003D06")]
  public class ChatSettingSaveData
  {
    [Token(Token = "0x4010C9F")]
    [FieldOffset(Offset = "0x10")]
    public bool simpleMessage;
    [Token(Token = "0x4010CA0")]
    [FieldOffset(Offset = "0x11")]
    public bool guildNewBadge;

    [Token(Token = "0x1700501E")]
    public static string Path
    {
      [Token(Token = "0x6018862"), Address(RVA = "0x293DB1C", Offset = "0x293DB1C", VA = "0x293DB1C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6018863")]
    [Address(RVA = "0x293DB8C", Offset = "0x293DB8C", VA = "0x293DB8C")]
    public void DeleteFile()
    {
    }

    [Token(Token = "0x6018864")]
    [Address(RVA = "0x293DBB8", Offset = "0x293DBB8", VA = "0x293DBB8")]
    public void Delete()
    {
    }

    [Token(Token = "0x6018865")]
    [Address(RVA = "0x293DBD0", Offset = "0x293DBD0", VA = "0x293DBD0")]
    public void Load()
    {
    }

    [Token(Token = "0x6018866")]
    [Address(RVA = "0x293DC88", Offset = "0x293DC88", VA = "0x293DC88")]
    public void Read(byte[] buf)
    {
    }

    [Token(Token = "0x6018867")]
    [Address(RVA = "0x293DE24", Offset = "0x293DE24", VA = "0x293DE24")]
    public void SetSimpleChatSetting(bool isSimple)
    {
    }

    [Token(Token = "0x6018868")]
    [Address(RVA = "0x293DE30", Offset = "0x293DE30", VA = "0x293DE30")]
    public void SetGuildNewBadge(bool isOn)
    {
    }

    [Token(Token = "0x6018869")]
    [Address(RVA = "0x293DE3C", Offset = "0x293DE3C", VA = "0x293DE3C")]
    public void Save()
    {
    }

    [Token(Token = "0x601886A")]
    [Address(RVA = "0x293DF04", Offset = "0x293DF04", VA = "0x293DF04")]
    public ChatSettingSaveData()
    {
    }
  }
}
