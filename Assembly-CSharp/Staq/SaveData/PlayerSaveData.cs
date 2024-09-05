// Decompiled with JetBrains decompiler
// Type: staq.SaveData.PlayerSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace staq.SaveData
{
  [Token(Token = "0x2003D38")]
  public class PlayerSaveData
  {
    [Token(Token = "0x4010D3F")]
    [FieldOffset(Offset = "0x10")]
    public string PlayerId;
    [Token(Token = "0x4010D40")]
    [FieldOffset(Offset = "0x18")]
    public string DeviceId;
    [Token(Token = "0x4010D41")]
    [FieldOffset(Offset = "0x20")]
    public string SecretKey;
    [Token(Token = "0x4010D42")]
    [FieldOffset(Offset = "0x28")]
    public string ServerName;
    [Token(Token = "0x4010D43")]
    [FieldOffset(Offset = "0x30")]
    public uint ShortId;
    [Token(Token = "0x4010D44")]
    [FieldOffset(Offset = "0x34")]
    public bool IsDecidedPlayerdataAccunt;
    [Token(Token = "0x4010D45")]
    [FieldOffset(Offset = "0x35")]
    public bool loaded;

    [Token(Token = "0x6018A09")]
    [Address(RVA = "0x2638ED0", Offset = "0x2638ED0", VA = "0x2638ED0")]
    public PlayerSaveData()
    {
    }

    [Token(Token = "0x6018A0A")]
    [Address(RVA = "0x2638F48", Offset = "0x2638F48", VA = "0x2638F48")]
    public string getPath() => (string) null;

    [Token(Token = "0x6018A0B")]
    [Address(RVA = "0x2638FB8", Offset = "0x2638FB8", VA = "0x2638FB8")]
    public bool getValid() => new bool();

    [Token(Token = "0x6018A0C")]
    [Address(RVA = "0x2638EEC", Offset = "0x2638EEC", VA = "0x2638EEC")]
    public void init()
    {
    }

    [Token(Token = "0x6018A0D")]
    [Address(RVA = "0x263900C", Offset = "0x263900C", VA = "0x263900C")]
    public void delete()
    {
    }

    [Token(Token = "0x6018A0E")]
    [Address(RVA = "0x2639024", Offset = "0x2639024", VA = "0x2639024")]
    public void deleteFile()
    {
    }

    [Token(Token = "0x6018A0F")]
    [Address(RVA = "0x2639050", Offset = "0x2639050", VA = "0x2639050")]
    public void load()
    {
    }

    [Token(Token = "0x6018A10")]
    [Address(RVA = "0x26391C4", Offset = "0x26391C4", VA = "0x26391C4")]
    public void save()
    {
    }
  }
}
