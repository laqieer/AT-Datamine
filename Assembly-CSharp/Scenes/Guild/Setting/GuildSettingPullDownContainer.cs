// Decompiled with JetBrains decompiler
// Type: Scenes.Guild.Setting.GuildSettingPullDownContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

#nullable disable
namespace Scenes.Guild.Setting
{
  [Token(Token = "0x2002BAF")]
  public class GuildSettingPullDownContainer : MonoBehaviour
  {
    [Token(Token = "0x400B9F1")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextMeshProUGUI txtTitle;
    [Token(Token = "0x400B9F2")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextMeshProUGUI selectedTitle;
    [Token(Token = "0x400B9F3")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject openImg;
    [Token(Token = "0x400B9F4")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject closeImg;
    [Token(Token = "0x400B9F5")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private CommonButton button;
    [Token(Token = "0x400B9F6")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Transform columnParent;
    [Token(Token = "0x400B9F7")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GuildSettingPullDownColumn columnPrefab;
    [Token(Token = "0x400B9F8")]
    [FieldOffset(Offset = "0x50")]
    private List<GuildSettingPullDownColumn> columns;

    [Token(Token = "0x17003AE1")]
    public int SelectedKey
    {
      [Token(Token = "0x60110FD"), Address(RVA = "0x1C7BA28", Offset = "0x1C7BA28", VA = "0x1C7BA28")] get
      {
        return new int();
      }
      [Token(Token = "0x60110FE"), Address(RVA = "0x1C7BA30", Offset = "0x1C7BA30", VA = "0x1C7BA30")] private set
      {
      }
    }

    [Token(Token = "0x60110FF")]
    [Address(RVA = "0x1C7B24C", Offset = "0x1C7B24C", VA = "0x1C7B24C")]
    public void Setup(string title, List<KeyValuePair<int, string>> columnsPair, int selectedKey)
    {
    }

    [Token(Token = "0x6011100")]
    [Address(RVA = "0x1C7BD5C", Offset = "0x1C7BD5C", VA = "0x1C7BD5C")]
    public void Open()
    {
    }

    [Token(Token = "0x6011101")]
    [Address(RVA = "0x1C7BC34", Offset = "0x1C7BC34", VA = "0x1C7BC34")]
    public void Close()
    {
    }

    [Token(Token = "0x6011102")]
    [Address(RVA = "0x1C7BE84", Offset = "0x1C7BE84", VA = "0x1C7BE84")]
    public void OnClick()
    {
    }

    [Token(Token = "0x6011103")]
    [Address(RVA = "0x1C7BA38", Offset = "0x1C7BA38", VA = "0x1C7BA38")]
    private void SetSelected(int key)
    {
    }

    [Token(Token = "0x6011104")]
    [Address(RVA = "0x1C7BEC4", Offset = "0x1C7BEC4", VA = "0x1C7BEC4")]
    public GuildSettingPullDownContainer()
    {
    }
  }
}
