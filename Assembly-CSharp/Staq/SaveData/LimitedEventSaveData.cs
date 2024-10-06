// Decompiled with JetBrains decompiler
// Type: staq.SaveData.LimitedEventSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace staq.SaveData
{
  [Token(Token = "0x2003D2A")]
  public class LimitedEventSaveData
  {
    [Token(Token = "0x4010D08")]
    [FieldOffset(Offset = "0x10")]
    private bool loaded;
    [Token(Token = "0x4010D09")]
    [FieldOffset(Offset = "0x18")]
    private HashSet<int> eventIds;
    [Token(Token = "0x4010D0A")]
    [FieldOffset(Offset = "0x20")]
    private HashSet<int> stageIds;
    [Token(Token = "0x4010D0B")]
    [FieldOffset(Offset = "0x28")]
    private HashSet<int> newEventIds;
    [Token(Token = "0x4010D0C")]
    [FieldOffset(Offset = "0x30")]
    private HashSet<int> newStageIds;

    [Token(Token = "0x17005041")]
    private static string Path
    {
      [Token(Token = "0x6018952"), Address(RVA = "0x2946910", Offset = "0x2946910", VA = "0x2946910")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6018953")]
    [Address(RVA = "0x2946960", Offset = "0x2946960", VA = "0x2946960")]
    public string GetPath() => (string) null;

    [Token(Token = "0x6018954")]
    [Address(RVA = "0x29469A8", Offset = "0x29469A8", VA = "0x29469A8")]
    public bool IsNewEvent(int eventId) => new bool();

    [Token(Token = "0x6018955")]
    [Address(RVA = "0x2946A2C", Offset = "0x2946A2C", VA = "0x2946A2C")]
    public bool IsNewStage(int stageId) => new bool();

    [Token(Token = "0x6018956")]
    [Address(RVA = "0x2946AB0", Offset = "0x2946AB0", VA = "0x2946AB0")]
    public bool AddNewEvent(int eventId) => new bool();

    [Token(Token = "0x6018957")]
    [Address(RVA = "0x2946B44", Offset = "0x2946B44", VA = "0x2946B44")]
    public bool AddNewStage(int stageId) => new bool();

    [Token(Token = "0x6018958")]
    [Address(RVA = "0x2946BD8", Offset = "0x2946BD8", VA = "0x2946BD8")]
    public void Delete()
    {
    }

    [Token(Token = "0x6018959")]
    [Address(RVA = "0x2946C00", Offset = "0x2946C00", VA = "0x2946C00")]
    public void Load()
    {
    }

    [Token(Token = "0x601895A")]
    [Address(RVA = "0x2946EF8", Offset = "0x2946EF8", VA = "0x2946EF8")]
    public void Save()
    {
    }

    [Token(Token = "0x601895B")]
    [Address(RVA = "0x2946D50", Offset = "0x2946D50", VA = "0x2946D50")]
    private void Read(byte[] buffer)
    {
    }

    [Token(Token = "0x601895C")]
    [Address(RVA = "0x2947134", Offset = "0x2947134", VA = "0x2947134")]
    public LimitedEventSaveData()
    {
    }
  }
}
