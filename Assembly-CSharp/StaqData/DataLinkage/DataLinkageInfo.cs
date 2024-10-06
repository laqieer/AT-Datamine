// Decompiled with JetBrains decompiler
// Type: StaqData.DataLinkage.DataLinkageInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network;

#nullable disable
namespace StaqData.DataLinkage
{
  [Token(Token = "0x20021B7")]
  public class DataLinkageInfo
  {
    [Token(Token = "0x4008EDC")]
    [FieldOffset(Offset = "0x10")]
    public FgGIDLinkageData FgGIDLinkageData;
    [Token(Token = "0x4008EDD")]
    [FieldOffset(Offset = "0x18")]
    public IDPasswordLinkageData IDPasswordLinkageData;

    [Token(Token = "0x17002CEC")]
    public bool IDPasswordLinked
    {
      [Token(Token = "0x600CDF7"), Address(RVA = "0x4B607FC", Offset = "0x4B607FC", VA = "0x4B607FC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002CED")]
    public bool FgGIDLinked
    {
      [Token(Token = "0x600CDF8"), Address(RVA = "0x4B6081C", Offset = "0x4B6081C", VA = "0x4B6081C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002CEE")]
    public bool IsInitialized
    {
      [Token(Token = "0x600CDF9"), Address(RVA = "0x4B6083C", Offset = "0x4B6083C", VA = "0x4B6083C")] get
      {
        return new bool();
      }
      [Token(Token = "0x600CDFA"), Address(RVA = "0x4B60844", Offset = "0x4B60844", VA = "0x4B60844")] private set
      {
      }
    }

    [Token(Token = "0x600CDFB")]
    [Address(RVA = "0x4B60850", Offset = "0x4B60850", VA = "0x4B60850")]
    public void Initialize(APIDasConnectListResponse response)
    {
    }

    [Token(Token = "0x600CDFC")]
    [Address(RVA = "0x4B6086C", Offset = "0x4B6086C", VA = "0x4B6086C")]
    public void Apply(APIDasConnectListResponse response)
    {
    }

    [Token(Token = "0x600CDFD")]
    [Address(RVA = "0x4B60ACC", Offset = "0x4B60ACC", VA = "0x4B60ACC")]
    public DataLinkageInfo()
    {
    }
  }
}
