// Decompiled with JetBrains decompiler
// Type: Story.APIResult.APIResult`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Story.APIResult
{
  [Token(Token = "0x2000733")]
  public abstract class APIResult<TRequest, TResponse>
  {
    [Token(Token = "0x170005FF")]
    public Action<TResponse> SucceededCallback
    {
      [Token(Token = "0x6002885")] private get => (Action<TResponse>) null;
      [Token(Token = "0x6002886")] set
      {
      }
    }

    [Token(Token = "0x17000600")]
    public Action FailedCallback
    {
      [Token(Token = "0x6002887")] private get => (Action) null;
      [Token(Token = "0x6002888")] set
      {
      }
    }

    [Token(Token = "0x6002889")]
    public void OnFinished(TRequest request, TResponse response)
    {
    }

    [Token(Token = "0x600288A")]
    protected virtual void OnSuccess(TRequest request, TResponse response)
    {
    }

    [Token(Token = "0x600288B")]
    protected virtual void OnFailed(TRequest request)
    {
    }

    [Token(Token = "0x600288C")]
    protected APIResult()
    {
    }
  }
}
