Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_02","110051_02_h")
Include("content_adv_advsmall_110051_02","Template110051_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110051_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110051_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_005)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110051_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_007)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110051_02_011,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_011)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110051_02_012,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_012)
	Camera008 = SetTemplate("Actor008",nil,CharaPos110051_02_012,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_012)
	Camera009 = SetTemplate("Actor009",nil,CharaPos110051_02_013,"content_motion3d_advarea_common_adv_templatecontroller","Chr_508_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_013)
	Camera010 = SetTemplate("Actor010",nil,CharaPos110051_02_010,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_010)
	Camera011 = SetTemplate("Actor011",nil,CharaPos110051_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_004)
	Camera012 = SetTemplate("Actor012",nil,CharaPos110051_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_006)
	InitializeTemplateRandomCamera110051_02()
	InitializeTemplate110051_02()
-- ▼直接出力
setup_template_moveobj_110051_02()
load_image("102010090_StillImage", "content_still_10201009_image", "102010090_StillImage")
load_image("MA011080201", "content_still_10101013_image", "101010130_StillImage")
Hide(Actor008)
set_enable_auto_lookat_all(false)
DontCameraOffset(Actor001)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor002)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor003)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor004)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor005)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor006)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor010)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor011)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor012)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110051)
	Actor001 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101028","003","101028003","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101028","002","101028002","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_3D("101029","001","101029001","content_animationpack__common","FacialPack","Actor009")
	Actor010 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor010")
	Actor011 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor011")
	Actor012 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor012")
	Actor013 = InitializeCharacter_TextOnly()
	Actor014 = InitializeCharacter_TextOnly()
	Actor015 = InitializeCharacter_2DOnly("101011","001","101011001")
	Actor016 = InitializeCharacter_2DOnly("101012","001","101012001")
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor009,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor010,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	showTime = 0.5
	showMask = true
	showBg = false


	strMask = "あり"
	strBg = "なし"
	strTime = "0.5"

	Talktest(Actor007,"CHRNAME_GALAHAD","speech","L","すちる表示します")

	while true do
		Talktest(Actor007,"CHRNAME_GALAHAD","speech","L","選んでみよう")

		open_select_window_direct(Actor007,"Normal","テスト","マスク","BG","タイム","おわる")
		if is_select(1) then
			test()
		elseif is_select(2) then
			selectMask()
		elseif is_select(3) then
			selectBG()
		elseif is_select(4) then
			selectTime()
		elseif is_select(5) then
			break;
		end

	end

	EndPlay()
end


function selectMask()

	while true do
		Talktest(Actor007,"CHRNAME_GALAHAD","speech","L","マスクを表示するか")

		open_select_window_direct(Actor007,"Normal","マスク表示する","マスク表示しない","もどる")
		if is_select(1) then
			showMask = true
			strMask = "あり"
			break
		elseif is_select(2) then
			showMask = false
			strMask = "なし"
			break
		elseif is_select(3) then
			break;
		end
	end
end

function selectBG()
	while true do
		Talktest(Actor007,"CHRNAME_GALAHAD","speech","L","BGを表示するか")

		open_select_window_direct(Actor007,"Normal","BG表示する","BG表示しない","もどる")
		if is_select(1) then
			showBg = true
			strBg = "あり"
			break
		elseif is_select(2) then
			showBg = false
			strBg = "なし"
			break
		elseif is_select(3) then
			break;
		end
	end

end


function selectTime()
	while true do
		Talktest(Actor007,"CHRNAME_GALAHAD","speech","L","フェード時間")

		open_select_window_direct(Actor007,"Normal","0.5","1","3","もどる")
		if is_select(1) then
			showTime = 0.5
			strTime = "0.5"
			break
		elseif is_select(2) then
			showTime = 1
			strTime = "1"
			break
		elseif is_select(3) then
			showTime = 3
			strTime = "3"
			break
		elseif is_select(4) then
			break;
		end
	end

end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("102010090_StillImage", "content_still_10201009_image", "102010090_StillImage")
load_image_preload("MA011080201", "content_still_10101013_image", "101010130_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110051)
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101028","003","101028003","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101028","002","101028002","content_animationpack__common","FacialPack","Actor008")
	InitializeCharacter_3D_Preload("101029","001","101029001","content_animationpack__common","FacialPack","Actor009")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor010")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor011")
	InitializeCharacter_3D_Preload("101022","001","101022001","content_animationpack__common","FacialPack","Actor012")
	InitializeCharacter_2DOnly_Preload("101011","001","101011001")
	InitializeCharacter_2DOnly_Preload("101012","001","101012001")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor009,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor010,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
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

    PlayBranchPoint(textId)
    
	-- テスト用
	message_direct(textId)
	-- 本番用
    --message(textId)

	EndBranchPoint()

	-- しゃべった人のモーションを戻す
	animator_default_motion_if_need(lastTalkControllerId)
end


function test()


	Talktest(Actor007,"CHRNAME_GALAHAD","speech","L","マスク:"..strMask.." BG:"..strBg.." 時間:"..strTime.." です" )



	local signal = show_image("MA011080201", 0.0, 0.0, showTime ,showMask,showBg)

    while signal.IsProccessing() do
        coroutine.yield()
    end

	wait_time(2)

	signal = hide_image(showTime)

    while signal.IsProccessing() do
        coroutine.yield()
    end

end
