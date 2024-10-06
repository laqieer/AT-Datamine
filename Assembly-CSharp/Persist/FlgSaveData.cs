// Decompiled with JetBrains decompiler
// Type: Persist.FlgSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using System.IO;

#nullable disable
namespace Persist
{
  [Token(Token = "0x20009EA")]
  public class FlgSaveData
  {
    [Token(Token = "0x4002DEC")]
    [FieldOffset(Offset = "0x10")]
    private int version;
    [Token(Token = "0x4002DED")]
    [FieldOffset(Offset = "0x18")]
    private string fileName;
    [Token(Token = "0x4002DEE")]
    [FieldOffset(Offset = "0x20")]
    private Dictionary<int, List<int>> chapterToIdMap;

    [Token(Token = "0x170007FF")]
    public string FilePath
    {
      [Token(Token = "0x6003875"), Address(RVA = "0x310C6CC", Offset = "0x310C6CC", VA = "0x310C6CC")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6003876")]
    [Address(RVA = "0x310C78C", Offset = "0x310C78C", VA = "0x310C78C")]
    public FlgSaveData(string fileName)
    {
    }

    [Token(Token = "0x6003877")]
    [Address(RVA = "0x310C81C", Offset = "0x310C81C", VA = "0x310C81C")]
    public bool AddData(int chapterId, int id) => new bool();

    [Token(Token = "0x6003878")]
    [Address(RVA = "0x310CAEC", Offset = "0x310CAEC", VA = "0x310CAEC")]
    public void RemoveData(int chapterId, int id)
    {
    }

    [Token(Token = "0x6003879")]
    [Address(RVA = "0x310CBB0", Offset = "0x310CBB0", VA = "0x310CBB0")]
    public bool ContainsID(int chapterId, int id) => new bool();

    [Token(Token = "0x600387A")]
    [Address(RVA = "0x310CC78", Offset = "0x310CC78", VA = "0x310CC78")]
    public bool CheckNewFlgData(int chapterId) => new bool();

    [Token(Token = "0x600387B")]
    [Address(RVA = "0x310CD24", Offset = "0x310CD24", VA = "0x310CD24")]
    private void CreateDirectory()
    {
    }

    [Token(Token = "0x600387C")]
    [Address(RVA = "0x310CDAC", Offset = "0x310CDAC", VA = "0x310CDAC")]
    public void ResetAll()
    {
    }

    [Token(Token = "0x600387D")]
    [Address(RVA = "0x310CF50", Offset = "0x310CF50", VA = "0x310CF50")]
    public void Reset(int chapter)
    {
    }

    [Token(Token = "0x600387E")]
    [Address(RVA = "0x310CFF4", Offset = "0x310CFF4", VA = "0x310CFF4")]
    public void Save()
    {
    }

    [Token(Token = "0x600387F")]
    [Address(RVA = "0x310D500", Offset = "0x310D500", VA = "0x310D500")]
    public void Load()
    {
    }

    [Token(Token = "0x6003880")]
    [Address(RVA = "0x310D740", Offset = "0x310D740", VA = "0x310D740")]
    private void LoadVer0(BinaryReader reader)
    {
    }
  }
}
