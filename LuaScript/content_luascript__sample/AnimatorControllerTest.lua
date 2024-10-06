-- β1テスト/[03]0901放課後_コミュ -----------------------------------------------------------------------

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_common", "DemoCommonPack")
Include("content_luascript_common", "SceneCommonPack")

-- アセットなどを読み込む
function Load()
	demo_setup()
	load_scene("content_areascene_115014", "Area115014") -- ノワール教室：夕晴

	Noir = set_chara_animator("content_chr_101009_101009002_model", "101009002_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", CHARA3_AREA110011, "Sri_Std_loop_m", "Normal", "content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop")
	character2DDefaultStyleFull(Noir, "Noir",101009)
	
	Guinevere = set_chara_animator("content_chr_101011_101011001_model", "101011001_Model", "content_animationpack_101_101guin", "MotionPack_101Guin", "content_animationpack__common", "FacialPack", CHARA2_AREA110011, "Nbl_Std_loop_f", "Normal", "content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_SitController","to Sit01_Loop")
	character2DDefaultStyleFull(Guinevere, "Guinevere",101011)
	
	MAIN_CAMERA = set_camera({1.492, 1.869, -2.837,   13.47999, 312.6548, 0,   21})
end

-- シーケンスの実行
function Play()
	on_camera(MAIN_CAMERA)
	demo_start()

	open_narration_window()
	message_direct("アニメーターコントローラーのテスト")
	close_narration_window()

	
	animator_motion(Noir,"to  Std_Talkaaa")
	open_speech_window("PLAYERNAME_NOIR", nil, Noir)
	message_direct("存在しないトリガーテスト")
	close_speech_window()

	open_speech_window("PLAYERNAME_NOIR", nil, Noir)
	animator_motion(Noir,"to  Std_Talk")
	message_direct("★★★Std_Talkパクパクパクパクパクパク")
	close_speech_window()
	change_face(Noir, "Anger")
	open_speech_window("PLAYERNAME_NOIR", nil, Noir)
	animator_motion(Noir,"to  Std_Angry")
	message_direct("★★★Std_Angryパクパクパクパクパクパク")
	close_speech_window()
	open_speech_window("PLAYERNAME_NOIR", nil, Noir)
	animator_motion(Noir,"to  Std_Joy")
	message_direct("★★★Std_Joyパクパクパクパクパクパク")
	close_speech_window()
	open_speech_window("PLAYERNAME_NOIR", nil, Noir)
	animator_motion(Noir,"to  Std_Sad01")
	message_direct("★★★Std_Sad01パクパクパクパクパクパク")
	close_speech_window()
	open_speech_window("PLAYERNAME_NOIR", nil, Noir)
	animator_motion(Noir,"to  Std_Sad02")
	message_direct("★★★Std_Sad02パクパクパクパクパクパク")
	close_speech_window()


--[[
	open_speech_window("PLAYERNAME_NOIR", nil, Noir)
	animator_motion(Noir,"to  Std_Talk")
	message_direct("★★★Std_Talk")
	animator_motion(Noir,"default")
	wait_time(1.0)
	animator_motion(Noir,"to  Std_Angry")
	message_direct("★★★Std_Angry")
	animator_motion(Noir,"default")
	wait_time(1.0)
	animator_motion(Noir,"to  Std_Joy")
	message_direct("★★★Std_Joy")
	animator_motion(Noir,"default")
	wait_time(1.0)
	animator_motion(Noir,"to  Std_Sad01")
	message_direct("★★★Std_Sad01")
	animator_motion(Noir,"default")
	wait_time(1.0)
	animator_motion(Noir,"to  Std_Sad02")
	message_direct("★★★Std_Sad02")
	close_speech_window()
]]
--[[
	animator_motion(Guinevere,"default")
	animator_motion(Guinevere,"to Sit01_RH01")
	debug_print("★★★Sit01_RH01")
	wait_time(3.0)
	animator_motion(Guinevere,"default")
	animator_motion(Guinevere,"to Sit01_Talk")
	debug_print("★★★Sit01_Talk")
	wait_time(3.0)
	animator_motion(Guinevere,"default")
	animator_motion(Guinevere,"to Sit02_Loop")
	debug_print("★★★Sit02_Loop")
	wait_time(3.0)
	animator_motion(Guinevere,"default")
	animator_motion(Guinevere,"to Sit02_BA01")
	debug_print("★★★Sit02_BA01")
	wait_time(3.0)
	animator_motion(Guinevere,"default")
	animator_motion(Guinevere,"to Sit02_Talk")
	debug_print("★★★Sit02_Talk")
	wait_time(3.0)
	animator_motion(Guinevere,"default")
	animator_motion(Guinevere,"to Sit01_Talk")
	debug_print("★★★Sit01_Talk")
	wait_time(3.0)
]]	
	motion_inloop(Noir, "Sri_Std_yes_m", "Sri_Std_loop_m", 0.3, 1.0)
	open_speech_window("PLAYERNAME_NOIR", nil, Noir)
	message_direct("既存モーションとの切り替えテスト1")
	close_speech_window()
	
	animator_motion(Noir,"to  Std_Talk")
	open_speech_window("PLAYERNAME_NOIR", nil, Noir)
	message_direct("Std_Talk")
	close_speech_window()
	
	motion_inloop(Noir, "Sri_Std_yes_m", "Sri_Std_loop_m", 0.3, 1.0)
	open_speech_window("PLAYERNAME_NOIR", nil, Noir)
	message_direct("既存モーションとの切り替えテスト2")
	close_speech_window()
	
	animator_motion(Noir,"to  Std_Angry")
	open_speech_window("PLAYERNAME_NOIR", nil, Noir)
	message_direct("Std_Angry")
	close_speech_window()
	
	animator_motion(Noir,"to  Std_Joy")
	open_speech_window("PLAYERNAME_NOIR", nil, Noir)
	message_direct("Std_Joy")
	close_speech_window()
	
	animator_motion(Noir,"to  Std_Appl")
	animator_motion(Guinevere,"to Sit01_Talk")
	open_speech_window("PLAYERNAME_NOIR", nil, Noir)
	message_direct("Std_ApplとGuinevere同時にアクション")
	close_speech_window()
--	animator_motion(Guinevere,"default")
	
	animator_motion(Guinevere,"to Sit01_RH01")
	open_speech_window("CHRNAME_GUINEVERE", nil, Guinevere)
	message_direct("to Sit01_RH01")
	close_speech_window()
	
	animator_motion(Guinevere,"to Sit01_Talk")
	open_speech_window("CHRNAME_GUINEVERE", nil, Guinevere)
	message_direct("to Sit01_Talk")
	close_speech_window()
	
	animator_motion(Guinevere,"to Sit02_Loop")
	set_animator_default(Guinevere, "to Sit02_Loop")
	open_speech_window("CHRNAME_GUINEVERE", nil, Guinevere)
	message_direct("to Sit02_Loopへのデフォルトステートの切り替え")
	close_speech_window()
	
	motion(Guinevere, "Nbl_Sit_talk_loop_f", 0.3, 1.0, true)
	open_speech_window("CHRNAME_GUINEVERE", nil, Guinevere)
	message_direct("既存モーションとの切り替えテスト3")
	close_speech_window()
	
	animator_motion(Guinevere,"to Sit02_RH02")
	open_speech_window("CHRNAME_GUINEVERE", nil, Guinevere)
	message_direct("to Sit01_RH02")
	close_speech_window()

	animator_motion(Guinevere,"to Sit02_Talk")
	open_speech_window("CHRNAME_GUINEVERE", nil, Guinevere)
	message_direct("to Sit02_Talk")
	close_speech_window()
	
	animator_motion(Guinevere,"to Sit01_Loop")
	set_animator_default(Guinevere, "to Sit01_Loop")
	open_speech_window("CHRNAME_GUINEVERE", nil, Guinevere)
	message_direct("to Sit01_Loopへのデフォルトステートの切り替え")
	close_speech_window()

	demo_end()

end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	load_scene_preload("content_areascene_115014", "Area115014")
	set_chara_animator_preload("content_chr_101009_101009002_model", "101009002_Model", "content_animationpack__common", "MotionPackBeta2", "content_animationpack__common", "FacialPack", CHARA3_AREA110011, "Sri_Std_loop_m", "Normal", "content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop")
	character2DDefaultStyleFull_Preload(Noir, "Noir",101009)
	set_chara_animator_preload("content_chr_101011_101011001_model", "101011001_Model", "content_animationpack_101_101guin", "MotionPack_101Guin", "content_animationpack__common", "FacialPack", CHARA2_AREA110011, "Nbl_Std_loop_f", "Normal", "content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_SitController","to Sit01_Loop")
	character2DDefaultStyleFull_Preload(Guinevere, "Guinevere",101011)
end
