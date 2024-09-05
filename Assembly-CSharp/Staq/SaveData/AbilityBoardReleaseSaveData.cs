// Decompiled with JetBrains decompiler
// Type: staq.SaveData.AbilityBoardReleaseSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using staq.SaveSchema;
using System.Collections.Generic;

#nullable disable
namespace staq.SaveData
{
  [Token(Token = "0x2003CEE")]
  public class AbilityBoardReleaseSaveData
  {
    [Token(Token = "0x4010C4E")]
    [FieldOffset(Offset = "0x10")]
    public Dictionary<int, AbilityBoardReleaseSaveData.ReleaseData> abilityBoardReleaseData;

    [Token(Token = "0x17005006")]
    private static string Path
    {
      [Token(Token = "0x60187C0"), Address(RVA = "0x2937984", Offset = "0x2937984", VA = "0x2937984")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60187C1")]
    [Address(RVA = "0x29379D4", Offset = "0x29379D4", VA = "0x29379D4")]
    public string GetPath() => (string) null;

    [Token(Token = "0x60187C2")]
    [Address(RVA = "0x2937A1C", Offset = "0x2937A1C", VA = "0x2937A1C")]
    public void DeleteFile()
    {
    }

    [Token(Token = "0x60187C3")]
    [Address(RVA = "0x2937A48", Offset = "0x2937A48", VA = "0x2937A48")]
    public void Delete()
    {
    }

    [Token(Token = "0x60187C4")]
    [Address(RVA = "0x2937A60", Offset = "0x2937A60", VA = "0x2937A60")]
    public void Load()
    {
    }

    [Token(Token = "0x60187C5")]
    [Address(RVA = "0x2937D5C", Offset = "0x2937D5C", VA = "0x2937D5C")]
    public void Save()
    {
    }

    [Token(Token = "0x60187C6")]
    [Address(RVA = "0x2937BE0", Offset = "0x2937BE0", VA = "0x2937BE0")]
    public bool IsExist() => new bool();

    [Token(Token = "0x60187C7")]
    [Address(RVA = "0x2937BF4", Offset = "0x2937BF4", VA = "0x2937BF4")]
    private void ExchangeSaveData(AbilityBoardReleaseData dataList)
    {
    }

    [Token(Token = "0x60187C8")]
    [Address(RVA = "0x2937E08", Offset = "0x2937E08", VA = "0x2937E08")]
    private VectorOffset CreateReleaseDataVector(FlatBufferBuilder fbb) => new VectorOffset();

    [Token(Token = "0x60187C9")]
    [Address(RVA = "0x2937F9C", Offset = "0x2937F9C", VA = "0x2937F9C")]
    public int GetLatestReleaseBordId(int styleId) => new int();

    [Token(Token = "0x60187CA")]
    [Address(RVA = "0x2938020", Offset = "0x2938020", VA = "0x2938020")]
    public void UpdateReleaseData(int styleId, int boardId)
    {
    }

    [Token(Token = "0x60187CB")]
    [Address(RVA = "0x293811C", Offset = "0x293811C", VA = "0x293811C")]
    public AbilityBoardReleaseSaveData()
    {
    }

    [Token(Token = "0x2003CEF")]
    public class ReleaseData
    {
      [Token(Token = "0x4010C4F")]
      [FieldOffset(Offset = "0x10")]
      public int styleId;
      [Token(Token = "0x4010C50")]
      [FieldOffset(Offset = "0x14")]
      public int boardId;

      [Token(Token = "0x60187CC")]
      [Address(RVA = "0x2937F70", Offset = "0x2937F70", VA = "0x2937F70")]
      public ReleaseData(int style, int board)
      {
      }
    }
  }
}
