// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Battle.ResultRetry.ConsumeItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Battle.ResultRetry
{
  [Token(Token = "0x20037BE")]
  public class ConsumeItem : MonoBehaviour
  {
    [Token(Token = "0x400F3AB")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Image _icon;
    [Token(Token = "0x400F3AC")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text _numText;

    [Token(Token = "0x6015F07")]
    [Address(RVA = "0x232A558", Offset = "0x232A558", VA = "0x232A558")]
    public void Initialize(AssetCachedSpawner spawner, int consumeItemId, int consumeNum)
    {
    }

    [Token(Token = "0x6015F08")]
    [Address(RVA = "0x232A694", Offset = "0x232A694", VA = "0x232A694")]
    public void SetIcon(Sprite sprite)
    {
    }

    [Token(Token = "0x6015F09")]
    [Address(RVA = "0x232A760", Offset = "0x232A760", VA = "0x232A760")]
    public void SetConsumeNum(int num)
    {
    }

    [Token(Token = "0x6015F0A")]
    [Address(RVA = "0x232A7EC", Offset = "0x232A7EC", VA = "0x232A7EC")]
    public ConsumeItem()
    {
    }
  }
}
