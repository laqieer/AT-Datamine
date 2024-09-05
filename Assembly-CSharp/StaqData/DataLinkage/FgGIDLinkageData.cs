// Decompiled with JetBrains decompiler
// Type: StaqData.DataLinkage.FgGIDLinkageData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace StaqData.DataLinkage
{
  [Il2CppDummyDll.Token(Token = "0x20021BB")]
  public class FgGIDLinkageData
  {
    [Il2CppDummyDll.Token(Token = "0x17002CEF")]
    public bool IsLinked
    {
      [Il2CppDummyDll.Token(Token = "0x600CE02"), Address(RVA = "0x4B60BF8", Offset = "0x4B60BF8", VA = "0x4B60BF8")] get
      {
        return new bool();
      }
      [Il2CppDummyDll.Token(Token = "0x600CE03"), Address(RVA = "0x4B60C00", Offset = "0x4B60C00", VA = "0x4B60C00")] private set
      {
      }
    }

    [Il2CppDummyDll.Token(Token = "0x17002CF0")]
    public string Token
    {
      [Il2CppDummyDll.Token(Token = "0x600CE04"), Address(RVA = "0x4B60C0C", Offset = "0x4B60C0C", VA = "0x4B60C0C")] get
      {
        return (string) null;
      }
      [Il2CppDummyDll.Token(Token = "0x600CE05"), Address(RVA = "0x4B60C14", Offset = "0x4B60C14", VA = "0x4B60C14")] private set
      {
      }
    }

    [Il2CppDummyDll.Token(Token = "0x17002CF1")]
    public bool IsLogined
    {
      [Il2CppDummyDll.Token(Token = "0x600CE06"), Address(RVA = "0x4B60C1C", Offset = "0x4B60C1C", VA = "0x4B60C1C")] get
      {
        return new bool();
      }
    }

    [Il2CppDummyDll.Token(Token = "0x600CE07")]
    [Address(RVA = "0x4B60AB4", Offset = "0x4B60AB4", VA = "0x4B60AB4")]
    public void OnDataLinkageChanged(bool isLinked)
    {
    }

    [Il2CppDummyDll.Token(Token = "0x600CE08")]
    [Address(RVA = "0x4B60C3C", Offset = "0x4B60C3C", VA = "0x4B60C3C")]
    public void OnTokenChanged(string token)
    {
    }

    [Il2CppDummyDll.Token(Token = "0x600CE09")]
    [Address(RVA = "0x4B60B64", Offset = "0x4B60B64", VA = "0x4B60B64")]
    public FgGIDLinkageData()
    {
    }
  }
}
