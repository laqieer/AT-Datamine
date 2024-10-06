// Decompiled with JetBrains decompiler
// Type: DataLinkage.IDPassword.IDPasswordData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace DataLinkage.IDPassword
{
  [Token(Token = "0x2001FA6")]
  public class IDPasswordData
  {
    [Token(Token = "0x4008745")]
    public const int MaxPasswordLength = 12;
    [Token(Token = "0x4008746")]
    public const int MinPasswordLength = 8;

    [Token(Token = "0x170026E8")]
    public string Id
    {
      [Token(Token = "0x600BBE2"), Address(RVA = "0x1E4FE94", Offset = "0x1E4FE94", VA = "0x1E4FE94")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600BBE3"), Address(RVA = "0x1E4FE9C", Offset = "0x1E4FE9C", VA = "0x1E4FE9C")] private set
      {
      }
    }

    [Token(Token = "0x170026E9")]
    public string Password
    {
      [Token(Token = "0x600BBE4"), Address(RVA = "0x1E4FEA4", Offset = "0x1E4FEA4", VA = "0x1E4FEA4")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600BBE5"), Address(RVA = "0x1E4FEAC", Offset = "0x1E4FEAC", VA = "0x1E4FEAC")] private set
      {
      }
    }

    [Token(Token = "0x170026EA")]
    public bool IsValidId
    {
      [Token(Token = "0x600BBE6"), Address(RVA = "0x1E4FEB4", Offset = "0x1E4FEB4", VA = "0x1E4FEB4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600BBE7"), Address(RVA = "0x1E4FEBC", Offset = "0x1E4FEBC", VA = "0x1E4FEBC")] private set
      {
      }
    }

    [Token(Token = "0x170026EB")]
    public bool IsValidPassword
    {
      [Token(Token = "0x600BBE8"), Address(RVA = "0x1E4FEC8", Offset = "0x1E4FEC8", VA = "0x1E4FEC8")] get
      {
        return new bool();
      }
      [Token(Token = "0x600BBE9"), Address(RVA = "0x1E4FED0", Offset = "0x1E4FED0", VA = "0x1E4FED0")] private set
      {
      }
    }

    [Token(Token = "0x170026EC")]
    public bool IsValid
    {
      [Token(Token = "0x600BBEA"), Address(RVA = "0x1E4DEA4", Offset = "0x1E4DEA4", VA = "0x1E4DEA4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600BBEB")]
    [Address(RVA = "0x1E4DE50", Offset = "0x1E4DE50", VA = "0x1E4DE50")]
    public IDPasswordData(string id, string password)
    {
    }

    [Token(Token = "0x600BBEC")]
    [Address(RVA = "0x1E4FEDC", Offset = "0x1E4FEDC", VA = "0x1E4FEDC")]
    private bool VerifyIdValid(string id) => new bool();

    [Token(Token = "0x600BBED")]
    [Address(RVA = "0x1E4FEFC", Offset = "0x1E4FEFC", VA = "0x1E4FEFC")]
    private bool VerifyPasswordValid(string password) => new bool();
  }
}
