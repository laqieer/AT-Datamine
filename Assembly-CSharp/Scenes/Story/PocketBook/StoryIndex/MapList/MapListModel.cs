// Decompiled with JetBrains decompiler
// Type: Scenes.Story.PocketBook.StoryIndex.MapList.MapListModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Data;
using FreeMap.Parameter.UIParam;
using Il2CppDummyDll;
using System;

#nullable disable
namespace Scenes.Story.PocketBook.StoryIndex.MapList
{
  [Token(Token = "0x2002E30")]
  public class MapListModel
  {
    [Token(Token = "0x14000170")]
    public event Action<CurrentFreeActionParam> OnSet
    {
      [Token(Token = "0x60120EA"), Address(RVA = "0x437F5AC", Offset = "0x437F5AC", VA = "0x437F5AC")] add
      {
      }
      [Token(Token = "0x60120EB"), Address(RVA = "0x437F65C", Offset = "0x437F65C", VA = "0x437F65C")] remove
      {
      }
    }

    [Token(Token = "0x60120EC")]
    [Address(RVA = "0x437F70C", Offset = "0x437F70C", VA = "0x437F70C")]
    public void Set(CurrentFreeActionParam freeactionParam)
    {
    }

    [Token(Token = "0x14000171")]
    public event Action OnShow
    {
      [Token(Token = "0x60120ED"), Address(RVA = "0x437F728", Offset = "0x437F728", VA = "0x437F728")] add
      {
      }
      [Token(Token = "0x60120EE"), Address(RVA = "0x437F7C4", Offset = "0x437F7C4", VA = "0x437F7C4")] remove
      {
      }
    }

    [Token(Token = "0x60120EF")]
    [Address(RVA = "0x437F860", Offset = "0x437F860", VA = "0x437F860")]
    public void Show()
    {
    }

    [Token(Token = "0x14000172")]
    public event Action OnHide
    {
      [Token(Token = "0x60120F0"), Address(RVA = "0x437F87C", Offset = "0x437F87C", VA = "0x437F87C")] add
      {
      }
      [Token(Token = "0x60120F1"), Address(RVA = "0x437F918", Offset = "0x437F918", VA = "0x437F918")] remove
      {
      }
    }

    [Token(Token = "0x60120F2")]
    [Address(RVA = "0x437F9B4", Offset = "0x437F9B4", VA = "0x437F9B4")]
    public void Hide()
    {
    }

    [Token(Token = "0x14000173")]
    public event Action OnRelease
    {
      [Token(Token = "0x60120F3"), Address(RVA = "0x437F9D0", Offset = "0x437F9D0", VA = "0x437F9D0")] add
      {
      }
      [Token(Token = "0x60120F4"), Address(RVA = "0x437FA6C", Offset = "0x437FA6C", VA = "0x437FA6C")] remove
      {
      }
    }

    [Token(Token = "0x60120F5")]
    [Address(RVA = "0x437FB08", Offset = "0x437FB08", VA = "0x437FB08")]
    public void Release()
    {
    }

    [Token(Token = "0x14000174")]
    public event Action<FreeMapUIParamBase> OnSelectParam
    {
      [Token(Token = "0x60120F6"), Address(RVA = "0x437FB24", Offset = "0x437FB24", VA = "0x437FB24")] add
      {
      }
      [Token(Token = "0x60120F7"), Address(RVA = "0x437FBD4", Offset = "0x437FBD4", VA = "0x437FBD4")] remove
      {
      }
    }

    [Token(Token = "0x60120F8")]
    [Address(RVA = "0x437FC84", Offset = "0x437FC84", VA = "0x437FC84")]
    public void Select(FreeMapUIParamBase param)
    {
    }

    [Token(Token = "0x14000175")]
    public event Action<int> OnSelectArea
    {
      [Token(Token = "0x60120F9"), Address(RVA = "0x437FCA0", Offset = "0x437FCA0", VA = "0x437FCA0")] add
      {
      }
      [Token(Token = "0x60120FA"), Address(RVA = "0x437FD50", Offset = "0x437FD50", VA = "0x437FD50")] remove
      {
      }
    }

    [Token(Token = "0x60120FB")]
    [Address(RVA = "0x437FE00", Offset = "0x437FE00", VA = "0x437FE00")]
    public void Select(int areaID)
    {
    }

    [Token(Token = "0x60120FC")]
    [Address(RVA = "0x437FE1C", Offset = "0x437FE1C", VA = "0x437FE1C")]
    public MapListModel()
    {
    }
  }
}
