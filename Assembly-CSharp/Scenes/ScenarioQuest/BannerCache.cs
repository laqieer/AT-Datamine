// Decompiled with JetBrains decompiler
// Type: Scenes.ScenarioQuest.BannerCache
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.ScenarioQuest
{
  [Token(Token = "0x2002935")]
  public class BannerCache
  {
    [Token(Token = "0x400AFC6")]
    private const string BANNER_TOP_FORMAT = "{0}Image/ScenarioEvent/{1}/Top/{1}_EventTop.png";

    [Token(Token = "0x170038C9")]
    public Dictionary<int, Texture2D> TopEventBanners
    {
      [Token(Token = "0x6010361"), Address(RVA = "0x474FA30", Offset = "0x474FA30", VA = "0x474FA30")] get
      {
        return (Dictionary<int, Texture2D>) null;
      }
    }

    [Token(Token = "0x6010362")]
    [Address(RVA = "0x474FA38", Offset = "0x474FA38", VA = "0x474FA38")]
    public IEnumerator RequestBanner(int eventID) => (IEnumerator) null;

    [Token(Token = "0x6010363")]
    [Address(RVA = "0x474FAD8", Offset = "0x474FAD8", VA = "0x474FAD8")]
    public IEnumerator RequestBanners(int[] eventIDs) => (IEnumerator) null;

    [Token(Token = "0x6010364")]
    [Address(RVA = "0x474FB74", Offset = "0x474FB74", VA = "0x474FB74")]
    public void Destroy()
    {
    }

    [Token(Token = "0x6010365")]
    [Address(RVA = "0x474FB78", Offset = "0x474FB78", VA = "0x474FB78")]
    public void DestroyTopEventBanners()
    {
    }

    [Token(Token = "0x6010366")]
    [Address(RVA = "0x474FD24", Offset = "0x474FD24", VA = "0x474FD24")]
    public BannerCache()
    {
    }
  }
}
