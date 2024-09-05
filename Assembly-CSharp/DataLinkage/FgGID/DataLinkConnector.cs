// Decompiled with JetBrains decompiler
// Type: DataLinkage.FgGID.DataLinkConnector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network;
using Network.API;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace DataLinkage.FgGID
{
  [Token(Token = "0x2001FBB")]
  public class DataLinkConnector : DataLinkConnectorBase, IDisposable
  {
    [Token(Token = "0x4008784")]
    private const string FgGIDLoginAPIPath = "dasc/pass/fggid/v1/login";
    [Token(Token = "0x4008785")]
    [FieldOffset(Offset = "0x18")]
    private DeepLinkEventListener fgGIDDeepLinkEventListener;
    [Token(Token = "0x4008786")]
    [FieldOffset(Offset = "0x20")]
    private OpenUrlHandler openUrlHandler;

    [Token(Token = "0x170026F6")]
    private string CallbackScheme
    {
      [Token(Token = "0x600BC63"), Address(RVA = "0x1E52E18", Offset = "0x1E52E18", VA = "0x1E52E18")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600BC64")]
    [Address(RVA = "0x1E48988", Offset = "0x1E48988", VA = "0x1E48988")]
    public DataLinkConnector(
      MonoBehaviour coroutineRunner,
      DeepLinkEventDispatcher deepLinkEventDispatcher,
      OpenUrlHandler openUrlHandler)
    {
    }

    [Token(Token = "0x600BC65")]
    [Address(RVA = "0x1E52E84", Offset = "0x1E52E84", VA = "0x1E52E84")]
    public void RequestLogin(Action<LoginResultData> onLogin)
    {
    }

    [Token(Token = "0x600BC66")]
    [Address(RVA = "0x1E5310C", Offset = "0x1E5310C", VA = "0x1E5310C")]
    public void RequestToken(
      string code,
      string state,
      Action<APIDascFgGIDTokenResponse> onSuccess,
      DataLinkConnector.ErrorHandler.OnErrorEvent onError)
    {
    }

    [Token(Token = "0x600BC67")]
    [Address(RVA = "0x1E531C0", Offset = "0x1E531C0", VA = "0x1E531C0")]
    public void RequestAddDevice(
      string secretKey,
      APIDascFgGIDConnectInfo connectInfo,
      Action<APIDascFgGIDAddDeviceResponse> onSuccess,
      DataLinkConnector.ErrorHandler.OnErrorEvent onError)
    {
    }

    [Token(Token = "0x600BC68")]
    [Address(RVA = "0x1E53274", Offset = "0x1E53274", VA = "0x1E53274")]
    public void RequestConnect(
      string secretKey,
      string deviceID,
      APIDascFgGIDConnectInfo connectInfo,
      Action<APIDascFgGIDConnectResponse> onSuccess,
      DataLinkConnector.ErrorHandler.OnErrorEvent onError)
    {
    }

    [Token(Token = "0x600BC69")]
    [Address(RVA = "0x1E53330", Offset = "0x1E53330", VA = "0x1E53330")]
    public void RequestDisconnect(
      string secretKey,
      string deviceID,
      APIDascFgGIDConnectInfo connectInfo,
      Action<APIDascFgGIDDisconnectResponse> onSuccess,
      DataLinkConnector.ErrorHandler.OnErrorEvent onError)
    {
    }

    [Token(Token = "0x600BC6A")]
    [Address(RVA = "0x1E533EC", Offset = "0x1E533EC", VA = "0x1E533EC")]
    public void RequestAPIMissionDatalink(Action<APIMissionData_linkResponse> onSuccess)
    {
    }

    [Token(Token = "0x600BC6B")]
    [Address(RVA = "0x1E53138", Offset = "0x1E53138", VA = "0x1E53138")]
    private IEnumerator RequestTokenAsync(
      string code,
      string state,
      Action<APIDascFgGIDTokenResponse> onSuccess,
      DataLinkConnector.ErrorHandler.OnErrorEvent onError)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600BC6C")]
    [Address(RVA = "0x1E532A0", Offset = "0x1E532A0", VA = "0x1E532A0")]
    private IEnumerator RequestConnectAsync(
      string secretKey,
      string deviceID,
      APIDascFgGIDConnectInfo connectInfo,
      Action<APIDascFgGIDConnectResponse> onSuccess,
      DataLinkConnector.ErrorHandler.OnErrorEvent onError)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600BC6D")]
    [Address(RVA = "0x1E5335C", Offset = "0x1E5335C", VA = "0x1E5335C")]
    private IEnumerator RequestDisconnectAsync(
      string secretKey,
      string deviceID,
      APIDascFgGIDConnectInfo connectInfo,
      Action<APIDascFgGIDDisconnectResponse> onSuccess,
      DataLinkConnector.ErrorHandler.OnErrorEvent onError)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600BC6E")]
    [Address(RVA = "0x1E531EC", Offset = "0x1E531EC", VA = "0x1E531EC")]
    private IEnumerator RequestAddDeviceAsync(
      string secretKey,
      APIDascFgGIDConnectInfo connectInfo,
      Action<APIDascFgGIDAddDeviceResponse> onSuccess,
      DataLinkConnector.ErrorHandler.OnErrorEvent onError)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600BC6F")]
    [Address(RVA = "0x1E534C0", Offset = "0x1E534C0", VA = "0x1E534C0", Slot = "4")]
    public void Dispose()
    {
    }

    [Token(Token = "0x2001FBC")]
    public class ErrorHandler
    {
      [Token(Token = "0x4008787")]
      [FieldOffset(Offset = "0x10")]
      private DataLinkConnector.ErrorHandler.OnErrorEvent onError;
      [Token(Token = "0x4008788")]
      [FieldOffset(Offset = "0x18")]
      private HashSet<string> ErrorCode;

      [Token(Token = "0x600BC70")]
      [Address(RVA = "0x1E534E4", Offset = "0x1E534E4", VA = "0x1E534E4")]
      public ErrorHandler(
        DataLinkConnector.ErrorHandler.OnErrorEvent onError)
      {
      }

      [Token(Token = "0x600BC71")]
      [Address(RVA = "0x1E535FC", Offset = "0x1E535FC", VA = "0x1E535FC")]
      public IEnumerator OnError(NetworkErrorResult networkErrorResult) => (IEnumerator) null;

      [Token(Token = "0x2001FBD")]
      public struct ErrorData
      {
        [Token(Token = "0x170026F7")]
        public string Code
        {
          [Token(Token = "0x600BC72"), Address(RVA = "0x1E53698", Offset = "0x1E53698", VA = "0x1E53698")] readonly get
          {
            return (string) null;
          }
          [Token(Token = "0x600BC73"), Address(RVA = "0x1E536A0", Offset = "0x1E536A0", VA = "0x1E536A0")] private set
          {
          }
        }

        [Token(Token = "0x600BC74")]
        [Address(RVA = "0x1E536A8", Offset = "0x1E536A8", VA = "0x1E536A8")]
        public ErrorData(string errorCode)
        {
        }
      }

      [Token(Token = "0x2001FBE")]
      public delegate IEnumerator OnErrorEvent(DataLinkConnector.ErrorHandler.ErrorData result);
    }
  }
}
