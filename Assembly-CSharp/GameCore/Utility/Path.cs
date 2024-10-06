// Decompiled with JetBrains decompiler
// Type: GameCore.Utility.Path
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace GameCore.Utility
{
  [Token(Token = "0x2000BD0")]
  public static class Path
  {
    [Token(Token = "0x40035CF")]
    [FieldOffset(Offset = "0x0")]
    private static readonly string PersistDirName;
    [Token(Token = "0x40035D0")]
    [FieldOffset(Offset = "0x8")]
    private static readonly string IgnoreDeleteOnAccountRecreateDirName;
    [Token(Token = "0x40035D1")]
    [FieldOffset(Offset = "0x10")]
    private static readonly string AssetBundleDirName;
    [Token(Token = "0x40035D2")]
    [FieldOffset(Offset = "0x18")]
    private static string AndroidPersistentDataPath;

    [Token(Token = "0x6004392")]
    [Address(RVA = "0x36411F8", Offset = "0x36411F8", VA = "0x36411F8")]
    public static string GetPlatformFolderForAssetBundles() => (string) null;

    [Token(Token = "0x6004393")]
    [Address(RVA = "0x364130C", Offset = "0x364130C", VA = "0x364130C")]
    public static string GetLocalPersistPath() => (string) null;

    [Token(Token = "0x6004394")]
    [Address(RVA = "0x3641964", Offset = "0x3641964", VA = "0x3641964")]
    public static string GetLocalNotPlayerPersistPath() => (string) null;

    [Token(Token = "0x6004395")]
    [Address(RVA = "0x36419C4", Offset = "0x36419C4", VA = "0x36419C4")]
    public static string GetLocalIgnoreDeleteOnAccountRecreatePath() => (string) null;

    [Token(Token = "0x6004396")]
    [Address(RVA = "0x3641A24", Offset = "0x3641A24", VA = "0x3641A24")]
    public static string GetHashOfAssetBundleLabel(string labelName) => (string) null;

    [Token(Token = "0x6004397")]
    [Address(RVA = "0x3641A98", Offset = "0x3641A98", VA = "0x3641A98")]
    public static string GetLocalAssetBundlePath() => (string) null;

    [Token(Token = "0x6004398")]
    [Address(RVA = "0x3641AF8", Offset = "0x3641AF8", VA = "0x3641AF8")]
    public static string GetLocalStremingAssetsPath() => (string) null;

    [Token(Token = "0x6004399")]
    [Address(RVA = "0x3641B40", Offset = "0x3641B40", VA = "0x3641B40")]
    public static string GetAndroidHiddenStoragePath() => (string) null;

    [Token(Token = "0x600439A")]
    [Address(RVA = "0x3641258", Offset = "0x3641258", VA = "0x3641258")]
    public static string GetPlatformFolderForAssetBundles(RuntimePlatform platform)
    {
      return (string) null;
    }

    [Token(Token = "0x170009D3")]
    public static string PersistentDataPath
    {
      [Token(Token = "0x600439B"), Address(RVA = "0x364136C", Offset = "0x364136C", VA = "0x364136C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170009D4")]
    public static string TemporaryCachePath
    {
      [Token(Token = "0x600439C"), Address(RVA = "0x3642094", Offset = "0x3642094", VA = "0x3642094")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170009D5")]
    public static string DataPath
    {
      [Token(Token = "0x600439D"), Address(RVA = "0x364209C", Offset = "0x364209C", VA = "0x364209C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170009D6")]
    public static string StreamingAssetsPath
    {
      [Token(Token = "0x600439E"), Address(RVA = "0x36420A4", Offset = "0x36420A4", VA = "0x36420A4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600439F")]
    [Address(RVA = "0x36420AC", Offset = "0x36420AC", VA = "0x36420AC")]
    static Path()
    {
    }
  }
}
