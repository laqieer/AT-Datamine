-- このluaスクリプトは、MA_01B110_22.xlsm の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_01","110071_01_h")
Include("content_adv_advsmall_110071_01","Template110071_01_h")

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter("101009","001","101009001",CharaPos001,"101009001","Chr_002_01_StdController","to Std_Loop")
	Actor002 = InitializeCharacter("101010","001","101010001",CharaPos005,"101010001","Chr_001_01_StdController","to Std_Loop")
	Actor003 = InitializeCharacter("101026","001","101026001",CharaPos007,"101026001","Chr_008_01_StdController","to Std_Loop")
	Actor004 = InitializeCharacter("101024","001","101024001",CharaPos003,"101024001","Chr_010_01_StdController","to Std_Loop")
	Actor005 = InitializeCharacter("101025","001","101025001",CharaPos008,"101025001","Chr_515_01_StdController","to Std_Loop")
	InitializeCharaCamera(CameraAssetBundleName,CameraPos001,Actor001)
	InitializeCharaCamera(CameraAssetBundleName,CameraPos005,Actor002)
	InitializeCharaCamera(CameraAssetBundleName,CameraPos007,Actor003)
	InitializeCharaCamera(CameraAssetBundleName,CameraPos003,Actor004)
	InitializeCharaCamera(CameraAssetBundleName,CameraPos008,Actor005)
	InitializeTemplateRandomCamera()
	InitializeTemplate()
end

function Play()
	StartPlay()

	open_select_window_direct(Actor001, "Normal", "2.0", "5.6", "8", "11")
	if is_select(1) then
		SetDepthOfFieldAperture(2)
	elseif is_select(2) then
		SetDepthOfFieldAperture(5.6)
	elseif is_select(3) then
		SetDepthOfFieldAperture(8)
	elseif is_select(4) then
		SetDepthOfFieldAperture(11)
	end

	playStory()

	EndPlay()
end


function playStory()
	--★★ランスロット★★:ではな、ノワール<br>気を付けて行ってこい
	TalkTest(Actor002,"CHRNAME_LANCELOT","speech","L","ランスロットです")

	--★★ノワール★★:ああ<br>ランスロットもな
	TalkTest(Actor001,"CHRNAME_NOIR","speech","L","ノワールです")

	--★★ボールス★★:かつてバルバロイに襲われたことがあってな<br>そのときに命を救ってもらった
	TalkTest(Actor004,"CHRNAME_BORS","speech","L","ボールスです")

	--★★クレア★★:それだけじゃないでしょう？
	TalkTest(Actor005,"CHRNAME_CLARE","speech","L","クレアです")


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
    
	-- テスト用
	message_direct(textId)
	-- 本番用
    --message(textId)

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
	load_area_scene_preload(110071)
	InitializeCharacter_Preload("101009","001","101009001",CharaPos001,"101009001","Chr_002_01_StdController","to Std_Loop")
	InitializeCharacter_Preload("101010","001","101010001",CharaPos005,"101010001","Chr_001_01_StdController","to Std_Loop")
	InitializeCharacter_Preload("101026","001","101026001",CharaPos007,"101026001","Chr_008_01_StdController","to Std_Loop")
	InitializeCharacter_Preload("101024","001","101024001",CharaPos003,"101024001","Chr_010_01_StdController","to Std_Loop")
	InitializeCharacter_Preload("101025","001","101025001",CharaPos008,"101025001","Chr_515_01_StdController","to Std_Loop")
	system.PreLoadRequest(CameraAssetBundleName)
end
