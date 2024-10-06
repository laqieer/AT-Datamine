// Decompiled with JetBrains decompiler
// Type: Connection.NetworkQueue
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DesignPattern;
using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Connection
{
  [Token(Token = "0x20021CA")]
  public class NetworkQueue : SingletonMonoBehaviour<NetworkQueue>
  {
    [Token(Token = "0x4008F16")]
    [FieldOffset(Offset = "0x20")]
    private NetworkQueue.ConnectNode connectingStartNode;

    [Token(Token = "0x600CE73")]
    [Address(RVA = "0x4B644F4", Offset = "0x4B644F4", VA = "0x4B644F4")]
    public void Request(
      object obj,
      NetworkQueue.ApiConnectSequence seq,
      NetworkQueue.ApiStartCallback start,
      NetworkQueue.ApiEndedCallback ended)
    {
    }

    [Token(Token = "0x600CE74")]
    [Address(RVA = "0x4B649FC", Offset = "0x4B649FC", VA = "0x4B649FC")]
    public void Request(NetworkQueue.IConnectSequence sequence, NetworkQueue.IApiEvent apiEvent)
    {
    }

    [Token(Token = "0x600CE75")]
    [Address(RVA = "0x4B64C0C", Offset = "0x4B64C0C", VA = "0x4B64C0C")]
    public bool IsNetworkQueueing() => new bool();

    [Token(Token = "0x600CE76")]
    [Address(RVA = "0x4B64C1C", Offset = "0x4B64C1C", VA = "0x4B64C1C")]
    public NetworkQueue()
    {
    }

    [Token(Token = "0x20021CB")]
    public interface IConnectSequence
    {
      [Token(Token = "0x600CE78")]
      IEnumerator Connect();
    }

    [Token(Token = "0x20021CC")]
    public interface IApiEvent
    {
      [Token(Token = "0x17002D0D")]
      bool IsCancel { [Token(Token = "0x600CE79")] get; }

      [Token(Token = "0x600CE7A")]
      void OnApiStart(object obj);

      [Token(Token = "0x600CE7B")]
      void OnApiEnded(object obj);
    }

    [Token(Token = "0x20021CD")]
    public delegate IEnumerator ApiConnectSequence();

    [Token(Token = "0x20021CE")]
    public delegate bool ApiStartCallback(object obj);

    [Token(Token = "0x20021CF")]
    public delegate void ApiEndedCallback(object obj);

    [Token(Token = "0x20021D0")]
    [Serializable]
    private class ConnectNode
    {
      [Token(Token = "0x4008F17")]
      [FieldOffset(Offset = "0x10")]
      [SerializeField]
      public string temp;
      [Token(Token = "0x4008F18")]
      [FieldOffset(Offset = "0x18")]
      private object obj;
      [Token(Token = "0x4008F19")]
      [FieldOffset(Offset = "0x20")]
      private NetworkQueue.ApiConnectSequence connetctSeq;
      [Token(Token = "0x4008F1A")]
      [FieldOffset(Offset = "0x28")]
      private NetworkQueue.ApiStartCallback onStart;
      [Token(Token = "0x4008F1B")]
      [FieldOffset(Offset = "0x30")]
      private NetworkQueue.ApiEndedCallback onEnded;
      [Token(Token = "0x4008F1C")]
      [FieldOffset(Offset = "0x38")]
      private NetworkQueue.ConnectNode.ConnectEndedCallback onConnectEnded;
      [Token(Token = "0x4008F1D")]
      [FieldOffset(Offset = "0x40")]
      [SerializeField]
      private NetworkQueue.ConnectNode next;

      [Token(Token = "0x600CE88")]
      [Address(RVA = "0x4B648EC", Offset = "0x4B648EC", VA = "0x4B648EC")]
      public ConnectNode(
        object obj,
        NetworkQueue.ApiConnectSequence seq,
        NetworkQueue.ApiStartCallback start,
        NetworkQueue.ApiEndedCallback ended,
        NetworkQueue.ConnectNode.ConnectEndedCallback nodeEnded)
      {
      }

      [Token(Token = "0x600CE89")]
      [Address(RVA = "0x4B64994", Offset = "0x4B64994", VA = "0x4B64994")]
      public IEnumerator Connect() => (IEnumerator) null;

      [Token(Token = "0x600CE8A")]
      [Address(RVA = "0x4B64980", Offset = "0x4B64980", VA = "0x4B64980")]
      public void SetLast(NetworkQueue.ConnectNode element)
      {
      }

      [Token(Token = "0x20021D1")]
      public delegate void ConnectEndedCallback();
    }
  }
}
