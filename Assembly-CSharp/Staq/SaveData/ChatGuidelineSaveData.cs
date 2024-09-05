// Decompiled with JetBrains decompiler
// Type: staq.SaveData.ChatGuidelineSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace staq.SaveData
{
  [Token(Token = "0x2003D00")]
  public class ChatGuidelineSaveData
  {
    [Token(Token = "0x4010C91")]
    [FieldOffset(Offset = "0x10")]
    public bool chatGuidelineState;
    [Token(Token = "0x4010C92")]
    [FieldOffset(Offset = "0x18")]
    public string chatGuidelineVersion;

    [Token(Token = "0x1700501C")]
    public static string Path
    {
      [Token(Token = "0x601884B"), Address(RVA = "0x293C6C8", Offset = "0x293C6C8", VA = "0x293C6C8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x601884C")]
    [Address(RVA = "0x293C738", Offset = "0x293C738", VA = "0x293C738")]
    public void Delete()
    {
    }

    [Token(Token = "0x601884D")]
    [Address(RVA = "0x293C758", Offset = "0x293C758", VA = "0x293C758")]
    public void Load()
    {
    }

    [Token(Token = "0x601884E")]
    [Address(RVA = "0x293C800", Offset = "0x293C800", VA = "0x293C800")]
    public void Read(byte[] buf)
    {
    }

    [Token(Token = "0x601884F")]
    [Address(RVA = "0x293C9B0", Offset = "0x293C9B0", VA = "0x293C9B0")]
    public void SetGuidelineState(bool state, string version)
    {
    }

    [Token(Token = "0x6018850")]
    [Address(RVA = "0x293C9C0", Offset = "0x293C9C0", VA = "0x293C9C0")]
    public void Save()
    {
    }

    [Token(Token = "0x6018851")]
    [Address(RVA = "0x293CA9C", Offset = "0x293CA9C", VA = "0x293CA9C")]
    public ChatGuidelineSaveData()
    {
    }
  }
}
