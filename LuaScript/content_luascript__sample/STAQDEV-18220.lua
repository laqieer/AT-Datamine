Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_113021_01","113021_01_h")
Include("content_adv_advsmall_113021_01","Template113021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-10,CharaPos113021_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName113021_01,CameraPos113021_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos113021_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_014_01_StdController","to Std_Loop",CameraAssetBundleName113021_01,CameraPos113021_01_007)
	InitializeTemplateRandomCamera113021_01()
	InitializeTemplate113021_01()
-- ▼直接出力
DontChangeRandomCamera(true)
set_camera_nearclip(Camera001,1)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(113021)
	Actor001 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101050","001","101050001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	TalkTest(Actor001,"CHRNAME_DINATAN","speech","L","目を閉じるてすとです")

	while true do
		open_select_window_direct(Actor001, "Normal", "Forceきく","Forceきかない", "Reserve", "終了")

		CloseTalkWindow()
		wait_time(FADE_TIME)

		if is_select(1) then
			forceOK()
		elseif is_select(2) then
			forceNG()
		elseif is_select(3) then
			Reserve()
		else
			break
		end
	end

	TalkTest(Actor002,"CHRNAME_BRIAN","speech","R","おわりです")
	EndPlay()
end


function forceOK()
	TalkTest(Actor002,"CHRNAME_BRIAN","speech","L","強制目とじできるケース")

	force_eyesync(Actor002,"Close")

	TalkTest(Actor002,"CHRNAME_BRIAN","speech","L","顔を出しっぱなしなら普通にきく")


	TalkTest(Actor002,"CHRNAME_BRIAN","speech","L","もどす")

	force_eyesync(Actor002,"Auto")

	TalkTest(Actor002,"CHRNAME_BRIAN","speech","L","もどった")

	CloseTalkWindow()
end

function forceNG()
	TalkTest(Actor001,"CHRNAME_DINATAN","speech","L","強制目とじだめなケース")

	CloseTalkWindow()
	wait_time(FADE_TIME)

	force_eyesync(Actor002,"Close")

	change_face(Actor002,"Pain")

	TalkTest(Actor002,"CHRNAME_BRIAN","speech","L","キャラ切替とforceを併用するケース")

	change_face(Actor002,"Normal")
	TalkTest(Actor002,"CHRNAME_BRIAN","speech","L","もどしておく")

	force_eyesync(Actor002,"Auto")

	TalkTest(Actor002,"CHRNAME_BRIAN","speech","L","もどった")

	TalkTest(Actor001,"CHRNAME_DINATAN","speech","L","別キャラをだす")


	force_eyesync(Actor002,"Close")

	TalkTest(Actor002,"CHRNAME_BRIAN","speech","L","これはどうだ")

	TalkTest(Actor002,"CHRNAME_BRIAN","speech","L","だめですね")

	force_eyesync(Actor002,"Auto")

	TalkTest(Actor002,"CHRNAME_BRIAN","speech","L","おわりです")

	CloseTalkWindow()
end

function Reserve()
	TalkTest(Actor001,"CHRNAME_DINATAN","speech","L","予約しておくテスト")
	CloseTalkWindow()
	wait_time(FADE_TIME)

	-- キャラ切替と同時に目パチ指定するときの関数
	reserve_eyesync(Actor002,"Close")

	change_face(Actor002,"Pain")

	TalkTest(Actor002,"CHRNAME_BRIAN","speech","L","予約しておけば閉じられる")

	TalkTest(Actor002,"CHRNAME_BRIAN","speech","L","戻そう")

	force_eyesync(Actor002,"Auto")

	TalkTest(Actor002,"CHRNAME_BRIAN","speech","L","戻った")


	TalkTest(Actor001,"CHRNAME_DINATAN","speech","L","別キャラをだす")

	reserve_eyesync(Actor002,"Close")

	TalkTest(Actor002,"CHRNAME_BRIAN","speech","L","これならどうだ")


	force_eyesync(Actor002,"Auto")

	TalkTest(Actor002,"CHRNAME_BRIAN","speech","L","終わりです")

	CloseTalkWindow()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(113021)
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101050","001","101050001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName113021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end

function TalkTest(controllerId, talkerNameTag, frameType, dir, textId)
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

    PlayBranchPoint(textId)
    
	-- テスト用
	message_direct(textId)
	-- 本番用
    --message(textId)

	EndBranchPoint()

	-- しゃべった人のモーションを戻す
	animator_default_motion_if_need(lastTalkControllerId)
end
