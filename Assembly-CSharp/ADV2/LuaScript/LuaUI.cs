// Decompiled with JetBrains decompiler
// Type: ADV2.LuaScript.LuaUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using ADV2.Utility;
using Dicing;
using Il2CppDummyDll;
using MoonSharp.Interpreter;
using System;
using System.Collections;
using System.Collections.Generic;
using UI.Utilities;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ADV2.LuaScript
{
  [Token(Token = "0x2003EEA")]
  [MoonSharpUserData]
  public class LuaUI : LuaSignal, IDisposable
  {
    [Token(Token = "0x40113D9")]
    [FieldOffset(Offset = "0x18")]
    protected Adv2UI advObject;
    [Token(Token = "0x40113DA")]
    [FieldOffset(Offset = "0x20")]
    private Adv2BranchPointController branchPointController;
    [Token(Token = "0x40113DB")]
    [FieldOffset(Offset = "0x28")]
    private ImageAdjustController imageAdjustController;
    [Token(Token = "0x40113DC")]
    [FieldOffset(Offset = "0x30")]
    private UnityEngine.Coroutine moveCoroutine;
    [Token(Token = "0x40113DD")]
    [FieldOffset(Offset = "0x38")]
    private UnityEngine.Coroutine scaleCoroutine;

    [Token(Token = "0x601968B")]
    [Address(RVA = "0x3734600", Offset = "0x3734600", VA = "0x3734600")]
    public LuaUI(Adv2UI instance)
    {
    }

    [Token(Token = "0x601968C")]
    [Address(RVA = "0x3736B48", Offset = "0x3736B48", VA = "0x3736B48", Slot = "4")]
    public override void Empty(bool isRemoveObject)
    {
    }

    [Token(Token = "0x601968D")]
    [Address(RVA = "0x3736C10", Offset = "0x3736C10", VA = "0x3736C10", Slot = "5")]
    public void Dispose()
    {
    }

    [Token(Token = "0x601968E")]
    [Address(RVA = "0x3736C20", Offset = "0x3736C20", VA = "0x3736C20")]
    public LuaUI CreateLoadUI(string partsTag) => (LuaUI) null;

    [Token(Token = "0x601968F")]
    [Address(RVA = "0x3736D54", Offset = "0x3736D54", VA = "0x3736D54")]
    public LuaUI DuplicateUI() => (LuaUI) null;

    [Token(Token = "0x6019690")]
    [Address(RVA = "0x3736DC8", Offset = "0x3736DC8", VA = "0x3736DC8")]
    public void SetActive(bool isActive)
    {
    }

    [Token(Token = "0x6019691")]
    [Address(RVA = "0x37365B4", Offset = "0x37365B4", VA = "0x37365B4")]
    public void SetActive(string partsTag, bool isActive)
    {
    }

    [Token(Token = "0x6019692")]
    [Address(RVA = "0x3736DE8", Offset = "0x3736DE8", VA = "0x3736DE8")]
    public void ResetSelectedObject(string partsTag)
    {
    }

    [Token(Token = "0x6019693")]
    [Address(RVA = "0x3736EE0", Offset = "0x3736EE0", VA = "0x3736EE0")]
    public bool GetActive() => new bool();

    [Token(Token = "0x6019694")]
    [Address(RVA = "0x3736EFC", Offset = "0x3736EFC", VA = "0x3736EFC")]
    public bool GetActive(string partsTag) => new bool();

    [Token(Token = "0x6019695")]
    [Address(RVA = "0x3736FA0", Offset = "0x3736FA0", VA = "0x3736FA0")]
    public string GetText(string messageTag) => (string) null;

    [Token(Token = "0x6019696")]
    [Address(RVA = "0x3736FBC", Offset = "0x3736FBC", VA = "0x3736FBC")]
    public string[] GetTexts(string messageTag) => (string[]) null;

    [Token(Token = "0x6019697")]
    [Address(RVA = "0x3737094", Offset = "0x3737094", VA = "0x3737094")]
    public void SetTextTag(string partsTag, string messageTag)
    {
    }

    [Token(Token = "0x6019698")]
    [Address(RVA = "0x37370E0", Offset = "0x37370E0", VA = "0x37370E0")]
    public void SetMessageTag(string partsTag, string messageTag, string inputKey)
    {
    }

    [Token(Token = "0x6019699")]
    [Address(RVA = "0x3734CB0", Offset = "0x3734CB0", VA = "0x3734CB0")]
    public void SetText(string partsTag, string messageText)
    {
    }

    [Token(Token = "0x601969A")]
    [Address(RVA = "0x3737134", Offset = "0x3737134", VA = "0x3737134")]
    public void SetMessage(string partsTag, string messageText, string inputKey)
    {
    }

    [Token(Token = "0x601969B")]
    [Address(RVA = "0x3737150", Offset = "0x3737150", VA = "0x3737150")]
    public bool IsOneCharacterProcess(string partsTag) => new bool();

    [Token(Token = "0x601969C")]
    [Address(RVA = "0x373716C", Offset = "0x373716C", VA = "0x373716C")]
    public void DrawMessageAll(string partsTag)
    {
    }

    [Token(Token = "0x601969D")]
    [Address(RVA = "0x3737188", Offset = "0x3737188", VA = "0x3737188")]
    public void SetSimpleText(string partsTag, string text)
    {
    }

    [Token(Token = "0x601969E")]
    [Address(RVA = "0x37371F4", Offset = "0x37371F4", VA = "0x37371F4")]
    public void SetSimpleTextTag(string partsTag, string messageTag)
    {
    }

    [Token(Token = "0x601969F")]
    [Address(RVA = "0x3737240", Offset = "0x3737240", VA = "0x3737240")]
    public LuaSignalMini Play(string tweenGroupID, bool lastActive) => (LuaSignalMini) null;

    [Token(Token = "0x60196A0")]
    [Address(RVA = "0x37372DC", Offset = "0x37372DC", VA = "0x37372DC")]
    public LuaSignalMini Play(bool lastActive, List<string> tweenGroupIDs) => (LuaSignalMini) null;

    [Token(Token = "0x60196A1")]
    [Address(RVA = "0x3737378", Offset = "0x3737378", VA = "0x3737378")]
    public void PlayStop()
    {
    }

    [Token(Token = "0x60196A2")]
    [Address(RVA = "0x3737394", Offset = "0x3737394", VA = "0x3737394")]
    public LuaSignalMini WaitPlayingTween() => (LuaSignalMini) null;

    [Token(Token = "0x60196A3")]
    [Address(RVA = "0x3736204", Offset = "0x3736204", VA = "0x3736204")]
    public LuaSignalMini Play(string partsTag, string tweenGroupID, bool lastActive)
    {
      return (LuaSignalMini) null;
    }

    [Token(Token = "0x60196A4")]
    [Address(RVA = "0x3737410", Offset = "0x3737410", VA = "0x3737410")]
    public void Skip()
    {
    }

    [Token(Token = "0x60196A5")]
    [Address(RVA = "0x373742C", Offset = "0x373742C", VA = "0x373742C")]
    public void CancelInput(params string[] keys)
    {
    }

    [Token(Token = "0x60196A6")]
    [Address(RVA = "0x37374EC", Offset = "0x37374EC", VA = "0x37374EC")]
    public void Input(params string[] keys)
    {
    }

    [Token(Token = "0x60196A7")]
    [Address(RVA = "0x373758C", Offset = "0x373758C", VA = "0x373758C")]
    public void Input(LuaUI[] parts, string buttonName)
    {
    }

    [Token(Token = "0x60196A8")]
    [Address(RVA = "0x3737694", Offset = "0x3737694", VA = "0x3737694")]
    public void Input(Table table, bool isKey, bool isSelectOption = false)
    {
    }

    [Token(Token = "0x60196A9")]
    [Address(RVA = "0x3737D98", Offset = "0x3737D98", VA = "0x3737D98")]
    public void SetButtonFunction(string key, DynValue callback, bool clear)
    {
    }

    [Token(Token = "0x60196AA")]
    [Address(RVA = "0x3737E80", Offset = "0x3737E80", VA = "0x3737E80")]
    public void SetEventFunction(string key, string eventTypeName, DynValue callback, bool clear)
    {
    }

    [Token(Token = "0x60196AB")]
    [Address(RVA = "0x3738024", Offset = "0x3738024", VA = "0x3738024")]
    public void SetButtonColor(string key, float r, float g, float b, float a)
    {
    }

    [Token(Token = "0x60196AC")]
    [Address(RVA = "0x3738040", Offset = "0x3738040", VA = "0x3738040")]
    public void SetImageColor(string key, float r, float g, float b, float a)
    {
    }

    [Token(Token = "0x60196AD")]
    [Address(RVA = "0x373805C", Offset = "0x373805C", VA = "0x373805C")]
    public void SetButtonEnable(string key, bool enable)
    {
    }

    [Token(Token = "0x60196AE")]
    [Address(RVA = "0x373807C", Offset = "0x373807C", VA = "0x373807C")]
    public void SetButtonInteractable(string key, bool interactable)
    {
    }

    [Token(Token = "0x60196AF")]
    [Address(RVA = "0x373809C", Offset = "0x373809C", VA = "0x373809C")]
    public void SetButtonsInteractable(bool interactable)
    {
    }

    [Token(Token = "0x60196B0")]
    [Address(RVA = "0x37380BC", Offset = "0x37380BC", VA = "0x37380BC")]
    public void SetButtonActive(string key, bool active)
    {
    }

    [Token(Token = "0x60196B1")]
    [Address(RVA = "0x37380DC", Offset = "0x37380DC", VA = "0x37380DC")]
    public void SetAsLastSibling()
    {
    }

    [Token(Token = "0x60196B2")]
    [Address(RVA = "0x37380F8", Offset = "0x37380F8", VA = "0x37380F8")]
    public void SetAsFirstSibling()
    {
    }

    [Token(Token = "0x60196B3")]
    [Address(RVA = "0x3738114", Offset = "0x3738114", VA = "0x3738114")]
    public void ChangeParent2dRoot()
    {
    }

    [Token(Token = "0x60196B4")]
    [Address(RVA = "0x3738130", Offset = "0x3738130", VA = "0x3738130")]
    public void ChangeParentBack2dRoot()
    {
    }

    [Token(Token = "0x60196B5")]
    [Address(RVA = "0x373814C", Offset = "0x373814C", VA = "0x373814C")]
    public void SetAdvLogPivot(string partsTag)
    {
    }

    [Token(Token = "0x60196B6")]
    [Address(RVA = "0x3738214", Offset = "0x3738214", VA = "0x3738214")]
    public string GetSelectedKey() => (string) null;

    [Token(Token = "0x60196B7")]
    [Address(RVA = "0x3738230", Offset = "0x3738230", VA = "0x3738230")]
    public void AttachStackObject(string parentObjectTag, string stackTag)
    {
    }

    [Token(Token = "0x60196B8")]
    [Address(RVA = "0x3738480", Offset = "0x3738480", VA = "0x3738480")]
    public void DeattachStackObject(string parentObjectTag)
    {
    }

    [Token(Token = "0x60196B9")]
    [Address(RVA = "0x3738608", Offset = "0x3738608", VA = "0x3738608")]
    public void AttachCharacterImage(
      string parentObjectTag,
      string stackTag,
      string facial2DTag,
      LuaHuman human,
      bool validLipsync,
      float talkSpeed)
    {
    }

    [Token(Token = "0x60196BA")]
    [Address(RVA = "0x3738B64", Offset = "0x3738B64", VA = "0x3738B64")]
    public void ChangeCharacterImage(string objectTag, string stackTag)
    {
    }

    [Token(Token = "0x60196BB")]
    [Address(RVA = "0x3735020", Offset = "0x3735020", VA = "0x3735020")]
    public void CreateCharacterBustUpImage(
      string objectTag,
      string stackTag,
      IllustLayoutInfo illustLayoutInfo)
    {
    }

    [Token(Token = "0x60196BC")]
    [Address(RVA = "0x3734CCC", Offset = "0x3734CCC", VA = "0x3734CCC")]
    public void DestroyChildren(string objectTag)
    {
    }

    [Token(Token = "0x60196BD")]
    [Address(RVA = "0x3738A40", Offset = "0x3738A40", VA = "0x3738A40")]
    private void InitializeImageAdjustController(
      CharaImage characterImage,
      IllustLayoutInfo illustLayoutInfo)
    {
    }

    [Token(Token = "0x60196BE")]
    [Address(RVA = "0x3738D18", Offset = "0x3738D18", VA = "0x3738D18")]
    public void ChangeCharacterFacial(string parentObjectTag, string facial2DTag)
    {
    }

    [Token(Token = "0x60196BF")]
    [Address(RVA = "0x3738E30", Offset = "0x3738E30", VA = "0x3738E30")]
    public void SetOnImage2D(string stackTag, float offsetX, float offsetY)
    {
    }

    [Token(Token = "0x60196C0")]
    [Address(RVA = "0x37390D8", Offset = "0x37390D8", VA = "0x37390D8")]
    public void SetMaskImage2D(bool showMask)
    {
    }

    [Token(Token = "0x60196C1")]
    [Address(RVA = "0x37391E0", Offset = "0x37391E0", VA = "0x37391E0")]
    public void SetImagePosition(float x, float y)
    {
    }

    [Token(Token = "0x60196C2")]
    [Address(RVA = "0x3739318", Offset = "0x3739318", VA = "0x3739318")]
    public LuaSignalMini ImageMoveTo(float x, float y, float duration, string methodName)
    {
      return (LuaSignalMini) null;
    }

    [Token(Token = "0x60196C3")]
    [Address(RVA = "0x37395A0", Offset = "0x37395A0", VA = "0x37395A0")]
    private IEnumerator coMoveTo(
      RectTransform rect,
      float x,
      float y,
      float duration,
      Easing.Method method,
      Adv2Manager.OnProccessSignal signal)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60196C4")]
    [Address(RVA = "0x3739678", Offset = "0x3739678", VA = "0x3739678")]
    public void SetImageScale(float x, float y)
    {
    }

    [Token(Token = "0x60196C5")]
    [Address(RVA = "0x37397B4", Offset = "0x37397B4", VA = "0x37397B4")]
    public LuaSignalMini ImageScaleTo(float x, float y, float duration, string methodName)
    {
      return (LuaSignalMini) null;
    }

    [Token(Token = "0x60196C6")]
    [Address(RVA = "0x37399B8", Offset = "0x37399B8", VA = "0x37399B8")]
    private IEnumerator coScaleTo(
      RectTransform rect,
      float x,
      float y,
      float duration,
      Easing.Method method,
      Adv2Manager.OnProccessSignal signal)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60196C7")]
    [Address(RVA = "0x3739A90", Offset = "0x3739A90", VA = "0x3739A90")]
    public void SetFadeDuration(string parentObjectTag, string TweenGroupTag, float duration)
    {
    }

    [Token(Token = "0x60196C8")]
    [Address(RVA = "0x3739BAC", Offset = "0x3739BAC", VA = "0x3739BAC")]
    public void SetSliderValue(string tweenGroupID, float fromValue, float toValue)
    {
    }

    [Token(Token = "0x60196C9")]
    [Address(RVA = "0x3739BC8", Offset = "0x3739BC8", VA = "0x3739BC8")]
    public void SetLockState()
    {
    }

    [Token(Token = "0x60196CA")]
    [Address(RVA = "0x3739C40", Offset = "0x3739C40", VA = "0x3739C40")]
    public void SetOpenFooter(LuaUI luaUI, bool fristOpen, bool fristOpenInLifeTime)
    {
    }

    [Token(Token = "0x60196CB")]
    [Address(RVA = "0x3739D60", Offset = "0x3739D60", VA = "0x3739D60")]
    public void SetChaperItemIcon(string key, int itemId, int num)
    {
    }

    [Token(Token = "0x60196CC")]
    [Address(RVA = "0x3739D7C", Offset = "0x3739D7C", VA = "0x3739D7C")]
    public void StartTimeline(string parts)
    {
    }

    [Token(Token = "0x60196CD")]
    [Address(RVA = "0x3739E00", Offset = "0x3739E00", VA = "0x3739E00")]
    public void StopTimeline(string parts)
    {
    }

    [Token(Token = "0x60196CE")]
    [Address(RVA = "0x3739E70", Offset = "0x3739E70", VA = "0x3739E70")]
    public void ResetTimeline(string parts)
    {
    }

    [Token(Token = "0x60196CF")]
    [Address(RVA = "0x3739EF4", Offset = "0x3739EF4", VA = "0x3739EF4")]
    public bool WaitForTimeline(string partsTag) => new bool();

    [Token(Token = "0x60196D0")]
    [Address(RVA = "0x3739F70", Offset = "0x3739F70", VA = "0x3739F70")]
    public void SetTimelineSignal(string parts, int index, DynValue callback)
    {
    }

    [Token(Token = "0x60196D1")]
    [Address(RVA = "0x373A0C8", Offset = "0x373A0C8", VA = "0x373A0C8")]
    public void SetTimeline(string partsTag, string name)
    {
    }

    [Token(Token = "0x60196D2")]
    [Address(RVA = "0x3735DC8", Offset = "0x3735DC8", VA = "0x3735DC8")]
    public void SetItemIcon(string partsTag, int index)
    {
    }

    [Token(Token = "0x60196D3")]
    [Address(RVA = "0x373A24C", Offset = "0x373A24C", VA = "0x373A24C")]
    public void SetSkillIcon(string partsTag, int index)
    {
    }

    [Token(Token = "0x60196D4")]
    [Address(RVA = "0x373A400", Offset = "0x373A400", VA = "0x373A400")]
    public void SetCommunicationSkillIcon(string partsTag, int index)
    {
    }

    [Token(Token = "0x60196D5")]
    [Address(RVA = "0x3735C74", Offset = "0x3735C74", VA = "0x3735C74")]
    public void SetStyleIcon(string partsTag, int index)
    {
    }

    [Token(Token = "0x60196D6")]
    [Address(RVA = "0x373A65C", Offset = "0x373A65C", VA = "0x373A65C")]
    public void SetCutinCharacterImage(
      string objectTag,
      string stackTag,
      string facial2DTag,
      bool mouthOpen,
      LuaHuman human,
      bool opened)
    {
    }

    [Token(Token = "0x60196D7")]
    [Address(RVA = "0x373A884", Offset = "0x373A884", VA = "0x373A884")]
    public LuaSignalMini InitializeTimelineController(string objectTag) => (LuaSignalMini) null;

    [Token(Token = "0x60196D8")]
    [Address(RVA = "0x373AAB0", Offset = "0x373AAB0", VA = "0x373AAB0")]
    public LuaSignalMini PlayUITimelineControllerInAnimation(string objectTag, string playKey = null)
    {
      return (LuaSignalMini) null;
    }

    [Token(Token = "0x60196D9")]
    [Address(RVA = "0x373AD60", Offset = "0x373AD60", VA = "0x373AD60")]
    public LuaSignalMini PlayUITimelineControllerOutAnimation(
      string objectTag,
      bool lastActive,
      string playKey = null)
    {
      return (LuaSignalMini) null;
    }

    [Token(Token = "0x60196DA")]
    [Address(RVA = "0x373AFE8", Offset = "0x373AFE8", VA = "0x373AFE8")]
    public void ResetAdvLogList()
    {
    }

    [Token(Token = "0x60196DB")]
    [Address(RVA = "0x373B0A4", Offset = "0x373B0A4", VA = "0x373B0A4")]
    public LuaSignal BranchPointControll(string command, string textId) => (LuaSignal) null;

    [Token(Token = "0x60196DC")]
    [Address(RVA = "0x373B248", Offset = "0x373B248", VA = "0x373B248")]
    public void SetScrollPosition(
      string partTag,
      float horizontalNormalizedPosition,
      float verticalNormalizedPosition)
    {
    }

    [Token(Token = "0x60196DD")]
    [Address(RVA = "0x373B360", Offset = "0x373B360", VA = "0x373B360")]
    public void SetEnableScroll(string partTag, bool horizontal, bool vertical)
    {
    }

    [Token(Token = "0x60196DE")]
    [Address(RVA = "0x373B45C", Offset = "0x373B45C", VA = "0x373B45C")]
    public LuaSignalMini MoveSelectBoxScrollObject(
      string scrollRectTag,
      string targetTag,
      float time)
    {
      return (LuaSignalMini) null;
    }

    [Token(Token = "0x60196DF")]
    [Address(RVA = "0x373B8B4", Offset = "0x373B8B4", VA = "0x373B8B4")]
    private IEnumerator coMoveSelectBoxScrollObject(
      ScrollRect scrollRect,
      float targetPos,
      float duration,
      Adv2Manager.OnProccessSignal signal)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60196E0")]
    [Address(RVA = "0x373B964", Offset = "0x373B964", VA = "0x373B964")]
    public void SetMaskColor(string colorCode)
    {
    }

    [Token(Token = "0x60196E1")]
    [Address(RVA = "0x373BA94", Offset = "0x373BA94", VA = "0x373BA94")]
    public void EnableUnmaskRaycastFilter(bool enableRaycastFilter)
    {
    }

    [Token(Token = "0x60196E2")]
    [Address(RVA = "0x373BB9C", Offset = "0x373BB9C", VA = "0x373BB9C")]
    public void SetTutorialUnmask(float x, float y, float width, float height)
    {
    }

    [Token(Token = "0x60196E3")]
    [Address(RVA = "0x373BD40", Offset = "0x373BD40", VA = "0x373BD40")]
    private void SetTargetPosition(
      RectTransform setObject,
      RectTransform targetTransform,
      float offsetX,
      float offsetY,
      float offsetSizeX,
      float offsetSizeY)
    {
    }

    [Token(Token = "0x60196E4")]
    [Address(RVA = "0x373BF98", Offset = "0x373BF98", VA = "0x373BF98")]
    public void SetTutorialUnmaskTarget(
      string accesserName,
      bool imageMask,
      float offsetX,
      float offsetY,
      float offsetSizeX,
      float offsetSizeY)
    {
    }

    [Token(Token = "0x60196E5")]
    [Address(RVA = "0x373C2F4", Offset = "0x373C2F4", VA = "0x373C2F4")]
    public void SetTutorialUnmaskStyleThumb(
      string accesserName,
      int styleId,
      bool imageMask,
      float offsetX,
      float offsetY,
      float offsetSizeX,
      float offsetSizeY)
    {
    }

    [Token(Token = "0x60196E6")]
    [Address(RVA = "0x373C400", Offset = "0x373C400", VA = "0x373C400")]
    public void SetTutorialUnmaskExpeditionFieldBanner(
      string accesserName,
      int stageId,
      bool imageMask,
      float offsetX,
      float offsetY,
      float offsetSizeX,
      float offsetSizeY)
    {
    }

    [Token(Token = "0x60196E7")]
    [Address(RVA = "0x373C50C", Offset = "0x373C50C", VA = "0x373C50C")]
    public void SetTutorialUnmaskExpeditionBossList(
      string accesserName,
      int bossId,
      string objectName,
      bool imageMask,
      float offsetX,
      float offsetY,
      float offsetSizeX,
      float offsetSizeY)
    {
    }

    [Token(Token = "0x60196E8")]
    [Address(RVA = "0x373C09C", Offset = "0x373C09C", VA = "0x373C09C")]
    private void SetTutorialUnmaskTarget(
      GameObject unmaskGo,
      GameObject targetGo,
      bool imageMask,
      float offsetX,
      float offsetY,
      float offsetSizeX,
      float offsetSizeY)
    {
    }

    [Token(Token = "0x60196E9")]
    [Address(RVA = "0x373C64C", Offset = "0x373C64C", VA = "0x373C64C")]
    public void SetPosition(string partObject, float x, float y)
    {
    }

    [Token(Token = "0x60196EA")]
    [Address(RVA = "0x373C758", Offset = "0x373C758", VA = "0x373C758")]
    public void SetPositionTarget(
      string partObject,
      string accesserName,
      float offsetX,
      float offsetY)
    {
    }

    [Token(Token = "0x60196EB")]
    [Address(RVA = "0x373C934", Offset = "0x373C934", VA = "0x373C934")]
    public void SetPositionStyleThumb(
      string partObject,
      string accesserName,
      int styleId,
      float offsetX,
      float offsetY)
    {
    }

    [Token(Token = "0x60196EC")]
    [Address(RVA = "0x373CB18", Offset = "0x373CB18", VA = "0x373CB18")]
    public void SetPositionExpeditionFieldBanner(
      string partObject,
      string accesserName,
      int stageId,
      float offsetX,
      float offsetY)
    {
    }

    [Token(Token = "0x60196ED")]
    [Address(RVA = "0x373CCFC", Offset = "0x373CCFC", VA = "0x373CCFC")]
    public void SetPositionExpeditionBossList(
      string partObject,
      string accesserName,
      int bossId,
      string objectName,
      float offsetX,
      float offsetY)
    {
    }

    [Token(Token = "0x60196EE")]
    [Address(RVA = "0x373CF18", Offset = "0x373CF18", VA = "0x373CF18")]
    public void SetRotation(string partObject, float z)
    {
    }

    [Token(Token = "0x60196EF")]
    [Address(RVA = "0x373D024", Offset = "0x373D024", VA = "0x373D024")]
    public void SetCanvasGroupAlpha(string partTag, float alpha)
    {
    }
  }
}
