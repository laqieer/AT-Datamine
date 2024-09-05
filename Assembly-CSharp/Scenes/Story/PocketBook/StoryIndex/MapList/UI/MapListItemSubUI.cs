// Decompiled with JetBrains decompiler
// Type: Scenes.Story.PocketBook.StoryIndex.MapList.UI.MapListItemSubUI
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
  [Token(Token = "0x2002E39")]
  public class MapListItemSubUI : MonoBehaviour, InstanceHandler<MapListItemSubUI>.IManaged
  {
    [Token(Token = "0x400C65C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextAccessor text;
    [Token(Token = "0x400C65D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Transform selectOn;
    [Token(Token = "0x400C65E")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject purposeIcon;

    [Token(Token = "0x14000177")]
    public event Action OnClick
    {
      [Token(Token = "0x601211D"), Address(RVA = "0x4381524", Offset = "0x4381524", VA = "0x4381524")] add
      {
      }
      [Token(Token = "0x601211E"), Address(RVA = "0x4381E8C", Offset = "0x4381E8C", VA = "0x4381E8C")] remove
      {
      }
    }

    [Token(Token = "0x601211F")]
    [Address(RVA = "0x437F190", Offset = "0x437F190", VA = "0x437F190")]
    public MapListItemSubUI CreateInstance() => (MapListItemSubUI) null;

    [Token(Token = "0x6012120")]
    [Address(RVA = "0x437F124", Offset = "0x437F124", VA = "0x437F124")]
    public void SetText(string text)
    {
    }

    [Token(Token = "0x6012121")]
    [Address(RVA = "0x437F140", Offset = "0x437F140", VA = "0x437F140")]
    public void Select(bool active)
    {
    }

    [Token(Token = "0x6012122")]
    [Address(RVA = "0x437F170", Offset = "0x437F170", VA = "0x437F170")]
    public void SetPurpose(bool sw)
    {
    }

    [Token(Token = "0x6012123")]
    [Address(RVA = "0x437F37C", Offset = "0x437F37C", VA = "0x437F37C")]
    public void Show(bool show)
    {
    }

    [Token(Token = "0x6012124")]
    [Address(RVA = "0x4381F28", Offset = "0x4381F28", VA = "0x4381F28")]
    public void OnClickEvent()
    {
    }

    [Token(Token = "0x6012125")]
    [Address(RVA = "0x4381F44", Offset = "0x4381F44", VA = "0x4381F44", Slot = "4")]
    private void Scenes\u002EStory\u002EPocketBook\u002EStoryIndex\u002EInstanceHandler\u003CScenes\u002EStory\u002EPocketBook\u002EStoryIndex\u002EMapList\u002EUI\u002EMapListItemSubUI\u003E\u002EIManaged\u002EOnInitialize()
    {
    }

    [Token(Token = "0x6012126")]
    [Address(RVA = "0x4381F48", Offset = "0x4381F48", VA = "0x4381F48", Slot = "5")]
    private void Scenes\u002EStory\u002EPocketBook\u002EStoryIndex\u002EInstanceHandler\u003CScenes\u002EStory\u002EPocketBook\u002EStoryIndex\u002EMapList\u002EUI\u002EMapListItemSubUI\u003E\u002EIManaged\u002EOnRelease()
    {
    }

    [Token(Token = "0x6012127")]
    [Address(RVA = "0x4381F4C", Offset = "0x4381F4C", VA = "0x4381F4C")]
    public MapListItemSubUI()
    {
    }
  }
}
