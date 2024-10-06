Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")

function Load()
	demo_setup_nofade()

	setup2D_S_Noir(3)
	setup2D_S_Guinevere()


end

-- プレイヤーフェイズ2
function Play()
	Play_start(false)

	--ギネヴィアセリフ
	change_face(Guinevere, "Normal")
	open_speech_window("CHRNAME_GUINEVERE",Guinevere,nil) --ギネヴィア
	message("BT_TUTORIAL07_040001") --守ってばっかりは性に合わないわ！
	close_speech_window()


	--ノワールセリフ
	change_face(Noir3, "Normal")
	open_speech_window("CHRNAME_NOIR",Noir3,nil) --ノワール
	message("BT_TUTORIAL07_040002") --身を隠しながら戦った方がいいな
	close_speech_window()


	
	--ギネヴィアをノワールにデュアルさせる
	manual_command_double(2, 6, 4, 6, 5)
	--ノワール攻撃
	manual_command_skill(1, 6, 4, 5, 4, 0)

	Play_end(false)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_S_Noir_preload(3)
	setup2D_S_Guinevere_preload()
end
