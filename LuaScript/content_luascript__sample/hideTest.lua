-- このluaスクリプトは、adv_event_small_hide.xlsm の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_02","110051_02_h")
Include("content_adv_advsmall_110051_02","Template110051_02_h")

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110051)
	Actor001 = InitializeCharacter("101009","002","101009002",CharaPos001,"101009002","Com_m_SitController","to Sit01_Loop")
	Actor002 = InitializeCharacter("101009","004","101009004",CharaPos002,"101009004","Com_m_SitController","to Sit01_Loop")
	Actor003 = InitializeCharacter("101014","001","101014001",CharaPos001,"101014001","Chr_004_01_SitController","to Sit01_Loop")
	InitializeCharaCamera(CameraAssetBundleName,CameraPos001,Actor001)
	InitializeCharaCamera(CameraAssetBundleName,CameraPos002,Actor002)
	InitializeCharaCamera(CameraAssetBundleName,CameraPos001,Actor003)
	InitializeTemplateRandomCamera()
	InitializeTemplate()
-- ▼直接出力
Hide(Actor003)

-- ▲直接出力
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:
	TalkTest(Actor001,"CHRNAME_NOIR","speech","L","恐怖を教えてやろう")

-- ▼直接出力
Hide(Actor001)

-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
Appear(Actor003)

-- ▲直接出力

	--★★トリスタン★★:
	TalkTest(Actor003,"CHRNAME_NOIR","speech","L","ですやんか")

	PlayAction(Actor003,"to  Std_Talk")

	--★★トリスタン★★:
	TalkTest(Actor003,"CHRNAME_NOIR","speech","L","ふたこと")

	PlayAction(Actor003,"to  Std_Talk")

	--★★トリスタン★★:
	TalkTest(Actor003,"CHRNAME_NOIR","speech","L","みこと")

	EndPlay()
end


function TalkTest(controllerId, talkerNameTag, frameType, dir, textId)
	-- 必要があれば前回開いたウインドウを閉じる
	if CheckIfNeedClose(controllerId, frameType, dir) == true then
		CloseTalkWindow()
	end
	-- 必要があればウインドウを開く
	if CheckIfNeedOpen(controllerId, frameType, dir) == true then
		OpenTalkWindow(talkerNameTag, controllerId, frameType, dir)
	end

	if manager ~= nil then
		-- カメラワークのための通知
		manager.CloseupUpExclusiveCamera(controllerId)
	end

	lastTalkControllerId = controllerId

    PlayReservedPlayAction()

    PlayBranchPoint(textId)
    
	-- テスト用
	message_direct(textId)
	-- 本番用
    --message(textId)

	EndBranchPoint()

	-- しゃべった人のモーションを戻す
	animator_default_motion_if_need(lastTalkControllerId)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110051)
	InitializeCharacter_Preload("101009","002","101009002",CharaPos001,"101009002","Com_m_SitController","to Sit01_Loop")
	InitializeCharacter_Preload("101009","004","101009004",CharaPos002,"101009004","Com_m_SitController","to Sit01_Loop")
	InitializeCharacter_Preload("101014","001","101014001",CharaPos001,"101014001","Chr_004_01_SitController","to Sit01_Loop")
	system.PreLoadRequest(CameraAssetBundleName)
end
