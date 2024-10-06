// Decompiled with JetBrains decompiler
// Type: Connection.ConnectionPlayerProfile
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.API;
using System;

#nullable disable
namespace Connection
{
  [Token(Token = "0x20021C8")]
  public class ConnectionPlayerProfile : APIConnection
  {
    [Token(Token = "0x4008F13")]
    [FieldOffset(Offset = "0x10")]
    private APIPlayerProfileRequest request;
    [Token(Token = "0x4008F14")]
    [FieldOffset(Offset = "0x18")]
    public Action finishAction;
    [Token(Token = "0x4008F15")]
    [FieldOffset(Offset = "0x20")]
    private ConnectionPlayerProfile.IConnectionEvent connection;

    [Token(Token = "0x600CE6B")]
    [Address(RVA = "0x4B64024", Offset = "0x4B64024", VA = "0x4B64024")]
    public void Register(
      ConnectionPlayerProfile.IConnectionEvent connection)
    {
    }

    [Token(Token = "0x600CE6C")]
    [Address(RVA = "0x4B6402C", Offset = "0x4B6402C", VA = "0x4B6402C", Slot = "4")]
    public override void Connect()
    {
    }

    [Token(Token = "0x600CE6D")]
    [Address(RVA = "0x4B64620", Offset = "0x4B64620", VA = "0x4B64620")]
    private bool OnStart(object obj) => new bool();

    [Token(Token = "0x600CE6E")]
    [Address(RVA = "0x4B64628", Offset = "0x4B64628", VA = "0x4B64628")]
    private void OnFinish(object obj)
    {
    }

    [Token(Token = "0x600CE6F")]
    [Address(RVA = "0x4B6472C", Offset = "0x4B6472C", VA = "0x4B6472C")]
    public void Replace(APIPlayerProfile api)
    {
    }

    [Token(Token = "0x600CE70")]
    [Address(RVA = "0x4B647C0", Offset = "0x4B647C0", VA = "0x4B647C0")]
    public ConnectionPlayerProfile()
    {
    }

    [Token(Token = "0x20021C9")]
    public interface IConnectionEvent
    {
      [Token(Token = "0x600CE72")]
      void OnFinish(APIPlayerProfile api);
    }
  }
}
