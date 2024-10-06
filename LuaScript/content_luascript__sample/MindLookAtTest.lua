-- β1テスト/[03]0901放課後_コミュ -----------------------------------------------------------------------

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_common", "DemoCommonPack")
Include("content_luascript_common", "SceneCommonPack")

-- アセットなどを読み込む
function Load()
	demo_setup()
	load_area_scene(110011) -- 教室

	Noir = set_chara_animator("content_chr_101009_101009002_model", "101009002_Model", "content_animationpack_000", "MotionPack_000ComM", "content_animationpack__common", "FacialPack", CHARA3_AREA110011, "Com_Std01_Loop_m", "Normal", "content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop")
	character2DDefaultStyleFull(Noir, "Noir",101009)
	
	Guinevere = set_chara_animator("content_chr_101011_101011001_model", "101011001_Model", "content_animationpack_000", "MotionPack_000ComF", "content_animationpack__common", "FacialPack", CHARA2_AREA110011, "Com_Std01_Loop_f", "Normal", "content_motion3d_advarea_common_adv_templatecontroller","Chr_508_01_StdController","to Std_Loop")
	character2DDefaultStyleFull(Guinevere, "Guinevere",101011)
	
	animator_motion(Guinevere,"to  Std_Talk")
	
	MAIN_CAMERA = set_camera({1.492, 1.869, -2.837,   13.47999, 312.6548, 0,   21})
end

-- シーケンスの実行
function Play()
	on_camera(MAIN_CAMERA)
	demo_start()

	
	open_mind_window("Noir",Noir,nil)
	message_direct("これが<ruby=おれ>継承者キラーズ</ruby>ですよ<br><ruby=おれ>継承者キラーズ</ruby><ruby=おれ>継承者キラーズ</ruby>！")
	close_mind_window()
	
	open_speech_window("Noir",Noir,nil)
	message_direct("…")
	close_speech_window()
	
	open_speech_window("Noir",Noir,nil)
	message_direct("……")
	close_speech_window()
	
	open_speech_window("Noir",Noir,nil)
	message_direct("これが<ruby=ゲシュタルト・シフト>GS</ruby>ですよ<br><ruby=ゲシュタルト・シフト>じーえす</ruby><ruby=ゲシュタルト・シフト>じーえす</ruby>！")
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
	set_chara_animator_preload("content_chr_101009_101009002_model", "101009002_Model", "content_animationpack_000", "MotionPack_000ComM", "content_animationpack__common", "FacialPack", CHARA3_AREA110011, "Com_Std01_Loop_m", "Normal", "content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop")
	character2DDefaultStyleFull_Preload(Noir, "Noir",101009)
	set_chara_animator_preload("content_chr_101011_101011001_model", "101011001_Model", "content_animationpack_000", "MotionPack_000ComF", "content_animationpack__common", "FacialPack", CHARA2_AREA110011, "Com_Std01_Loop_f", "Normal", "content_motion3d_advarea_common_adv_templatecontroller","Chr_508_01_StdController","to Std_Loop")
	character2DDefaultStyleFull_Preload(Guinevere, "Guinevere",101011)
end
