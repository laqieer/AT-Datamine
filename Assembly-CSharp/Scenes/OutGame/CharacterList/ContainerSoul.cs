// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.CharacterList.ContainerSoul
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.OutGameMenu;
using TMPro;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.CharacterList
{
  [Token(Token = "0x200371B")]
  public class ContainerSoul : MonoBehaviour
  {
    [Token(Token = "0x400F0A0")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextMeshProUGUI _costText;
    [Token(Token = "0x400F0A1")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CharacterListHeader _header;

    [Token(Token = "0x6015B3F")]
    [Address(RVA = "0x1D89DE0", Offset = "0x1D89DE0", VA = "0x1D89DE0")]
    public void SetCost(int cost, int diff, bool isEnough)
    {
    }

    [Token(Token = "0x6015B40")]
    [Address(RVA = "0x1D89F34", Offset = "0x1D89F34", VA = "0x1D89F34")]
    public ContainerSoul()
    {
    }
  }
}
