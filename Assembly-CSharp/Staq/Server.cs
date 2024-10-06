// Decompiled with JetBrains decompiler
// Type: staq.Server
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace staq
{
  [Token(Token = "0x2003C4B")]
  public class Server
  {
    [Token(Token = "0x4010B91")]
    [FieldOffset(Offset = "0x10")]
    public string Name;
    [Token(Token = "0x4010B92")]
    [FieldOffset(Offset = "0x18")]
    protected string host;

    [Token(Token = "0x17004D34")]
    public virtual string DomainHost
    {
      [Token(Token = "0x6017B50"), Address(RVA = "0x37B1EAC", Offset = "0x37B1EAC", VA = "0x37B1EAC", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17004D35")]
    public virtual string Host
    {
      [Token(Token = "0x6017B51"), Address(RVA = "0x37B1EB4", Offset = "0x37B1EB4", VA = "0x37B1EB4", Slot = "5")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6017B52")]
    [Address(RVA = "0x37B1EBC", Offset = "0x37B1EBC", VA = "0x37B1EBC")]
    public Server(string name, string input)
    {
    }

    [Token(Token = "0x17004D36")]
    public virtual string Scheme
    {
      [Token(Token = "0x6017B53"), Address(RVA = "0x37B1EE8", Offset = "0x37B1EE8", VA = "0x37B1EE8", Slot = "6")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17004D37")]
    public virtual string RootUrl
    {
      [Token(Token = "0x6017B54"), Address(RVA = "0x37B1F28", Offset = "0x37B1F28", VA = "0x37B1F28", Slot = "7")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17004D38")]
    public virtual bool DirectDLC
    {
      [Token(Token = "0x6017B55"), Address(RVA = "0x37B1FBC", Offset = "0x37B1FBC", VA = "0x37B1FBC", Slot = "8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004D39")]
    public virtual string DirectDLCUrl
    {
      [Token(Token = "0x6017B56"), Address(RVA = "0x37B1FC4", Offset = "0x37B1FC4", VA = "0x37B1FC4", Slot = "9")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6017B57")]
    [Address(RVA = "0x37B1FD0", Offset = "0x37B1FD0", VA = "0x37B1FD0")]
    public string GetAPIUrl(string apiPath) => (string) null;

    [Token(Token = "0x6017B58")]
    [Address(RVA = "0x37B1FF8", Offset = "0x37B1FF8", VA = "0x37B1FF8", Slot = "10")]
    public virtual string GetInformation() => (string) null;
  }
}
