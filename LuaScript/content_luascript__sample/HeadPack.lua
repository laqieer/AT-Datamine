-- β1テスト/[03]0901放課後_コミュ -----------------------------------------------------------------------

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_common", "DemoCommonPack")
Include("content_luascript_common", "SceneCommonPack")

Include("content_luascript_story_alpha6", "lb_testdemo02_0401")

-- アセットなどを読み込む
function Load()
	demo_setup()
	load_area_scene(115014) -- ノワール教室：夕晴
	Noir = set_chara_animator("content_chr_101009_101009002_model", "101009002_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", {0,0,-0.1,0}, "Sri_Std_loop_m", "Normal", "content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop")
	load_head_animation(Noir, "content_animationpack__common", "HeadPack")
	--Noir = set_chara("content_chr_101009_101009002_model", "101009002_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", CHARA3_AREA110011, "Sri_Std_loop_m", "Normal")
	character2DDefaultStyleFull(Noir, "Noir",101009)
	
	MAIN_CAMERA = set_camera(CAMERA_AREA110011)
	
	-- サウンド事前設定
	load_sound("VO_kutipaku_test")

end

-- シーケンスの実行
function Play()
	on_camera(MAIN_CAMERA)
	animator_motion(Noir,"to Std_Loop")
	demo_start()

	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
	message_direct("コントローラーで再生")
	close_speech_window()
	
	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
	message_direct("うなずくループ")
	close_speech_window()

	play_head_motion(Noir, "Nod", 0.3, 1.0, true)

	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
	message_direct("うなずく止める")
	close_speech_window()

	stop_head_motion(Noir)

	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
	message_direct("うなずく一回")
	close_speech_window()

	play_head_motion(Noir, "Nod", 0.3, 1.0, false)

	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
	message_direct("否定ループ")
	close_speech_window()

	play_head_motion(Noir, "No", 0.3, 1.0, true)

	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
	message_direct("否定止める")
	close_speech_window()

	stop_head_motion(Noir)

	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
	message_direct("否定一回")
	close_speech_window()

	play_head_motion(Noir, "No", 0.3, 1.0, false)

	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
	message_direct("パックにきりかえで再生")
	close_speech_window()
	motion(Noir, "Sri_Std_loop_m", 0.0, 1.0, true)
	
	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
	message_direct("うなずくループ")
	close_speech_window()

	play_head_motion(Noir, "Nod", 0.3, 1.0, true)

	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
	message_direct("うなずく止める")
	close_speech_window()

	stop_head_motion(Noir)

	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
	message_direct("うなずく一回")
	close_speech_window()

	play_head_motion(Noir, "Nod", 0.3, 1.0, false)

	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
	message_direct("否定ループ")
	close_speech_window()

	play_head_motion(Noir, "No", 0.3, 1.0, true)

	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
	message_direct("否定止める")
	close_speech_window()

	stop_head_motion(Noir)

	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
	message_direct("否定一回")
	close_speech_window()

	play_head_motion(Noir, "No", 0.3, 1.0, false)
	
	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
	message_direct("終わり")
	close_speech_window()
	demo_end()

end

function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	load_area_scene_preload(115014)
	set_chara_animator_preload("content_chr_101009_101009002_model", "101009002_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", {0,0,-0.1,0}, "Sri_Std_loop_m", "Normal", "content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop")
	load_head_animation_preload(Noir, "content_animationpack__common", "HeadPack")
	character2DDefaultStyleFull_Preload(Noir, "Noir",101009)
end
