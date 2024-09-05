// Decompiled with JetBrains decompiler
// Type: staq.Settings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Firebase.Messaging;
using GameCore.DesignPattern;
using Il2CppDummyDll;
using System.Collections.Generic;
using System.Globalization;

#nullable disable
namespace staq
{
  [Token(Token = "0x2003C30")]
  public class Settings : Singleton<Settings>
  {
    [Token(Token = "0x4010B0D")]
    private const string UnexpectedPlatform_AppKey = "unexpected_platform";
    [Token(Token = "0x4010B11")]
    [FieldOffset(Offset = "0x20")]
    private string appKey;
    [Token(Token = "0x4010B12")]
    [FieldOffset(Offset = "0x28")]
    public List<Settings.Message> Messages;
    [Token(Token = "0x4010B13")]
    [FieldOffset(Offset = "0x30")]
    public UserData UserData;
    [Token(Token = "0x4010B14")]
    [FieldOffset(Offset = "0x38")]
    public string appVersion;
    [Token(Token = "0x4010B15")]
    [FieldOffset(Offset = "0x40")]
    public bool showGetAssetLog;
    [Token(Token = "0x4010B16")]
    [FieldOffset(Offset = "0x0")]
    public static string DMMAPIToken;

    [Token(Token = "0x17004CDB")]
    public bool IsAdSettingInitialized
    {
      [Token(Token = "0x6017A75"), Address(RVA = "0x2385980", Offset = "0x2385980", VA = "0x2385980")] get
      {
        return new bool();
      }
      [Token(Token = "0x6017A76"), Address(RVA = "0x2385988", Offset = "0x2385988", VA = "0x2385988")] private set
      {
      }
    }

    [Token(Token = "0x17004CDC")]
    public bool IsIronSourceInitialized
    {
      [Token(Token = "0x6017A77"), Address(RVA = "0x2385994", Offset = "0x2385994", VA = "0x2385994")] get
      {
        return new bool();
      }
      [Token(Token = "0x6017A78"), Address(RVA = "0x238599C", Offset = "0x238599C", VA = "0x238599C")] private set
      {
      }
    }

    [Token(Token = "0x17004CDD")]
    public string AdsUserId
    {
      [Token(Token = "0x6017A79"), Address(RVA = "0x23859A8", Offset = "0x23859A8", VA = "0x23859A8")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6017A7A"), Address(RVA = "0x23859B0", Offset = "0x23859B0", VA = "0x23859B0")] private set
      {
      }
    }

    [Token(Token = "0x6017A7B")]
    [Address(RVA = "0x23859B8", Offset = "0x23859B8", VA = "0x23859B8")]
    public void SetIronSourceAppKey(string appKey)
    {
    }

    [Token(Token = "0x6017A7C")]
    [Address(RVA = "0x2385A74", Offset = "0x2385A74", VA = "0x2385A74")]
    private void Init(string pPlayerID)
    {
    }

    [Token(Token = "0x6017A7D")]
    [Address(RVA = "0x2385BF0", Offset = "0x2385BF0", VA = "0x2385BF0")]
    public void InitIronSource()
    {
    }

    [Token(Token = "0x6017A7E")]
    [Address(RVA = "0x2385E6C", Offset = "0x2385E6C", VA = "0x2385E6C")]
    private void SdkInitializationCompletedEvent()
    {
    }

    [Token(Token = "0x17004CDE")]
    public string GitVersion
    {
      [Token(Token = "0x6017A7F"), Address(RVA = "0x2385EF4", Offset = "0x2385EF4", VA = "0x2385EF4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6017A80")]
    [Address(RVA = "0x2385EFC", Offset = "0x2385EFC", VA = "0x2385EFC")]
    public void InitBacktrace()
    {
    }

    [Token(Token = "0x6017A81")]
    [Address(RVA = "0x23860DC", Offset = "0x23860DC", VA = "0x23860DC")]
    public void OnMessageReceived(object sender, MessageReceivedEventArgs e)
    {
    }

    [Token(Token = "0x6017A82")]
    [Address(RVA = "0x2386788", Offset = "0x2386788", VA = "0x2386788")]
    public void OnTokenReceived(object sender, TokenReceivedEventArgs token)
    {
    }

    [Token(Token = "0x6017A83")]
    [Address(RVA = "0x2386814", Offset = "0x2386814", VA = "0x2386814")]
    public void InitFirebaseMessaging()
    {
    }

    [Token(Token = "0x6017A84")]
    [Address(RVA = "0x2386914", Offset = "0x2386914", VA = "0x2386914")]
    public void InitFirebase()
    {
    }

    [Token(Token = "0x17004CDF")]
    public CultureInfo cultureInfo
    {
      [Token(Token = "0x6017A85"), Address(RVA = "0x23869E4", Offset = "0x23869E4", VA = "0x23869E4")] get
      {
        return (CultureInfo) null;
      }
    }

    [Token(Token = "0x6017A86")]
    [Address(RVA = "0x2386A88", Offset = "0x2386A88", VA = "0x2386A88")]
    public void SetLanguage(string lang)
    {
    }

    [Token(Token = "0x6017A87")]
    [Address(RVA = "0x2386B1C", Offset = "0x2386B1C", VA = "0x2386B1C")]
    public Settings()
    {
    }

    [Token(Token = "0x17004CE0")]
    public bool ProxyServerRequired
    {
      [Token(Token = "0x6017A88"), Address(RVA = "0x2386C80", Offset = "0x2386C80", VA = "0x2386C80")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004CE1")]
    public string Language
    {
      [Token(Token = "0x6017A89"), Address(RVA = "0x2386E58", Offset = "0x2386E58", VA = "0x2386E58")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6017A8A")]
    [Address(RVA = "0x2386EE0", Offset = "0x2386EE0", VA = "0x2386EE0")]
    public string GetAPIUrl(string api) => (string) null;

    [Token(Token = "0x6017A8B")]
    [Address(RVA = "0x2386F2C", Offset = "0x2386F2C", VA = "0x2386F2C")]
    public static bool GetUseDLC() => new bool();

    [Token(Token = "0x6017A8C")]
    [Address(RVA = "0x2386D00", Offset = "0x2386D00", VA = "0x2386D00")]
    public Server GetGameServer() => (Server) null;

    [Token(Token = "0x6017A8D")]
    [Address(RVA = "0x2386F34", Offset = "0x2386F34", VA = "0x2386F34")]
    public Server GetProxyServer() => (Server) null;

    [Token(Token = "0x6017A8E")]
    [Address(RVA = "0x2386F04", Offset = "0x2386F04", VA = "0x2386F04")]
    public Server GetFrontendServer() => (Server) null;

    [Token(Token = "0x6017A8F")]
    [Address(RVA = "0x238746C", Offset = "0x238746C", VA = "0x238746C")]
    public Server GetBackendServer() => (Server) null;

    [Token(Token = "0x6017A90")]
    [Address(RVA = "0x2387470", Offset = "0x2387470", VA = "0x2387470")]
    public static bool GetDirectDLC() => new bool();

    [Token(Token = "0x6017A91")]
    [Address(RVA = "0x23874CC", Offset = "0x23874CC", VA = "0x23874CC")]
    public string GetDirectDLCUrl() => (string) null;

    [Token(Token = "0x17004CE2")]
    public static bool EnableSystemLog
    {
      [Token(Token = "0x6017A92"), Address(RVA = "0x2387530", Offset = "0x2387530", VA = "0x2387530")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004CE3")]
    public static bool EnableNetworkLog
    {
      [Token(Token = "0x6017A93"), Address(RVA = "0x2387604", Offset = "0x2387604", VA = "0x2387604")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004CE4")]
    public static bool EnableLoadingTime
    {
      [Token(Token = "0x6017A94"), Address(RVA = "0x23876D8", Offset = "0x23876D8", VA = "0x23876D8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6017A95")]
    [Address(RVA = "0x23876E0", Offset = "0x23876E0", VA = "0x23876E0")]
    public static List<Server> GetServers() => (List<Server>) null;

    [Token(Token = "0x6017A96")]
    [Address(RVA = "0x23870F4", Offset = "0x23870F4", VA = "0x23870F4")]
    public List<Server> GetProxyServers() => (List<Server>) null;

    [Token(Token = "0x6017A97")]
    [Address(RVA = "0x2388CE0", Offset = "0x2388CE0", VA = "0x2388CE0")]
    static Settings()
    {
    }

    [Token(Token = "0x2003C31")]
    public class AdQualitySdkInit : ISAdQualityInitCallback
    {
      [Token(Token = "0x6017A99")]
      [Address(RVA = "0x2388E40", Offset = "0x2388E40", VA = "0x2388E40", Slot = "4")]
      public void adQualitySdkInitSuccess()
      {
      }

      [Token(Token = "0x6017A9A")]
      [Address(RVA = "0x2388EA8", Offset = "0x2388EA8", VA = "0x2388EA8", Slot = "5")]
      public void adQualitySdkInitFailed(
        ISAdQualityInitError adQualitySdkInitError,
        string errorMessage)
      {
      }

      [Token(Token = "0x6017A9B")]
      [Address(RVA = "0x2385BE8", Offset = "0x2385BE8", VA = "0x2385BE8")]
      public AdQualitySdkInit()
      {
      }
    }

    [Token(Token = "0x2003C32")]
    public class Message
    {
      [Token(Token = "0x4010B17")]
      [FieldOffset(Offset = "0x10")]
      private string Title;
      [Token(Token = "0x4010B18")]
      [FieldOffset(Offset = "0x18")]
      private string Body;

      [Token(Token = "0x6017A9C")]
      [Address(RVA = "0x2388F9C", Offset = "0x2388F9C", VA = "0x2388F9C")]
      public Message()
      {
      }
    }
  }
}
