// Decompiled with JetBrains decompiler
// Type: Persist.Persist`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Persist
{
  [Token(Token = "0x20009E9")]
  public class Persist<T> where T : new()
  {
    [Token(Token = "0x4002DEA")]
    [FieldOffset(Offset = "0x0")]
    public string fileName;
    [Token(Token = "0x4002DEB")]
    [FieldOffset(Offset = "0x0")]
    public object value;

    [Token(Token = "0x170007FB")]
    public string DirectoryPath
    {
      [Token(Token = "0x600386D")] get => (string) null;
    }

    [Token(Token = "0x170007FC")]
    public string FilePath
    {
      [Token(Token = "0x600386E")] get => (string) null;
    }

    [Token(Token = "0x170007FD")]
    public bool Exists
    {
      [Token(Token = "0x600386F")] get => new bool();
    }

    [Token(Token = "0x170007FE")]
    public T Data
    {
      [Token(Token = "0x6003870")] get => (T) null;
      [Token(Token = "0x6003871")] set
      {
      }
    }

    [Token(Token = "0x6003872")]
    public Persist(string name)
    {
    }

    [Token(Token = "0x6003873")]
    public void Delete()
    {
    }

    [Token(Token = "0x6003874")]
    public void Flush()
    {
    }
  }
}
