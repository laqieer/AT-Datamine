// Decompiled with JetBrains decompiler
// Type: Scenes.Story.PocketBook.StoryIndex.MapList.UI.MapListItemMainUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UI;
using UnityEngine;

#nullable disable
namespace Scenes.Story.PocketBook.StoryIndex.MapList.UI
{
  [Token(Token = "0x2002E38")]
  public class MapListItemMainUI : MonoBehaviour, InstanceHandler<MapListItemMainUI>.IManaged
  {
    [Token(Token = "0x400C65A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextAccessor title;

    [Token(Token = "0x14000176")]
    public event Action OnClick
    {
      [Token(Token = "0x6012115"), Address(RVA = "0x437EE04", Offset = "0x437EE04", VA = "0x437EE04")] add
      {
      }
      [Token(Token = "0x6012116"), Address(RVA = "0x4381DC4", Offset = "0x4381DC4", VA = "0x4381DC4")] remove
      {
      }
    }

    [Token(Token = "0x6012117")]
    [Address(RVA = "0x437EEA0", Offset = "0x437EEA0", VA = "0x437EEA0")]
    public MapListItemMainUI CreateInstance() => (MapListItemMainUI) null;

    [Token(Token = "0x6012118")]
    [Address(RVA = "0x437EDE8", Offset = "0x437EDE8", VA = "0x437EDE8")]
    public void SetTitle(string text)
    {
    }

    [Token(Token = "0x6012119")]
    [Address(RVA = "0x4381E60", Offset = "0x4381E60", VA = "0x4381E60")]
    public void OnClickEvent()
    {
    }

    [Token(Token = "0x601211A")]
    [Address(RVA = "0x4381E7C", Offset = "0x4381E7C", VA = "0x4381E7C", Slot = "4")]
    private void Scenes\u002EStory\u002EPocketBook\u002EStoryIndex\u002EInstanceHandler\u003CScenes\u002EStory\u002EPocketBook\u002EStoryIndex\u002EMapList\u002EUI\u002EMapListItemMainUI\u003E\u002EIManaged\u002EOnInitialize()
    {
    }

    [Token(Token = "0x601211B")]
    [Address(RVA = "0x4381E80", Offset = "0x4381E80", VA = "0x4381E80", Slot = "5")]
    private void Scenes\u002EStory\u002EPocketBook\u002EStoryIndex\u002EInstanceHandler\u003CScenes\u002EStory\u002EPocketBook\u002EStoryIndex\u002EMapList\u002EUI\u002EMapListItemMainUI\u003E\u002EIManaged\u002EOnRelease()
    {
    }

    [Token(Token = "0x601211C")]
    [Address(RVA = "0x4381E84", Offset = "0x4381E84", VA = "0x4381E84")]
    public MapListItemMainUI()
    {
    }
  }
}
