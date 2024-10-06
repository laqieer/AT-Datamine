// Decompiled with JetBrains decompiler
// Type: LoginBonus.LoginBonusRewardListView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace LoginBonus
{
  [Token(Token = "0x2000B05")]
  public class LoginBonusRewardListView : MonoBehaviour
  {
    [Token(Token = "0x4003265")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<LoginBonusRewardListItemView> rewardListItems;

    [Token(Token = "0x6003ECB")]
    [Address(RVA = "0x2C15718", Offset = "0x2C15718", VA = "0x2C15718")]
    public void Setup(
      AssetCachedSpawner assetCachedSpawner,
      LoginBonusRewardHolder loginBonusRewardHolder,
      Action<ILoginBonusRewardUIParam> onRewardItemClicked)
    {
    }

    [Token(Token = "0x6003ECC")]
    [Address(RVA = "0x2C167FC", Offset = "0x2C167FC", VA = "0x2C167FC")]
    public LoginBonusRewardListItemView GetListItem(ILoginBonusRewardUIParam param)
    {
      return (LoginBonusRewardListItemView) null;
    }

    [Token(Token = "0x6003ECD")]
    [Address(RVA = "0x2C162A0", Offset = "0x2C162A0", VA = "0x2C162A0")]
    public IEnumerator PlayCheckIconOffAll() => (IEnumerator) null;

    [Token(Token = "0x6003ECE")]
    [Address(RVA = "0x2C17220", Offset = "0x2C17220", VA = "0x2C17220")]
    public LoginBonusRewardListView()
    {
    }
  }
}
