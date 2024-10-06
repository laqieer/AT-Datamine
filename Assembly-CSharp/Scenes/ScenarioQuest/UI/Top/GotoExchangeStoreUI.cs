// Decompiled with JetBrains decompiler
// Type: Scenes.ScenarioQuest.UI.Top.GotoExchangeStoreUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.ScenarioQuest.UI.Top
{
  [Token(Token = "0x2002946")]
  [AddComponentMenu("ScenarioQuestTopExchangeStoreUI")]
  public class GotoExchangeStoreUI : MonoBehaviour
  {
    [Token(Token = "0x400AFF3")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Button btn;
    [Token(Token = "0x400AFF4")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Image image;
    [Token(Token = "0x400AFF5")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TextMeshProUGUI text;

    [Token(Token = "0x14000146")]
    public event Action OnClick
    {
      [Token(Token = "0x60103AC"), Address(RVA = "0x475143C", Offset = "0x475143C", VA = "0x475143C")] add
      {
      }
      [Token(Token = "0x60103AD"), Address(RVA = "0x47514D8", Offset = "0x47514D8", VA = "0x47514D8")] remove
      {
      }
    }

    [Token(Token = "0x60103AE")]
    [Address(RVA = "0x4751574", Offset = "0x4751574", VA = "0x4751574")]
    public void LoadMedalIcon(AssetCachedSpawner spawner, int exchangeId)
    {
    }

    [Token(Token = "0x60103AF")]
    [Address(RVA = "0x4751704", Offset = "0x4751704", VA = "0x4751704")]
    public void SetExChangeText(int exchangeId)
    {
    }

    [Token(Token = "0x60103B0")]
    [Address(RVA = "0x47517C4", Offset = "0x47517C4", VA = "0x47517C4")]
    private void SetText(int id)
    {
    }

    [Token(Token = "0x60103B1")]
    [Address(RVA = "0x47518A8", Offset = "0x47518A8", VA = "0x47518A8")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x60103B2")]
    [Address(RVA = "0x4751994", Offset = "0x4751994", VA = "0x4751994")]
    private void ClickInvoke()
    {
    }

    [Token(Token = "0x60103B3")]
    [Address(RVA = "0x47519B8", Offset = "0x47519B8", VA = "0x47519B8")]
    public GotoExchangeStoreUI()
    {
    }
  }
}
