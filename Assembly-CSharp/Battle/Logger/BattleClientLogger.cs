// Decompiled with JetBrains decompiler
// Type: Battle.Logger.BattleClientLogger
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Process;
using Il2CppDummyDll;
using LogModule.Logger.ClientLogs;
using System;

#nullable disable
namespace Battle.Logger
{
  [Token(Token = "0x20022BA")]
  public class BattleClientLogger : ClientLogsLogger
  {
    [Token(Token = "0x4009268")]
    [FieldOffset(Offset = "0x0")]
    protected static BattleClientLogger instance;
    [Token(Token = "0x4009269")]
    private const string KEY = "battle";
    [Token(Token = "0x400926A")]
    private const string URL = "https://production-clientlogs-bq.astr.gu3.jp";

    [Token(Token = "0x600D3D8")]
    [Address(RVA = "0x19DB038", Offset = "0x19DB038", VA = "0x19DB038")]
    public new void Debug(string tag, string message)
    {
    }

    [Token(Token = "0x600D3D9")]
    [Address(RVA = "0x19DB078", Offset = "0x19DB078", VA = "0x19DB078")]
    public new void Info(string tag, string message)
    {
    }

    [Token(Token = "0x600D3DA")]
    [Address(RVA = "0x19DB0B8", Offset = "0x19DB0B8", VA = "0x19DB0B8")]
    public new void Warning(string tag, string message)
    {
    }

    [Token(Token = "0x600D3DB")]
    [Address(RVA = "0x19DB0F8", Offset = "0x19DB0F8", VA = "0x19DB0F8")]
    public new void Error(string tag, string message)
    {
    }

    [Token(Token = "0x600D3DC")]
    [Address(RVA = "0x19DB138", Offset = "0x19DB138", VA = "0x19DB138")]
    public new void Critical(string tag, string message)
    {
    }

    [Token(Token = "0x17002DE7")]
    public static BattleClientLogger Instance
    {
      [Token(Token = "0x600D3DD"), Address(RVA = "0x19DB178", Offset = "0x19DB178", VA = "0x19DB178")] get
      {
        return (BattleClientLogger) null;
      }
    }

    [Token(Token = "0x600D3DE")]
    [Address(RVA = "0x19DB1F8", Offset = "0x19DB1F8", VA = "0x19DB1F8")]
    public BattleClientLogger(int bufferSize = 1)
    {
    }

    [Token(Token = "0x600D3DF")]
    [Address(RVA = "0x19DB26C", Offset = "0x19DB26C", VA = "0x19DB26C")]
    public void SendLog(BattleCore core, bool compress = true)
    {
    }

    [Token(Token = "0x600D3E0")]
    [Address(RVA = "0x19DB580", Offset = "0x19DB580", VA = "0x19DB580")]
    public string GetTag(StoryBattleConfig config) => (string) null;

    [Token(Token = "0x20022BB")]
    [Serializable]
    private class StoryBattleLogParam
    {
      [Token(Token = "0x400926B")]
      [FieldOffset(Offset = "0x10")]
      public string player_id;
      [Token(Token = "0x400926C")]
      [FieldOffset(Offset = "0x18")]
      public string battle_uuid;
      [Token(Token = "0x400926D")]
      [FieldOffset(Offset = "0x20")]
      public string log;

      [Token(Token = "0x600D3E1")]
      [Address(RVA = "0x19DB578", Offset = "0x19DB578", VA = "0x19DB578")]
      public StoryBattleLogParam()
      {
      }
    }

    [Token(Token = "0x20022BC")]
    [Serializable]
    private class ArenaBattleLogParam
    {
      [Token(Token = "0x400926E")]
      [FieldOffset(Offset = "0x10")]
      public string player_id;
      [Token(Token = "0x400926F")]
      [FieldOffset(Offset = "0x18")]
      public long battle_id;
      [Token(Token = "0x4009270")]
      [FieldOffset(Offset = "0x20")]
      public string log;

      [Token(Token = "0x600D3E2")]
      [Address(RVA = "0x19DB5FC", Offset = "0x19DB5FC", VA = "0x19DB5FC")]
      public ArenaBattleLogParam()
      {
      }
    }
  }
}
