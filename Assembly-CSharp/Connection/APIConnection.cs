// Decompiled with JetBrains decompiler
// Type: Connection.APIConnection
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Connection
{
  [Token(Token = "0x20021C7")]
  public abstract class APIConnection
  {
    [Token(Token = "0x4008F12")]
    private const int SuccesCode = 0;

    [Token(Token = "0x600CE65")]
    public abstract void Connect();

    [Token(Token = "0x600CE66")]
    [Address(RVA = "0x4B63F84", Offset = "0x4B63F84", VA = "0x4B63F84")]
    protected void AssertionOnNetworkError()
    {
    }

    [Token(Token = "0x600CE67")]
    [Address(RVA = "0x4B63F88", Offset = "0x4B63F88", VA = "0x4B63F88")]
    protected void OnFinish(object obj, int resultCode)
    {
    }

    [Token(Token = "0x600CE68")]
    [Address(RVA = "0x4B64014", Offset = "0x4B64014", VA = "0x4B64014", Slot = "5")]
    protected virtual void OnSuccess(object obj)
    {
    }

    [Token(Token = "0x600CE69")]
    [Address(RVA = "0x4B64018", Offset = "0x4B64018", VA = "0x4B64018", Slot = "6")]
    protected virtual void OnFailure(object obj)
    {
    }

    [Token(Token = "0x600CE6A")]
    [Address(RVA = "0x4B6401C", Offset = "0x4B6401C", VA = "0x4B6401C")]
    protected APIConnection()
    {
    }
  }
}
