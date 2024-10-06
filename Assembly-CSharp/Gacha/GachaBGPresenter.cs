// Decompiled with JetBrains decompiler
// Type: Gacha.GachaBGPresenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Gacha
{
  [Token(Token = "0x200155C")]
  internal class GachaBGPresenter
  {
    [Token(Token = "0x400621C")]
    [FieldOffset(Offset = "0x10")]
    private IGachaBGView view;
    [Token(Token = "0x400621D")]
    [FieldOffset(Offset = "0x18")]
    private GachaBGResourceModel model;
    [Token(Token = "0x400621E")]
    [FieldOffset(Offset = "0x20")]
    public bool IsRunnning;

    [Token(Token = "0x60078FE")]
    [Address(RVA = "0x44F6A54", Offset = "0x44F6A54", VA = "0x44F6A54")]
    public GachaBGPresenter(IGachaBGView view, GachaBGResourceModel model)
    {
    }

    [Token(Token = "0x60078FF")]
    [Address(RVA = "0x44F6A80", Offset = "0x44F6A80", VA = "0x44F6A80")]
    public void Start()
    {
    }

    [Token(Token = "0x6007900")]
    [Address(RVA = "0x44E9514", Offset = "0x44E9514", VA = "0x44E9514")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6007901")]
    [Address(RVA = "0x44E9158", Offset = "0x44E9158", VA = "0x44E9158")]
    public void Release()
    {
    }

    [Token(Token = "0x6007902")]
    [Address(RVA = "0x44FF734", Offset = "0x44FF734", VA = "0x44FF734")]
    private void OnBGTextureResourceChanged(BGTextureResource bgResource)
    {
    }

    [Token(Token = "0x6007903")]
    [Address(RVA = "0x44FF874", Offset = "0x44FF874", VA = "0x44FF874")]
    private void OnBGMovieResourceChanged(BGMovieResource bgResource)
    {
    }

    [Token(Token = "0x6007904")]
    [Address(RVA = "0x44FF940", Offset = "0x44FF940", VA = "0x44FF940")]
    private void OnVideoFinished()
    {
    }

    [Token(Token = "0x6007905")]
    [Address(RVA = "0x44FF9F0", Offset = "0x44FF9F0", VA = "0x44FF9F0")]
    private void OnBGWaitTimeFinisihed()
    {
    }
  }
}
