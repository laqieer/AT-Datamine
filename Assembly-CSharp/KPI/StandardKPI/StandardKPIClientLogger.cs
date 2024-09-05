// Decompiled with JetBrains decompiler
// Type: KPI.StandardKPI.StandardKPIClientLogger
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using LogModule.Logger.ClientLogs;

#nullable disable
namespace KPI.StandardKPI
{
  [Token(Token = "0x2000A67")]
  public class StandardKPIClientLogger : ClientLogsLogger
  {
    [Token(Token = "0x400304A")]
    [FieldOffset(Offset = "0x0")]
    protected static StandardKPIClientLogger instance;
    [Token(Token = "0x400304B")]
    private const string KEY = "stdkpi";
    [Token(Token = "0x400304C")]
    private const string URL = "https://production-clientlogs-bq.astr.gu3.jp";

    [Token(Token = "0x6003B36")]
    [Address(RVA = "0x331C434", Offset = "0x331C434", VA = "0x331C434")]
    public new void Info(string tag, string message)
    {
    }

    [Token(Token = "0x1700086F")]
    public static StandardKPIClientLogger Instance
    {
      [Token(Token = "0x6003B37"), Address(RVA = "0x331C474", Offset = "0x331C474", VA = "0x331C474")] get
      {
        return (StandardKPIClientLogger) null;
      }
    }

    [Token(Token = "0x6003B38")]
    [Address(RVA = "0x331C4F4", Offset = "0x331C4F4", VA = "0x331C4F4")]
    public StandardKPIClientLogger(int bufferSize = 1)
    {
    }

    [Token(Token = "0x6003B39")]
    public void SendLog<T>(StandardKPILogParam<T> param) where T : IStandardKPILogBodyParam
    {
    }
  }
}
