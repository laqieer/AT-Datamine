// Decompiled with JetBrains decompiler
// Type: Scenes.Expedition.BossList.BossDeck.BossDeckUnit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Tween;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.Expedition.BossList.BossDeck
{
  [Token(Token = "0x2002D48")]
  [AddComponentMenu("Scenes/Expedition/BossList/BossDeck/Unit")]
  public class BossDeckUnit : MonoBehaviour
  {
    [Token(Token = "0x400C250")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject dotParent;
    [Token(Token = "0x400C251")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject topPararaBoost;
    [Token(Token = "0x400C252")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400C257")]
    [FieldOffset(Offset = "0x48")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400C258")]
    [FieldOffset(Offset = "0x50")]
    private GameObject dotObject;
    [Token(Token = "0x400C259")]
    [FieldOffset(Offset = "0x58")]
    private Queue<(int num, bool lit)> queEffects;
    [Token(Token = "0x400C25A")]
    [FieldOffset(Offset = "0x60")]
    private Queue<(int num, bool lit)> flashEffects;
    [Token(Token = "0x400C25B")]
    [FieldOffset(Offset = "0x68")]
    private (int num, bool lit) lastEffect;
    [Token(Token = "0x400C25C")]
    private const int MAX_PARARA_BOOST = 5;

    [Token(Token = "0x17003C8A")]
    public int? StyleId
    {
      [Token(Token = "0x6011B32"), Address(RVA = "0x42B4A34", Offset = "0x42B4A34", VA = "0x42B4A34")] get
      {
        return new int?();
      }
      [Token(Token = "0x6011B33"), Address(RVA = "0x42B4A3C", Offset = "0x42B4A3C", VA = "0x42B4A3C")] private set
      {
      }
    }

    [Token(Token = "0x17003C8B")]
    public int? Rank
    {
      [Token(Token = "0x6011B34"), Address(RVA = "0x42B4A44", Offset = "0x42B4A44", VA = "0x42B4A44")] get
      {
        return new int?();
      }
      [Token(Token = "0x6011B35"), Address(RVA = "0x42B4A4C", Offset = "0x42B4A4C", VA = "0x42B4A4C")] private set
      {
      }
    }

    [Token(Token = "0x17003C8C")]
    public bool IsLoading
    {
      [Token(Token = "0x6011B36"), Address(RVA = "0x42B4A54", Offset = "0x42B4A54", VA = "0x42B4A54")] get
      {
        return new bool();
      }
      [Token(Token = "0x6011B37"), Address(RVA = "0x42B4A5C", Offset = "0x42B4A5C", VA = "0x42B4A5C")] private set
      {
      }
    }

    [Token(Token = "0x17003C8D")]
    public bool IsPlayingAnime
    {
      [Token(Token = "0x6011B38"), Address(RVA = "0x42B4A68", Offset = "0x42B4A68", VA = "0x42B4A68")] get
      {
        return new bool();
      }
      [Token(Token = "0x6011B39"), Address(RVA = "0x42B4A70", Offset = "0x42B4A70", VA = "0x42B4A70")] private set
      {
      }
    }

    [Token(Token = "0x6011B3A")]
    [Address(RVA = "0x42B4A7C", Offset = "0x42B4A7C", VA = "0x42B4A7C")]
    public void Initialize(AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x6011B3B")]
    [Address(RVA = "0x42B4C10", Offset = "0x42B4C10", VA = "0x42B4C10")]
    public void SetDot(int styleId)
    {
    }

    [Token(Token = "0x6011B3C")]
    [Address(RVA = "0x42B4A84", Offset = "0x42B4A84", VA = "0x42B4A84")]
    public void SetEmpty()
    {
    }

    [Token(Token = "0x6011B3D")]
    [Address(RVA = "0x42B5000", Offset = "0x42B5000", VA = "0x42B5000")]
    public void SetPararaBoost(int rank)
    {
    }

    [Token(Token = "0x6011B3E")]
    [Address(RVA = "0x42B4E48", Offset = "0x42B4E48", VA = "0x42B4E48")]
    private void PlayEffectPararaBoost(bool isFirst)
    {
    }

    [Token(Token = "0x6011B3F")]
    [Address(RVA = "0x42B53D0", Offset = "0x42B53D0", VA = "0x42B53D0")]
    private void ResetPararaBoost(int rank)
    {
    }

    [Token(Token = "0x6011B40")]
    [Address(RVA = "0x42B4DA0", Offset = "0x42B4DA0", VA = "0x42B4DA0")]
    private void DeleteObject()
    {
    }

    [Token(Token = "0x6011B41")]
    [Address(RVA = "0x42B5434", Offset = "0x42B5434", VA = "0x42B5434")]
    private string GetPararaBoostAnim(int number, bool lit) => (string) null;

    [Token(Token = "0x6011B42")]
    [Address(RVA = "0x42B5540", Offset = "0x42B5540", VA = "0x42B5540")]
    public BossDeckUnit()
    {
    }
  }
}
