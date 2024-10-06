// Decompiled with JetBrains decompiler
// Type: Scenes.Arena.ArenaTeam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using Scenes.OutGame.PersonalEmblem;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Arena
{
  [Token(Token = "0x2003150")]
  public class ArenaTeam : MonoBehaviour
  {
    [Token(Token = "0x400D203")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<Image> teamList;
    [Token(Token = "0x400D204")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private List<GameObject> unknownList;
    [Token(Token = "0x400D205")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private ArenaSceneBase sceneBase;
    [Token(Token = "0x400D206")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text playerName;
    [Token(Token = "0x400D207")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text combatPower;
    [Token(Token = "0x400D208")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private PersonalEmblemThumb personalEmblemThumb;
    [Token(Token = "0x400D209")]
    [FieldOffset(Offset = "0x48")]
    private List<AssetSpawnOperation<Sprite>> operationList;

    [Token(Token = "0x60133DB")]
    [Address(RVA = "0x4A238F4", Offset = "0x4A238F4", VA = "0x4A238F4")]
    public void Initialize(TeamParameter teamParam, bool unknown, Action onFinish)
    {
    }

    [Token(Token = "0x60133DC")]
    [Address(RVA = "0x4A23E8C", Offset = "0x4A23E8C", VA = "0x4A23E8C")]
    private (string, string) GetBundle(int styleId) => ();

    [Token(Token = "0x60133DD")]
    [Address(RVA = "0x4A23F0C", Offset = "0x4A23F0C", VA = "0x4A23F0C")]
    public ArenaTeam()
    {
    }
  }
}
