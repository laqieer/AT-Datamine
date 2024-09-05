// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.QuestSelect.MapWorldManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using Scenes.OutGame.QuestSelectMap;
using StaqData;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

#nullable disable
namespace Scenes.OutGame.QuestSelect
{
  [Token(Token = "0x20033D0")]
  public class MapWorldManager : MonoBehaviour
  {
    [Token(Token = "0x400E121")]
    [FieldOffset(Offset = "0x18")]
    private AssetCachedSpawner asp;
    [Token(Token = "0x400E122")]
    [FieldOffset(Offset = "0x20")]
    private MapWorldGroundPrefabProvider groundResProvider;
    [Token(Token = "0x400E123")]
    [FieldOffset(Offset = "0x28")]
    private MapWorldDotCharaModelPrefabProvider dotResProvider;
    [Token(Token = "0x400E124")]
    [FieldOffset(Offset = "0x30")]
    private MapWorldLandmarkResourceDictProvider landResProvider;
    [Token(Token = "0x400E125")]
    [FieldOffset(Offset = "0x38")]
    private MapWorldLocationDataProvider locDataProvider;
    [Token(Token = "0x400E126")]
    [FieldOffset(Offset = "0x40")]
    private MapSceneManager mapManger;
    [Token(Token = "0x400E127")]
    [FieldOffset(Offset = "0x48")]
    private int questIndex;
    [Token(Token = "0x400E128")]
    [FieldOffset(Offset = "0x50")]
    private List<string> addedAssetbundleNames;
    [Token(Token = "0x400E129")]
    [FieldOffset(Offset = "0x58")]
    private Dictionary<int, int> mapIdDictByQuestIndex;
    [Token(Token = "0x400E12A")]
    [FieldOffset(Offset = "0x60")]
    private Scene mapScene;

    [Token(Token = "0x60145D4")]
    [Address(RVA = "0x1885D30", Offset = "0x1885D30", VA = "0x1885D30")]
    public void Initialize(int charaStyleId, int worldResourceId, List<QuestInfo> questInfoList)
    {
    }

    [Token(Token = "0x60145D5")]
    [Address(RVA = "0x1886454", Offset = "0x1886454", VA = "0x1886454")]
    public IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x60145D6")]
    [Address(RVA = "0x18864E4", Offset = "0x18864E4", VA = "0x18864E4")]
    public void StartOrRequest(int questIndex)
    {
    }

    [Token(Token = "0x60145D7")]
    [Address(RVA = "0x18865D4", Offset = "0x18865D4", VA = "0x18865D4")]
    public void MapStart()
    {
    }

    [Token(Token = "0x60145D8")]
    [Address(RVA = "0x1886658", Offset = "0x1886658", VA = "0x1886658")]
    public void Destory()
    {
    }

    [Token(Token = "0x60145D9")]
    [Address(RVA = "0x188693C", Offset = "0x188693C", VA = "0x188693C")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x60145DA")]
    [Address(RVA = "0x18869C0", Offset = "0x18869C0", VA = "0x18869C0")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x60145DB")]
    [Address(RVA = "0x1886A44", Offset = "0x1886A44", VA = "0x1886A44")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x60145DC")]
    [Address(RVA = "0x1886A48", Offset = "0x1886A48", VA = "0x1886A48")]
    public MapWorldManager()
    {
    }
  }
}
