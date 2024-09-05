// Decompiled with JetBrains decompiler
// Type: staq.SaveData.GachaSettingSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace staq.SaveData
{
  [Token(Token = "0x2003D1C")]
  public class GachaSettingSaveData
  {
    [Token(Token = "0x17005030")]
    public bool IsSkipPlayback
    {
      [Token(Token = "0x60188E6"), Address(RVA = "0x2942ECC", Offset = "0x2942ECC", VA = "0x2942ECC")] get
      {
        return new bool();
      }
      [Token(Token = "0x60188E7"), Address(RVA = "0x2942ED4", Offset = "0x2942ED4", VA = "0x2942ED4")] set
      {
      }
    }

    [Token(Token = "0x17005031")]
    public static string Path
    {
      [Token(Token = "0x60188E8"), Address(RVA = "0x2942EE0", Offset = "0x2942EE0", VA = "0x2942EE0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60188E9")]
    [Address(RVA = "0x2942F30", Offset = "0x2942F30", VA = "0x2942F30")]
    public string GetPath() => (string) null;

    [Token(Token = "0x60188EA")]
    [Address(RVA = "0x2942F78", Offset = "0x2942F78", VA = "0x2942F78")]
    public void DeleteFile()
    {
    }

    [Token(Token = "0x60188EB")]
    [Address(RVA = "0x2942FA8", Offset = "0x2942FA8", VA = "0x2942FA8")]
    public void Delete()
    {
    }

    [Token(Token = "0x60188EC")]
    [Address(RVA = "0x2942FC0", Offset = "0x2942FC0", VA = "0x2942FC0")]
    public void Load()
    {
    }

    [Token(Token = "0x60188ED")]
    [Address(RVA = "0x2943130", Offset = "0x2943130", VA = "0x2943130")]
    public void Save()
    {
    }

    [Token(Token = "0x60188EE")]
    [Address(RVA = "0x29431E8", Offset = "0x29431E8", VA = "0x29431E8")]
    public GachaSettingSaveData()
    {
    }
  }
}
