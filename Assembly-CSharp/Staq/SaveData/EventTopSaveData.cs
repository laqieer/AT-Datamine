// Decompiled with JetBrains decompiler
// Type: staq.SaveData.EventTopSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace staq.SaveData
{
  [Token(Token = "0x2003D0B")]
  public class EventTopSaveData
  {
    [Token(Token = "0x4010CC9")]
    [FieldOffset(Offset = "0x18")]
    private List<EventTopSaveData.EventData> eventDataList;
    [Token(Token = "0x4010CCA")]
    private const string SaveDataFileName = "/scenario_event_quest_data.dat";

    [Token(Token = "0x17005025")]
    public bool loaded
    {
      [Token(Token = "0x601888A"), Address(RVA = "0x293F020", Offset = "0x293F020", VA = "0x293F020")] get
      {
        return new bool();
      }
      [Token(Token = "0x601888B"), Address(RVA = "0x293F028", Offset = "0x293F028", VA = "0x293F028")] private set
      {
      }
    }

    [Token(Token = "0x601888C")]
    [Address(RVA = "0x293F034", Offset = "0x293F034", VA = "0x293F034")]
    public string GetPath() => (string) null;

    [Token(Token = "0x601888D")]
    [Address(RVA = "0x293F0A4", Offset = "0x293F0A4", VA = "0x293F0A4")]
    public EventTopSaveData.EventData GetData(int id) => (EventTopSaveData.EventData) null;

    [Token(Token = "0x601888E")]
    [Address(RVA = "0x293F288", Offset = "0x293F288", VA = "0x293F288")]
    public bool Check(int id) => new bool();

    [Token(Token = "0x601888F")]
    [Address(RVA = "0x293F374", Offset = "0x293F374", VA = "0x293F374")]
    public void DeleteFile()
    {
    }

    [Token(Token = "0x6018890")]
    [Address(RVA = "0x293F3A4", Offset = "0x293F3A4", VA = "0x293F3A4")]
    public void Load()
    {
    }

    [Token(Token = "0x6018891")]
    [Address(RVA = "0x293F6E8", Offset = "0x293F6E8", VA = "0x293F6E8")]
    public void Save()
    {
    }

    [Token(Token = "0x6018892")]
    [Address(RVA = "0x293F79C", Offset = "0x293F79C", VA = "0x293F79C")]
    private VectorOffset CreateEventDataVector(FlatBufferBuilder fbb) => new VectorOffset();

    [Token(Token = "0x6018893")]
    [Address(RVA = "0x293F8B0", Offset = "0x293F8B0", VA = "0x293F8B0")]
    public EventTopSaveData()
    {
    }

    [Token(Token = "0x2003D0C")]
    public class EventData
    {
      [Token(Token = "0x4010CCB")]
      [FieldOffset(Offset = "0x10")]
      public int EventId;
      [Token(Token = "0x4010CCC")]
      [FieldOffset(Offset = "0x14")]
      public bool IsOpenFreeBattle;
      [Token(Token = "0x4010CCD")]
      [FieldOffset(Offset = "0x15")]
      public bool IsOpenSpecialBattle;
      [Token(Token = "0x4010CCE")]
      [FieldOffset(Offset = "0x16")]
      public bool IsOpenScoreAttack;

      [Token(Token = "0x6018894")]
      [Address(RVA = "0x293F240", Offset = "0x293F240", VA = "0x293F240")]
      public EventData(int eventId, bool isOpenFree, bool IsOpenSpecial, bool isOpenScoreAttack)
      {
      }
    }
  }
}
