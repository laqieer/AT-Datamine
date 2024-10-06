// Decompiled with JetBrains decompiler
// Type: ISAdQualityConfig
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
[Token(Token = "0x2000089")]
public class ISAdQualityConfig
{
  [Token(Token = "0x4000247")]
  [FieldOffset(Offset = "0x10")]
  private string userId;
  [Token(Token = "0x4000248")]
  [FieldOffset(Offset = "0x18")]
  private bool userIdSet;
  [Token(Token = "0x4000249")]
  [FieldOffset(Offset = "0x19")]
  private bool testMode;
  [Token(Token = "0x400024A")]
  [FieldOffset(Offset = "0x20")]
  private ISAdQualityInitCallback adQualityInitCallback;
  [Token(Token = "0x400024B")]
  [FieldOffset(Offset = "0x28")]
  private ISAdQualityLogLevel logLevel;
  [Token(Token = "0x400024C")]
  [FieldOffset(Offset = "0x30")]
  private string initializationSource;
  [Token(Token = "0x400024D")]
  [FieldOffset(Offset = "0x38")]
  private bool coppa;
  [Token(Token = "0x400024E")]
  [FieldOffset(Offset = "0x3C")]
  private ISAdQualityDeviceIdType deviceIdType;

  [Token(Token = "0x60004D9")]
  [Address(RVA = "0x44ADDF4", Offset = "0x44ADDF4", VA = "0x44ADDF4")]
  public ISAdQualityConfig()
  {
  }

  [Token(Token = "0x17000024")]
  public string UserId
  {
    [Token(Token = "0x60004DA"), Address(RVA = "0x44AFFA0", Offset = "0x44AFFA0", VA = "0x44AFFA0")] get
    {
      return (string) null;
    }
    [Token(Token = "0x60004DB"), Address(RVA = "0x44AFFA8", Offset = "0x44AFFA8", VA = "0x44AFFA8")] set
    {
    }
  }

  [Token(Token = "0x17000025")]
  internal bool UserIdSet
  {
    [Token(Token = "0x60004DC"), Address(RVA = "0x44AFFB8", Offset = "0x44AFFB8", VA = "0x44AFFB8")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x17000026")]
  public bool TestMode
  {
    [Token(Token = "0x60004DD"), Address(RVA = "0x44AFFC0", Offset = "0x44AFFC0", VA = "0x44AFFC0")] get
    {
      return new bool();
    }
    [Token(Token = "0x60004DE"), Address(RVA = "0x44AFFC8", Offset = "0x44AFFC8", VA = "0x44AFFC8")] set
    {
    }
  }

  [Token(Token = "0x17000027")]
  public ISAdQualityLogLevel LogLevel
  {
    [Token(Token = "0x60004DF"), Address(RVA = "0x44AFFD4", Offset = "0x44AFFD4", VA = "0x44AFFD4")] get
    {
      return new ISAdQualityLogLevel();
    }
    [Token(Token = "0x60004E0"), Address(RVA = "0x44AFFDC", Offset = "0x44AFFDC", VA = "0x44AFFDC")] set
    {
    }
  }

  [Token(Token = "0x17000028")]
  public ISAdQualityInitCallback AdQualityInitCallback
  {
    [Token(Token = "0x60004E1"), Address(RVA = "0x44AFFE4", Offset = "0x44AFFE4", VA = "0x44AFFE4")] get
    {
      return (ISAdQualityInitCallback) null;
    }
    [Token(Token = "0x60004E2"), Address(RVA = "0x44AFFEC", Offset = "0x44AFFEC", VA = "0x44AFFEC")] set
    {
    }
  }

  [Token(Token = "0x17000029")]
  public string InitializationSource
  {
    [Token(Token = "0x60004E3"), Address(RVA = "0x44AFFF4", Offset = "0x44AFFF4", VA = "0x44AFFF4")] get
    {
      return (string) null;
    }
    [Token(Token = "0x60004E4"), Address(RVA = "0x44AFFFC", Offset = "0x44AFFFC", VA = "0x44AFFFC")] set
    {
    }
  }

  [Token(Token = "0x1700002A")]
  public bool Coppa
  {
    [Token(Token = "0x60004E5"), Address(RVA = "0x44B0004", Offset = "0x44B0004", VA = "0x44B0004")] get
    {
      return new bool();
    }
    [Token(Token = "0x60004E6"), Address(RVA = "0x44B000C", Offset = "0x44B000C", VA = "0x44B000C")] set
    {
    }
  }

  [Token(Token = "0x1700002B")]
  public ISAdQualityDeviceIdType DeviceIdType
  {
    [Token(Token = "0x60004E7"), Address(RVA = "0x44B0018", Offset = "0x44B0018", VA = "0x44B0018")] get
    {
      return new ISAdQualityDeviceIdType();
    }
    [Token(Token = "0x60004E8"), Address(RVA = "0x44B0020", Offset = "0x44B0020", VA = "0x44B0020")] set
    {
    }
  }
}
