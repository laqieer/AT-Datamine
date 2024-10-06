Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_common", "DemoCommonPack")
Include("content_luascript_common", "SceneCommonPack")

-- アセットなどを読み込む
function Load()
	demo_setup()
	load_area_scene(110071) -- 前庭
	
	Noir = set_chara_animator("content_chr_101009_101009002_model", "101009002_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", CHARA3_AREA110011, "Sri_Std_loop_m", "Normal", "content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop")
	character2DDefaultStyleFull(Noir, "Noir",101009)

-- サウンド事前設定
	load_sound("VO_kutipaku_test")
	
end

-- シーケンスの実行
function Play()


--	wait_time(0.1)	--おまじない
	demo_start()
	
	open_speech_window("PLAYERNAME_NOIR", nil, Noir)
	message("DAY1_07.01.FRI.Class.01.01")
	close_speech_window()
	
	open_speech_window("PLAYERNAME_NOIR", nil, Noir)
	message("DAY1_07.01.FRI.Class.01.02")
	close_speech_window()
	
	open_speech_window("PLAYERNAME_NOIR", nil, Noir)
	message("DAY1_07.01.FRI.Class.01.03")
	close_speech_window()
	
	open_speech_window("PLAYERNAME_NOIR", nil, Noir)
	message("DAY1_07.01.FRI.Class.01.04")
	close_speech_window()

	demo_end()

end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	load_area_scene_preload(110071)
	set_chara_animator_preload("content_chr_101009_101009002_model", "101009002_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", CHARA3_AREA110011, "Sri_Std_loop_m", "Normal", "content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop")
	character2DDefaultStyleFull_Preload(Noir, "Noir",101009)
end
