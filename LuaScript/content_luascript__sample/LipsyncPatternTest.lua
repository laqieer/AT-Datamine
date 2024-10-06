-- β1テスト/[03]0901放課後_コミュ -----------------------------------------------------------------------

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_common", "DemoCommonPack")
Include("content_luascript_common", "SceneCommonPack")

-- アセットなどを読み込む
function Load()
	demo_setup()
	load_area_scene(110011) -- 教室

	Noir = set_chara("content_chr_101009_101009002_model", "101009002_Model", "content_animationpack__common", "MotionPack", "content_animationpack__common", "FacialPack", 0, 0.06, 0.4, 65, "Sri_Std_loop_m", "Normal")
	--character2DFull(Noir, "Noir", 101009005)
	character2DFull(Noir, "Noir", 101009001)
	
	Dinatan = set_chara_unknown()
	character2DFull(Dinatan, "Dinatan", 101012004)

	MAIN_CAMERA = set_camera(CAMERA_AREA110011)
	
	-- サウンド事前設定
	load_sound("VO_kutipaku_test")
	
end

-- シーケンスの実行
function Play()
	on_camera(MAIN_CAMERA)
	demo_start()
	
	open_narration_window()
	message_direct("口パクテスト")
	close_narration_window()
	
	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
	message_direct("口パクテスト無音文字入りテストテストテストパクテストテストテストテスト・・・・・・・・・・・・・・・・パクテストテストテストテストパクテストテストテストテスト")
	close_speech_window()
	
	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
	message_direct("口パクテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテスト")
	close_speech_window()

	change_face(Noir,"Anger")
	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
	message_direct("口パクテストテストテストテストパクテストテストテストテスト・・・・・・・・・・・・・・・・パクテストテストテストテストパクテストテストテストテスト")
	close_speech_window()
	
	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
	message_direct("口パクテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテストテスト")
	close_speech_window()

	open_speech_window("PLAYERNAME_NOIR", Dinatan, nil)
	message_direct("2Dキャラ表示だけの口パクテスト2Dキャラ表示だけの口パクテスト2Dキャラ表示だけの口パクテスト2Dキャラ表示だけの口パクテスト2Dキャラ表示だけの口パクテスト2Dキャラ表示だけの口パクテスト2Dキャラ表示だけの口パクテスト2Dキャラ表示だけの口パクテスト2Dキャラ表示だけの口パクテスト2Dキャラ表示だけの口")
	close_speech_window()
	
	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
	v_message_direct("dios_story0101_0006_02","俺たちは騎士だ。信じる道が違うというなら、その剣で、証明して見せろ")
	close_speech_window()
	
	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
	v_message_direct("dios_story0101_0006","理想だけでは何も変えられない、そう気づかされたんだよ")
	close_speech_window()
	
	open_speech_window("PLAYERNAME_NOIR", Noir, nil)
	v_message_direct("logi_story0101_0006_2","すべてが変わり続ける世の中で、変わらずにあり続けるものがある")
	close_speech_window()
	
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
	load_area_scene_preload(110011)
	set_chara_preload("content_chr_101009_101009002_model", "101009002_Model", "content_animationpack__common", "MotionPack", "content_animationpack__common", "FacialPack", 0, 0.06, 0.4, 65, "Sri_Std_loop_m", "Normal")
	character2DFull_Preload(Noir, "Noir", 101009001)
	character2DFull_Preload(Dinatan, "Dinatan", 101012004)
end
