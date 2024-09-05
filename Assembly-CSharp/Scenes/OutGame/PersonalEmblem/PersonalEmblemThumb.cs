// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.PersonalEmblem.PersonalEmblemThumb
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.PersonalEmblem
{
  [Token(Token = "0x20034DE")]
  public class PersonalEmblemThumb : MonoBehaviour
  {
    [Token(Token = "0x400E610")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Image emblemImage;

    [Token(Token = "0x6014BD1")]
    [Address(RVA = "0x1D6690C", Offset = "0x1D6690C", VA = "0x1D6690C")]
    public void LoadImage(int emblemId, AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x6014BD2")]
    [Address(RVA = "0x1D64B28", Offset = "0x1D64B28", VA = "0x1D64B28")]
    public IEnumerator LoadImageAsync(int emblemId) => (IEnumerator) null;

    [Token(Token = "0x6014BD3")]
    [Address(RVA = "0x1D712D0", Offset = "0x1D712D0", VA = "0x1D712D0")]
    public IEnumerator LoadImageAsync(int emblemId, AssetCachedSpawner assetCachedSpawner)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6014BD4")]
    [Address(RVA = "0x1D71374", Offset = "0x1D71374", VA = "0x1D71374")]
    public PersonalEmblemThumb()
    {
    }
  }
}
