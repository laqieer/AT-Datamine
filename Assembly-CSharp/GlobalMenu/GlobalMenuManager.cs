// Decompiled with JetBrains decompiler
// Type: GlobalMenu.GlobalMenuManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.UI.Control.Position;
using GameCore.DesignPattern;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace GlobalMenu
{
  [Token(Token = "0x2000B93")]
  public class GlobalMenuManager : 
    SingletonMonoBehaviour<GlobalMenuManager>,
    IAvoidRectTransfromAccessor
  {
    [Token(Token = "0x17000998")]
    public List<UITransfromAvoidElementBase> AvoidIconRectTransformList
    {
      [Token(Token = "0x60041FB"), Address(RVA = "0x2A32D54", Offset = "0x2A32D54", VA = "0x2A32D54", Slot = "8")] get
      {
        return (List<UITransfromAvoidElementBase>) null;
      }
    }

    [Token(Token = "0x60041FC")]
    [Address(RVA = "0x2A32DC4", Offset = "0x2A32DC4", VA = "0x2A32DC4")]
    public bool IsAvailable() => new bool();

    [Token(Token = "0x60041FD")]
    [Address(RVA = "0x2A32DCC", Offset = "0x2A32DCC", VA = "0x2A32DCC")]
    public bool SetGlobaleMenuActive(bool active) => new bool();

    [Token(Token = "0x17000999")]
    public bool IsViaGlobalMenu
    {
      [Token(Token = "0x60041FE"), Address(RVA = "0x2A32DD4", Offset = "0x2A32DD4", VA = "0x2A32DD4")] get
      {
        return new bool();
      }
      [Token(Token = "0x60041FF"), Address(RVA = "0x2A32DDC", Offset = "0x2A32DDC", VA = "0x2A32DDC")] set
      {
      }
    }

    [Token(Token = "0x1700099A")]
    public bool IsViaGameMenu
    {
      [Token(Token = "0x6004200"), Address(RVA = "0x2A32DE8", Offset = "0x2A32DE8", VA = "0x2A32DE8")] get
      {
        return new bool();
      }
      [Token(Token = "0x6004201"), Address(RVA = "0x2A32DF0", Offset = "0x2A32DF0", VA = "0x2A32DF0")] set
      {
      }
    }

    [Token(Token = "0x6004202")]
    [Address(RVA = "0x2A32D00", Offset = "0x2A32D00", VA = "0x2A32D00")]
    public void PlayCurrentMenu()
    {
    }

    [Token(Token = "0x6004203")]
    [Address(RVA = "0x2A32DFC", Offset = "0x2A32DFC", VA = "0x2A32DFC")]
    public void OpenNormalMenu()
    {
    }

    [Token(Token = "0x6004204")]
    [Address(RVA = "0x2A32E00", Offset = "0x2A32E00", VA = "0x2A32E00")]
    public void SetCallbackToChangeState(Action changeMainMenu)
    {
    }

    [Token(Token = "0x6004205")]
    [Address(RVA = "0x2A32E04", Offset = "0x2A32E04", VA = "0x2A32E04")]
    public void SetCallbackToDeactiveAction(Action deactiveMenu)
    {
    }

    [Token(Token = "0x6004206")]
    [Address(RVA = "0x2A32E08", Offset = "0x2A32E08", VA = "0x2A32E08")]
    public void SetCallbackToChangeStateBySubScene(Action changeMainMenu)
    {
    }

    [Token(Token = "0x6004207")]
    [Address(RVA = "0x2A32E0C", Offset = "0x2A32E0C", VA = "0x2A32E0C")]
    public void SetCallbackToDeactiveActionBySubScene(Action deactiveMenu)
    {
    }

    [Token(Token = "0x6004208")]
    [Address(RVA = "0x2A32E10", Offset = "0x2A32E10", VA = "0x2A32E10")]
    public IEnumerator LoadWaitByAssetBundle() => (IEnumerator) null;

    [Token(Token = "0x6004209")]
    [Address(RVA = "0x2A32E98", Offset = "0x2A32E98", VA = "0x2A32E98")]
    public void ActiveMenu()
    {
    }

    [Token(Token = "0x600420A")]
    [Address(RVA = "0x2A32E9C", Offset = "0x2A32E9C", VA = "0x2A32E9C")]
    public void DeactiveMenu()
    {
    }

    [Token(Token = "0x600420B")]
    [Address(RVA = "0x2A32EA0", Offset = "0x2A32EA0", VA = "0x2A32EA0")]
    public void DeleteGlobalMenu()
    {
    }

    [Token(Token = "0x600420C")]
    [Address(RVA = "0x2A32EA4", Offset = "0x2A32EA4", VA = "0x2A32EA4", Slot = "9")]
    public virtual void OnBackToGlobalMenu()
    {
    }

    [Token(Token = "0x600420D")]
    [Address(RVA = "0x2A32EA8", Offset = "0x2A32EA8", VA = "0x2A32EA8")]
    public void SetHeaderVisible(bool isVisible)
    {
    }

    [Token(Token = "0x600420E")]
    [Address(RVA = "0x2A32EAC", Offset = "0x2A32EAC", VA = "0x2A32EAC")]
    public GlobalMenuManager()
    {
    }
  }
}
