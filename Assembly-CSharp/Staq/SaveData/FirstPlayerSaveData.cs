// Decompiled with JetBrains decompiler
// Type: staq.SaveData.FirstPlayerSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace staq.SaveData
{
  [Token(Token = "0x2003D11")]
  public class FirstPlayerSaveData
  {
    [Token(Token = "0x17005028")]
    public string PlayerId
    {
      [Token(Token = "0x60188A7"), Address(RVA = "0x2940008", Offset = "0x2940008", VA = "0x2940008")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60188A8"), Address(RVA = "0x2940010", Offset = "0x2940010", VA = "0x2940010")] private set
      {
      }
    }

    [Token(Token = "0x17005029")]
    private static string Path
    {
      [Token(Token = "0x60188A9"), Address(RVA = "0x2940018", Offset = "0x2940018", VA = "0x2940018")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60188AA")]
    [Address(RVA = "0x2940068", Offset = "0x2940068", VA = "0x2940068")]
    public string GetPath() => (string) null;

    [Token(Token = "0x60188AB")]
    [Address(RVA = "0x29400B0", Offset = "0x29400B0", VA = "0x29400B0")]
    public void DeleteFile()
    {
    }

    [Token(Token = "0x60188AC")]
    [Address(RVA = "0x29400DC", Offset = "0x29400DC", VA = "0x29400DC")]
    public void Delete()
    {
    }

    [Token(Token = "0x60188AD")]
    [Address(RVA = "0x29400F4", Offset = "0x29400F4", VA = "0x29400F4")]
    public void Load()
    {
    }

    [Token(Token = "0x60188AE")]
    [Address(RVA = "0x2940270", Offset = "0x2940270", VA = "0x2940270")]
    private void Save()
    {
    }

    [Token(Token = "0x60188AF")]
    [Address(RVA = "0x294025C", Offset = "0x294025C", VA = "0x294025C")]
    private bool IsExist() => new bool();

    [Token(Token = "0x60188B0")]
    [Address(RVA = "0x294033C", Offset = "0x294033C", VA = "0x294033C")]
    public void SetPlayerId(string playerId)
    {
    }

    [Token(Token = "0x60188B1")]
    [Address(RVA = "0x294038C", Offset = "0x294038C", VA = "0x294038C")]
    public FirstPlayerSaveData()
    {
    }
  }
}
