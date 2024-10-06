-- β1テスト/[03]0901放課後_コミュ -----------------------------------------------------------------------

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_common", "DemoCommonPack")
Include("content_luascript_common", "SceneCommonPack")

Include("content_luascript_story_alpha6", "lb_testdemo02_0401")

-- アセットなどを読み込む
function Load()
	demo_setup()

	Noir = set_chara("content_chr_101009_101009002_model", "101009002_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", CHARA3_AREA110011, "Sri_Std_loop_m", "Normal")
	character2DDefaultStyleFull(Noir, "Noir",101009)
	
	MAIN_CAMERA = set_camera(CAMERA_AREA110011)
	
	-- サウンド事前設定
	load_sound("VO_kutipaku_test")

end

-- シーケンスの実行
function Play()
	on_camera(MAIN_CAMERA)
	demo_start()
	
	change_face(Noir, "Sad")
	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
	v_message_direct("dios_story0101_0006_02","俺たちは騎士だ。信じる道が違うというなら、その剣で、証明して見せろ")
	close_speech_window()
	
	change_face(Noir, "Sad")
	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
	v_message_direct("dios_story0101_0006","理想だけでは何も変えられない、そう気づかされたんだよ")
	close_speech_window()
	
	change_face(Noir, "Sad")
	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
	v_message_direct("logi_story0101_0006_2","すべてが変わり続ける世の中で、変わらずにあり続けるものがある")
	close_speech_window()
	
	change_face(Noir, "Sad")
	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
	v_message_direct("logi_story0101_0003","ディオス・・・僕らはもう、同じ道を歩んでいけないのか")
	close_speech_window()
	
	demo_end()

end

function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	set_chara_preload("content_chr_101009_101009002_model", "101009002_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", CHARA3_AREA110011, "Sri_Std_loop_m", "Normal")
	character2DDefaultStyleFull_Preload(Noir, "Noir",101009)
end
