// Decompiled with JetBrains decompiler
// Type: staq.SaveData.LobbySaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace staq.SaveData
{
  [Token(Token = "0x2003D2B")]
  public class LobbySaveData
  {
    [Token(Token = "0x4010D0E")]
    [FieldOffset(Offset = "0x18")]
    public Dictionary<int, LobbySaveData.PlayEvent> PlayedLeaderUnitEvent;

    [Token(Token = "0x17005042")]
    public bool loaded
    {
      [Token(Token = "0x601895D"), Address(RVA = "0x294720C", Offset = "0x294720C", VA = "0x294720C")] private set
      {
      }
      [Token(Token = "0x601895E"), Address(RVA = "0x2947218", Offset = "0x2947218", VA = "0x2947218")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17005043")]
    public static string Path
    {
      [Token(Token = "0x601895F"), Address(RVA = "0x2947220", Offset = "0x2947220", VA = "0x2947220")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6018960")]
    [Address(RVA = "0x2947270", Offset = "0x2947270", VA = "0x2947270")]
    public string getPath() => (string) null;

    [Token(Token = "0x6018961")]
    [Address(RVA = "0x29472B8", Offset = "0x29472B8", VA = "0x29472B8")]
    public void deleteFile()
    {
    }

    [Token(Token = "0x6018962")]
    [Address(RVA = "0x2947328", Offset = "0x2947328", VA = "0x2947328")]
    public void delete()
    {
    }

    [Token(Token = "0x6018963")]
    [Address(RVA = "0x2947344", Offset = "0x2947344", VA = "0x2947344")]
    public void load()
    {
    }

    [Token(Token = "0x6018964")]
    [Address(RVA = "0x29476D8", Offset = "0x29476D8", VA = "0x29476D8")]
    public void save()
    {
    }

    [Token(Token = "0x6018965")]
    [Address(RVA = "0x29479DC", Offset = "0x29479DC", VA = "0x29479DC")]
    public bool IsWatchedLeaderUnitEvent(int tableId, out DateTime playDate) => new bool();

    [Token(Token = "0x6018966")]
    [Address(RVA = "0x2947AA0", Offset = "0x2947AA0", VA = "0x2947AA0")]
    public void AddWatchedLeaderUnitEvent(int tableId, DateTime timestamp)
    {
    }

    [Token(Token = "0x6018967")]
    [Address(RVA = "0x2947B54", Offset = "0x2947B54", VA = "0x2947B54")]
    public void ResetPlayLeaderUnitEvent()
    {
    }

    [Token(Token = "0x6018968")]
    [Address(RVA = "0x2947608", Offset = "0x2947608", VA = "0x2947608")]
    private static LobbySaveData.PlayEvent ConvPlayLeaderEvent(staq.SaveSchema.PlayEvent? data)
    {
      return new LobbySaveData.PlayEvent();
    }

    [Token(Token = "0x6018969")]
    [Address(RVA = "0x2947BA4", Offset = "0x2947BA4", VA = "0x2947BA4")]
    public LobbySaveData()
    {
    }

    [Token(Token = "0x2003D2C")]
    public struct PlayEvent
    {
      [Token(Token = "0x4010D0F")]
      [FieldOffset(Offset = "0x0")]
      public int TableId;
      [Token(Token = "0x4010D10")]
      [FieldOffset(Offset = "0x8")]
      public DateTime PlayDate;

      [Token(Token = "0x601896A")]
      [Address(RVA = "0x2947BAC", Offset = "0x2947BAC", VA = "0x2947BAC", Slot = "3")]
      public override string ToString() => (string) null;
    }
  }
}
