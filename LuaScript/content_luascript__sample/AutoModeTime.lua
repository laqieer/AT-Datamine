-- β1テスト/[03]0901放課後_コミュ -----------------------------------------------------------------------

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_common", "DemoCommonPack")
Include("content_luascript_common", "SceneCommonPack")

-- アセットなどを読み込む
function Load()
	demo_setup()
	load_area_scene(110011) -- ノワール教室：夕晴

	Noir = set_chara("content_chr_101009_101009002_model", "101009002_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", CHARA3_AREA110011, "Sri_Std_loop_m", "Normal")
	character2DDefaultStyleFull(Noir, "Noir",101009)
	
	MAIN_CAMERA = set_camera(CAMERA_AREA110011)
end

-- シーケンスの実行
function Play()
	on_camera(MAIN_CAMERA)
	demo_start()

	open_narration_window()
	message_direct("オート時の文字送りの時間調整")
	close_narration_window()

	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
	message_direct("最短1秒、最長3秒")
	close_speech_window()
	
	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
	message_direct("12345") 
	close_speech_window()
	
	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
	message_direct("1234567890") 
	close_speech_window()
	
	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
	message_direct("12345678901234567890") 
	close_speech_window()
	
	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
	message_direct("123456789012345678901234567890") 
	close_speech_window()
	
	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
	message_direct("1234567890123456789012345678901234567890") 
	close_speech_window()
	
	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
	message_direct("12345678901234567890123456789012345678901234567890") 
	close_speech_window()
	
	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
	message_direct("123456789012345678901234567890123456789012345678901234567890") 
	close_speech_window()
	
	
	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
	message_direct("1234567890123456789012345678901234567890123456789012345678901234567890") 
	close_speech_window()
	
	demo_end()

end

function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	load_area_scene_preload(110011)
	set_chara_preload("content_chr_101009_101009002_model", "101009002_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", CHARA3_AREA110011, "Sri_Std_loop_m", "Normal")
	character2DDefaultStyleFull_Preload(Noir, "Noir",101009)
end
