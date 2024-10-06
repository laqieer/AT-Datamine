// Decompiled with JetBrains decompiler
// Type: GameCore.RawData.RawDataManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

#nullable disable
namespace GameCore.RawData
{
  [Token(Token = "0x2000CB3")]
  public static class RawDataManager
  {
    [Token(Token = "0x4003925")]
    [FieldOffset(Offset = "0x0")]
    private static UpdateTimestamps updateTimestamps;
    [Token(Token = "0x4003926")]
    [FieldOffset(Offset = "0x8")]
    private static DateTime nextCheckTime;
    [Token(Token = "0x4003927")]
    [FieldOffset(Offset = "0x10")]
    private static readonly string localTimestampsJson;
    [Token(Token = "0x4003928")]
    [FieldOffset(Offset = "0x18")]
    private static readonly string serverTimestampsJson;
    [Token(Token = "0x4003929")]
    private const int NextCheckInterbalMin = 3;
    [Token(Token = "0x400392A")]
    private const int InitializeCacheErrorRetryCount = 3;
    [Token(Token = "0x400392B")]
    [FieldOffset(Offset = "0x20")]
    private static UnityWebRequest downloadRequest;

    [Token(Token = "0x600493A")]
    [Address(RVA = "0x3135A88", Offset = "0x3135A88", VA = "0x3135A88")]
    public static IEnumerator InitializeCache() => (IEnumerator) null;

    [Token(Token = "0x600493B")]
    [Address(RVA = "0x3135B10", Offset = "0x3135B10", VA = "0x3135B10")]
    public static IEnumerator GetTextureRawData(string uri0, Action<Texture2D> callback)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600493C")]
    [Address(RVA = "0x3135BAC", Offset = "0x3135BAC", VA = "0x3135BAC")]
    public static void GetTextureRawDataAsync(string uri0, Action<Texture2D> callback)
    {
    }

    [Token(Token = "0x600493D")]
    [Address(RVA = "0x3136668", Offset = "0x3136668", VA = "0x3136668")]
    public static IEnumerator GetMovieRawData(string uri, Action<MovieData> result)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600493E")]
    [Address(RVA = "0x3136704", Offset = "0x3136704", VA = "0x3136704")]
    public static void GetMovieRawDataAsync(
      string uri,
      Action<MovieData> endCallback,
      Action startCallback = null)
    {
    }

    [Token(Token = "0x600493F")]
    [Address(RVA = "0x3136C58", Offset = "0x3136C58", VA = "0x3136C58")]
    private static void GetMovieRawDataFromServer(
      string uri,
      Action<MovieData> callback,
      Action startCallback = null)
    {
    }

    [Token(Token = "0x6004940")]
    [Address(RVA = "0x3136F14", Offset = "0x3136F14", VA = "0x3136F14")]
    public static float DownloadProgress() => new float();

    [Token(Token = "0x6004941")]
    [Address(RVA = "0x3136FA8", Offset = "0x3136FA8", VA = "0x3136FA8")]
    public static void DeleteImageCache()
    {
    }

    [Token(Token = "0x6004942")]
    [Address(RVA = "0x3137308", Offset = "0x3137308", VA = "0x3137308")]
    public static void DeleteMovieCache()
    {
    }

    [Token(Token = "0x6004943")]
    [Address(RVA = "0x313719C", Offset = "0x313719C", VA = "0x313719C")]
    private static UpdateTimestamps LoadUpdateTimestamp() => (UpdateTimestamps) null;

    [Token(Token = "0x6004944")]
    [Address(RVA = "0x31375B8", Offset = "0x31375B8", VA = "0x31375B8")]
    private static void SaveUpdateTimestamp()
    {
    }

    [Token(Token = "0x6004945")]
    [Address(RVA = "0x3137628", Offset = "0x3137628", VA = "0x3137628")]
    private static void GetUpdateTimestamp(Action<UpdateTimestamps> callback)
    {
    }

    [Token(Token = "0x6004946")]
    [Address(RVA = "0x3136300", Offset = "0x3136300", VA = "0x3136300")]
    private static void DeleteImageCacheCheckTimestamp(string imageCategory, Action<bool> callback)
    {
    }

    [Token(Token = "0x6004947")]
    [Address(RVA = "0x3136AD0", Offset = "0x3136AD0", VA = "0x3136AD0")]
    private static void DeleteMovieCacheCheckTimestamp(string movieCategory, Action<bool> callback)
    {
    }

    [Token(Token = "0x6004948")]
    [Address(RVA = "0x3137738", Offset = "0x3137738", VA = "0x3137738")]
    private static string GetRealUri(string uri0) => (string) null;

    [Token(Token = "0x6004949")]
    [Address(RVA = "0x3135EF0", Offset = "0x3135EF0", VA = "0x3135EF0")]
    private static string GetImageAssetBundleName(string uri0) => (string) null;

    [Token(Token = "0x600494A")]
    [Address(RVA = "0x31378D8", Offset = "0x31378D8", VA = "0x31378D8")]
    private static string GetImageCacheFileName(string uri0) => (string) null;

    [Token(Token = "0x600494B")]
    [Address(RVA = "0x313619C", Offset = "0x313619C", VA = "0x313619C")]
    private static string GetImageCategory(string uri) => (string) null;

    [Token(Token = "0x600494C")]
    [Address(RVA = "0x3137A38", Offset = "0x3137A38", VA = "0x3137A38")]
    private static string GetMovieCacheFileName(string uri0) => (string) null;

    [Token(Token = "0x600494D")]
    [Address(RVA = "0x31369AC", Offset = "0x31369AC", VA = "0x31369AC")]
    private static string GetMovieCategory(string uri) => (string) null;

    [Token(Token = "0x600494E")]
    [Address(RVA = "0x3137B9C", Offset = "0x3137B9C", VA = "0x3137B9C")]
    private static Texture2D GetTextureRawDataFromLocal(string uri0) => (Texture2D) null;

    [Token(Token = "0x600494F")]
    [Address(RVA = "0x3136488", Offset = "0x3136488", VA = "0x3136488")]
    private static void GetTextureRawDataFromServer(string uri0, Action<Texture2D> callback)
    {
    }

    [Token(Token = "0x6004950")]
    [Address(RVA = "0x313605C", Offset = "0x313605C", VA = "0x313605C")]
    private static string GetImageCachePath(string uri0) => (string) null;

    [Token(Token = "0x6004951")]
    [Address(RVA = "0x313724C", Offset = "0x313724C", VA = "0x313724C")]
    private static void ImageCacheDelete(string imageCategory)
    {
    }

    [Token(Token = "0x6004952")]
    [Address(RVA = "0x3136874", Offset = "0x3136874", VA = "0x3136874")]
    public static string GetMovieCachePath(string uri0) => (string) null;

    [Token(Token = "0x6004953")]
    [Address(RVA = "0x31374FC", Offset = "0x31374FC", VA = "0x31374FC")]
    private static void MovieCacheDelete(string movieCategory)
    {
    }

    [Token(Token = "0x6004954")]
    [Address(RVA = "0x3137CE4", Offset = "0x3137CE4", VA = "0x3137CE4")]
    static RawDataManager()
    {
    }
  }
}
