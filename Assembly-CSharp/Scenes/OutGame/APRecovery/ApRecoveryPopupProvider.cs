// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.APRecovery.ApRecoveryPopupProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.APRecovery
{
  [Token(Token = "0x2003960")]
  public class ApRecoveryPopupProvider
  {
    [Token(Token = "0x17004A34")]
    public Action<string> OnMessage
    {
      [Token(Token = "0x60168CF"), Address(RVA = "0x42EF60C", Offset = "0x42EF60C", VA = "0x42EF60C")] get
      {
        return (Action<string>) null;
      }
      [Token(Token = "0x60168D0"), Address(RVA = "0x42EF614", Offset = "0x42EF614", VA = "0x42EF614")] set
      {
      }
    }

    [Token(Token = "0x60168D1")]
    [Address(RVA = "0x42EC878", Offset = "0x42EC878", VA = "0x42EC878")]
    public IEnumerator RequestAsync(
      AssetCachedSpawner assetCachedSpawner,
      Transform baseTransform = null,
      Vector2 contentOffset = default (Vector2),
      Action<ApRecoveryPopup> callback = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60168D2")]
    [Address(RVA = "0x42EF644", Offset = "0x42EF644", VA = "0x42EF644")]
    private void OnToasterMessage(string message)
    {
    }

    [Token(Token = "0x60168D3")]
    [Address(RVA = "0x42EC870", Offset = "0x42EC870", VA = "0x42EC870")]
    public ApRecoveryPopupProvider()
    {
    }
  }
}
