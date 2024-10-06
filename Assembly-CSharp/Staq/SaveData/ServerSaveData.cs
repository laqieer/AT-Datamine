// Decompiled with JetBrains decompiler
// Type: staq.SaveData.ServerSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using staq.SaveSchema;

#nullable disable
namespace staq.SaveData
{
  [Token(Token = "0x2003D3E")]
  public class ServerSaveData
  {
    [Token(Token = "0x4010D51")]
    [FieldOffset(Offset = "0x10")]
    public string Name;
    [Token(Token = "0x4010D52")]
    [FieldOffset(Offset = "0x18")]
    public string Host;
    [Token(Token = "0x4010D53")]
    [FieldOffset(Offset = "0x20")]
    public ServerDeclType Type;

    [Token(Token = "0x1700506F")]
    public static string Path
    {
      [Token(Token = "0x6018A42"), Address(RVA = "0x263B130", Offset = "0x263B130", VA = "0x263B130")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6018A43")]
    [Address(RVA = "0x263B1A0", Offset = "0x263B1A0", VA = "0x263B1A0")]
    public static string GetTypeName(ServerDeclType type) => (string) null;

    [Token(Token = "0x6018A44")]
    [Address(RVA = "0x263B228", Offset = "0x263B228", VA = "0x263B228")]
    public bool getValid() => new bool();

    [Token(Token = "0x6018A45")]
    [Address(RVA = "0x263B2A8", Offset = "0x263B2A8", VA = "0x263B2A8")]
    public void init()
    {
    }

    [Token(Token = "0x6018A46")]
    [Address(RVA = "0x263B458", Offset = "0x263B458", VA = "0x263B458")]
    public void load(string path)
    {
    }

    [Token(Token = "0x6018A47")]
    [Address(RVA = "0x263B344", Offset = "0x263B344", VA = "0x263B344")]
    public void read(byte[] buf)
    {
    }

    [Token(Token = "0x6018A48")]
    [Address(RVA = "0x263B47C", Offset = "0x263B47C", VA = "0x263B47C")]
    public void save(string path)
    {
    }

    [Token(Token = "0x6018A49")]
    [Address(RVA = "0x263B59C", Offset = "0x263B59C", VA = "0x263B59C")]
    public ServerSaveData()
    {
    }
  }
}
