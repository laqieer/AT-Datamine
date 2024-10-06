// Decompiled with JetBrains decompiler
// Type: HorizontalInfiniteScrollView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
[Token(Token = "0x20002CE")]
public class HorizontalInfiniteScrollView : InfiniteScrollView
{
  [Token(Token = "0x400105E")]
  [FieldOffset(Offset = "0x89")]
  public bool isAtLeft;
  [Token(Token = "0x400105F")]
  [FieldOffset(Offset = "0x8A")]
  public bool isAtRight;
  [Token(Token = "0x4001060")]
  [FieldOffset(Offset = "0x8B")]
  [Tooltip("Cell 配置座標にCellPrefab の座標を加える")]
  [SerializeField]
  private bool AddCellPrefabPosition;

  [Token(Token = "0x170001B8")]
  public bool DisabledLastAddSpacing
  {
    [Token(Token = "0x6001185"), Address(RVA = "0x1BF35A0", Offset = "0x1BF35A0", VA = "0x1BF35A0")] get
    {
      return new bool();
    }
    [Token(Token = "0x6001186"), Address(RVA = "0x1BF35A8", Offset = "0x1BF35A8", VA = "0x1BF35A8")] set
    {
    }
  }

  [Token(Token = "0x6001187")]
  [Address(RVA = "0x1BF35B4", Offset = "0x1BF35B4", VA = "0x1BF35B4", Slot = "17")]
  public override void Initialize()
  {
  }

  [Token(Token = "0x6001188")]
  [Address(RVA = "0x1BF35D4", Offset = "0x1BF35D4", VA = "0x1BF35D4", Slot = "18")]
  protected override void OnValueChanged(Vector2 normalizedPosition)
  {
  }

  [Token(Token = "0x6001189")]
  [Address(RVA = "0x1BF3938", Offset = "0x1BF3938", VA = "0x1BF3938", Slot = "19")]
  public override sealed void Refresh()
  {
  }

  [Token(Token = "0x600118A")]
  [Address(RVA = "0x1BF3A34", Offset = "0x1BF3A34", VA = "0x1BF3A34")]
  private void DoRefresh()
  {
  }

  [Token(Token = "0x600118B")]
  [Address(RVA = "0x1BF39CC", Offset = "0x1BF39CC", VA = "0x1BF39CC")]
  private IEnumerator DelayToRefresh() => (IEnumerator) null;

  [Token(Token = "0x600118C")]
  [Address(RVA = "0x1BF3BD8", Offset = "0x1BF3BD8", VA = "0x1BF3BD8", Slot = "22")]
  public override void Snap(int index, float duration)
  {
  }

  [Token(Token = "0x600118D")]
  [Address(RVA = "0x1BF3DC8", Offset = "0x1BF3DC8", VA = "0x1BF3DC8", Slot = "21")]
  public override void Remove(int index)
  {
  }

  [Token(Token = "0x600118E")]
  [Address(RVA = "0x1BF3E70", Offset = "0x1BF3E70", VA = "0x1BF3E70")]
  public HorizontalInfiniteScrollView()
  {
  }
}
