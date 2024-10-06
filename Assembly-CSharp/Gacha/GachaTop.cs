// Decompiled with JetBrains decompiler
// Type: Gacha.GachaTop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using StaqData;
using System;

#nullable disable
namespace Gacha
{
  [Token(Token = "0x200152A")]
  internal class GachaTop
  {
    [Token(Token = "0x4006151")]
    [FieldOffset(Offset = "0x10")]
    private GachaTopView gachaTopView;
    [Token(Token = "0x4006152")]
    [FieldOffset(Offset = "0x18")]
    private GachaBGPresenter gachaBGPresenter;
    [Token(Token = "0x4006153")]
    [FieldOffset(Offset = "0x20")]
    private IGachaResourceProvider resourceProvider;
    [Token(Token = "0x4006154")]
    [FieldOffset(Offset = "0x28")]
    private GachaDetailGroupInfo gachaDetailGroupInfo;
    [Token(Token = "0x4006155")]
    [FieldOffset(Offset = "0x30")]
    private GachaPayButtonTab gachaPayButtonTab;
    [Token(Token = "0x4006156")]
    [FieldOffset(Offset = "0x38")]
    public Action<GachaPaymentModel> PayButtonClicked;
    [Token(Token = "0x4006157")]
    [FieldOffset(Offset = "0x40")]
    public GachaTop.ProvidePopupOpen ProvidePopupOpenCallback;
    [Token(Token = "0x4006158")]
    [FieldOffset(Offset = "0x48")]
    public GachaTop.PickupPopupOpen PickupPopupOpenCallback;
    [Token(Token = "0x4006159")]
    [FieldOffset(Offset = "0x50")]
    private int selectedGachaIndex;

    [Token(Token = "0x17001272")]
    private int currentGroupId
    {
      [Token(Token = "0x60077E3"), Address(RVA = "0x44F59C0", Offset = "0x44F59C0", VA = "0x44F59C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001273")]
    private int currentGachaId
    {
      [Token(Token = "0x60077E4"), Address(RVA = "0x44F5A30", Offset = "0x44F5A30", VA = "0x44F5A30")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001274")]
    protected GachaDetailInfo CurrentGachaDetail
    {
      [Token(Token = "0x60077E5"), Address(RVA = "0x44F5A98", Offset = "0x44F5A98", VA = "0x44F5A98")] get
      {
        return (GachaDetailInfo) null;
      }
    }

    [Token(Token = "0x60077E6")]
    [Address(RVA = "0x44F5AF4", Offset = "0x44F5AF4", VA = "0x44F5AF4")]
    public GachaTop(
      GachaTopView view,
      GachaPayButtonTab gachaPayButtonTab,
      IGachaResourceProvider resourceProvider,
      AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x60077E7")]
    [Address(RVA = "0x44F5BA8", Offset = "0x44F5BA8", VA = "0x44F5BA8")]
    public void Open()
    {
    }

    [Token(Token = "0x60077E8")]
    [Address(RVA = "0x44F5D24", Offset = "0x44F5D24", VA = "0x44F5D24")]
    public void Close()
    {
    }

    [Token(Token = "0x60077E9")]
    [Address(RVA = "0x44F5D98", Offset = "0x44F5D98", VA = "0x44F5D98")]
    public void SetupGachaTop(GachaDetailGroupInfo gachaDetailGroupInfo)
    {
    }

    [Token(Token = "0x60077EA")]
    [Address(RVA = "0x44F65A8", Offset = "0x44F65A8", VA = "0x44F65A8")]
    public void UpdateGachaButtons()
    {
    }

    [Token(Token = "0x60077EB")]
    [Address(RVA = "0x44F61E4", Offset = "0x44F61E4", VA = "0x44F61E4")]
    private void UpdateGachaButtons(int groupId)
    {
    }

    [Token(Token = "0x60077EC")]
    [Address(RVA = "0x44F65CC", Offset = "0x44F65CC", VA = "0x44F65CC")]
    private bool HasPaymentTicket(int groupId) => new bool();

    [Token(Token = "0x60077ED")]
    [Address(RVA = "0x44F5EF8", Offset = "0x44F5EF8", VA = "0x44F5EF8")]
    private void AssignGachaBGPresenter(IGachaBGView view)
    {
    }

    [Token(Token = "0x60077EE")]
    [Address(RVA = "0x44F6138", Offset = "0x44F6138", VA = "0x44F6138")]
    private void UnassignGachaBGPresenter(IGachaBGView view)
    {
    }

    [Token(Token = "0x60077EF")]
    [Address(RVA = "0x44F603C", Offset = "0x44F603C", VA = "0x44F603C")]
    private void SetGachaTopTexture(int gachaId)
    {
    }

    [Token(Token = "0x60077F0")]
    [Address(RVA = "0x44F6AA4", Offset = "0x44F6AA4", VA = "0x44F6AA4", Slot = "4")]
    public virtual void OnGachaDetailChanged(GachaInfoHolder gachaInfoHolder, string gachaName)
    {
    }

    [Token(Token = "0x60077F1")]
    [Address(RVA = "0x44F6B10", Offset = "0x44F6B10", VA = "0x44F6B10")]
    public void SetInteractable(bool interactable)
    {
    }

    [Token(Token = "0x60077F2")]
    [Address(RVA = "0x44F6B2C", Offset = "0x44F6B2C", VA = "0x44F6B2C")]
    public void OpenProvidePopup(bool isOpenRatio)
    {
    }

    [Token(Token = "0x60077F3")]
    [Address(RVA = "0x44F6BD4", Offset = "0x44F6BD4", VA = "0x44F6BD4")]
    public void OpenPickupPopup()
    {
    }

    [Token(Token = "0x60077F4")]
    [Address(RVA = "0x44F6C74", Offset = "0x44F6C74", VA = "0x44F6C74")]
    public void OnBackScene()
    {
    }

    [Token(Token = "0x200152B")]
    public delegate void ProvidePopupOpen(string gachaName, int groupId, bool isOpenRatio);

    [Token(Token = "0x200152C")]
    public delegate void PickupPopupOpen(string gachaName, int groupId);
  }
}
