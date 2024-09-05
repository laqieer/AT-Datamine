// Decompiled with JetBrains decompiler
// Type: staq.ExternalServer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace staq
{
  [Token(Token = "0x2003C4C")]
  public class ExternalServer : Server
  {
    [Token(Token = "0x6017B59")]
    [Address(RVA = "0x37B231C", Offset = "0x37B231C", VA = "0x37B231C")]
    public ExternalServer(string name, string inputHost)
    {
    }

    [Token(Token = "0x17004D3A")]
    public override string Scheme
    {
      [Token(Token = "0x6017B5A"), Address(RVA = "0x37B2348", Offset = "0x37B2348", VA = "0x37B2348", Slot = "6")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17004D3B")]
    public override bool DirectDLC
    {
      [Token(Token = "0x6017B5B"), Address(RVA = "0x37B2388", Offset = "0x37B2388", VA = "0x37B2388", Slot = "8")] get
      {
        return new bool();
      }
    }
  }
}
