// Decompiled with JetBrains decompiler
// Type: Scenes.Story.PocketBook.StoryIndex.MapViewer.Model
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Data;
using FreeMap.Parameter.UIParam;
using Il2CppDummyDll;
using System;

#nullable disable
namespace Scenes.Story.PocketBook.StoryIndex.MapViewer
{
  [Token(Token = "0x2002E29")]
  public class Model
  {
    [Token(Token = "0x400C61B")]
    [FieldOffset(Offset = "0x38")]
    private FreeMapUIParamBase active;

    [Token(Token = "0x14000167")]
    public event Action<int> OnSelectArea
    {
      [Token(Token = "0x6012080"), Address(RVA = "0x437CC40", Offset = "0x437CC40", VA = "0x437CC40")] add
      {
      }
      [Token(Token = "0x6012081"), Address(RVA = "0x437D1B4", Offset = "0x437D1B4", VA = "0x437D1B4")] remove
      {
      }
    }

    [Token(Token = "0x6012082")]
    [Address(RVA = "0x437D264", Offset = "0x437D264", VA = "0x437D264")]
    public void SelectArea(int areaID)
    {
    }

    [Token(Token = "0x14000168")]
    public event Action OnRefreshIcon
    {
      [Token(Token = "0x6012083"), Address(RVA = "0x437CE50", Offset = "0x437CE50", VA = "0x437CE50")] add
      {
      }
      [Token(Token = "0x6012084"), Address(RVA = "0x437D280", Offset = "0x437D280", VA = "0x437D280")] remove
      {
      }
    }

    [Token(Token = "0x6012085")]
    [Address(RVA = "0x437D31C", Offset = "0x437D31C", VA = "0x437D31C")]
    public void RefreshIcon()
    {
    }

    [Token(Token = "0x14000169")]
    public event Action<FreeMapUIParamBase> OnSelectIcon
    {
      [Token(Token = "0x6012086"), Address(RVA = "0x437CCF0", Offset = "0x437CCF0", VA = "0x437CCF0")] add
      {
      }
      [Token(Token = "0x6012087"), Address(RVA = "0x437D338", Offset = "0x437D338", VA = "0x437D338")] remove
      {
      }
    }

    [Token(Token = "0x1400016A")]
    public event Action<FreeMapUIParamBase> OnUnSelectIcon
    {
      [Token(Token = "0x6012088"), Address(RVA = "0x437CDA0", Offset = "0x437CDA0", VA = "0x437CDA0")] add
      {
      }
      [Token(Token = "0x6012089"), Address(RVA = "0x437D3E8", Offset = "0x437D3E8", VA = "0x437D3E8")] remove
      {
      }
    }

    [Token(Token = "0x1400016B")]
    public event Action<CurrentFreeActionParam> OnChangeTimezone
    {
      [Token(Token = "0x601208A"), Address(RVA = "0x437CF88", Offset = "0x437CF88", VA = "0x437CF88")] add
      {
      }
      [Token(Token = "0x601208B"), Address(RVA = "0x437D498", Offset = "0x437D498", VA = "0x437D498")] remove
      {
      }
    }

    [Token(Token = "0x601208C")]
    [Address(RVA = "0x437D548", Offset = "0x437D548", VA = "0x437D548")]
    public void ChangeTimezone(CurrentFreeActionParam param)
    {
    }

    [Token(Token = "0x601208D")]
    [Address(RVA = "0x437D564", Offset = "0x437D564", VA = "0x437D564")]
    public void SelectIcon(FreeMapUIParamBase param)
    {
    }

    [Token(Token = "0x601208E")]
    [Address(RVA = "0x437D584", Offset = "0x437D584", VA = "0x437D584")]
    public void UnSelectIcon()
    {
    }

    [Token(Token = "0x601208F")]
    [Address(RVA = "0x437D5B4", Offset = "0x437D5B4", VA = "0x437D5B4")]
    public bool IsActive(FreeMapUIParamBase param) => new bool();

    [Token(Token = "0x6012090")]
    [Address(RVA = "0x437D5EC", Offset = "0x437D5EC", VA = "0x437D5EC")]
    public FreeMapUIParamBase GetActive() => (FreeMapUIParamBase) null;

    [Token(Token = "0x1400016C")]
    public event Action OnUpdate
    {
      [Token(Token = "0x6012091"), Address(RVA = "0x437CEEC", Offset = "0x437CEEC", VA = "0x437CEEC")] add
      {
      }
      [Token(Token = "0x6012092"), Address(RVA = "0x437D5F4", Offset = "0x437D5F4", VA = "0x437D5F4")] remove
      {
      }
    }

    [Token(Token = "0x6012093")]
    [Address(RVA = "0x437D690", Offset = "0x437D690", VA = "0x437D690")]
    public void Update()
    {
    }

    [Token(Token = "0x1400016D")]
    public event Action<FreeMapUIParamBase> OnClickIcon
    {
      [Token(Token = "0x6012094"), Address(RVA = "0x437D6AC", Offset = "0x437D6AC", VA = "0x437D6AC")] add
      {
      }
      [Token(Token = "0x6012095"), Address(RVA = "0x437D75C", Offset = "0x437D75C", VA = "0x437D75C")] remove
      {
      }
    }

    [Token(Token = "0x6012096")]
    [Address(RVA = "0x437D80C", Offset = "0x437D80C", VA = "0x437D80C")]
    public void InvokeOnClickIcon(FreeMapUIParamBase param)
    {
    }

    [Token(Token = "0x6012097")]
    [Address(RVA = "0x437D828", Offset = "0x437D828", VA = "0x437D828")]
    public Model()
    {
    }
  }
}
