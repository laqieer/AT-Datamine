// Decompiled with JetBrains decompiler
// Type: Home.HomeNetworkConnector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using Network.API;
using System;
using System.Threading;

#nullable disable
namespace Home
{
  [Token(Token = "0x2000B3F")]
  internal class HomeNetworkConnector
  {
    [Token(Token = "0x400337A")]
    [FieldOffset(Offset = "0x10")]
    private CancellationTokenSource cancellationTokenSource;

    [Token(Token = "0x600401F")]
    [Address(RVA = "0x2A236A4", Offset = "0x2A236A4", VA = "0x2A236A4")]
    public HomeNetworkConnector()
    {
    }

    [Token(Token = "0x6004020")]
    [Address(RVA = "0x2A23710", Offset = "0x2A23710", VA = "0x2A23710")]
    public void RequestStoryInfo(
      int chapterID,
      Action<APIStoryResponse> onSuccess,
      Action onFailed = null)
    {
    }

    [Token(Token = "0x6004021")]
    [Address(RVA = "0x2A23730", Offset = "0x2A23730", VA = "0x2A23730")]
    private UniTaskVoid RequestStoryInfoAsync(
      int chapterID,
      Action<APIStoryResponse> onSuccess,
      Action onFailed)
    {
      return new UniTaskVoid();
    }

    [Token(Token = "0x6004022")]
    [Address(RVA = "0x2A237D0", Offset = "0x2A237D0", VA = "0x2A237D0")]
    public void RequestExpedition(Action<APIExpeditionResponse> onSuccess, Action onFailed = null)
    {
    }

    [Token(Token = "0x6004023")]
    [Address(RVA = "0x2A237F0", Offset = "0x2A237F0", VA = "0x2A237F0")]
    private UniTaskVoid RequestExpeditionAsync(
      Action<APIExpeditionResponse> onSuccess,
      Action onFailed)
    {
      return new UniTaskVoid();
    }
  }
}
