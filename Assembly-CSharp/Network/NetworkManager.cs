// Decompiled with JetBrains decompiler
// Type: Network.NetworkManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DesignPattern;
using GameCore.MasterData;
using GameCore.Popup;
using Il2CppDummyDll;
using Network.Encrypt;
using staq;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.Networking;

#nullable disable
namespace Network
{
  [Token(Token = "0x2001A07")]
  public class NetworkManager : Singleton<NetworkManager>
  {
    [Token(Token = "0x4006F63")]
    [FieldOffset(Offset = "0x0")]
    private static readonly string ConnectTypePost;
    [Token(Token = "0x4006F64")]
    [FieldOffset(Offset = "0x8")]
    private static readonly string HeaderParamDeviceOS;
    [Token(Token = "0x4006F65")]
    [FieldOffset(Offset = "0x10")]
    private static readonly string HeaderParamDlcVersion;
    [Token(Token = "0x4006F66")]
    [FieldOffset(Offset = "0x18")]
    private static readonly string HeaderParamApplicationVersion;
    [Token(Token = "0x4006F67")]
    [FieldOffset(Offset = "0x20")]
    private static readonly string HeaderParamContentType;
    [Token(Token = "0x4006F68")]
    [FieldOffset(Offset = "0x28")]
    private static readonly string HeaderParamContentTypeValue;
    [Token(Token = "0x4006F69")]
    [FieldOffset(Offset = "0x30")]
    private static readonly string HeaderParamContentTypeValueEncrypt;
    [Token(Token = "0x4006F6A")]
    [FieldOffset(Offset = "0x38")]
    private static readonly string HeaderParamStorePlatform;
    [Token(Token = "0x4006F6B")]
    [FieldOffset(Offset = "0x40")]
    private static readonly string HeaderParamAuthorization;
    [Token(Token = "0x4006F6C")]
    [FieldOffset(Offset = "0x48")]
    private static readonly string HeaderParamAuth;
    [Token(Token = "0x4006F6D")]
    [FieldOffset(Offset = "0x50")]
    private static readonly string HeaderParamRequestId;
    [Token(Token = "0x4006F6E")]
    [FieldOffset(Offset = "0x58")]
    private static readonly string HeaderParamRequestTime;
    [Token(Token = "0x4006F6F")]
    private const string ResponseHeaderServerTime = "X-GUMI-SERVER-TIME";
    [Token(Token = "0x4006F70")]
    [FieldOffset(Offset = "0x60")]
    private static readonly string HeaderParamContentTypeValueHTML;
    [Token(Token = "0x4006F71")]
    [FieldOffset(Offset = "0x68")]
    private static readonly string HeaderParamUserAgent;
    [Token(Token = "0x4006F72")]
    [FieldOffset(Offset = "0x70")]
    private static readonly string UserAgentFormat;
    [Token(Token = "0x4006F73")]
    [FieldOffset(Offset = "0x78")]
    private static readonly string UserAgentFormatNotString;
    [Token(Token = "0x4006F74")]
    [FieldOffset(Offset = "0x80")]
    private static readonly string UserAgentFormatEnd;
    [Token(Token = "0x4006F75")]
    private const string ErrorCodeRequestTimeout = "Connection Timeout";
    [Token(Token = "0x4006F77")]
    private const int RequestTimeout = 60;
    [Token(Token = "0x4006F78")]
    private const float RetrySeconds = 1f;
    [Token(Token = "0x4006F83")]
    [FieldOffset(Offset = "0x50")]
    private Session SessionInfo;
    [Token(Token = "0x4006F87")]
    [FieldOffset(Offset = "0x78")]
    private Dictionary<string, string> requestIDDic;
    [Token(Token = "0x4006F88")]
    [FieldOffset(Offset = "0x80")]
    private bool isConnecting;
    [Token(Token = "0x4006F89")]
    [FieldOffset(Offset = "0x88")]
    private ErrorMessageJson banErrorMessage;

    [Token(Token = "0x1700181B")]
    private bool ClockAdjusterBeforeOtherApiExecuted
    {
      [Token(Token = "0x6009476"), Address(RVA = "0x4D160F8", Offset = "0x4D160F8", VA = "0x4D160F8")] get
      {
        return new bool();
      }
      [Token(Token = "0x6009477"), Address(RVA = "0x4D16100", Offset = "0x4D16100", VA = "0x4D16100")] set
      {
      }
    }

    [Token(Token = "0x1700181C")]
    private string POPUP_VERSIONUP_MESSAGE
    {
      [Token(Token = "0x6009478"), Address(RVA = "0x4D1610C", Offset = "0x4D1610C", VA = "0x4D1610C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700181D")]
    private string POPUP_VERSIONUP_OFFICIALSITE
    {
      [Token(Token = "0x6009479"), Address(RVA = "0x4D16200", Offset = "0x4D16200", VA = "0x4D16200")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700181E")]
    private string POPUP_VERSIONUP_STORE
    {
      [Token(Token = "0x600947A"), Address(RVA = "0x4D16280", Offset = "0x4D16280", VA = "0x4D16280")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700181F")]
    private string POPUP_UNKNOWNERROR_MESSAGE
    {
      [Token(Token = "0x600947B"), Address(RVA = "0x4D16300", Offset = "0x4D16300", VA = "0x4D16300")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001820")]
    private string POPUP_UNKNOWNERROR_RETRY
    {
      [Token(Token = "0x600947C"), Address(RVA = "0x4D16380", Offset = "0x4D16380", VA = "0x4D16380")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001821")]
    private string POPUP_UNKNOWNERROR_RESTART
    {
      [Token(Token = "0x600947D"), Address(RVA = "0x4D16400", Offset = "0x4D16400", VA = "0x4D16400")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x14000130")]
    public event Action<NetworkErrorResult> NetworkErrorListener
    {
      [Token(Token = "0x600947E"), Address(RVA = "0x4D16480", Offset = "0x4D16480", VA = "0x4D16480")] add
      {
      }
      [Token(Token = "0x600947F"), Address(RVA = "0x4D16530", Offset = "0x4D16530", VA = "0x4D16530")] remove
      {
      }
    }

    [Token(Token = "0x17001822")]
    public string APIPath
    {
      [Token(Token = "0x6009480"), Address(RVA = "0x4D165E0", Offset = "0x4D165E0", VA = "0x4D165E0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009481"), Address(RVA = "0x4D165E8", Offset = "0x4D165E8", VA = "0x4D165E8")] private set
      {
      }
    }

    [Token(Token = "0x17001823")]
    public string Query
    {
      [Token(Token = "0x6009482"), Address(RVA = "0x4D165F0", Offset = "0x4D165F0", VA = "0x4D165F0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009483"), Address(RVA = "0x4D165F8", Offset = "0x4D165F8", VA = "0x4D165F8")] private set
      {
      }
    }

    [Token(Token = "0x17001824")]
    public RequestType RequestType
    {
      [Token(Token = "0x6009484"), Address(RVA = "0x4D16600", Offset = "0x4D16600", VA = "0x4D16600")] get
      {
        return new RequestType();
      }
      [Token(Token = "0x6009485"), Address(RVA = "0x4D16608", Offset = "0x4D16608", VA = "0x4D16608")] private set
      {
      }
    }

    [Token(Token = "0x17001825")]
    public string Json
    {
      [Token(Token = "0x6009486"), Address(RVA = "0x4D16610", Offset = "0x4D16610", VA = "0x4D16610")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009487"), Address(RVA = "0x4D16618", Offset = "0x4D16618", VA = "0x4D16618")] private set
      {
      }
    }

    [Token(Token = "0x17001826")]
    public bool IsError
    {
      [Token(Token = "0x6009488"), Address(RVA = "0x4D16620", Offset = "0x4D16620", VA = "0x4D16620")] get
      {
        return new bool();
      }
      [Token(Token = "0x6009489"), Address(RVA = "0x4D16628", Offset = "0x4D16628", VA = "0x4D16628")] private set
      {
      }
    }

    [Token(Token = "0x17001827")]
    public bool IsBanned
    {
      [Token(Token = "0x600948A"), Address(RVA = "0x4D16634", Offset = "0x4D16634", VA = "0x4D16634")] get
      {
        return new bool();
      }
      [Token(Token = "0x600948B"), Address(RVA = "0x4D1663C", Offset = "0x4D1663C", VA = "0x4D1663C")] private set
      {
      }
    }

    [Token(Token = "0x17001828")]
    public bool IsRetry
    {
      [Token(Token = "0x600948C"), Address(RVA = "0x4D16648", Offset = "0x4D16648", VA = "0x4D16648")] get
      {
        return new bool();
      }
      [Token(Token = "0x600948D"), Address(RVA = "0x4D16650", Offset = "0x4D16650", VA = "0x4D16650")] private set
      {
      }
    }

    [Token(Token = "0x17001829")]
    public int ResponseCode
    {
      [Token(Token = "0x600948E"), Address(RVA = "0x4D1665C", Offset = "0x4D1665C", VA = "0x4D1665C")] get
      {
        return new int();
      }
      [Token(Token = "0x600948F"), Address(RVA = "0x4D16664", Offset = "0x4D16664", VA = "0x4D16664")] private set
      {
      }
    }

    [Token(Token = "0x1700182A")]
    public string DownloadHandlerText
    {
      [Token(Token = "0x6009490"), Address(RVA = "0x4D1666C", Offset = "0x4D1666C", VA = "0x4D1666C")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009491"), Address(RVA = "0x4D16674", Offset = "0x4D16674", VA = "0x4D16674")] private set
      {
      }
    }

    [Token(Token = "0x1700182B")]
    public bool HasAccessToken
    {
      [Token(Token = "0x6009492"), Address(RVA = "0x4D1667C", Offset = "0x4D1667C", VA = "0x4D1667C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700182C")]
    public bool IsReturningTitle
    {
      [Token(Token = "0x6009493"), Address(RVA = "0x4D1669C", Offset = "0x4D1669C", VA = "0x4D1669C")] get
      {
        return new bool();
      }
      [Token(Token = "0x6009494"), Address(RVA = "0x4D166A4", Offset = "0x4D166A4", VA = "0x4D166A4")] private set
      {
      }
    }

    [Token(Token = "0x6009495")]
    [Address(RVA = "0x4D166B0", Offset = "0x4D166B0", VA = "0x4D166B0")]
    public void FinishReturningTitle()
    {
    }

    [Token(Token = "0x6009496")]
    [Address(RVA = "0x4D166B8", Offset = "0x4D166B8", VA = "0x4D166B8")]
    public string AppVersion() => (string) null;

    [Token(Token = "0x1700182D")]
    public string DlcVersion
    {
      [Token(Token = "0x6009497"), Address(RVA = "0x4D16708", Offset = "0x4D16708", VA = "0x4D16708")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009498"), Address(RVA = "0x4D16710", Offset = "0x4D16710", VA = "0x4D16710")] private set
      {
      }
    }

    [Token(Token = "0x1700182E")]
    private ResumeClockAdjuster ClockAdjuster
    {
      [Token(Token = "0x6009499"), Address(RVA = "0x4D16718", Offset = "0x4D16718", VA = "0x4D16718")] get
      {
        return (ResumeClockAdjuster) null;
      }
      [Token(Token = "0x600949A"), Address(RVA = "0x4D16720", Offset = "0x4D16720", VA = "0x4D16720")] set
      {
      }
    }

    [Token(Token = "0x1700182F")]
    public string DeviceID
    {
      [Token(Token = "0x600949B"), Address(RVA = "0x4D16728", Offset = "0x4D16728", VA = "0x4D16728")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001830")]
    public string SecretKey
    {
      [Token(Token = "0x600949C"), Address(RVA = "0x4D167AC", Offset = "0x4D167AC", VA = "0x4D167AC")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600949D")]
    [Address(RVA = "0x4D16830", Offset = "0x4D16830", VA = "0x4D16830")]
    public NetworkManager()
    {
    }

    [Token(Token = "0x600949E")]
    [Address(RVA = "0x4D168D0", Offset = "0x4D168D0", VA = "0x4D168D0")]
    public IEnumerator Register() => (IEnumerator) null;

    [Token(Token = "0x600949F")]
    [Address(RVA = "0x4D16938", Offset = "0x4D16938", VA = "0x4D16938")]
    public void OnRegisterDeviceID(string deviceID, string playerID)
    {
    }

    [Token(Token = "0x60094A0")]
    [Address(RVA = "0x4D16A58", Offset = "0x4D16A58", VA = "0x4D16A58")]
    public IEnumerator InheritedPlayerData(string deviceID, string playerID, Action onComplete = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60094A1")]
    [Address(RVA = "0x4D16AE0", Offset = "0x4D16AE0", VA = "0x4D16AE0")]
    public IEnumerator RequestAccessToken() => (IEnumerator) null;

    [Token(Token = "0x60094A2")]
    [Address(RVA = "0x4D16B48", Offset = "0x4D16B48", VA = "0x4D16B48")]
    public IEnumerator RetryRequestAccessToken() => (IEnumerator) null;

    [Token(Token = "0x60094A3")]
    [Address(RVA = "0x4D16BB0", Offset = "0x4D16BB0", VA = "0x4D16BB0")]
    private IEnumerator ClockAdjustAsync() => (IEnumerator) null;

    [Token(Token = "0x60094A4")]
    [Address(RVA = "0x4D16C18", Offset = "0x4D16C18", VA = "0x4D16C18")]
    public void RequestClockAdjustBeforeOtherApi()
    {
    }

    [Token(Token = "0x60094A5")]
    [Address(RVA = "0x4D16C20", Offset = "0x4D16C20", VA = "0x4D16C20")]
    private void BanErrorCheck(string apiPath, ResponseParam responseParam = default (ResponseParam))
    {
    }

    [Token(Token = "0x60094A6")]
    [Address(RVA = "0x4D16DE0", Offset = "0x4D16DE0", VA = "0x4D16DE0")]
    public IEnumerator HandleCommonError(NetworkErrorResult networkErrorResult)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60094A7")]
    [Address(RVA = "0x4D16E54", Offset = "0x4D16E54", VA = "0x4D16E54")]
    private void ReturnToTitleScene()
    {
    }

    [Token(Token = "0x60094A8")]
    [Address(RVA = "0x4D1703C", Offset = "0x4D1703C", VA = "0x4D1703C")]
    private void ReturnToTitleCallback(string sceneName)
    {
    }

    [Token(Token = "0x60094A9")]
    [Address(RVA = "0x4D17198", Offset = "0x4D17198", VA = "0x4D17198")]
    private Tuple<string, string> DeviceInfo() => (Tuple<string, string>) null;

    [Token(Token = "0x60094AA")]
    [Address(RVA = "0x4D1738C", Offset = "0x4D1738C", VA = "0x4D1738C")]
    private string GetUserAgentParam() => (string) null;

    [Token(Token = "0x60094AB")]
    [Address(RVA = "0x4D17858", Offset = "0x4D17858", VA = "0x4D17858")]
    private UnityWebRequest CreateRequest(
      RequestType requestType,
      string apiPath,
      string json,
      Settings setting,
      string url,
      bool createRequestID,
      bool isRequestEncryption,
      ref APICypher apiCypher,
      out Dictionary<string, string> headers)
    {
      return (UnityWebRequest) null;
    }

    [Token(Token = "0x60094AC")]
    [Address(RVA = "0x4D183AC", Offset = "0x4D183AC", VA = "0x4D183AC")]
    private string ResponseEncoding(
      UnityWebRequest request,
      APICypher apiCypher,
      out bool isResponseEnctyption)
    {
      return (string) null;
    }

    [Token(Token = "0x60094AD")]
    [Address(RVA = "0x4D10C44", Offset = "0x4D10C44", VA = "0x4D10C44")]
    public IEnumerator Connect(
      string apiPath,
      string query,
      RequestType requestType,
      string json,
      bool authCheck = true,
      NetworkManager.OnSuccess onSuccess = null,
      NetworkManager.OnError onError = null,
      bool createRequestID = true)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60094AE")]
    [Address(RVA = "0x4D1811C", Offset = "0x4D1811C", VA = "0x4D1811C")]
    private string GetPlatformName() => (string) null;

    [Token(Token = "0x60094AF")]
    [Address(RVA = "0x4D1815C", Offset = "0x4D1815C", VA = "0x4D1815C")]
    public string GetStorePlatformName() => (string) null;

    [Token(Token = "0x60094B0")]
    [Address(RVA = "0x4D168C8", Offset = "0x4D168C8", VA = "0x4D168C8")]
    public void ResetAccessToken()
    {
    }

    [Token(Token = "0x60094B1")]
    [Address(RVA = "0x4D18AEC", Offset = "0x4D18AEC", VA = "0x4D18AEC")]
    public void SetAccessToken(string accessToken, float expiresIn)
    {
    }

    [Token(Token = "0x60094B2")]
    [Address(RVA = "0x4D18B24", Offset = "0x4D18B24", VA = "0x4D18B24")]
    public void AccountReset()
    {
    }

    [Token(Token = "0x60094B3")]
    [Address(RVA = "0x4D18B2C", Offset = "0x4D18B2C", VA = "0x4D18B2C")]
    public bool IsAccount() => new bool();

    [Token(Token = "0x60094B4")]
    [Address(RVA = "0x4D1819C", Offset = "0x4D1819C", VA = "0x4D1819C")]
    private string RequestToString(string url, Dictionary<string, string> headers, string json)
    {
      return (string) null;
    }

    [Token(Token = "0x60094B5")]
    [Address(RVA = "0x4D18B64", Offset = "0x4D18B64", VA = "0x4D18B64")]
    private string ResponseHeadersToString(string url, Dictionary<string, string> headers)
    {
      return (string) null;
    }

    [Token(Token = "0x60094B6")]
    [Address(RVA = "0x4D18E30", Offset = "0x4D18E30", VA = "0x4D18E30")]
    private IEnumerator ShowAuthenticationDeviceRevokedPopup() => (IEnumerator) null;

    [Token(Token = "0x60094B7")]
    [Address(RVA = "0x4D18E90", Offset = "0x4D18E90", VA = "0x4D18E90")]
    private IEnumerator ShowServerMaintenancePopup() => (IEnumerator) null;

    [Token(Token = "0x60094B8")]
    [Address(RVA = "0x4D18EF8", Offset = "0x4D18EF8", VA = "0x4D18EF8")]
    private IEnumerator ShowApplicationVersionErrorPopup() => (IEnumerator) null;

    [Token(Token = "0x60094B9")]
    [Address(RVA = "0x4D18F60", Offset = "0x4D18F60", VA = "0x4D18F60")]
    private IEnumerator ShowCommunicationErrorPopup() => (IEnumerator) null;

    [Token(Token = "0x60094BA")]
    [Address(RVA = "0x4D18FC0", Offset = "0x4D18FC0", VA = "0x4D18FC0")]
    private IEnumerator ShowUnknownErrorPopup(
      string code,
      UnityAction<CommonPopup.ButtonType> callback)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60094BB")]
    [Address(RVA = "0x4D1903C", Offset = "0x4D1903C", VA = "0x4D1903C")]
    private IEnumerator ShowBanPopup(bool returnTitle = true) => (IEnumerator) null;

    [Token(Token = "0x60094BC")]
    [Address(RVA = "0x4D14F98", Offset = "0x4D14F98", VA = "0x4D14F98")]
    public void ResetConnectState()
    {
    }

    [Token(Token = "0x60094BD")]
    [Address(RVA = "0x4D15230", Offset = "0x4D15230", VA = "0x4D15230")]
    public void RetrySet(bool retry = true)
    {
    }

    [Token(Token = "0x60094BE")]
    [Address(RVA = "0x4D190B8", Offset = "0x4D190B8", VA = "0x4D190B8")]
    public INetworkErrorData GetErrorData(
      string errorCode,
      string apiPath,
      long httpStatus,
      int extraStatus)
    {
      return (INetworkErrorData) null;
    }

    [Token(Token = "0x60094BF")]
    [Address(RVA = "0x4D1926C", Offset = "0x4D1926C", VA = "0x4D1926C")]
    static NetworkManager()
    {
    }

    [Token(Token = "0x2001A08")]
    public delegate IEnumerator OnError(NetworkErrorResult networkErrorResult);

    [Token(Token = "0x2001A09")]
    public delegate void OnSuccess(string json);

    [Token(Token = "0x2001A0A")]
    private class DisposeAction : IDisposable
    {
      [Token(Token = "0x4006F8A")]
      [FieldOffset(Offset = "0x10")]
      private Action OnDispose;

      [Token(Token = "0x60094CA")]
      [Address(RVA = "0x4D195C8", Offset = "0x4D195C8", VA = "0x4D195C8")]
      public DisposeAction(Action onDispose)
      {
      }

      [Token(Token = "0x60094CB")]
      [Address(RVA = "0x4D195F0", Offset = "0x4D195F0", VA = "0x4D195F0", Slot = "4")]
      public void Dispose()
      {
      }
    }
  }
}
