// Decompiled with JetBrains decompiler
// Type: KPI.StandardKPI.StandardKPILogParamBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace KPI.StandardKPI
{
  [Token(Token = "0x2000A71")]
  public abstract class StandardKPILogParamBase : IStandardKPILogParam
  {
    [Token(Token = "0x4003062")]
    [FieldOffset(Offset = "0x10")]
    public StandardKPIRequiredParam standardkpi;
    [Token(Token = "0x4003063")]
    [FieldOffset(Offset = "0x18")]
    public StandardKPIHeaderParam header;

    [Token(Token = "0x17000874")]
    public abstract string LogFormatType { [Token(Token = "0x6003B46")] get; }

    [Token(Token = "0x6003B47")]
    [Address(RVA = "0x331C80C", Offset = "0x331C80C", VA = "0x331C80C")]
    protected StandardKPILogParamBase()
    {
    }
  }
}
