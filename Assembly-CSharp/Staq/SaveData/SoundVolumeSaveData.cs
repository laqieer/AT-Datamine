// Decompiled with JetBrains decompiler
// Type: staq.SaveData.SoundVolumeSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace staq.SaveData
{
  [Token(Token = "0x2003D49")]
  public class SoundVolumeSaveData
  {
    [Token(Token = "0x4010D72")]
    [FieldOffset(Offset = "0x14")]
    public float BgmVolume;
    [Token(Token = "0x4010D73")]
    [FieldOffset(Offset = "0x18")]
    public float SeVolume;
    [Token(Token = "0x4010D74")]
    [FieldOffset(Offset = "0x1C")]
    public float VoiceVolume;

    [Token(Token = "0x17005090")]
    public bool loaded
    {
      [Token(Token = "0x6018A99"), Address(RVA = "0x263E860", Offset = "0x263E860", VA = "0x263E860")] get
      {
        return new bool();
      }
      [Token(Token = "0x6018A9A"), Address(RVA = "0x263E868", Offset = "0x263E868", VA = "0x263E868")] private set
      {
      }
    }

    [Token(Token = "0x17005091")]
    public static string Path
    {
      [Token(Token = "0x6018A9B"), Address(RVA = "0x263E874", Offset = "0x263E874", VA = "0x263E874")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6018A9C")]
    [Address(RVA = "0x263E8C4", Offset = "0x263E8C4", VA = "0x263E8C4")]
    public string GetPath() => (string) null;

    [Token(Token = "0x6018A9D")]
    [Address(RVA = "0x263E90C", Offset = "0x263E90C", VA = "0x263E90C")]
    public void Delete()
    {
    }

    [Token(Token = "0x6018A9E")]
    [Address(RVA = "0x263E928", Offset = "0x263E928", VA = "0x263E928")]
    public void DeleteFile()
    {
    }

    [Token(Token = "0x6018A9F")]
    [Address(RVA = "0x263E958", Offset = "0x263E958", VA = "0x263E958")]
    public void Load()
    {
    }

    [Token(Token = "0x6018AA0")]
    [Address(RVA = "0x263EAFC", Offset = "0x263EAFC", VA = "0x263EAFC")]
    public void Save()
    {
    }

    [Token(Token = "0x6018AA1")]
    [Address(RVA = "0x263EC20", Offset = "0x263EC20", VA = "0x263EC20")]
    public SoundVolumeSaveData()
    {
    }
  }
}
