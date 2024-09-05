// Decompiled with JetBrains decompiler
// Type: GameCore.RawData.RawTextureManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace GameCore.RawData
{
  [Token(Token = "0x2000CCA")]
  internal class RawTextureManager
  {
    [Token(Token = "0x400396D")]
    [FieldOffset(Offset = "0x10")]
    private Dictionary<string, RawTextureHolder> RawTextures;
    [Token(Token = "0x400396E")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<string, RawTextureManager.LoadRequestRawTexture> LoadReqestus;

    [Token(Token = "0x600499D")]
    [Address(RVA = "0x313A308", Offset = "0x313A308", VA = "0x313A308")]
    public void LoadTexture(string url, Action<RawTextureHandle> onFinished)
    {
    }

    [Token(Token = "0x600499E")]
    [Address(RVA = "0x313A4D4", Offset = "0x313A4D4", VA = "0x313A4D4")]
    private void RequestLoadRawTexture(string url, Action<RawTextureHandle> onFinished)
    {
    }

    [Token(Token = "0x600499F")]
    [Address(RVA = "0x313A7B8", Offset = "0x313A7B8", VA = "0x313A7B8")]
    private void OnTextureReleased(string id)
    {
    }

    [Token(Token = "0x60049A0")]
    [Address(RVA = "0x313A810", Offset = "0x313A810", VA = "0x313A810")]
    public IEnumerator WaitForLoading() => (IEnumerator) null;

    [Token(Token = "0x60049A1")]
    [Address(RVA = "0x313A8A0", Offset = "0x313A8A0", VA = "0x313A8A0")]
    public void Release()
    {
    }

    [Token(Token = "0x60049A2")]
    [Address(RVA = "0x313AA28", Offset = "0x313AA28", VA = "0x313AA28")]
    public RawTextureManager()
    {
    }

    [Token(Token = "0x2000CCB")]
    private class LoadRequestRawTexture
    {
      [Token(Token = "0x400396F")]
      [FieldOffset(Offset = "0x10")]
      public Action<RawTextureHolder> RequestFinished;

      [Token(Token = "0x17000AC1")]
      public string Url
      {
        [Token(Token = "0x60049A3"), Address(RVA = "0x313AAE8", Offset = "0x313AAE8", VA = "0x313AAE8")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x60049A4")]
      [Address(RVA = "0x313A6E0", Offset = "0x313A6E0", VA = "0x313A6E0")]
      public LoadRequestRawTexture(string url)
      {
      }

      [Token(Token = "0x60049A5")]
      [Address(RVA = "0x313A708", Offset = "0x313A708", VA = "0x313A708")]
      public void StartLoad()
      {
      }

      [Token(Token = "0x60049A6")]
      [Address(RVA = "0x313AAF0", Offset = "0x313AAF0", VA = "0x313AAF0")]
      private void OnRequestFinished(Texture2D texture)
      {
      }
    }
  }
}
