// Decompiled with JetBrains decompiler
// Type: staq.AdvertisementClientLogger
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using LogModule.Logger.ClientLogs;
using System;

#nullable disable
namespace staq
{
  [Token(Token = "0x2003C19")]
  public class AdvertisementClientLogger : ClientLogsLogger
  {
    [Token(Token = "0x4010A94")]
    [FieldOffset(Offset = "0x0")]
    protected static AdvertisementClientLogger instance;
    [Token(Token = "0x4010A95")]
    private const string KEY = "RewardedVideo";
    [Token(Token = "0x4010A96")]
    private const string URL = "https://production-clientlogs-bq.astr.gu3.jp";

    [Token(Token = "0x60179F7")]
    [Address(RVA = "0x2381898", Offset = "0x2381898", VA = "0x2381898")]
    public new void Debug(string tag, string message)
    {
    }

    [Token(Token = "0x60179F8")]
    [Address(RVA = "0x23818D8", Offset = "0x23818D8", VA = "0x23818D8")]
    public new void Info(string tag, string message)
    {
    }

    [Token(Token = "0x60179F9")]
    [Address(RVA = "0x2381918", Offset = "0x2381918", VA = "0x2381918")]
    public new void Warning(string tag, string message)
    {
    }

    [Token(Token = "0x60179FA")]
    [Address(RVA = "0x2381958", Offset = "0x2381958", VA = "0x2381958")]
    public new void Error(string tag, string message)
    {
    }

    [Token(Token = "0x60179FB")]
    [Address(RVA = "0x2381998", Offset = "0x2381998", VA = "0x2381998")]
    public new void Critical(string tag, string message)
    {
    }

    [Token(Token = "0x17004CC6")]
    public static AdvertisementClientLogger Instance
    {
      [Token(Token = "0x60179FC"), Address(RVA = "0x23819D8", Offset = "0x23819D8", VA = "0x23819D8")] get
      {
        return (AdvertisementClientLogger) null;
      }
    }

    [Token(Token = "0x60179FD")]
    [Address(RVA = "0x2381A58", Offset = "0x2381A58", VA = "0x2381A58")]
    public AdvertisementClientLogger(int bufferSize = 1)
    {
    }

    [Token(Token = "0x60179FE")]
    [Address(RVA = "0x2381ACC", Offset = "0x2381ACC", VA = "0x2381ACC")]
    public void SendLog(
      string tab,
      string eventType,
      string advertisement_id,
      string ad_info_log,
      string error_log = null)
    {
    }

    [Token(Token = "0x2003C1A")]
    [Serializable]
    private class AdvertisementLogParam
    {
      [Token(Token = "0x4010A97")]
      [FieldOffset(Offset = "0x10")]
      public string player_id;
      [Token(Token = "0x4010A98")]
      [FieldOffset(Offset = "0x18")]
      public string app_version;
      [Token(Token = "0x4010A99")]
      [FieldOffset(Offset = "0x20")]
      public string dlc_Version;
      [Token(Token = "0x4010A9A")]
      [FieldOffset(Offset = "0x28")]
      public string event_type;
      [Token(Token = "0x4010A9B")]
      [FieldOffset(Offset = "0x30")]
      public string advertisement_id;
      [Token(Token = "0x4010A9C")]
      [FieldOffset(Offset = "0x38")]
      public string ad_info_log;
      [Token(Token = "0x4010A9D")]
      [FieldOffset(Offset = "0x40")]
      public string error_log;

      [Token(Token = "0x60179FF")]
      [Address(RVA = "0x2381C64", Offset = "0x2381C64", VA = "0x2381C64")]
      public AdvertisementLogParam()
      {
      }
    }
  }
}
