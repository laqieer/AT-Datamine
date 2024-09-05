// Decompiled with JetBrains decompiler
// Type: DataLinkage.IDPassword.DataLinkConnector
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
namespace DataLinkage.IDPassword
{
  [Token(Token = "0x2001F9B")]
  public class DataLinkConnector : DataLinkConnectorBase
  {
    [Token(Token = "0x600BBA5")]
    [Address(RVA = "0x1E48A60", Offset = "0x1E48A60", VA = "0x1E48A60")]
    public DataLinkConnector(MonoBehaviour coroutineRunner)
    {
    }

    [Token(Token = "0x600BBA6")]
    [Address(RVA = "0x1E4EB90", Offset = "0x1E4EB90", VA = "0x1E4EB90")]
    public void RequestRegister(
      string userId,
      string secretKey,
      Action<APIDascIDPasswordRegisterResponse> onSuccess,
      DataLinkConnector.ErrorHandler.OnErrorEvent onError)
    {
    }

    [Token(Token = "0x600BBA7")]
    [Address(RVA = "0x1E4EC44", Offset = "0x1E4EC44", VA = "0x1E4EC44")]
    public void RequestDeleteUser(
      string userId,
      string secretKey,
      Action<APIDascIDPasswordDeleteUserResponse> onSuccess,
      DataLinkConnector.ErrorHandler.OnErrorEvent onError)
    {
    }

    [Token(Token = "0x600BBA8")]
    [Address(RVA = "0x1E4ECF8", Offset = "0x1E4ECF8", VA = "0x1E4ECF8")]
    public void RequestAddDevice(
      string secretKey,
      APIDascIDPasswordConnectInfo connectInfo,
      Action<APIDascIDPasswordAddDeviceResponse> onSuccess,
      DataLinkConnector.ErrorHandler.OnErrorEvent onError,
      Action onFinished)
    {
    }

    [Token(Token = "0x600BBA9")]
    [Address(RVA = "0x1E4EDB4", Offset = "0x1E4EDB4", VA = "0x1E4EDB4")]
    public void RequestConnect(
      string secretKey,
      string deviceID,
      APIDascIDPasswordConnectInfo connectInfo,
      Action<APIDascIDPasswordConnectResponse> onSuccess,
      DataLinkConnector.ErrorHandler.OnErrorEvent onError)
    {
    }

    [Token(Token = "0x600BBAA")]
    [Address(RVA = "0x1E4EE70", Offset = "0x1E4EE70", VA = "0x1E4EE70")]
    public void RequestDisconnect(
      string secretKey,
      string deviceID,
      APIDascIDPasswordConnectInfo connectInfo,
      Action<APIDascIDPasswordDisconnectResponse> onSuccess,
      DataLinkConnector.ErrorHandler.OnErrorEvent onError)
    {
    }

    [Token(Token = "0x600BBAB")]
    [Address(RVA = "0x1E4EF2C", Offset = "0x1E4EF2C", VA = "0x1E4EF2C")]
    public void RequestAPIMissionDatalink(Action<APIMissionData_linkResponse> onSuccess)
    {
    }

    [Token(Token = "0x600BBAC")]
    [Address(RVA = "0x1E4EBBC", Offset = "0x1E4EBBC", VA = "0x1E4EBBC")]
    private IEnumerator RequestRegisterAsync(
      string userId,
      string secretKey,
      Action<APIDascIDPasswordRegisterResponse> onSuccess,
      DataLinkConnector.ErrorHandler.OnErrorEvent onError)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600BBAD")]
    [Address(RVA = "0x1E4EC70", Offset = "0x1E4EC70", VA = "0x1E4EC70")]
    private IEnumerator RequestDeleteUserAsync(
      string userId,
      string secretKey,
      Action<APIDascIDPasswordDeleteUserResponse> onSuccess,
      DataLinkConnector.ErrorHandler.OnErrorEvent onError)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600BBAE")]
    [Address(RVA = "0x1E4EDE0", Offset = "0x1E4EDE0", VA = "0x1E4EDE0")]
    private IEnumerator RequestConnectAsync(
      string secretKey,
      string deviceID,
      APIDascIDPasswordConnectInfo connectInfo,
      Action<APIDascIDPasswordConnectResponse> onSuccess,
      DataLinkConnector.ErrorHandler.OnErrorEvent onError)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600BBAF")]
    [Address(RVA = "0x1E4EE9C", Offset = "0x1E4EE9C", VA = "0x1E4EE9C")]
    private IEnumerator RequestDisconnectAsync(
      string secretKey,
      string deviceID,
      APIDascIDPasswordConnectInfo connectInfo,
      Action<APIDascIDPasswordDisconnectResponse> onSuccess,
      DataLinkConnector.ErrorHandler.OnErrorEvent onError)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600BBB0")]
    [Address(RVA = "0x1E4ED24", Offset = "0x1E4ED24", VA = "0x1E4ED24")]
    private IEnumerator RequestAddDeviceAsync(
      string secretKey,
      APIDascIDPasswordConnectInfo connectInfo,
      Action<APIDascIDPasswordAddDeviceResponse> onSuccess,
      DataLinkConnector.ErrorHandler.OnErrorEvent onError,
      Action onFinished)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x2001F9C")]
    public class ErrorHandler
    {
      [Token(Token = "0x4008718")]
      [FieldOffset(Offset = "0x10")]
      private DataLinkConnector.ErrorHandler.OnErrorEvent onError;
      [Token(Token = "0x4008719")]
      [FieldOffset(Offset = "0x18")]
      private HashSet<string> ErrorCode;

      [Token(Token = "0x600BBB1")]
      [Address(RVA = "0x1E4F028", Offset = "0x1E4F028", VA = "0x1E4F028")]
      public ErrorHandler(
        DataLinkConnector.ErrorHandler.OnErrorEvent onError)
      {
      }

      [Token(Token = "0x600BBB2")]
      [Address(RVA = "0x1E4F11C", Offset = "0x1E4F11C", VA = "0x1E4F11C")]
      public IEnumerator OnError(NetworkErrorResult networkErrorResult) => (IEnumerator) null;

      [Token(Token = "0x2001F9D")]
      public struct ErrorData
      {
        [Token(Token = "0x170026DB")]
        public string Code
        {
          [Token(Token = "0x600BBB3"), Address(RVA = "0x1E4F1B8", Offset = "0x1E4F1B8", VA = "0x1E4F1B8")] readonly get
          {
            return (string) null;
          }
          [Token(Token = "0x600BBB4"), Address(RVA = "0x1E4F1C0", Offset = "0x1E4F1C0", VA = "0x1E4F1C0")] private set
          {
          }
        }

        [Token(Token = "0x600BBB5")]
        [Address(RVA = "0x1E4F1C8", Offset = "0x1E4F1C8", VA = "0x1E4F1C8")]
        public ErrorData(string errorCode)
        {
        }
      }

      [Token(Token = "0x2001F9E")]
      public delegate IEnumerator OnErrorEvent(DataLinkConnector.ErrorHandler.ErrorData result);
    }
  }
}
