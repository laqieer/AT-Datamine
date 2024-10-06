// Decompiled with JetBrains decompiler
// Type: staq.SaveData.ChallengeGuildRaidSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace staq.SaveData
{
  [Token(Token = "0x2003CFB")]
  public class ChallengeGuildRaidSaveData
  {
    [Token(Token = "0x4010C82")]
    [FieldOffset(Offset = "0x10")]
    public int RaidId;
    [Token(Token = "0x4010C83")]
    [FieldOffset(Offset = "0x14")]
    public int Lap;
    [Token(Token = "0x4010C84")]
    [FieldOffset(Offset = "0x18")]
    public int PositionId;
    [Token(Token = "0x4010C85")]
    [FieldOffset(Offset = "0x1C")]
    public bool IsMock;
    [Token(Token = "0x4010C86")]
    [FieldOffset(Offset = "0x20")]
    public int MockLap;

    [Token(Token = "0x17005014")]
    private static string Path
    {
      [Token(Token = "0x6018822"), Address(RVA = "0x293AFD0", Offset = "0x293AFD0", VA = "0x293AFD0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6018823")]
    [Address(RVA = "0x293B020", Offset = "0x293B020", VA = "0x293B020")]
    public string GetPath() => (string) null;

    [Token(Token = "0x6018824")]
    [Address(RVA = "0x293B068", Offset = "0x293B068", VA = "0x293B068")]
    public void DeleteFile()
    {
    }

    [Token(Token = "0x6018825")]
    [Address(RVA = "0x293B094", Offset = "0x293B094", VA = "0x293B094")]
    public bool IsExist() => new bool();

    [Token(Token = "0x6018826")]
    [Address(RVA = "0x293B0A8", Offset = "0x293B0A8", VA = "0x293B0A8")]
    public void Delete()
    {
    }

    [Token(Token = "0x6018827")]
    [Address(RVA = "0x293B0C0", Offset = "0x293B0C0", VA = "0x293B0C0")]
    public void Load()
    {
    }

    [Token(Token = "0x6018828")]
    [Address(RVA = "0x293B27C", Offset = "0x293B27C", VA = "0x293B27C")]
    public void Save()
    {
    }

    [Token(Token = "0x6018829")]
    [Address(RVA = "0x293B374", Offset = "0x293B374", VA = "0x293B374")]
    public void SetData(int raidId, int lap, int position, bool isMock, int mockLap)
    {
    }

    [Token(Token = "0x601882A")]
    [Address(RVA = "0x293B38C", Offset = "0x293B38C", VA = "0x293B38C")]
    public ChallengeGuildRaidSaveData()
    {
    }
  }
}
