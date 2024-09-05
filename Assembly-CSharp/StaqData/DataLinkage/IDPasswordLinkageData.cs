// Decompiled with JetBrains decompiler
// Type: StaqData.DataLinkage.IDPasswordLinkageData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace StaqData.DataLinkage
{
  [Il2CppDummyDll.Token(Token = "0x20021BC")]
  public class IDPasswordLinkageData
  {
    [Il2CppDummyDll.Token(Token = "0x17002CF2")]
    public bool IsLinked
    {
      [Il2CppDummyDll.Token(Token = "0x600CE0A"), Address(RVA = "0x4B60C44", Offset = "0x4B60C44", VA = "0x4B60C44")] get
      {
        return new bool();
      }
      [Il2CppDummyDll.Token(Token = "0x600CE0B"), Address(RVA = "0x4B60C4C", Offset = "0x4B60C4C", VA = "0x4B60C4C")] private set
      {
      }
    }

    [Il2CppDummyDll.Token(Token = "0x17002CF3")]
    public string Token
    {
      [Il2CppDummyDll.Token(Token = "0x600CE0C"), Address(RVA = "0x4B60C58", Offset = "0x4B60C58", VA = "0x4B60C58")] get
      {
        return (string) null;
      }
      [Il2CppDummyDll.Token(Token = "0x600CE0D"), Address(RVA = "0x4B60C60", Offset = "0x4B60C60", VA = "0x4B60C60")] private set
      {
      }
    }

    [Il2CppDummyDll.Token(Token = "0x17002CF4")]
    public bool IsLogined
    {
      [Il2CppDummyDll.Token(Token = "0x600CE0E"), Address(RVA = "0x4B60C68", Offset = "0x4B60C68", VA = "0x4B60C68")] get
      {
        return new bool();
      }
    }

    [Il2CppDummyDll.Token(Token = "0x17002CF5")]
    public string UserID
    {
      [Il2CppDummyDll.Token(Token = "0x600CE0F"), Address(RVA = "0x4B60C88", Offset = "0x4B60C88", VA = "0x4B60C88")] get
      {
        return (string) null;
      }
      [Il2CppDummyDll.Token(Token = "0x600CE10"), Address(RVA = "0x4B60C90", Offset = "0x4B60C90", VA = "0x4B60C90")] private set
      {
      }
    }

    [Il2CppDummyDll.Token(Token = "0x17002CF6")]
    public string Password
    {
      [Il2CppDummyDll.Token(Token = "0x600CE11"), Address(RVA = "0x4B60C98", Offset = "0x4B60C98", VA = "0x4B60C98")] get
      {
        return (string) null;
      }
      [Il2CppDummyDll.Token(Token = "0x600CE12"), Address(RVA = "0x4B60CA0", Offset = "0x4B60CA0", VA = "0x4B60CA0")] private set
      {
      }
    }

    [Il2CppDummyDll.Token(Token = "0x600CE13")]
    [Address(RVA = "0x4B60AC0", Offset = "0x4B60AC0", VA = "0x4B60AC0")]
    public void OnDataLinkageChanged(bool isLinked)
    {
    }

    [Il2CppDummyDll.Token(Token = "0x600CE14")]
    [Address(RVA = "0x4B60CA8", Offset = "0x4B60CA8", VA = "0x4B60CA8")]
    public void OnTokenChanged(string token)
    {
    }

    [Il2CppDummyDll.Token(Token = "0x600CE15")]
    [Address(RVA = "0x4B60CB0", Offset = "0x4B60CB0", VA = "0x4B60CB0")]
    public void OnUserIDChanged(string userID)
    {
    }

    [Il2CppDummyDll.Token(Token = "0x600CE16")]
    [Address(RVA = "0x4B60CB8", Offset = "0x4B60CB8", VA = "0x4B60CB8")]
    public void OnPasswordChanged(string password)
    {
    }

    [Il2CppDummyDll.Token(Token = "0x600CE17")]
    [Address(RVA = "0x4B60B6C", Offset = "0x4B60B6C", VA = "0x4B60B6C")]
    public IDPasswordLinkageData()
    {
    }
  }
}
