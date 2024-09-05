// Decompiled with JetBrains decompiler
// Type: Network.APIDascIDPasswordAddDeviceRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network
{
  [Token(Token = "0x20019D0")]
  [Serializable]
  public class APIDascIDPasswordAddDeviceRequest
  {
    [Token(Token = "0x4006EBF")]
    [FieldOffset(Offset = "0x10")]
    public string secret_key;
    [Token(Token = "0x4006EC0")]
    [FieldOffset(Offset = "0x18")]
    public APIDascIDPasswordConnectInfo connect_info;

    [Token(Token = "0x6009377")]
    [Address(RVA = "0x4D119F0", Offset = "0x4D119F0", VA = "0x4D119F0")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x6009378")]
    [Address(RVA = "0x4D11A38", Offset = "0x4D11A38", VA = "0x4D11A38")]
    public APIDascIDPasswordAddDeviceRequest()
    {
    }
  }
}
