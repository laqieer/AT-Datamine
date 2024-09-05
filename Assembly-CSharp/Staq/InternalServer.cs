// Decompiled with JetBrains decompiler
// Type: staq.InternalServer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace staq
{
  [Token(Token = "0x2003C4D")]
  public class InternalServer : Server
  {
    [Token(Token = "0x4010B93")]
    [FieldOffset(Offset = "0x20")]
    private string PublicHost;
    [Token(Token = "0x4010B94")]
    [FieldOffset(Offset = "0x28")]
    private string PrivateHost;

    [Token(Token = "0x17004D3C")]
    public override string DomainHost
    {
      [Token(Token = "0x6017B5C"), Address(RVA = "0x37B2390", Offset = "0x37B2390", VA = "0x37B2390", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17004D3D")]
    public override string Host
    {
      [Token(Token = "0x6017B5D"), Address(RVA = "0x37B2398", Offset = "0x37B2398", VA = "0x37B2398", Slot = "5")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6017B5E")]
    [Address(RVA = "0x37B23A0", Offset = "0x37B23A0", VA = "0x37B23A0")]
    private void ParseHost(string host)
    {
    }

    [Token(Token = "0x6017B5F")]
    [Address(RVA = "0x37B2490", Offset = "0x37B2490", VA = "0x37B2490")]
    public InternalServer(string name, string host)
    {
    }

    [Token(Token = "0x6017B60")]
    [Address(RVA = "0x37B24C4", Offset = "0x37B24C4", VA = "0x37B24C4", Slot = "10")]
    public override string GetInformation() => (string) null;
  }
}
