// Decompiled with JetBrains decompiler
// Type: staq.SaveData.NoticeSettingSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace staq.SaveData
{
  [Token(Token = "0x2003D32")]
  public class NoticeSettingSaveData
  {
    [Token(Token = "0x4010D2A")]
    [FieldOffset(Offset = "0x11")]
    public bool battleFinishVibration;
    [Token(Token = "0x4010D2B")]
    [FieldOffset(Offset = "0x12")]
    public bool pushNotice;
    [Token(Token = "0x4010D2C")]
    [FieldOffset(Offset = "0x13")]
    public bool allApEecovery;
    [Token(Token = "0x4010D2D")]
    [FieldOffset(Offset = "0x14")]
    public bool fragmentPoolFull;
    [Token(Token = "0x4010D2E")]
    [FieldOffset(Offset = "0x15")]
    public bool factorizeRexovery;

    [Token(Token = "0x17005053")]
    public bool loaded
    {
      [Token(Token = "0x60189BD"), Address(RVA = "0x26367A0", Offset = "0x26367A0", VA = "0x26367A0")] get
      {
        return new bool();
      }
      [Token(Token = "0x60189BE"), Address(RVA = "0x26367A8", Offset = "0x26367A8", VA = "0x26367A8")] private set
      {
      }
    }

    [Token(Token = "0x17005054")]
    public bool IsAllApEecovery
    {
      [Token(Token = "0x60189BF"), Address(RVA = "0x26367B4", Offset = "0x26367B4", VA = "0x26367B4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17005055")]
    public bool IsFragmentPoolFull
    {
      [Token(Token = "0x60189C0"), Address(RVA = "0x26367D4", Offset = "0x26367D4", VA = "0x26367D4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17005056")]
    public bool IsFactorizeRexovery
    {
      [Token(Token = "0x60189C1"), Address(RVA = "0x26367F4", Offset = "0x26367F4", VA = "0x26367F4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17005057")]
    public static string Path
    {
      [Token(Token = "0x60189C2"), Address(RVA = "0x2636814", Offset = "0x2636814", VA = "0x2636814")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60189C3")]
    [Address(RVA = "0x2636864", Offset = "0x2636864", VA = "0x2636864")]
    public string GetPath() => (string) null;

    [Token(Token = "0x60189C4")]
    [Address(RVA = "0x26368AC", Offset = "0x26368AC", VA = "0x26368AC")]
    public void DeleteFile()
    {
    }

    [Token(Token = "0x60189C5")]
    [Address(RVA = "0x26368DC", Offset = "0x26368DC", VA = "0x26368DC")]
    public void Delete()
    {
    }

    [Token(Token = "0x60189C6")]
    [Address(RVA = "0x26368F8", Offset = "0x26368F8", VA = "0x26368F8")]
    public void Load()
    {
    }

    [Token(Token = "0x60189C7")]
    [Address(RVA = "0x2636AD8", Offset = "0x2636AD8", VA = "0x2636AD8")]
    public void Save()
    {
    }

    [Token(Token = "0x60189C8")]
    [Address(RVA = "0x2636BD8", Offset = "0x2636BD8", VA = "0x2636BD8")]
    public NoticeSettingSaveData()
    {
    }
  }
}
