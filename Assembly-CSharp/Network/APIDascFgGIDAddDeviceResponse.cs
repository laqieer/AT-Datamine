// Decompiled with JetBrains decompiler
// Type: Network.APIDascFgGIDAddDeviceResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network
{
  [Token(Token = "0x20019BE")]
  [Serializable]
  public class APIDascFgGIDAddDeviceResponse
  {
    [Token(Token = "0x4006E8A")]
    [FieldOffset(Offset = "0x10")]
    public string device_id;
    [Token(Token = "0x4006E8B")]
    [FieldOffset(Offset = "0x18")]
    public string player_id;

    [Token(Token = "0x6009325")]
    [Address(RVA = "0x4D10794", Offset = "0x4D10794", VA = "0x4D10794")]
    public APIDascFgGIDAddDeviceResponse()
    {
    }
  }
}
