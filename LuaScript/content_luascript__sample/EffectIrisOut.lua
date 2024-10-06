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
	InitializeTemplateRandomCamera110071_01()
	InitializeTemplate110071_01()

--	irisOut = load_ui_effect("content_effect_adv_ui_irisout", "IrisOut")
--	irisOut = system.LoadUI("content_effect3D_common_adv", "ef_c_adv_irisout", -1)
--Ef_C_Adv_Killers_Area

	load_image("103050100", "content_still_10305010_image", "103050100_StillImage")

end

function Play()
	StartPlay()

	PlayAction(Actor001,"to Std_Joy")


	Talktest(Actor001,"CHRNAME_NOIR","speech","R","アイリスアウトっていうらしい")


	Talktest(Actor001,"CHRNAME_NOIR","speech","R","画面外から縮小")

	irisout_set_to_wait(0,0, 2000,100,2)

	Talktest(Actor001,"CHRNAME_NOIR","speech","R","ちぢみます")

	irisout_to_wait(0,0.5)

	Talktest(Actor001,"CHRNAME_NOIR","speech","R","もういっかい")

	irisout_set_to_wait(-20,160, 2000,300,2)

	Talktest(Actor001,"CHRNAME_NOIR","speech","R","もうアイリスアウトはこりごりだよ")

	irisout_to_wait(0,3.0)

	Talktest(Actor001,"CHRNAME_NOIR","speech","R","あけてみる")

	irisout_to_wait(2000,3.0)

	irisout_active(false)

	Talktest(Actor001,"CHRNAME_NOIR","speech","R","スチルにかぶせられるかテスト")

	setup_small_camera_start()

	fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)

	show_image("103050100", 0.0, 0.0, 0.0,true,false)

	fadein(IMAGE_TIME_IN_IN)
	
	Talktest(Actor001,"CHRNAME_NOIR","speech","R","画像です")

	irisout_set_to_wait(0,0, 2000,300,2)

	Talktest(Actor001,"CHRNAME_NOIR","speech","R","ちぢもう")


	irisout_to_wait(0,3.0)

	Talktest(Actor001,"CHRNAME_NOIR","speech","R","おわりです")



	EndPlay()

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

function Talktest(controllerId, talkerNameTag, frameType, dir, textId)
	-- 必要があれば前回開いたウインドウを閉じる
	if CheckIfNeedClose(controllerId, frameType, dir) == true then
		CloseTalkWindow()
	end

	if manager ~= nil then
		-- カメラワークのための通知
		manager.CloseupUpExclusiveCamera(controllerId)
	end

	-- 必要があればウインドウを開く
	if CheckIfNeedOpen(controllerId, frameType, dir) == true then
		OpenTalkWindow(talkerNameTag, controllerId, frameType, dir)
    else
        -- ウインドウを開いたまま名前を変更する
        if lastTalkControllerId == controllerId and lastNameTag ~= talkerNameTag then 
            local onSimple = lastTalkFrameType == "simple"
            local validTalker = (talkerNameTag ~= nil)
            set_name_tag(talkerNameTag, onSimple, validTalker)     
	    end
	end

	lastTalkControllerId = controllerId
    lastNameTag = talkerNameTag

    PlayReservedPlayAction()

	-- テスト用
	message_direct(textId)
	-- 本番用
    --message(textId)

	-- しゃべった人のモーションを戻す
	animator_default_motion_if_need(lastTalkControllerId)
end
