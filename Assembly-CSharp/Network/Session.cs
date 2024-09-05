// Decompiled with JetBrains decompiler
// Type: Network.Session
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Network
{
  [Token(Token = "0x2001A06")]
  internal struct Session
  {
    [Token(Token = "0x17001813")]
    public static Session Empty
    {
      [Token(Token = "0x600946A"), Address(RVA = "0x4D15FF4", Offset = "0x4D15FF4", VA = "0x4D15FF4")] get
      {
        return new Session();
      }
    }

    [Token(Token = "0x17001814")]
    public string AccessToken
    {
      [Token(Token = "0x600946B"), Address(RVA = "0x4D16000", Offset = "0x4D16000", VA = "0x4D16000")] readonly get
      {
        return (string) null;
      }
      [Token(Token = "0x600946C"), Address(RVA = "0x4D16008", Offset = "0x4D16008", VA = "0x4D16008")] private set
      {
      }
    }

    [Token(Token = "0x17001815")]
    public float ExpiresIn
    {
      [Token(Token = "0x600946D"), Address(RVA = "0x4D16010", Offset = "0x4D16010", VA = "0x4D16010")] readonly get
      {
        return new float();
      }
      [Token(Token = "0x600946E"), Address(RVA = "0x4D16018", Offset = "0x4D16018", VA = "0x4D16018")] private set
      {
      }
    }

    [Token(Token = "0x17001816")]
    public float CreatedTime
    {
      [Token(Token = "0x600946F"), Address(RVA = "0x4D16020", Offset = "0x4D16020", VA = "0x4D16020")] readonly get
      {
        return new float();
      }
      [Token(Token = "0x6009470"), Address(RVA = "0x4D16028", Offset = "0x4D16028", VA = "0x4D16028")] private set
      {
      }
    }

    [Token(Token = "0x17001817")]
    public bool IsEmpty
    {
      [Token(Token = "0x6009471"), Address(RVA = "0x4D16030", Offset = "0x4D16030", VA = "0x4D16030")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001818")]
    public bool IsValid
    {
      [Token(Token = "0x6009472"), Address(RVA = "0x4D1603C", Offset = "0x4D1603C", VA = "0x4D1603C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001819")]
    public bool IsInvalid
    {
      [Token(Token = "0x6009473"), Address(RVA = "0x4D160BC", Offset = "0x4D160BC", VA = "0x4D160BC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700181A")]
    public bool IsExpired
    {
      [Token(Token = "0x6009474"), Address(RVA = "0x4D16088", Offset = "0x4D16088", VA = "0x4D16088")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6009475")]
    [Address(RVA = "0x4D160D4", Offset = "0x4D160D4", VA = "0x4D160D4")]
    public Session(string accessToken, float expiresIn)
    {
    }
  }
}
