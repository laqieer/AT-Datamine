// Decompiled with JetBrains decompiler
// Type: Scenes.Story.PocketBook.PocketBookSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Data;
using FreeMap.State;
using GameCore.Scene;
using Il2CppDummyDll;
using Scenes.Story.PocketBook.StoryIndex;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Scenes.Story.PocketBook
{
  [Token(Token = "0x2002DBC")]
  public class PocketBookSubScene : SubScene
  {
    [Token(Token = "0x400C493")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private RectTransform parent;
    [Token(Token = "0x400C494")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private string openSeName;
    [Token(Token = "0x400C495")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private string closeSeName;
    [Token(Token = "0x400C496")]
    [FieldOffset(Offset = "0x70")]
    public bool SkipCloseSE;
    [Token(Token = "0x400C497")]
    [FieldOffset(Offset = "0x78")]
    private PocketBookLoader loader;
    [Token(Token = "0x400C498")]
    [FieldOffset(Offset = "0x80")]
    private FreeMapStateManager freeMapStateManager;
    [Token(Token = "0x400C499")]
    [FieldOffset(Offset = "0x88")]
    private CurrentFreeActionParam currentFreeactionParam;
    [Token(Token = "0x400C49A")]
    [FieldOffset(Offset = "0x90")]
    private IPocketBookEventHandler pocketBookEventHandler;
    [Token(Token = "0x400C49B")]
    [FieldOffset(Offset = "0x98")]
    private Func<bool> IsTimeSkipped;
    [Token(Token = "0x400C49C")]
    [FieldOffset(Offset = "0xA0")]
    private PocketBookStoryIndex.Tab.Type tabType;
    [Token(Token = "0x400C49D")]
    [FieldOffset(Offset = "0xA8")]
    private PocketBookHeader header;
    [Token(Token = "0x400C49E")]
    [FieldOffset(Offset = "0xB0")]
    private PocketBookSubScene.HeaderScale headerScale;
    [Token(Token = "0x400C49F")]
    [FieldOffset(Offset = "0xB8")]
    private Canvas canvas;

    [Token(Token = "0x6011E2A")]
    [Address(RVA = "0x3FA8FD8", Offset = "0x3FA8FD8", VA = "0x3FA8FD8")]
    public Canvas GetCanvas() => (Canvas) null;

    [Token(Token = "0x6011E2B")]
    [Address(RVA = "0x3FA8FE0", Offset = "0x3FA8FE0", VA = "0x3FA8FE0")]
    private void ChangeSoundEvent(bool isOpen)
    {
    }

    [Token(Token = "0x6011E2C")]
    [Address(RVA = "0x3FA90A0", Offset = "0x3FA90A0", VA = "0x3FA90A0")]
    private void PlayToOpenOrCloseSE(bool isOpen)
    {
    }

    [Token(Token = "0x6011E2D")]
    [Address(RVA = "0x3FA9144", Offset = "0x3FA9144", VA = "0x3FA9144", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x6011E2E")]
    [Address(RVA = "0x3FA91EC", Offset = "0x3FA91EC", VA = "0x3FA91EC", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6011E2F")]
    [Address(RVA = "0x3FA927C", Offset = "0x3FA927C", VA = "0x3FA927C", Slot = "21")]
    public override IEnumerator EnableEffect() => (IEnumerator) null;

    [Token(Token = "0x6011E30")]
    [Address(RVA = "0x3FA930C", Offset = "0x3FA930C", VA = "0x3FA930C", Slot = "22")]
    public override IEnumerator DisableEffect() => (IEnumerator) null;

    [Token(Token = "0x6011E31")]
    [Address(RVA = "0x3FA939C", Offset = "0x3FA939C", VA = "0x3FA939C", Slot = "30")]
    protected override void BackKeyDownActionInSubScene()
    {
    }

    [Token(Token = "0x6011E32")]
    [Address(RVA = "0x3FA93A0", Offset = "0x3FA93A0", VA = "0x3FA93A0")]
    private void PlayCloseSe()
    {
    }

    [Token(Token = "0x6011E33")]
    [Address(RVA = "0x3FA93D0", Offset = "0x3FA93D0", VA = "0x3FA93D0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6011E34")]
    [Address(RVA = "0x3FA94F4", Offset = "0x3FA94F4", VA = "0x3FA94F4", Slot = "26")]
    public override IEnumerator OnBackSceneAsync() => (IEnumerator) null;

    [Token(Token = "0x6011E35")]
    [Address(RVA = "0x3FA9584", Offset = "0x3FA9584", VA = "0x3FA9584")]
    public void UpdateEventHandler(IPocketBookEventHandler newHandler)
    {
    }

    [Token(Token = "0x6011E36")]
    [Address(RVA = "0x3FA95A4", Offset = "0x3FA95A4", VA = "0x3FA95A4")]
    public PocketBookSubScene()
    {
    }

    [Token(Token = "0x2002DBD")]
    public enum PrefabType
    {
      [Token(Token = "0x400C4A1")] Header,
      [Token(Token = "0x400C4A2")] Index,
      [Token(Token = "0x400C4A3")] TimeSkip,
      [Token(Token = "0x400C4A4")] Profile,
      [Token(Token = "0x400C4A5")] TimeSkip_Popup,
      [Token(Token = "0x400C4A6")] Calendar_Popup,
    }

    [Token(Token = "0x2002DBE")]
    private class HeaderScale
    {
      [Token(Token = "0x400C4A7")]
      [FieldOffset(Offset = "0x10")]
      private Transform root;
      [Token(Token = "0x400C4A8")]
      [FieldOffset(Offset = "0x18")]
      private Vector3 scale;

      [Token(Token = "0x6011E3A")]
      [Address(RVA = "0x3FA9718", Offset = "0x3FA9718", VA = "0x3FA9718")]
      public HeaderScale(PocketBookHeader header)
      {
      }

      [Token(Token = "0x6011E3B")]
      [Address(RVA = "0x3FA9778", Offset = "0x3FA9778", VA = "0x3FA9778")]
      public void Show()
      {
      }

      [Token(Token = "0x6011E3C")]
      [Address(RVA = "0x3FA97A0", Offset = "0x3FA97A0", VA = "0x3FA97A0")]
      public void Hide()
      {
      }
    }
  }
}
