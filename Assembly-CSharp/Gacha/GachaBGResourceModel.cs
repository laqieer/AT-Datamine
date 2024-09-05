// Decompiled with JetBrains decompiler
// Type: Gacha.GachaBGResourceModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Gacha
{
  [Token(Token = "0x2001533")]
  internal class GachaBGResourceModel
  {
    [Token(Token = "0x4006176")]
    [FieldOffset(Offset = "0x10")]
    private GachaBGResourceModel.BGResourceInfo[] bgResourceInfo;
    [Token(Token = "0x4006177")]
    [FieldOffset(Offset = "0x18")]
    private int currentBGIndex;
    [Token(Token = "0x4006178")]
    [FieldOffset(Offset = "0x20")]
    private IGachaResourceProvider resourceProvider;
    [Token(Token = "0x4006179")]
    [FieldOffset(Offset = "0x28")]
    public Action<BGMovieResource> BGMovieResourceChanged;
    [Token(Token = "0x400617A")]
    [FieldOffset(Offset = "0x30")]
    public Action<BGTextureResource> BGTextureResourceChanged;
    [Token(Token = "0x400617B")]
    [FieldOffset(Offset = "0x38")]
    public Action WaitTimeFinisihed;

    [Token(Token = "0x1700127D")]
    private GachaBGResourceModel.BGResourceInfo currentBGResourceInfo
    {
      [Token(Token = "0x6007828"), Address(RVA = "0x44F7774", Offset = "0x44F7774", VA = "0x44F7774")] get
      {
        return (GachaBGResourceModel.BGResourceInfo) null;
      }
    }

    [Token(Token = "0x6007829")]
    [Address(RVA = "0x44F68A4", Offset = "0x44F68A4", VA = "0x44F68A4")]
    public GachaBGResourceModel(
      List<GachaBackgroundResource> backgroundResources,
      IGachaResourceProvider resourceProvider)
    {
    }

    [Token(Token = "0x600782A")]
    [Address(RVA = "0x44F77B0", Offset = "0x44F77B0", VA = "0x44F77B0")]
    public void RequestGachaBGResource()
    {
    }

    [Token(Token = "0x600782B")]
    [Address(RVA = "0x44F7990", Offset = "0x44F7990", VA = "0x44F7990")]
    public void RequestNextBGResource()
    {
    }

    [Token(Token = "0x600782C")]
    [Address(RVA = "0x44F79C0", Offset = "0x44F79C0", VA = "0x44F79C0")]
    public void StartWaitTime(float waitTime)
    {
    }

    [Token(Token = "0x600782D")]
    [Address(RVA = "0x44F7AA4", Offset = "0x44F7AA4", VA = "0x44F7AA4")]
    private IEnumerator WaitTime(float wittTime, Action onFinisihed) => (IEnumerator) null;

    [Token(Token = "0x2001534")]
    private class BGResourceInfo
    {
      [Token(Token = "0x400617C")]
      [FieldOffset(Offset = "0x10")]
      public string url;
      [Token(Token = "0x400617D")]
      [FieldOffset(Offset = "0x18")]
      public GachaResourceTypeEnum resourceType;

      [Token(Token = "0x6007831")]
      [Address(RVA = "0x44F77A8", Offset = "0x44F77A8", VA = "0x44F77A8")]
      public BGResourceInfo()
      {
      }
    }
  }
}
