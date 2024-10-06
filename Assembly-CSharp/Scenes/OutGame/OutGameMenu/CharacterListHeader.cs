// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.CharacterListHeader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using UI.SortFilter;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x200399D")]
  public class CharacterListHeader : MonoBehaviour
  {
    [Token(Token = "0x400FBC7")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private BtnSoul _soulBtn;
    [Token(Token = "0x400FBC8")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private BtnCoin _coinBtn;
    [Token(Token = "0x400FBC9")]
    [FieldOffset(Offset = "0x28")]
    private AssetCachedSpawner _assetCachedSpawner;

    [Token(Token = "0x6016A27")]
    [Address(RVA = "0x3F5F0CC", Offset = "0x3F5F0CC", VA = "0x3F5F0CC")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6016A28")]
    [Address(RVA = "0x3F5F1BC", Offset = "0x3F5F1BC", VA = "0x3F5F1BC")]
    public void UpdateView()
    {
    }

    [Token(Token = "0x6016A29")]
    [Address(RVA = "0x3F5F25C", Offset = "0x3F5F25C", VA = "0x3F5F25C")]
    public void UpdateRedSoulCount(int diff)
    {
    }

    [Token(Token = "0x6016A2A")]
    [Address(RVA = "0x3F5F2DC", Offset = "0x3F5F2DC", VA = "0x3F5F2DC")]
    public CharacterListHeader()
    {
    }
  }
}
