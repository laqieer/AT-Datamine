// Decompiled with JetBrains decompiler
// Type: staq.SaveData.QuestSeletedSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace staq.SaveData
{
  [Token(Token = "0x2003D3B")]
  public class QuestSeletedSaveData
  {
    [Token(Token = "0x4010D4C")]
    [FieldOffset(Offset = "0x10")]
    public List<int> QuestSelectedList;

    [Token(Token = "0x1700506C")]
    public static string Path
    {
      [Token(Token = "0x6018A2A"), Address(RVA = "0x2639EB4", Offset = "0x2639EB4", VA = "0x2639EB4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700506D")]
    public bool loaded
    {
      [Token(Token = "0x6018A2B"), Address(RVA = "0x2639F04", Offset = "0x2639F04", VA = "0x2639F04")] get
      {
        return new bool();
      }
      [Token(Token = "0x6018A2C"), Address(RVA = "0x2639F0C", Offset = "0x2639F0C", VA = "0x2639F0C")] private set
      {
      }
    }

    [Token(Token = "0x6018A2D")]
    [Address(RVA = "0x2639F18", Offset = "0x2639F18", VA = "0x2639F18")]
    public string GetPath() => (string) null;

    [Token(Token = "0x6018A2E")]
    [Address(RVA = "0x2639F60", Offset = "0x2639F60", VA = "0x2639F60")]
    public void DeleteFile()
    {
    }

    [Token(Token = "0x6018A2F")]
    [Address(RVA = "0x2639F90", Offset = "0x2639F90", VA = "0x2639F90")]
    public void Delete()
    {
    }

    [Token(Token = "0x6018A30")]
    [Address(RVA = "0x2639F98", Offset = "0x2639F98", VA = "0x2639F98")]
    public void Save()
    {
    }

    [Token(Token = "0x6018A31")]
    [Address(RVA = "0x263A074", Offset = "0x263A074", VA = "0x263A074")]
    public void Load()
    {
    }

    [Token(Token = "0x6018A32")]
    [Address(RVA = "0x263A33C", Offset = "0x263A33C", VA = "0x263A33C")]
    public void AddQuestSelected(int questId)
    {
    }

    [Token(Token = "0x6018A33")]
    [Address(RVA = "0x263A3F4", Offset = "0x263A3F4", VA = "0x263A3F4")]
    public bool IsQuestSelected(int questId) => new bool();

    [Token(Token = "0x6018A34")]
    [Address(RVA = "0x263A458", Offset = "0x263A458", VA = "0x263A458")]
    public QuestSeletedSaveData()
    {
    }
  }
}
