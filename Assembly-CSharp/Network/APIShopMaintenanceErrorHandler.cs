// Decompiled with JetBrains decompiler
// Type: Network.APIShopMaintenanceErrorHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace Network
{
  [Token(Token = "0x2001A2C")]
  public class APIShopMaintenanceErrorHandler
  {
    [Token(Token = "0x4007007")]
    [FieldOffset(Offset = "0x10")]
    private readonly NetworkErrorEventListener _listener;

    [Token(Token = "0x6009559")]
    [Address(RVA = "0x48ED76C", Offset = "0x48ED76C", VA = "0x48ED76C")]
    public APIShopMaintenanceErrorHandler()
    {
    }

    [Token(Token = "0x600955A")]
    [Address(RVA = "0x48ED7D8", Offset = "0x48ED7D8", VA = "0x48ED7D8")]
    public IEnumerator HandleError(NetworkErrorResult networkErrorResult) => (IEnumerator) null;
  }
}
