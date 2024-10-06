// Decompiled with JetBrains decompiler
// Type: Scenes.Story.ChapterShop.ChapterShopAnimation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UI.Direction;

#nullable disable
namespace Scenes.Story.ChapterShop
{
  [Token(Token = "0x2002EEF")]
  public class ChapterShopAnimation
  {
    [Token(Token = "0x400C934")]
    private const string MuteTrackName = "Layout_Footer_Button";
    [Token(Token = "0x400C935")]
    private const string UnmuteTrackName = "Button_Back";

    [Token(Token = "0x17003E33")]
    public bool IsPlaying
    {
      [Token(Token = "0x6012566"), Address(RVA = "0x22FA01C", Offset = "0x22FA01C", VA = "0x22FA01C")] get
      {
        return new bool();
      }
      [Token(Token = "0x6012567"), Address(RVA = "0x22FA024", Offset = "0x22FA024", VA = "0x22FA024")] private set
      {
      }
    }

    [Token(Token = "0x6012568")]
    [Address(RVA = "0x22FA030", Offset = "0x22FA030", VA = "0x22FA030")]
    public void Open(
      UITimelineController timelineController,
      string timelineAssetName,
      Action finishAction)
    {
    }

    [Token(Token = "0x6012569")]
    [Address(RVA = "0x22FA208", Offset = "0x22FA208", VA = "0x22FA208")]
    public void Close(
      UITimelineController timelineController,
      string timelineAssetName,
      Action finishAction)
    {
    }

    [Token(Token = "0x601256A")]
    [Address(RVA = "0x22FA360", Offset = "0x22FA360", VA = "0x22FA360")]
    public void OpenPopup(
      UITimelineController timelineController,
      string timelineAssetName,
      Action finishAction)
    {
    }

    [Token(Token = "0x601256B")]
    [Address(RVA = "0x22FA4B0", Offset = "0x22FA4B0", VA = "0x22FA4B0")]
    public void ClosePopup(
      UITimelineController timelineController,
      string timelineAssetName,
      Action finishAction)
    {
    }

    [Token(Token = "0x601256C")]
    [Address(RVA = "0x22FA188", Offset = "0x22FA188", VA = "0x22FA188")]
    private void ChangeMuteTrack(UITimelineController timelineController)
    {
    }

    [Token(Token = "0x601256D")]
    [Address(RVA = "0x22FA600", Offset = "0x22FA600", VA = "0x22FA600")]
    public ChapterShopAnimation()
    {
    }
  }
}
