// Decompiled with JetBrains decompiler
// Type: Scenes.Story.PocketBook.StoryIndex.MapList.UI.MapListUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Scenes.Story.PocketBook.StoryIndex.MapList.UI
{
  [Token(Token = "0x2002E3A")]
  public class MapListUI : MonoBehaviour
  {
    [Token(Token = "0x400C660")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private MapListItemMainUI mainUI;
    [Token(Token = "0x400C661")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private MapListItemSubUI subUI;

    [Token(Token = "0x6012128")]
    [Address(RVA = "0x4381F54", Offset = "0x4381F54", VA = "0x4381F54")]
    private void Awake()
    {
    }

    [Token(Token = "0x6012129")]
    [Address(RVA = "0x4381B58", Offset = "0x4381B58", VA = "0x4381B58")]
    public MapListItemHandler CreateHandler() => (MapListItemHandler) null;

    [Token(Token = "0x601212A")]
    [Address(RVA = "0x4371478", Offset = "0x4371478", VA = "0x4371478")]
    public MapListView CreateView() => (MapListView) null;

    [Token(Token = "0x601212B")]
    [Address(RVA = "0x4381FA4", Offset = "0x4381FA4", VA = "0x4381FA4")]
    public MapListUI()
    {
    }
  }
}
