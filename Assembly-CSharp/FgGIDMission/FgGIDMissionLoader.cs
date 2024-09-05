// Decompiled with JetBrains decompiler
// Type: FgGIDMission.FgGIDMissionLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace FgGIDMission
{
  [Token(Token = "0x2001982")]
  public class FgGIDMissionLoader
  {
    [Token(Token = "0x4006DA8")]
    [FieldOffset(Offset = "0x10")]
    private Dictionary<string, Texture2D> RawTextures;
    [Token(Token = "0x4006DA9")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<string, FgGIDMissionLoader.LoadRequestRawTexture> LoadReqestus;

    [Token(Token = "0x60091AF")]
    [Address(RVA = "0x4D0BA08", Offset = "0x4D0BA08", VA = "0x4D0BA08")]
    public void LoadTexture(string url, Action<Texture2D> onFinished)
    {
    }

    [Token(Token = "0x60091B0")]
    [Address(RVA = "0x4D0BB54", Offset = "0x4D0BB54", VA = "0x4D0BB54")]
    private void CreateLoadRequestRawTexture(string url, Action<Texture2D> onFinished)
    {
    }

    [Token(Token = "0x60091B1")]
    [Address(RVA = "0x4D0BE0C", Offset = "0x4D0BE0C", VA = "0x4D0BE0C")]
    public FgGIDMissionLoader()
    {
    }

    [Token(Token = "0x2001983")]
    private class LoadRequestRawTexture
    {
      [Token(Token = "0x4006DAA")]
      [FieldOffset(Offset = "0x10")]
      public Action<Texture2D> RequestFinished;

      [Token(Token = "0x1700177A")]
      public string Url
      {
        [Token(Token = "0x60091B2"), Address(RVA = "0x4D0BECC", Offset = "0x4D0BECC", VA = "0x4D0BECC")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x60091B3")]
      [Address(RVA = "0x4D0BD30", Offset = "0x4D0BD30", VA = "0x4D0BD30")]
      public LoadRequestRawTexture(string url)
      {
      }

      [Token(Token = "0x60091B4")]
      [Address(RVA = "0x4D0BD58", Offset = "0x4D0BD58", VA = "0x4D0BD58")]
      public void StartLoad()
      {
      }

      [Token(Token = "0x60091B5")]
      [Address(RVA = "0x4D0BED4", Offset = "0x4D0BED4", VA = "0x4D0BED4")]
      private void OnRequestFinished(Texture2D texture)
      {
      }
    }
  }
}
