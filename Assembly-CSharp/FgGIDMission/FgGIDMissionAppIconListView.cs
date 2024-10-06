// Decompiled with JetBrains decompiler
// Type: FgGIDMission.FgGIDMissionAppIconListView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace FgGIDMission
{
  [Token(Token = "0x20019A1")]
  public class FgGIDMissionAppIconListView : MonoBehaviour
  {
    [Token(Token = "0x4006DFF")]
    [FieldOffset(Offset = "0x18")]
    [Header("アプリアイコン表示用テンプレ")]
    [SerializeField]
    private FgGIDMissionAppIconView templateListItemView;
    [Token(Token = "0x4006E00")]
    [FieldOffset(Offset = "0x20")]
    private int RequiredAppIconCount;
    [Token(Token = "0x4006E01")]
    [FieldOffset(Offset = "0x24")]
    private int MaxAppIconCount;
    [Token(Token = "0x4006E02")]
    [FieldOffset(Offset = "0x28")]
    private List<FgGIDMissionAppIconView> listItems;
    [Token(Token = "0x4006E03")]
    [FieldOffset(Offset = "0x30")]
    private IFgGIDMissionAppIconListPresenter presenter;

    [Token(Token = "0x17001789")]
    public IFgGIDMissionAppIconListPresenter Presenter
    {
      [Token(Token = "0x6009236"), Address(RVA = "0x4D0C648", Offset = "0x4D0C648", VA = "0x4D0C648")] set
      {
      }
    }

    [Token(Token = "0x6009237")]
    [Address(RVA = "0x4D0F9FC", Offset = "0x4D0F9FC", VA = "0x4D0F9FC")]
    private void Awake()
    {
    }

    [Token(Token = "0x6009238")]
    [Address(RVA = "0x4D0E140", Offset = "0x4D0E140", VA = "0x4D0E140")]
    public void InitializeListItem(int dataCount)
    {
    }

    [Token(Token = "0x6009239")]
    [Address(RVA = "0x4D0FA28", Offset = "0x4D0FA28", VA = "0x4D0FA28")]
    public FgGIDMissionAppIconListView()
    {
    }
  }
}
