// Decompiled with JetBrains decompiler
// Type: KPI.StandardKPI.StandardKPIUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace KPI.StandardKPI
{
  [Token(Token = "0x2000A73")]
  public static class StandardKPIUtility
  {
    [Token(Token = "0x4003068")]
    [FieldOffset(Offset = "0x0")]
    public static readonly string GameId;
    [Token(Token = "0x4003069")]
    [FieldOffset(Offset = "0x8")]
    public static readonly string StandardKPIShemaVersion;
    [Token(Token = "0x400306A")]
    [FieldOffset(Offset = "0x10")]
    public static readonly string DefaultWorldId;
    [Token(Token = "0x400306B")]
    [FieldOffset(Offset = "0x18")]
    public static readonly string DefaultAvatarId;

    [Token(Token = "0x6003B49")]
    [Address(RVA = "0x331C81C", Offset = "0x331C81C", VA = "0x331C81C")]
    public static string GetGameId() => (string) null;

    [Token(Token = "0x6003B4A")]
    [Address(RVA = "0x331C874", Offset = "0x331C874", VA = "0x331C874")]
    public static string GetEnvironment() => (string) null;

    [Token(Token = "0x6003B4B")]
    [Address(RVA = "0x331C8D0", Offset = "0x331C8D0", VA = "0x331C8D0")]
    public static string GetWorldId() => (string) null;

    [Token(Token = "0x6003B4C")]
    [Address(RVA = "0x331C928", Offset = "0x331C928", VA = "0x331C928")]
    public static string GetPlayerId() => (string) null;

    [Token(Token = "0x6003B4D")]
    [Address(RVA = "0x331C9AC", Offset = "0x331C9AC", VA = "0x331C9AC")]
    public static string GetDeviceId() => (string) null;

    [Token(Token = "0x6003B4E")]
    [Address(RVA = "0x331CA30", Offset = "0x331CA30", VA = "0x331CA30")]
    public static string GetAvatarId() => (string) null;

    [Token(Token = "0x6003B4F")]
    [Address(RVA = "0x331CA88", Offset = "0x331CA88", VA = "0x331CA88")]
    public static string GetStorePlatform() => (string) null;

    [Token(Token = "0x6003B50")]
    [Address(RVA = "0x331CAD8", Offset = "0x331CAD8", VA = "0x331CAD8")]
    public static string GetDeviceOS() => (string) null;

    [Token(Token = "0x6003B51")]
    [Address(RVA = "0x331CAE0", Offset = "0x331CAE0", VA = "0x331CAE0")]
    public static string ToStandardKPIJson(StandardKPILogParamBase body) => (string) null;

    [Token(Token = "0x6003B52")]
    [Address(RVA = "0x331CB9C", Offset = "0x331CB9C", VA = "0x331CB9C")]
    public static void Initialize()
    {
    }

    [Token(Token = "0x6003B53")]
    [Address(RVA = "0x331CE08", Offset = "0x331CE08", VA = "0x331CE08")]
    static StandardKPIUtility()
    {
    }
  }
}
