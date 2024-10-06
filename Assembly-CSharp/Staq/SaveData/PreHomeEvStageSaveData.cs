// Decompiled with JetBrains decompiler
// Type: staq.SaveData.PreHomeEvStageSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace staq.SaveData
{
  [Token(Token = "0x2003D39")]
  public class PreHomeEvStageSaveData
  {
    [Token(Token = "0x4010D48")]
    [FieldOffset(Offset = "0x18")]
    private List<int> recordIds;

    [Token(Token = "0x17005067")]
    private bool isModified
    {
      [Token(Token = "0x6018A11"), Address(RVA = "0x2639384", Offset = "0x2639384", VA = "0x2639384")] set
      {
      }
      [Token(Token = "0x6018A12"), Address(RVA = "0x2639390", Offset = "0x2639390", VA = "0x2639390")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17005068")]
    private bool loaded
    {
      [Token(Token = "0x6018A13"), Address(RVA = "0x2639398", Offset = "0x2639398", VA = "0x2639398")] set
      {
      }
      [Token(Token = "0x6018A14"), Address(RVA = "0x26393A4", Offset = "0x26393A4", VA = "0x26393A4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17005069")]
    private static string Path
    {
      [Token(Token = "0x6018A15"), Address(RVA = "0x26393AC", Offset = "0x26393AC", VA = "0x26393AC")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6018A16")]
    [Address(RVA = "0x26393FC", Offset = "0x26393FC", VA = "0x26393FC")]
    public void Delete()
    {
    }

    [Token(Token = "0x6018A17")]
    [Address(RVA = "0x2639840", Offset = "0x2639840", VA = "0x2639840")]
    public string GetPath() => (string) null;

    [Token(Token = "0x6018A18")]
    [Address(RVA = "0x263941C", Offset = "0x263941C", VA = "0x263941C")]
    public void DeleteFile()
    {
    }

    [Token(Token = "0x6018A19")]
    [Address(RVA = "0x2639888", Offset = "0x2639888", VA = "0x2639888")]
    public void LoadIfNeed()
    {
    }

    [Token(Token = "0x6018A1A")]
    [Address(RVA = "0x263948C", Offset = "0x263948C", VA = "0x263948C")]
    public void Load(bool force = false)
    {
    }

    [Token(Token = "0x6018A1B")]
    [Address(RVA = "0x2639890", Offset = "0x2639890", VA = "0x2639890")]
    public void SaveIfModified()
    {
    }

    [Token(Token = "0x6018A1C")]
    [Address(RVA = "0x2639898", Offset = "0x2639898", VA = "0x2639898")]
    public void Save(bool force = false)
    {
    }

    [Token(Token = "0x6018A1D")]
    [Address(RVA = "0x26399B0", Offset = "0x26399B0", VA = "0x26399B0")]
    public void Record(int recordId)
    {
    }

    [Token(Token = "0x6018A1E")]
    [Address(RVA = "0x2639A88", Offset = "0x2639A88", VA = "0x2639A88")]
    public bool DoesExist(int recordId) => new bool();

    [Token(Token = "0x6018A1F")]
    [Address(RVA = "0x2639AE0", Offset = "0x2639AE0", VA = "0x2639AE0")]
    public PreHomeEvStageSaveData()
    {
    }
  }
}
