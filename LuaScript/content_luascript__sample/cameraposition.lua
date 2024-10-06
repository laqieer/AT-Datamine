-- このluaスクリプトは、adv_event_small.xlsm の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_luascript_common","Bgarea_124_Formation_h")

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	InitializeScene("112021")
	Actor001 = InitializeCharacter("101009","001","101009001",CharaPos001)
	Actor002 = InitializeCharacter("101011","001","101011001",CharaPos002)
	Actor003 = InitializeCharacter("101016","001","101016001",CharaPos003)
	Actor004 = InitializeCharacter("401005","001","401005001",CharaPos004)
	Actor005 = InitializeCharacter("401007","001","401007001",CharaPos005)
	Actor006 = InitializeCharacter("401006","001","401006001",CharaPos006)
	Camera001 = InitializeCharaCamera(CameraAssetBundleName,CameraPos001,Actor001)
	Camera002 = InitializeCharaCamera(CameraAssetBundleName,CameraPos002,Actor002)
	Camera003 = InitializeCharaCamera(CameraAssetBundleName,CameraPos003,Actor003)
	Camera004 = InitializeCharaCamera(CameraAssetBundleName,CameraPos004,Actor004)
	Camera005 = InitializeCharaCamera(CameraAssetBundleName,CameraPos005,Actor005)
	Camera006 = InitializeCharaCamera(CameraAssetBundleName,CameraPos006,Actor006)

	RndCamera001 = InitializeRandomCamera(CameraAssetBundleName, RandomCameraPos001)
	RndCamera002 = InitializeRandomCamera(CameraAssetBundleName, RandomCameraPos002)
	RndCamera003 = InitializeRandomCamera(CameraAssetBundleName, RandomCameraPos003)
	RndCamera004 = InitializeRandomCamera(CameraAssetBundleName, RandomCameraPos004)
	RndCamera005 = InitializeRandomCamera(CameraAssetBundleName, RandomCameraPos005)
	RndCamera006 = InitializeRandomCamera(CameraAssetBundleName, RandomCameraPos006)
	RndCamera007 = InitializeRandomCamera(CameraAssetBundleName, RandomCameraPos007)
	RndCamera008 = InitializeRandomCamera(CameraAssetBundleName, RandomCameraPos008)
	RndCamera009 = InitializeRandomCamera(CameraAssetBundleName, RandomCameraPos009)
	RndCamera010 = InitializeRandomCamera(CameraAssetBundleName, RandomCameraPos010)
	RndCamera011 = InitializeRandomCamera(CameraAssetBundleName, RandomCameraPos011)
end

function Play()
	StartPlay()

	selectAnimationTest()










	EndPlay()
end

function message_lancelot(message)
    open_speech_window("CHRNAME_LANCELOT", Actor002, nil)
    message_direct(message)
    close_speech_window()
end

function selectAnimationTest()
    while true do
        open_select_window_direct(Actor001, "Normal", "1～4","5～8 ","9～12", "13～15", "終わる")
        if is_select(1) then
        	test1to4()
        elseif is_select(2) then
			test5to8()
        elseif is_select(3) then
			test9to12()
        elseif is_select(4) then
			test13to15()
        else
            break
        end
    end
end


function test1to4()
    while true do
        open_select_window_direct(Actor001, "Normal", "カット1","カット2 ","カット3", "カット4", "戻る")
        if is_select(1) then
		    on_camera(RndCamera001)
  			message_lancelot("カット1　R1です")
        elseif is_select(2) then
		    on_camera(RndCamera002)
  			message_lancelot("カット2　R2です")
        elseif is_select(3) then
		    on_camera(RndCamera003)
  			message_lancelot("カット3　R3です")
        elseif is_select(4) then
		    on_camera(Camera003)
  			message_lancelot("カット4　P3です")
        else
            break
        end
    end
end

function test5to8()
    while true do
        open_select_window_direct(Actor001, "Normal", "カット5","カット6 ","カット7", "カット8", "戻る")
        if is_select(1) then
		    on_camera(RndCamera004)
  			message_lancelot("カット5　R4です")
        elseif is_select(2) then
		    on_camera(RndCamera005)
  			message_lancelot("カット6　R5です")
        elseif is_select(3) then
		    on_camera(Camera004)
  			message_lancelot("カット7　P4です")
        elseif is_select(4) then
		    on_camera(RndCamera006)
  			message_lancelot("カット8　R6です")
        else
            break
        end
    end
end

function test9to12()
    while true do
        open_select_window_direct(Actor001, "Normal", "カット9","カット10 ","カット11", "カット12", "戻る")
        if is_select(1) then
		    on_camera(Camera001)
  			message_lancelot("カット9　P1です")
        elseif is_select(2) then
		    on_camera(RndCamera008)
  			message_lancelot("カット10　R8です")
        elseif is_select(3) then
		    on_camera(RndCamera009)
  			message_lancelot("カット11　R9です")
        elseif is_select(4) then
		    on_camera(RndCamera010)
  			message_lancelot("カット12　R10です")
        else
            break
        end
    end
end

function test13to15()
    while true do
        open_select_window_direct(Actor001, "Normal", "カット13","カット14 ","カット15", "戻る")
        if is_select(1) then
		    on_camera(RndCamera011)
  			message_lancelot("カット13　R11です")
        elseif is_select(2) then
		    on_camera(Camera004)
  			message_lancelot("カット14　P4です")
        elseif is_select(3) then
		    on_camera(RndCamera012)
  			message_lancelot("カット15　R12は存在しないかもしれません。")
        else
            break
        end
    end
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	InitializeCharacter_Preload("101009","001","101009001",CharaPos001)
	InitializeCharacter_Preload("101011","001","101011001",CharaPos002)
	InitializeCharacter_Preload("101016","001","101016001",CharaPos003)
	InitializeCharacter_Preload("401005","001","401005001",CharaPos004)
	InitializeCharacter_Preload("401007","001","401007001",CharaPos005)
	InitializeCharacter_Preload("401006","001","401006001",CharaPos006)
end
