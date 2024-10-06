// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Popup.AddStatusContent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.EquipmentDetail;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Popup
{
  [Token(Token = "0x2003435")]
  public class AddStatusContent : MonoBehaviour
  {
    [Token(Token = "0x400E310")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text title;
    [Token(Token = "0x400E311")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private RectTransform parent;
    [Token(Token = "0x400E312")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private WeaponDetailAddedStatusContent baseStatusItem;
    [Token(Token = "0x400E313")]
    [FieldOffset(Offset = "0x30")]
    private List<WeaponDetailAddedStatusContent> createdList;

    [Token(Token = "0x601483D")]
    [Address(RVA = "0x189B3A0", Offset = "0x189B3A0", VA = "0x189B3A0")]
    public void Destroy()
    {
    }

    [Token(Token = "0x601483E")]
    [Address(RVA = "0x189B558", Offset = "0x189B558", VA = "0x189B558")]
    public void Set(string title, Tuple<string, int>[] statusDatas)
    {
    }

    [Token(Token = "0x601483F")]
    [Address(RVA = "0x189B85C", Offset = "0x189B85C", VA = "0x189B85C")]
    public AddStatusContent()
    {
    }
  }
}
