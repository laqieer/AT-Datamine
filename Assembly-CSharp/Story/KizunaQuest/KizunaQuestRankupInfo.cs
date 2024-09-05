// Decompiled with JetBrains decompiler
// Type: Story.KizunaQuest.KizunaQuestRankupInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using StaqData;
using UnityEngine;

#nullable disable
namespace Story.KizunaQuest
{
  [Token(Token = "0x200068F")]
  public class KizunaQuestRankupInfo : MonoBehaviour
  {
    [Token(Token = "0x4001F7F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RectTransform content;

    [Token(Token = "0x600256F")]
    [Address(RVA = "0x2F36454", Offset = "0x2F36454", VA = "0x2F36454")]
    public void Set(
      Communication communication,
      GameObject listItem,
      GameObject iconPrefab,
      AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x6002570")]
    [Address(RVA = "0x2F39574", Offset = "0x2F39574", VA = "0x2F39574")]
    public KizunaQuestRankupInfo()
    {
    }
  }
}
