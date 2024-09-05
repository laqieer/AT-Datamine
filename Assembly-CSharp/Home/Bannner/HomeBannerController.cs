// Decompiled with JetBrains decompiler
// Type: Home.Bannner.HomeBannerController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.RawData;
using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Home.Bannner
{
  [Token(Token = "0x2000B79")]
  public class HomeBannerController : MonoBehaviour
  {
    [Token(Token = "0x4003450")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private HomeBannerListView bannerListView;
    [Token(Token = "0x4003451")]
    [FieldOffset(Offset = "0x20")]
    private RawTextureManager rawTextureManager;
    [Token(Token = "0x4003452")]
    [FieldOffset(Offset = "0x28")]
    private HomeBannerList homeBannerList;

    [Token(Token = "0x600414B")]
    [Address(RVA = "0x2A2E9CC", Offset = "0x2A2E9CC", VA = "0x2A2E9CC")]
    private void Awake()
    {
    }

    [Token(Token = "0x600414C")]
    [Address(RVA = "0x2A2EA2C", Offset = "0x2A2EA2C", VA = "0x2A2EA2C")]
    public void Release()
    {
    }

    [Token(Token = "0x600414D")]
    [Address(RVA = "0x2A2EA50", Offset = "0x2A2EA50", VA = "0x2A2EA50")]
    public void Restart()
    {
    }

    [Token(Token = "0x600414E")]
    [Address(RVA = "0x2A2EA90", Offset = "0x2A2EA90", VA = "0x2A2EA90")]
    public IEnumerator LoadAsync(
      List<HomeBannerType> banners,
      HomeTransitionContoller transitionContoller)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600414F")]
    [Address(RVA = "0x2A2EB34", Offset = "0x2A2EB34", VA = "0x2A2EB34")]
    private IEnumerator DownloadBannerTextures(List<HomeBannerUIParameter> bannerParameters)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6004150")]
    [Address(RVA = "0x2A2EBD0", Offset = "0x2A2EBD0", VA = "0x2A2EBD0")]
    private void LoadHomeBannerTexture(
      BannerContentTypeEnum bannerContentType,
      string resourceName,
      Action<RawTextureHandle> onFinished)
    {
    }

    [Token(Token = "0x6004151")]
    [Address(RVA = "0x2A2EC30", Offset = "0x2A2EC30", VA = "0x2A2EC30")]
    private IEnumerator WaitForLoading() => (IEnumerator) null;

    [Token(Token = "0x6004152")]
    [Address(RVA = "0x2A2EC1C", Offset = "0x2A2EC1C", VA = "0x2A2EC1C")]
    public static string GetBannerURL(BannerContentTypeEnum bannerContentType, string resourceName)
    {
      return (string) null;
    }

    [Token(Token = "0x6004153")]
    [Address(RVA = "0x2A2EE78", Offset = "0x2A2EE78", VA = "0x2A2EE78")]
    private static string GetHomeBannerURL(string resourceName) => (string) null;

    [Token(Token = "0x6004154")]
    [Address(RVA = "0x2A2ECC0", Offset = "0x2A2ECC0", VA = "0x2A2ECC0")]
    public static string GetGachaBannerURL(string resourceName) => (string) null;

    [Token(Token = "0x6004155")]
    [Address(RVA = "0x2A2EEEC", Offset = "0x2A2EEEC", VA = "0x2A2EEEC")]
    public HomeBannerController()
    {
    }
  }
}
