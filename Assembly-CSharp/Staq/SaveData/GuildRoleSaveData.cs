// Decompiled with JetBrains decompiler
// Type: staq.SaveData.GuildRoleSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace staq.SaveData
{
  [Token(Token = "0x2003D24")]
  public class GuildRoleSaveData
  {
    [Token(Token = "0x17005036")]
    public bool loaded
    {
      [Token(Token = "0x601891B"), Address(RVA = "0x2944D14", Offset = "0x2944D14", VA = "0x2944D14")] get
      {
        return new bool();
      }
      [Token(Token = "0x601891C"), Address(RVA = "0x2944D1C", Offset = "0x2944D1C", VA = "0x2944D1C")] private set
      {
      }
    }

    [Token(Token = "0x17005037")]
    public int GuildRoleId
    {
      [Token(Token = "0x601891D"), Address(RVA = "0x2944D28", Offset = "0x2944D28", VA = "0x2944D28")] get
      {
        return new int();
      }
      [Token(Token = "0x601891E"), Address(RVA = "0x2944D30", Offset = "0x2944D30", VA = "0x2944D30")] private set
      {
      }
    }

    [Token(Token = "0x17005038")]
    public static string Path
    {
      [Token(Token = "0x601891F"), Address(RVA = "0x2944D38", Offset = "0x2944D38", VA = "0x2944D38")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6018920")]
    [Address(RVA = "0x2944D88", Offset = "0x2944D88", VA = "0x2944D88")]
    public string GetPath() => (string) null;

    [Token(Token = "0x6018921")]
    [Address(RVA = "0x2944DD0", Offset = "0x2944DD0", VA = "0x2944DD0")]
    public void DeleteFile()
    {
    }

    [Token(Token = "0x6018922")]
    [Address(RVA = "0x2944E00", Offset = "0x2944E00", VA = "0x2944E00")]
    public void Delete()
    {
    }

    [Token(Token = "0x6018923")]
    [Address(RVA = "0x2944E1C", Offset = "0x2944E1C", VA = "0x2944E1C")]
    public void Load()
    {
    }

    [Token(Token = "0x6018924")]
    [Address(RVA = "0x2944F98", Offset = "0x2944F98", VA = "0x2944F98")]
    public void Save(int id)
    {
    }

    [Token(Token = "0x6018925")]
    [Address(RVA = "0x2945068", Offset = "0x2945068", VA = "0x2945068")]
    public bool IsEmpty() => new bool();

    [Token(Token = "0x6018926")]
    [Address(RVA = "0x2945078", Offset = "0x2945078", VA = "0x2945078")]
    public GuildRoleSaveData()
    {
    }
  }
}
