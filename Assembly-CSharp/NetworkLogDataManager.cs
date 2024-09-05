// Decompiled with JetBrains decompiler
// Type: NetworkLogDataManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine.Networking;

#nullable disable
[Token(Token = "0x2000232")]
public class NetworkLogDataManager
{
  [Token(Token = "0x4000D03")]
  [FieldOffset(Offset = "0x0")]
  private static NetworkLogDataManager instance;
  [Token(Token = "0x4000D04")]
  [FieldOffset(Offset = "0x10")]
  private List<NetworkLogData> NetworkLogs;
  [Token(Token = "0x4000D05")]
  [FieldOffset(Offset = "0x18")]
  private Action<NetworkLogData> networkLogReceived;
  [Token(Token = "0x4000D06")]
  [FieldOffset(Offset = "0x20")]
  public Action NetworkLogCleared;

  [Token(Token = "0x17000134")]
  public static NetworkLogDataManager Instance
  {
    [Token(Token = "0x6000DE0"), Address(RVA = "0x1C88C90", Offset = "0x1C88C90", VA = "0x1C88C90")] get
    {
      return (NetworkLogDataManager) null;
    }
  }

  [Token(Token = "0x140000E0")]
  public event Action<NetworkLogData> NetworkLogReceived
  {
    [Token(Token = "0x6000DE1"), Address(RVA = "0x1C88D84", Offset = "0x1C88D84", VA = "0x1C88D84")] add
    {
    }
    [Token(Token = "0x6000DE2"), Address(RVA = "0x1C88F4C", Offset = "0x1C88F4C", VA = "0x1C88F4C")] remove
    {
    }
  }

  [Token(Token = "0x6000DE3")]
  [Address(RVA = "0x1C88FF4", Offset = "0x1C88FF4", VA = "0x1C88FF4")]
  public void Clear()
  {
  }

  [Token(Token = "0x6000DE4")]
  [Address(RVA = "0x1C8907C", Offset = "0x1C8907C", VA = "0x1C8907C")]
  public void AddNetworkLogError(
    UnityWebRequest unityWebRequest,
    bool requestEnctypted,
    bool responseEnctypted,
    string requestBody,
    string responseBody,
    string errorCode,
    Dictionary<string, string> requestHeaders,
    TimeSpan elapsedTime)
  {
  }

  [Token(Token = "0x6000DE5")]
  [Address(RVA = "0x1C89084", Offset = "0x1C89084", VA = "0x1C89084")]
  public void AddNetworkLog(
    UnityWebRequest unityWebRequest,
    bool requestEnctypted,
    bool responseEnctypted,
    string requestBody,
    string responseBody,
    string errorCode,
    Dictionary<string, string> requestHeaders,
    TimeSpan elapsedTime)
  {
  }

  [Token(Token = "0x6000DE6")]
  [Address(RVA = "0x1C89080", Offset = "0x1C89080", VA = "0x1C89080")]
  private void AddNetworkLog(
    UnityWebRequest unityWebRequest,
    bool isError,
    bool requestEnctypted,
    bool responseEnctypted,
    string requestBody,
    string responseBody,
    string errorCode,
    Dictionary<string, string> requestHeaders,
    TimeSpan elapsedTime)
  {
  }

  [Token(Token = "0x6000DE7")]
  [Address(RVA = "0x1C89088", Offset = "0x1C89088", VA = "0x1C89088")]
  private void AddNetworkLog(
    string url,
    bool isError,
    NetworkLogCustomFieldInfo requestCustomFields,
    Dictionary<string, string> requestHeaders,
    string requestBody,
    NetworkLogCustomFieldInfo responseCustomFields,
    Dictionary<string, string> responseHeaders,
    string responseBody,
    TimeSpan elapsedTime)
  {
  }

  [Token(Token = "0x6000DE8")]
  [Address(RVA = "0x1C88D08", Offset = "0x1C88D08", VA = "0x1C88D08")]
  public NetworkLogDataManager()
  {
  }
}
