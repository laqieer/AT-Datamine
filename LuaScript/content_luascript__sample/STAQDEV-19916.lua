-- このluaスクリプトは、MA_01105_09.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_01","110111_01_h")
Include("content_adv_advsmall_110111_01","Template110111_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_001)
	Camera002 = SetTemplate("Actor002",-110,CharaPos110111_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110111_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_008)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110111_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_004)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110111_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_003)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110111_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_005)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110111_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_006)
	Camera008 = SetTemplate("Actor008",nil,CharaPos110111_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_007)
	InitializeTemplateRandomCamera110111_01()
	InitializeTemplate110111_01()
-- ▼直接出力
--BgProp = setup_prop_object(10102009)
--set_pos(BgProp,{0,0,0})
-- ▲直接出力
-- ▼直接出力
--load_image("101010260", "content_still_10101026_image", "101010260_StillImage")
--show_image("101010260", 0.0, 0.0, 0,false,false)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_DrumRoll")
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_Area_Festival")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110111)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_2DOnly("101027","001","101027001")
	Actor010 = InitializeCharacter_2DOnly("101026","001","101026001")
	template1()
end

function Play()
	StartPlay()

	while true do
		Talktest(Actor006,"CHRNAME_RAGNAR","speech","L","人数選択です")

		open_select_window_direct(Actor006,"Normal","ひとりてすと","ふたりてすと","さんにんてすと","おわる")
		if is_select(1) then
			cutinselectfor1()
		elseif is_select(2) then
			cutinselectfor2()
		elseif is_select(3) then
			cutinselectfor3()
		elseif is_select(4) then
			break;
		end
	end
end

---------------------------------------------
function cutinselectfor1()
	open_cutin(1,1)
	on_cutin(1,Actor004,"Surprise")

	--★★ディナタン★★:えっ？
	Talktest(Actor004,"CHRNAME_DINATAN","speech","N","えっ")

	close_cutin()
	wait_time(1.0)
end


---------------------------------------------
function cutinselectfor2()
	while true do
		Talktest(Actor006,"CHRNAME_RAGNAR","speech","L","2人用のテスト")

		open_select_window_direct(Actor006,"Normal","右表示","左表示","両方表示","もどる")
		if is_select(1) then
			cutintest2_1()
		elseif is_select(2) then
			cutintest2_2()
		elseif is_select(3) then
			cutintest2_3()
		elseif is_select(4) then
			break;
		end
	end

end

function cutintest2_1()
	open_cutin(2,1)
	on_cutin(1,Actor004,"Surprise")

	--★★ディナタン★★:えっ？
	Talktest(Actor004,"CHRNAME_DINATAN","speech","N","えっ")

	close_cutin()
	wait_time(1.0)
end

function cutintest2_2()
	open_cutin(2,1)
	on_cutin(2,Actor004,"Surprise")

	--★★ディナタン★★:えっ？
	Talktest(Actor004,"CHRNAME_DINATAN","speech","N","えっ")

	close_cutin()
	wait_time(1.0)
end

function cutintest2_3()
	open_cutin(2,1)
	on_cutin(1,Actor004,"Surprise")
	on_cutin(2,Actor001,"Surprise")

	--★★ディナタン★★:えっ？
	Talktest(Actor004,"CHRNAME_DINATAN","speech","N","えっ")

	close_cutin()
	wait_time(1.0)
end

---------------------------------------------
-- 3人用
function cutinselectfor3()
	while true do
		Talktest(Actor006,"CHRNAME_RAGNAR","speech","L","3人用のテスト")

		open_select_window_direct(Actor006,"Normal","1人表示","二人表示","三人表示","もどる")
		if is_select(1) then
			cutinselect3_1()
		elseif is_select(2) then
			cutinselect3_2()
		elseif is_select(3) then
			cutinselect3_3()
		elseif is_select(4) then
			break;
		end
	end
end




function cutinselect3_1()
	while true do
		Talktest(Actor006,"CHRNAME_RAGNAR","speech","L","3人用で1人表示")

		open_select_window_direct(Actor006,"Normal","いち","にい","さん","もどる")
		if is_select(1) then
			cutintest3_1_1()
		elseif is_select(2) then
			cutintest3_1_2()
		elseif is_select(3) then
			cutintest3_1_3()
		elseif is_select(4) then
			break;
		end
	end
end

-- 3人用で二人表示
function cutinselect3_2()
	while true do
		Talktest(Actor006,"CHRNAME_RAGNAR","speech","L","3人用で二人表示")

		open_select_window_direct(Actor006,"Normal","いち","にい","さん","もどる")
		if is_select(1) then
			cutintest3_2_1()
		elseif is_select(2) then
			cutintest3_2_2()
		elseif is_select(3) then
			cutintest3_2_3()
		elseif is_select(4) then
			break;
		end
	end
end


-- 3人で3人表示
function cutinselect3_3()
	open_cutin(3,2)
	on_cutin(1,Actor002,"Surprise")
	on_cutin(2,Actor004,"Surprise")
	on_cutin(3,Actor001,"Surprise")

	--★★ディナタン★★:えっ？
	Talktest(Actor004,"CHRNAME_DINATAN","speech","N","えっ")


	--★★ノワール★★:えっ！
	Talktest(Actor001,"CHRNAME_NOIR","speech","N","えっ")


	--★★ギネヴィア★★:………えっ
	Talktest(Actor002,"CHRNAME_GUINEVERE","speech","N","えっ")

	close_cutin()
	wait_time(1.0)
end

function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10102009)
load_image_preload("101010260", "content_still_10101026_image", "101010260_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110111)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor008")
	InitializeCharacter_2DOnly_Preload("101027","001","101027001")
	InitializeCharacter_2DOnly_Preload("101026","001","101026001")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor008,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor007,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_01)
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



function cutintest3_1_1()
	open_cutin(3,2)
	on_cutin(1,Actor002,"Surprise")
--	on_cutin(2,Actor004,"Surprise")
--	on_cutin(3,Actor001,"Surprise")

	--★★ディナタン★★:えっ？
	Talktest(Actor004,"CHRNAME_DINATAN","speech","N","えっ")

	close_cutin()
	wait_time(1.0)
end

function cutintest3_1_2()
	open_cutin(3,2)
--	on_cutin(1,Actor002,"Surprise")
	on_cutin(2,Actor004,"Surprise")
--	on_cutin(3,Actor001,"Surprise")

	--★★ディナタン★★:えっ？
	Talktest(Actor004,"CHRNAME_DINATAN","speech","N","えっ")

	close_cutin()
	wait_time(1.0)
end

function cutintest3_1_3()
	open_cutin(3,2)
--	on_cutin(1,Actor002,"Surprise")
--	on_cutin(2,Actor004,"Surprise")
	on_cutin(3,Actor001,"Surprise")

	--★★ディナタン★★:えっ？
	Talktest(Actor004,"CHRNAME_DINATAN","speech","N","えっ")

	close_cutin()
	wait_time(1.0)
end


function cutintest3_2_1()
	open_cutin(3,2)
	on_cutin(1,Actor002,"Surprise")
	on_cutin(2,Actor004,"Surprise")
--	on_cutin(3,Actor001,"Surprise")

	--★★ディナタン★★:えっ？
	Talktest(Actor004,"CHRNAME_DINATAN","speech","N","えっ")

	close_cutin()
	wait_time(1.0)
end

function cutintest3_2_2()
	open_cutin(3,2)
	on_cutin(1,Actor002,"Surprise")
--	on_cutin(2,Actor004,"Surprise")
	on_cutin(3,Actor001,"Surprise")

	--★★ディナタン★★:えっ？
	Talktest(Actor004,"CHRNAME_DINATAN","speech","N","えっ")

	close_cutin()
	wait_time(1.0)
end

function cutintest3_2_3()
	open_cutin(3,2)
--	on_cutin(1,Actor002,"Surprise")
	on_cutin(2,Actor004,"Surprise")
	on_cutin(3,Actor001,"Surprise")

	--★★ディナタン★★:えっ？
	Talktest(Actor004,"CHRNAME_DINATAN","speech","N","えっ")

	close_cutin()
	wait_time(1.0)
end


